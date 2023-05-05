namespace LidellBackend.Models

{
    public class Fighter
    {
        public Guid Id { get; set; }

        public string FighterName { get; set; }

        public string Division { get; set; }

        public int Age { get; set; }

        public int FighterReach { get; set; }

        public string HomeTown { get; set; }

        public string FightStyle { get; set; }

        public string Record { get; set; }

        public string Photo { get; set; }

        public string Ranking { get; set; }
    }
}
