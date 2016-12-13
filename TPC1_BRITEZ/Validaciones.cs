using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace TPC1_BRITEZ
{
   public class Validaciones
    {
        public void CheckIfEmpty(string text, string name)
        {
            try
            {

                if (String.IsNullOrEmpty(text))
                {
                    throw new Exception("El campo " + name + " está vacío.");
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ValidateNumbers(string text, string name)
        {
            try
            {
                CheckIfEmpty(text, name);
                Regex regex = new Regex(@"[a-zA-Z]");
                Match match = regex.Match(text);
                if (match.Success)
                {
                    throw new Exception("Caracter inválido, sólo se admiten números en el campo " + name);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void ValidateText(string text, string name)
        {
            try
            {
                CheckIfEmpty(text, name);
                Regex regex = new Regex(@"[0-9]");
                Match match = regex.Match(text);
                if (match.Success)
                {
                    throw new Exception("Caracter inválido, sólo se admiten letras en el campo " + name);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        public void ValidateNumbersOnly(string text, string name)
        {
            try
            {

                Regex regex = new Regex(@"[^a-zA-Z]");
                Match match = regex.Match(text);
                if (match.Success)
                {
                    throw new Exception("Caracter inválido, sólo se admiten números en el campo " + name);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
