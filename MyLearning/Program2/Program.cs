try

{

    Console.WriteLine("Esta es la mejoL calculadora!!!");

    decimal typedNumber1 = 0;
    decimal typedNumber2 = 0;
    decimal result = 0;
    int typedOperation = 0;


    Console.WriteLine("porfavor digite el primer número");
    //try
    //{
    typedNumber1 = Convert.ToDecimal(Console.ReadLine());
    //}
    //catch (Exception)
    //{ 
    //    Console.WriteLine("Error: tu si eres palomo");
    //}

    Console.WriteLine("porfavor digite el segundo número");

    //try
    //{
    typedNumber2 = Convert.ToDecimal(Console.ReadLine());
    //}
    //catch (Exception)
    //{
    //    Console.WriteLine("Error: tu si eres palomo");
    //}


    Console.WriteLine("Porfavor digite el tipo de operacion que desea (solo el número");
    Console.WriteLine("1. Suma, 2. Resta, 3. Multiplicación, 4. División 5. Salir");

    //try
    //{
    typedOperation = Convert.ToInt32(Console.ReadLine());
    //}
    //catch (Exception)
    //{
    //    Console.WriteLine("Error: tu si eres palomo");
    //}


    switch (typedOperation)
    {
        case 1:
            {
                result = typedNumber1 + typedNumber2;
                break;
            }
        case 2:
            {
                result = typedNumber1 - typedNumber2;
                break;
            }
        case 3:
            {
                result = typedNumber1 * typedNumber2;
                break;
            }
        case 4:
            {
                //if (typedNumber2 != 0)
                //{
                result = typedNumber1 / typedNumber2;
                //}
                //else
                //{
                //    Console.WriteLine("Error: No se puede dividir entre cero");
                //}
                break;
            }
        default:
            {
                Console.WriteLine("Saliendo.....");
                break;
            }

    }
     

    if (typedOperation != 5)
    {
        Console.WriteLine($"El resultado de la operación es: {result}");

    }
    else
    {
        Console.WriteLine($"Saliendo.....");

    }

}
catch (Exception ex)
{
    Console.WriteLine("Error: tu si eres palomo");
    //Console.WriteLine($"Detalle del error: {ex.Message}");

    //if (ex.Message.Contains("was not in a correct format."))
    //{
    //    Console.WriteLine("Parece que has ingresado un valor no numérico. Por favor, asegúrate de ingresar solo números válidos.");
    //}
    //else
    //{
        Console.WriteLine($"Detalle del error: {ex.Message}");
    //}
}
finally
{
    Console.WriteLine("Gracias por usar la calculadora!!!");
}



Console.ReadKey();