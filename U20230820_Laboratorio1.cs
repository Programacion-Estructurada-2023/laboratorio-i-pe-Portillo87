using System;

class Program
{
    static void Main(string[] args)
    {
        // PARTE I: Realizar la declaración y asignación de valores.
        // Declarar variables de tipo texto y capturar valores desde la consola.
        Console.Write("Ingrese el Departamento: ");
        string? departamento = Console.ReadLine();

        Console.Write("Ingrese el Municipio: ");
        string? municipio = Console.ReadLine();

        Console.Write("Ingrese la Ciudad: ");
        string? ciudad = Console.ReadLine();

        // Declarar y asignar valores a variables de texto.
        //Declarar dos variables de texto, asignando su valor desde la declaración. 
        string? colonia = "Ciudad jardin";
        string? colorCasa = "Celeste";

        // Declarar y asignar valores a variables enteras desde consola.
        Console.WriteLine("Ingresar los años que ha vivido en la direccion actual: ");
        string? añosResidencia = Console.ReadLine();

        Console.WriteLine("Ingresar su edad: ");
        string? edadActual = Console.ReadLine();

        // Declarar y asignar valores a variables DateTime.
        DateTime fechaNacimiento = new DateTime(1987, 12, 21); 
        DateTime fechaActual = DateTime.Now;

        // PARTE II: Realizar el proceso de asignación de funciones.
        
        // Aplicar funciones a variables de tipo str, bool, y int.
        bool comparacion = ciudad == municipio; 
        string? textoConcatenado = departamento + " - " + municipio + " - " + ciudad;
        string? mayusculaColonia = colonia.ToUpper();
        string? minusculaColonia = colonia.ToLower();
        string? cadenaLimpia = colorCasa.Trim();
        int longitudColonia = colonia.Length;
        int longitudColorCasa = colorCasa.Length;

        DateTime fecha_Actual = fechaActual.AddDays(14);
        DateTime fecha_especifica = fechaNacimiento.AddDays(14);
        bool mayorDate = fecha_Actual > fecha_especifica;
        bool menorDate = fecha_Actual < fecha_especifica;

        // Mostrar resultados.
        Console.WriteLine("************************Iniciando Imprimiendo de Datos**********************");
        Console.WriteLine("Variables tipo texto: " + colonia + ", " + colorCasa);
        Console.WriteLine("Comparación de cadenas: " + comparacion + " " + ciudad + ", " + municipio);
        Console.WriteLine("Impresion de variables tipo entero: " + añosResidencia + " años de residencia");
        Console.WriteLine("Impresion de variable tipo entero: " + edadActual + " años de edad");
        Console.WriteLine("Texto concatenado: " + textoConcatenado);
        Console.WriteLine("Funcion texto a mayúscula: " + mayusculaColonia);
        Console.WriteLine("Funcoion minuscula: " + minusculaColonia);
        Console.WriteLine("Funcion Cadena limpia: " + cadenaLimpia);
        Console.WriteLine("Imprimiendo fechas actuales y especificas: " + fechaActual + ", " + fechaNacimiento);
        Console.WriteLine("Longitud de la Colonia: " + longitudColonia);
        Console.WriteLine("Variable tipo date para DOB mas 2 semanas: " + fecha_especifica);
        Console.WriteLine("Variable tipo date mas 2 semanas " + fecha_Actual);
        Console.WriteLine("Longitud del Color de Casa: " + longitudColorCasa);
        Console.WriteLine("************************Fin de Imprimiendo de Datos**********************");
        Console.ReadKey();

        // Autoevaluacion 8 de 10.
    }
}
