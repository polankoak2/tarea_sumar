// See https://aka.ms/new-console-template for more information
//Declaración de variables

int num1, num2, suma=0;

// Se ingresan datos por pantalla

    Console.WriteLine("Ingrese un numero:");
    num1 = int.Parse(Console.ReadLine());

    if (num1 % 2 != 0)
    {
        Console.WriteLine("Numero Impar, continue con el siguiente...");
    }
    else
    {
        Console.WriteLine("Numero Par, ingrese otro numero");
    }
    Console.WriteLine("Ingrese otro numero:");
    num2 = int.Parse(Console.ReadLine());

    if (num2 % 2 != 0)
    {
        Console.WriteLine("Numero Impar");
    }
    else
    {
        Console.WriteLine("Numero Par, ingrese otro numero");
    }

//Operación de suma

    suma = num1 + num2;

// Muestra el resultado por pantalla

Console.WriteLine("La suma de los números es: " +suma);

Console.WriteLine("Press any key to continue...");
Console.ReadKey(true);
