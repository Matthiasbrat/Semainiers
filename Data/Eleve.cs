namespace Semainier.Data
{
    public class Eleve
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public Semainier[] Semainiers { get; set; }
        public string numSemainiers { get; set; }
        public List<Eleve> allEleves { get; set; }
    }
}
