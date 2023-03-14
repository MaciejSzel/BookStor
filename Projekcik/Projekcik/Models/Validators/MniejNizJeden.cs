using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.Validators
{
    public class MniejNizJeden
    {
        public static string SprawdzCzyMniejszyOdJeden(string wartosc)
        {
            if (wartosc.StartsWith("0") || wartosc.StartsWith("-"))
            {
                return "Numer lokalu nie może być mniejszy niż jeden";
            }
            return null;
        }
    }
}
