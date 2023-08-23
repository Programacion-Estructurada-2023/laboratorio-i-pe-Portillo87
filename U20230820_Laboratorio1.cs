using System;

namespace VariablesDeclaracion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración y captura de valores desde la consola
            Console.Write("Ingrese el departamento: ");
            string? departamento = Console.ReadLine();

            Console.Write("Ingrese el municipio: ");
            string? municipio = Console.ReadLine();

            Console.Write("Ingrese la ciudad: ");
            string? ciudad = Console.ReadLine();

            // Declaración y asignación de variables de tipo texto
            string? colonia = "Ciudad Jardin";
            string? colorDeCasa = "Celeste";

            // Declaración y captura de valores enteros desde la consola
            Console.Write("Ingrese los años de vivir en su colonia: ");
            string? añosResidencia = Console.ReadLine();

            Console.Write("Ingrese su edad actual: ");
            string? edadActual = Console.ReadLine();

            // Declaración y asignación de variables de tipo Fecha y tiempo
            DateTime fechaNacimiento = new DateTime(1987, 12, 21); 
            DateTime fechaActual = DateTime.Now;

            // Aplicar función para comparar cadenas
            bool sonIguales = string.Equals(departamento, municipio, StringComparison.OrdinalIgnoreCase);

            // Aplicar función para concatenar texto
            string direccion = ciudad + ", " + municipio + ", " + departamento;

            // Aplicar función de Mayuscula
            string ciudadEnMayuscula = ciudad.ToUpper();

            // Aplicar función de limpiado de cadenas
            string coloniaLimpia = colonia.Trim();

            // Aplicar función de longitud de cadenas
            int longitudCiudad = ciudad.Length;
            int longitudColonia = colonia.Length;

            // Aplicar función de formateo de fechas
            string fechaNacimientoFormateada = fechaNacimiento.ToString("dd/MM/yyyy");
            string fechaActualFormateada = fechaActual.ToString("dd/MM/yyyy");

            // Adicionar 2 semanas a cada fecha ingresada
            DateTime fechaNacimientoMas2Semanas = fechaNacimiento.AddDays(14);
            DateTime fechaActualMas2Semanas = fechaActual.AddDays(14);

            // Comparar las fechas
            bool fecha1Mayor = fechaNacimiento > fechaActual;
            bool fecha1Menor = fechaNacimiento < fechaActual;

            // Imprimir los resultados.
            Console.WriteLine("***************Imprimiendo Datos**************:");
            Console.WriteLine("Departamento: {departamento}");
            Console.WriteLine("Municipio: {municipio}");
            Console.WriteLine("Ciudad: {ciudad}");
            Console.WriteLine("Colonia: {colonia}");
            Console.WriteLine("Color de casa: {colorDeCasa}");

            Console.WriteLine("Valores de variables enteras:");
            Console.WriteLine("Años de vivir en su residencia actual: {anosDeResidencia}");
            Console.WriteLine("Edad actual: {edadActual}");

            Console.WriteLine("Comparaciones de cadenas:");
            Console.WriteLine("Las cadenas 'departamento' y 'municipio son iguales: {sonIguales}");

            Console.WriteLine("Valores de funciones de fecha:");
            Console.WriteLine("Fecha de nacimiento formateada: {fechaNacimientoFormateada}");
            Console.WriteLine("Fecha actual formateada: {fechaActualFormateada}");
            Console.WriteLine("Fecha de nacimiento + 2 semanas: {fechaNacimientoMas2Semanas}");
            Console.WriteLine("Fecha actual + 2 semanas: {fechaActualMas2Semanas}");
            Console.WriteLine("Fecha de nacimiento mayor que fecha actual: {fecha1Mayor}");
            Console.WriteLine("Fecha de nacimiento menor que fecha actual: {fecha1Menor}");
            Console.WriteLine("***************Fin de Imprimiendo de Datos**************:");

            //Autoevalacion 8 de 10.
        }
    }
}
