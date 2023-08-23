using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaración y asignación de tipo texto.
            string? departamento, municipio, ciudad;
            Console.Write("\n Ingrese el nombre del departamento: ");
            departamento = Console.ReadLine();
            Console.Write("\n Ingrese el nombre del municipio: ");
            municipio = Console.ReadLine();
            Console.Write("\n Ingrese el nombre de la ciudad: ");
            ciudad = Console.ReadLine();

            string? colonia = "Ciudad Jardin";
            string? colorCasa = "Celeste";

            //Declaracion tipo int.
            int añosViviendo;
            int edadActual;
            Console.Write("\n Ingrese los años que lleva viviendo su casa: ");
            añosViviendo = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Ingrese su edad actual: ");
            edadActual = Convert.ToInt32(Console.ReadLine());

            DateTime fechaNacimiento = new DateTime(1987, 12, 21);
            DateTime fechaActual = DateTime.Now;

            //Aplicación de funciones a variables de texto.

            //Comparacion de cadenas.
            Console.WriteLine("\n************************Comparacion de cadenas**************************");
            Console.WriteLine("\n Colonia y Ciudad son iguales? >> " + string.Equals(colonia, ciudad));
            Console.WriteLine("\n Municipio y Ciudad son iguales? >> " + string.Equals(municipio, ciudad));

            //Funcion de concatenacion .
            string? concatenacion = departamento + " " + municipio +"  "+ ciudad;
            Console.WriteLine("\n Concatenación de texto >> " + concatenacion);

            //Funcion de mayusculas.
            string? mayusculas = departamento.ToUpper();
            Console.WriteLine("\n Departamento en mayúsculas >> " + mayusculas);

            //Funcion de limpiado
            string? limpiado = municipio.Trim();
            Console.WriteLine("\n Municipio limpiado de espacios >> " + limpiado);

            //Funcion de longitud.
            int longitudColonia = colonia.Length;
            int longitudColorCasa = colorCasa.Length;
            Console.WriteLine("\n Longitud de la Colonia >> " + longitudColonia);
            Console.WriteLine("\n Longitud del Color de Casa >> " + longitudColorCasa);

            //Aplicación de funciones a variables de fecha.

            //Formateo de fecha.
            Console.WriteLine("\n\n***************************Formateo de fechas**************************");
            Console.WriteLine("\n Fecha de nacimiento >> " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual >>> " + fechaActual.ToString("dd/MM/yyyy"));
            
            //Funcion de agregar semanas a las fecha.
            DateTime fechaNacimientoMas2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);

            Console.WriteLine("\n\n*********************Fechas con dos semanas adiciolanes****************");
            Console.WriteLine("\n Fecha de nacimiento + 2 semanas >> " + fechaNacimientoMas2Semanas.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual + 2 semanas >> " + fechaActualMas2Semanas.ToString("dd/MM/yyyy"));

            //Funcion de comparar fechas.
            bool fecha1Mayor = fechaNacimiento > fechaActual;
            bool fecha1Menor = fechaNacimiento < fechaActual;
            Console.WriteLine("\n Fecha de nacimiento mayor que fecha actual? >> " + fecha1Mayor);
            Console.WriteLine("\n Fecha de nacimiento menor que fecha actual? >> " + fecha1Menor);

            //Impresión de valores en consola.
            Console.WriteLine("\n\n*********************************************************************\n");
            Console.WriteLine("\n*******************Inicio de impresion de valores***********************" );
            Console.WriteLine("\n\n**************Valores ingresados de variables de texto*****************");
            Console.WriteLine("\n Departamento >> " + departamento);
            Console.WriteLine("\n Municipio >> " + municipio);
            Console.WriteLine("\n Ciudad >> " + ciudad);
            Console.WriteLine("\n Colonia >> " + colonia);
            Console.WriteLine("\n Color de Casa >> " + colorCasa);

            Console.WriteLine("\n\n*********************Valores de variable enteras***********************");
            Console.WriteLine("\n Años de vivir en su casa actual >> " + añosViviendo);
            Console.WriteLine("\n Edad actual >> " + edadActual);

            Console.WriteLine("\n\n*************************Comparacion de cadenas************************");
            Console.WriteLine("\n Colonia y Ciudad son iguales >> " + string.Equals(colonia, ciudad));
            Console.WriteLine("\n Municipio y Ciudad son iguales >> " + string.Equals(municipio, ciudad));

            Console.WriteLine("\n\n***************Valores obtenidos de funciones de fecha*****************");
            Console.WriteLine("\n Fecha de nacimiento >> " + fechaNacimiento.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n Fecha actual >> " + fechaActual.ToString("dd/MM/yyyy"));
            Console.WriteLine("\n*************************Fin de impresion******************************\n");
            Console.WriteLine("\n***********************************************************************\n");

            //Autoevaluacion 8 de 10.

        }
    }
}