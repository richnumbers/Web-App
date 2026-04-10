using System.Runtime.CompilerServices;

namespace DeckShuffle.Components.Modles
{
    public class Monster
    {
        private int hp;
        private int engery;
        private int maxEnergy;
        private string name;
        private int count;
        private int dmg;



        public Monster(int hp, int engery, string name)
        {
            this.hp = hp;
            this.engery = engery;
            this.maxEnergy = engery;
            this.name = name;
        }

        public void spendEnergy(int amount)
        {
            engery -= amount;
        }

        public void resetEnergy()
        {
            engery = maxEnergy;
        }

        public int getEnergy() { return engery; }

        public int getMaxEnergy() { return maxEnergy; }

        public int playCards(List<Cards> cards)
        {
            dmg = 0;
            count = 0;
            foreach (var card in cards)
            {
               if(card.getName() == "SwordSmash")
                {
                    count ++;
                    dmg += card.getDmg();
                }

               if(card.getName() == "heltHit")
                { 
                    count ++;
                    dmg += card.getDmg();
                }
           
            }
            if (count == 2)
            {
                return dmg;
            }
            else
            {
                dmg = 8;
                return dmg;
            }
        }
        public void takeDamage(int damage)
        {
            hp -= damage;
        }

        public int getHp() { return hp; }
         public string getName() { return name; }



    }
}
