namespace Terminal_RPG.Models.Humans
{
    class Wizard : Human
    {
        public Wizard(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
        {
            Name = name;
            Strength = str;
            Intelligence = 25;
            Dexterity = dex;
            Health = 50;
        }
        public override int Attack(Human target){
            int dmg = this.Intelligence * 5;
            target.Health -= dmg;
            System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Heal(Human target)
        {
            target.Health += 10 * this.Intelligence;
            return target.Health;
        }
    }
}