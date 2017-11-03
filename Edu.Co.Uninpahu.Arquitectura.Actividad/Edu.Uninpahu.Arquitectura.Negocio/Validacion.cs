using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edu.Uninpahu.Arquitectura.Negocio
{
    public class Validacion
    {

        public bool soloLetras(Char e)
        {
            bool retorno = false;
            //try
            //{
                if (Char.IsLetter(e))
                {
                    retorno = false;
                }
                else if (Char.IsControl(e))
                {
                    retorno = false;
                }
                else if (Char.IsSeparator(e))
                {
                    retorno = false;
                }
                else
                {
                    retorno = true;
                }
                return retorno;
            //}
            //catch (Exception ex)
            //{
             //   return retorno;
            //}
        }

        public bool soloNumeros(Char e)
        {
            bool retorno = false;
            //try
            //{
                if (Char.IsNumber(e))
                {
                    retorno = false;
                }
                else if (Char.IsControl(e))
                {
                    retorno = false;
                }
                else if (Char.IsSeparator(e))
                {
                    retorno = false;
                }
                else
                {
                    retorno = true;
                }
                return retorno;
            //}
            //catch (Exception ex)
            //{
            //    return retorno;
            //}
        }

        public bool espaciosVaciosBlanco(String dato)
        {
            bool retorno = true;
            if (dato.Equals("") || dato.Count() == 0)
            {
                retorno = false;
            }
            return retorno;
        }
    }
}
