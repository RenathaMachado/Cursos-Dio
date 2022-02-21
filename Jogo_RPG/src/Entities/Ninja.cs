namespace Jogo_RPG.src.Entities
{
    public class Ninja:WizardWhite
    {
        
        public Ninja(string name, int level, string heroType, int HP, int MP):base(name, level, heroType, HP, MP)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack(){

            return this.name + "Lançou Golpes";
            
        }

        public override string Attack(int bonus){

            if(bonus>6){
                return this.name +" " + "Lançou golpes super efetiva com bônus de"+" " + bonus;
            }else{
                return this.name + " "+ "Lançou golpes com força fraca de"+" " + bonus;
            }
            
        }
    }
}