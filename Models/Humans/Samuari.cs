using System;

namespace Terminal_RPG
{
    class Samuari : Human
    {
        public Samuari(string name, int str, int intel, int dex, int hp) : base(name, str, intel, dex, hp)
        {
            Name = name;
            Strength = str;
            Intelligence = intel;
            Dexterity = dex;
            Health = 200;
        }
        public override int Attack(Human target){
            int dmg = this.Strength * 5;
            if(target.Health <= 50)
                target.Health = 0;
            else
                target.Health -= dmg;
            System.Console.WriteLine($"{this.Name} attacked {target.Name} for {dmg} damage!");
            return target.Health;
        }
        public int Meditate()
        {
            this.Health = 200;
            return this.Health;
        }
    }
}