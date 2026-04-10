namespace DeckShuffle.Components.Modles
{
    public class Cards
    {
        private int _value;
        private int _dmg;
        private int _block;
        private string _name;

        public Cards(int value, int dmg, int block, string name)
        {
            _value = value;
            _dmg = dmg;
            _block = block;
            _name = name;
        }

        public int getCoast()
        {
            return _value;
        }

        public int getDmg()
        {
            return _dmg;
        }   
        public int getBlock()
        {
            return _block;
        }

        public string getName()
        {
            return _name;
        }     



    }
}
