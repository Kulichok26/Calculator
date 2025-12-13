using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Memory
    {
        public int M = 0;

        public void MPlus(int value)
        {
            this.M += value;
        }
        public void MMinus(int value)
        {
            this.M -= value;
        }
        public int MRecall()
        {
            return this.M;
        }
        public void MClear()
        {
            this.M = 0;
        }
    }
}
