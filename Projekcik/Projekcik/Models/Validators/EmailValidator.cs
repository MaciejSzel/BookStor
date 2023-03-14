using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.Validators
{
    public class EmailValidator:Validator
    {
        public static string SprawdzCzyZawiera(string wartosc)
        {
            char value = '@';
            
                if(wartosc.Contains(value))
                {
                    return null;
                }
                return "Nieprawidłowy adres email";
            
        }
    }
}
