namespace Jogo_RPG.src.Entities
{
    public class Knight:Hero
    {
        public Knight (string name, int level, string heroType, int HP, int MP):base(name, level, heroType, HP, MP)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;
        }

       
    }
}