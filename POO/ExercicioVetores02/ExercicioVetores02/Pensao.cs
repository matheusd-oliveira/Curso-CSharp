namespace ExercicioVetores02
{
    class Pensao
    {
        public string Name { get; set; }
        public string Mail { get; set; }
        public int Room { get; set; }

        public Pensao(string name, string mail)
        {
            Name = name;
            Mail = mail;
        }

        public override string ToString()
        {
            return Name + ", " + Mail;
        }
    }
}
