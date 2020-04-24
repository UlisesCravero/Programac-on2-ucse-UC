using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Logica;

namespace Practica4
{
    public sealed class Palabra
    {
        public string elString { get; set; }
    }

    public static class Extension
    {
        public static int CantidadPalabras(this Palabra p)
        {
            int resultado = p.elString.Split(' ').Length;
            return resultado;
        }

        public static int CantidadPalabras(this Palabra p, char caracter)
        {
            int resultado = p.elString.Split(caracter).Length;
            return resultado;
        }

        public static decimal DiferenciaFechas(this DateTime fecha1, DateTime fecha2)
        {
            int a = DateTime.Compare(fecha1, fecha2);
            TimeSpan resultado;

            if (a > 0)
            {
                resultado = fecha1.Subtract(fecha2);
            }
            else
            {
                resultado = fecha2.Subtract(fecha1);
            }

            return (Convert.ToDecimal(resultado.TotalSeconds) / 60);
        }

        public static decimal Promediolist(this List<int> enteros)
        {
            int suma = 0;
            foreach (var entero in enteros)
            {
                suma = suma + entero;
            }
            return suma / enteros.Count;
        }

        public static int SumaParRestaImpar(this List<int> enteros)
        {
            int sumaPares = 0;
            int restaImpares = 0;
            foreach (var entero in enteros)
            {
                if (entero % 2 == 0)
                {
                    sumaPares = sumaPares + entero;
                }
                else
                {
                    restaImpares = restaImpares - entero;
                }
            }
            return (sumaPares * restaImpares);
        }

        public static DateTime MostrarFechaComoString(this string fechaString)
        {
            try
            {
                DateTime fechaDate = DateTime.Parse(fechaString);
                return fechaDate;
            }
            catch(Exception e)
            {
                return DateTime.MinValue;
            }
        }

        public static string InvertirString(this string a)
        {
            char[] aux = a.ToCharArray();
            Array.Reverse(aux);
            return new string(aux);
        }

        public static string CrearStringDeUnArray(this string[] a, char separador)
        {
            string resultado= "";
            for (int i = 0; i < (a.Count()); i++)
            {
                if (i == 0)
                    resultado = a[i];
                else
                    resultado = resultado + separador + a[i]; 
            }
            return resultado;
        }

        public static bool SaberSiEsMail(this string email)
        {
            Regex regexMail = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regexMail.IsMatch(email);
           
            /*string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email,expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                   return true;
                else
                   return false;
            }
            else
            {
                return false;
            }*/
        }



    }

    public class Cliente
    {
        public string nombre { get; set; }
        public int cuit { get; set; }
        public double saldo { get; set; }

        public static Cliente operator -(Cliente cliente1, Cliente cliente2)
        {
            cliente1.saldo = (cliente1.cuit == cliente2.cuit) ? cliente1.saldo - cliente2.saldo : Math.Max(cliente1.saldo, cliente2.saldo);
            return cliente1;            
        }
    }

    public static class Temperatura
    {
        public static Double FarenheitACelcius(Double t)
        {
            return t / 2.12;
        }

        public static Double CelciusAFarenheit(Double t)
        {
            return t * 2.12;
        }
    }

    //----------------------DELEGADOS------------------------------
    class Delegado
    {
        public delegate string IdentificationNumero(int numero);
    }

    class Ejemplo
    {
        public string TipoNumero(int valorNumerico)
        {
            return valorNumerico > 0 ? "positivo" : valorNumerico < 0 ? "negativo" : "cero";
        }                                   
    }

    class OtroEjemplo
    {
        public static string TipoNumero(int valorNumerico)
        {
            return valorNumerico > 0 ? "+" : valorNumerico < 0 ? "-" : "";
        }                                   
    }
    //-------------------------------------------------------------------------


    class Program
    {
        static void Main(string[] args)
        {
            
            //--------------------------        1       -------------------------------
            Palabra unaPalabra = new Palabra();
            unaPalabra.elString = Console.ReadLine();
            Console.WriteLine(Extension.CantidadPalabras(unaPalabra));
            //--------------------------        3       -------------------------------
            DateTime fecha1 = new DateTime(1995,12,1,15,16,58);
            DateTime fecha2 = new DateTime(1995,12,3,15,16,58);
            Console.WriteLine(Extension.DiferenciaFechas(fecha1, fecha2));
            //-------------------------------------------------------------------------

            string[] a = new string[3];
            a[0] = "hola";
            a[1] = "como";
            a[2] = "va?";

            Console.WriteLine(Extension.CrearStringDeUnArray(a, '/'));
            //------------------------------- -------------------------------
            Console.WriteLine("Ingrese su mail");
            string email = "ulisescrave}{ro95@gmail.com";
            if (Extension.SaberSiEsMail(email))
	        {
                Console.WriteLine("Escrito correctamente");
	        }else
            {
                Console.WriteLine("Escrito mal");
            }
            //------------------------------------------------------------
            

            //--------------------------------------------------------------------
            Ejemplo ejemplo = new Ejemplo();

            

            Console.ReadLine();
        }
    }
}
