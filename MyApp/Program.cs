using System;
using System.IO;
//punto 1
    try
    {
        Console.WriteLine("Ingrese un numero, no sea boludo.");
        int texto =  Convert.ToInt32(Console.ReadLine());
        
    }
    catch (System.Exception)
    {
        Console.WriteLine("Sos un boludo.");
        
    }


//punto2

try
{
    Console.WriteLine("Ingrese un numero.");
    float dividendo =  Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese otro numero.");
    float divisor =  Convert.ToInt32(Console.ReadLine());

    float total = dividendo/divisor;

    Console.WriteLine("Total "+total );
}
catch (FormatException ex)
{
    Console.WriteLine("ingreso valor invlido");
    
}
catch (Exception ex){
     Console.WriteLine("error");
}

//punto 3

try
{
    Console.WriteLine("Ingrese kilometros conducidos.");
    float kilometros =  Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Ingrese litros usados.");
    float litros =  Convert.ToInt32(Console.ReadLine());

    

    float total = kilometros/litros;

    Console.WriteLine("Total "+total );
}
catch (Exception ex)
{
    Console.WriteLine("error en los datos");
    
}