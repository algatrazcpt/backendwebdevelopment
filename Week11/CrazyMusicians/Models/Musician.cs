namespace CrazyMusicians.Models
{
    public class Musician
    {
        int id;
        string name="";
        string job="";
        string traitInfo = "";

        public Musician()
        {

        }
        public Musician(string name, string job, string traitInfo)
        {
            this.name = name;
            this.job = job;
            this.traitInfo = traitInfo;
        }
        public Musician(int id, string name, string job, string traitInfo)
        {
            this.id = id;
            this.name = name;
            this.job = job;
            this.traitInfo = traitInfo;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public string Job { get => job; set => job = value; }
        public string TraitInfo { get => traitInfo; set => traitInfo = value; }
    }
}
