namespace Back_Projet_RPG.Models
{
    public abstract class Character
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public int LifePoint { get; set; }
        public int Strength { get; set; }
        public int Stamina { get; set; }
        public int Agility { get; set; }
        public int Intellect { get; set; }
        public int Luck { get; set; }
    }
}
