using System.Globalization;
using static Semainier.Data.DB;

namespace Semainier.Data
{
    public class EleveService
    {
        DBService dbService = new DBService();
        private List<Eleve> allEleves = new List<Eleve>();

        //async method
        public async Task<bool> NewEleve(Eleve newEleve)
        {
            if (newEleve.Email.Contains("@edu.vs.ch"))
            {
                allEleves.Add(newEleve);
            }
            return true;
        }

        public async Task<List<Eleve>> GetAllEleves()
        {
            return allEleves;
        }

        public async Task<Semainier[]> GetSemainiers(string email)
        {
            string id = (await dbService.ExecuteSqlCommandOnDB("SELECT Id FROM Eleve WHERE Email = '" + email + "';"))[1];

            return await LoadSemainiers(id, "WHERE Eleve_Id = " + id);
        }

        public async Task<Semainier[]> GetSemainiers(string email, string date)
        {
            string id = (await dbService.ExecuteSqlCommandOnDB("SELECT Id FROM Eleve WHERE Email = '" + email + "';"))[1];

            return await LoadSemainiers(id, "WHERE Date = '" + date + "'");
        }

        public async Task<Semainier[]> LoadSemainiers(string eleveId, string where)
        {
            await dbService.Connect();
            string[] results = await dbService.ExecuteSqlCommandOnDB("SELECT * FROM Devoir " + where + ";");
            List<object> lstSemainiers = ((results.Cast<string>().ToList()).SelectMany(x => x.ToString().Split('\t')).ToList()).Cast<object>().ToList();

            /* Création d'un tableau 2D de 8 éléments chacun. */
            var obj = (Enumerable.Range(0, lstSemainiers.Count / 8).Select(i => lstSemainiers.Skip(i * 8).Take(8).ToArray()).ToArray()).Skip(1);
            /* Trier le tableau par le premier élément de chaque sous-tableau. */
            var objSorted = obj.OrderBy(x => x[0]).Select((x, i) => new { Value = x, Index = i }).ToArray();

            /* Création d'un tableau d'objets Semainier. */
            Semainier[] semainiers = new Semainier[objSorted.Length];

            /* Une boucle for qui parcourt le tableau d'objets. */
            for (int i = 0; i < objSorted.Length; i++)
            {
                /* Analyser les données du tableau trié et les mettre dans des variables. */
                int realId = int.Parse(objSorted[i].Value[0].ToString());
                int id = objSorted[i].Index;
                string date = objSorted[i].Value[1].ToString().Split(' ')[0];
                int minutes = int.Parse(objSorted[i].Value[2].ToString());
                int matu = int.Parse(objSorted[i].Value[3].ToString());
                int? cp_Id = new List<string> { "", "NULL" }.Contains(objSorted[i].Value[6].ToString()) ? null : int.Parse(objSorted[i].Value[6].ToString());
                int? matu_Id = new List<string> { "", "NULL" }.Contains(objSorted[i].Value[7].ToString()) ? null : int.Parse(objSorted[i].Value[7].ToString());
                string more = objSorted[i].Value[4].ToString();
                int eleve_Id = int.Parse(objSorted[i].Value[5].ToString());
                string cmd = "SELECT Abrev FROM " + (matu == 1 ? "Matu" : "CP_CPR") + " WHERE Id = '" + (matu == 1 ? matu_Id : cp_Id) + "';";
                string subject = (await dbService.ExecuteSqlCommandOnDB(cmd))[1];

                /* Création d'un nouvel objet de type Semainier et affectation de valeurs à ses
                propriétés. */
                Semainier semainier = new Semainier()
                {
                    id = id + 1,
                    date = date,
                    minutes = minutes,
                    matu = matu,
                    cp_Id = cp_Id,
                    matu_Id = matu_Id,
                    subject = matu == 1 ? subject + " (Matu)" : subject,
                    more = more,
                    eleve_Id = eleve_Id,
                    realId = realId
                };

                /* Créer un nouvel objet semainier et l'ajouter au tableau semainiers. */
                semainiers[i] = semainier;
            }
            /* Ajout du semainier au tableau de semainiers statique (propriété mySemainiers) de la classe Semainier*/
            return semainiers;
        }
        
        public async Task<string> CountSemainiers(string email)
        {
            string id = GetEleveId(email).Result;
            return (await dbService.ExecuteSqlCommandOnDB("SELECT COUNT(*) FROM Devoir WHERE Eleve_Id = '" + id + "';"))[1];
        }
        
        public async Task<string> GetEleveId(string email)
        {
            var h = await dbService.ExecuteSqlCommandOnDB("SELECT Id FROM Eleve WHERE Email = '" + email + "';");
            return (await dbService.ExecuteSqlCommandOnDB("SELECT Id FROM Eleve WHERE Email = '" + email + "';"))[1];
        }
    }
}
