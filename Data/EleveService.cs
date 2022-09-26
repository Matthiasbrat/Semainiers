namespace Semainier.Data
{
    public class EleveService
    {
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

    }
}
