try

{

    // decimal[] typedNumbers = new decimal[2];
    List<decimal> typedNumbers = new List<decimal>();


    decimal result;
    int typedOperation;
    //var continueTypingNumbers = 1;
    int continueTypingNumbers;

    Console.WriteLine("Esta es la mejoL calculadora!!!");

    Console.WriteLine("porfavor digite el primer número");

    //typedNumbers[0] = Convert.ToDecimal(Console.ReadLine());
    typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));


    //Console.WriteLine("porfavor digite el segundo número");

    ////typedNumbers[1] = Convert.ToDecimal(Console.ReadLine());
    //typedNumbers.Add(Convert.ToDecimal(Console.ReadLine()));

    //Console.WriteLine("Quieres seguir digitnado numeros 1. Si, 2. No?");

    // continueTypingNumbers = Convert.ToInt32(Console.ReadLine());

    //AND && y Conjuncion
    //v y v = v
    //v y f = f
    //f y v = f
    //f y f = f

    //OR || y Disyuncion
    //v o v = v
    //v o f = v
    //f o v = v
    //f o f = f

    //NOT ! y Negacion
    //!v = f
    //!f = v

    //var edad = 18;
    //var esMayorDeEdad = true;
    //var tieneLicencia = true;

    //if(edad >=16 && (esMayorDeEdad || tieneLicencia))
    //{
    //    Console.WriteLine("Puedes conducir");
    //}
    //else
    //{
    //    Console.WriteLine("No puedes conducir");
    //}
    //if (edad >= 18)
    //{
    //    if (esMayorDeEdad)
    //    {
    //        if (tieneLicencia)
    //        {
    //            Console.WriteLine("Puedes conducir");
    //        }
    //        else
    //        {
    //            Console.WriteLine("No puedes conducir");
    //        }
    //    }
    //    else
    //    {
    //        Console.WriteLine("No puedes conducir");
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("No puedes conducir");
    //}
    // int index = 2;
    //while (continueTypingNumbers == 1)
    //{
    //    Console.WriteLine("porfavor digite el siguiente número");
    //    decimal newTypedNumber = Convert.ToDecimal(Console.ReadLine());
    //    typedNumbers.Add(newTypedNumber);
    //    //var oldTypedNumbers = typedNumbers;

    //    //typedNumbers = new decimal[index + 1];

    //    //for (int i = 0; i < oldTypedNumbers.Length; i++)
    //    //{
    //    //    typedNumbers[i] = oldTypedNumbers[i];
    //    //}

    //    //typedNumbers = typedNumbers.Concat(new decimal[] { newTypedNumber }).ToArray();
    //    //typedNumbers = typedNumbers.Append(newTypedNumber).ToArray();


    //    //typedNumbers[index] = newTypedNumber;
    //    //index++;


    //    Console.WriteLine("Quieres seguir digitnado numeros 1. Si, 2. No?");
    //    continueTypingNumbers = Convert.ToInt32(Console.ReadLine());
    //}

    do
    {
        Console.WriteLine("porfavor digite el siguiente número");
        decimal newTypedNumber = Convert.ToDecimal(Console.ReadLine());
        typedNumbers.Add(newTypedNumber);

        Console.WriteLine("Quieres seguir digitnado numeros 1. Si, 2. No?");
        continueTypingNumbers = Convert.ToInt32(Console.ReadLine());

    }
    while (continueTypingNumbers == 1);

    Console.WriteLine("Porfavor digite el tipo de operacion que desea (solo el número");
    Console.WriteLine("1. Suma, 2. Resta, 3. Multiplicación, 4. División 5. Salir");


    typedOperation = Convert.ToInt32(Console.ReadLine());

    result = 0;
    switch (typedOperation)
    {
        case 1:
            {
                //for (int i = 0; i < typedNumbers.Length - 1; i++)
                //{
                //    result = result + typedNumbers[i];

                //}
                //for (int i = 0; i < typedNumbers.Count - 1; i++)
                //{
                //    result = result + typedNumbers[i];

                //}
                foreach (var number in typedNumbers)
                {
                   // result = result + number;
                     result += number;
                }
                break;
            }
        case 2:
            {
                foreach (var number in typedNumbers)
                {
                    result -= number;
                }
                break;
            }
        case 3:
            {
                foreach (var number in typedNumbers)
                {
                    result *= number;
                }
                break;
            }
        case 4:
            {

                foreach (var number in typedNumbers)
                {
                    result /= number;
                }

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

    Console.WriteLine($"Detalle del error: {ex.Message}");
}
finally
{
    Console.WriteLine("Gracias por usar la calculadora!!!");
}



Console.ReadKey();