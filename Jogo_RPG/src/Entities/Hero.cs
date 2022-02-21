
using System;


namespace Jogo_RPG.src.Entities
{
    public abstract class Hero
    {
        
        public Hero(string name, int level, string heroType, int HP, int MP)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;
        }

        public string name { get; set; }
        public int level { get; set; }
        public string heroType { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }

        public override string ToString(){
            return this.name + " " + this.level +" " + this.heroType;
        }

        public virtual string Attack(){
            return this.name +" " + "Atacou com sua espada";
        }

    }
}