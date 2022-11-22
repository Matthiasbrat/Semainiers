#pragma warning disable CS8618

namespace Semainier.Data
{
    public class Semainier
    {
        public Semainier() { }

        // Id du devoir contenu dans la base de données.
        public int realId { get; set; }
        public int id { get; set; }
        public string date { get; set; } = "";
        public int minutes { get; set; } = 0;
        public int matu { get; set; } = 0;
        public string subject { get; set; } = "";
        public string more { get; set; } = "";
        public int eleve_Id { get; set; } = 0;
        public int? cp_Id { get; set; } = null;
        public int? matu_Id { get; set; } = null;

        // Dates dd.MM stockées dans des tableaux du numéro de la semaine
        public static string[][] weekDays { get; set; } = new string[44][];
        public static List<string> weeksNumber { get; set; } = new List<string>();
        // Id des semainiers filtrés par semaine
        public static List<List<(string Date, int Id)>> filteredSemainiersIds { get; set; }
        public static List<string> InWeek(List<string> dates, int week)
        {
            List<string> lstFilteredSemainiers = new List<string>();

            dates.ForEach(date =>
            {
                if (Semainier.weekDays[week].Contains(DateTime.Parse(date).Day.ToString().PadLeft(2, '0') + "." + DateTime.Parse(date).Month.ToString().PadLeft(2, '0')))
                {
                    lstFilteredSemainiers.Add(date);
                }
            });
            return lstFilteredSemainiers;
        }
    }
}
