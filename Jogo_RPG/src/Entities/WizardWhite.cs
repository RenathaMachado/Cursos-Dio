namespace Jogo_RPG.src.Entities
{
    public class WizardWhite : Hero
    {
        
        public WizardWhite (string name, int level, string heroType, int HP, int MP):base(name, level, heroType, HP, MP)
        {
            this.name = name;
            this.level = level;
            this.heroType = heroType;
            this.HP = HP;
            this.MP = MP;
        }

        public override string Attack(){

            return this.name + "Lançou magia branca";
            
        }

        public virtual string Attack(int bonus){

            if(bonus>6){
                return this.name +" " + "Lançou magia super efetiva com bônus de" + bonus;
            }else{
                return this.name + " "+ "Lançou magia com força fraca de" + bonus;
            }
            
        }

        
    }
}