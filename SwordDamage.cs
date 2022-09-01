using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwordDamageConsoleAppEncapsulated
{
    internal class SwordDamage
    {
        public SwordDamage(int roll)
        {
            this.roll = roll;
        }

        public const int BASE_DAMAGE = 3;

        private int roll;
        private int flaming;
        private decimal magic;
        public int Roll
        {
            get { return roll; }
            set
            {
                roll = value;
                CalculateDamage();
            }
        }
        public int Flaming
        {
            get { return flaming; }
            set
            {
                flaming = value;
                CalculateDamage();
            }
        }
        public decimal Magic
        {
            get { return magic; }
            set
            {
                magic = value;
                CalculateDamage();
            }
        }
        public int Damage { get; private set; }

        private void CalculateDamage()
        {
            Damage = (int)(Roll * Magic) + BASE_DAMAGE + Flaming;
        }
    }
}
