using System;
using System.IO;
using System.Net;
using System.Text.Json;
using System.Text.Json.Serialization;
using NewClass;
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

// punto 4













List<Provincia> provincias = new List<Provincia>();
var url = "https://apis.datos.gob.ar/georef/api/provincias?campos=id,nombre ";
var request = (HttpWebRequest) WebRequest.Create(url);
request.Method = "GET";
request.ContentType = "application/json";
request.Accept = "application/json";

try{
    using(WebResponse respuesta = request.GetResponse()){
        using(Stream StreamReader = respuesta.GetResponseStream()){
            if (StreamReader != null)
            {
                using (StreamReader objReader = new StreamReader(StreamReader))
                {
                    string responseBody = objReader.ReadToEnd();
                    provincias = JsonSerializer.Deserialize<List<Provincia>>(responseBody);
                    foreach (Provincia provincia in provincias)
                    {
                        Console.WriteLine(provincia.Nombre);
                        Console.WriteLine(provincia.Id);
                    }
                }
            }else
            {
                Console.WriteLine("No Responde");
            }
        }
    }
            
}catch(WebException e){
        Console.WriteLine(e.Message);
}