using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekcik.Models.Validators
{
    public class StringValidator : Validator
    {
        // To jest funkcja ktora sprawdza czy wartosc podana jako parametr zaczyna sie od duzej litery
        //Jezeli sie zaczyna to zwraca nulla 
        //jezeli sie nie zaczyna to zwraca komunikat bledu
        public static string SprawdzCzyZaczynaSieOdDuzej(string wartosc)
        {
            try
            {
                if (!char.IsUpper(wartosc, 0))
                {
                    return "Nie może zaczynać się od małej litery!!!";
                }
                return null;
            }
            catch (Exception) { }
            return null;
        }
    }
}
