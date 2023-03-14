using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.Validators
{
    public class CenaValidator
    {
        public static string SprawdzCena(decimal? wartosc)
        {
            if (wartosc < 1)
            {
                return "Cena książki nie może być mniejsza niż 0!!";
            }
            return null;
        }
    }
}
