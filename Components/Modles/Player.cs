namespace DeckShuffle.Components.Modles
{

    
    public class Player
    {
        int hp;
        int energy;
        int maxEnergy;
        int block;

        public Player(int hp, int energy)
        {
            this.hp = hp;
            this.energy = energy;
            this.maxEnergy = energy;
            this.block = 0;
        }

        public void  spendEnergy(int amount)
        {
            energy -= amount;
        }

        public bool asEnough(int amount)
        {
            if(energy >= amount)
            {
                return true;
            }
            else { return false; }
        }

        public int getEnergy() {return energy;}
        public int getHp() { return hp; }
        
        public void takeDamage(int damage)
        {
            damage -= block;
            if (damage <= 0)
            {
                damage = 0;
            }
            hp -= damage;
        }

        public void resetEnergy()
        {
            energy = maxEnergy;
        }

        public int getMaxEnergy() { return maxEnergy; }

        public int getBlock() { return block; }
        public void addBlock(int amount)
        {
            block += amount;
        }

        public void resetBlock()
        {
            block = 0;
        }
    }
}
