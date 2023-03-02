using Laboratorio1_Jairo_Alberto_Guaradado_Perez.Entidades;
using Laboratorio1_Jairo_Alberto_Guaradado_Perez.Negocio;
using System;

    Personas personas = new Personas();
    Clspersonas clspersonas = new Clspersonas();

        Console.WriteLine(" *** BIENVENIDO A NUESTRO PROGRAMA PARA CALCULAR TU IMC ***");

        Console.WriteLine(" *** Ingresa tu nombre: *** ");
        string Nombre = Console.ReadLine();

        Console.WriteLine(" *** Ingresa tu edad: *** ");
        int Edad = int.Parse(Console.ReadLine());

        Console.WriteLine(" *** Selecciona tu sexo Masculino(M) O Femenino(F): *** ");
        char sexo = char.Parse(Console.ReadLine());

        Console.WriteLine(" *** Digita tu peso en Kilogramos: *** ");
        int Peso = int.Parse(Console.ReadLine());

        Console.WriteLine(" *** Digita tu altura en Metros: *** ");
        double Altura = double.Parse(Console.ReadLine());

        double imc = Peso / Math.Pow(Altura, 2);
        Console.WriteLine(" Tu IMC es : " + imc );

       if (imc < 24)
       {
        Console.WriteLine(" Su IMC es ideal ");
       }

       else
       {
        Console.WriteLine(" Su IMC no es el ideal ");

       }

       if (Edad >= 18)
       {
        Console.WriteLine(" Es mayor de edad ");
       }
       else
       {
        Console.WriteLine(" Es menor de edad ");
       }
       personas.Nombre = Nombre;
       personas.Edad = Edad;
       personas.Sexo = sexo;
       personas.Peso = Peso;
       personas.Altura = Altura;

       clspersonas.AgregarPersonas(personas);

    foreach (var mostrar in clspersonas.ListarPersonas())
    {
        Console.WriteLine("Nombre: " + mostrar.Nombre);
        Console.WriteLine("Edad: " + mostrar.Edad);
        Console.WriteLine("Sexo: " + mostrar.Sexo);
        Console.WriteLine("Peso: " + mostrar.Peso + " KG ");
        Console.WriteLine("Altura: " + mostrar.Altura + " Metros ");
    }