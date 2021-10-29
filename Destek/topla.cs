using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destek
{
    internal class topla
    {
        public int toplam(int[] veriler)
        {
            int plus = 0;
            for (int i = 0; i < veriler.Length; i++)
            {
                plus += veriler[i];
            }
            return plus;
        }
    }
}
