using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hesaplama
{
    public class BasitHesaplama
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
