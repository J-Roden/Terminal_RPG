using System;

namespace Terminal_RPG
{
    class Ninja : Human
    {
        public Ninja(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = 175;
            Health = hp;
        }
        public override int Attack(Human target){
            int dmg = this.Dexterity * 5;
            Random rand = new Random();
            if(rand.NextDouble() < 0.2)
            {
                dmg += 20;
                System.Console.WriteLine("Critical!");
            }
            target.Health -= dmg;
            System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Steal(Human target)
        {
            target.Health -= 5;
            this.Health += 5;
            return this.Health;
        }
    }
}