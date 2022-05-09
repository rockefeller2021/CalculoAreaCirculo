using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Circulo
{
    static public float radio, diametro;

    public float Radio
    {
        set { radio = value; }
        get { return radio; }


    }

    public float Diametro
    {
        set { diametro = value; }
        get { return diametro; }

    }


}
class DatosNumero : Circulo
{

    public DatosNumero()
    {



    }
    public void Area()
    {
        
       
       
            var area = Math.PI * Math.Pow(Radio, 2);
            Console.WriteLine("El area del circulo es: " + area);
       
     }

    public void Perimetro()
        {
             
       
            var perimetro = Math.PI * Diametro ;
            Console.WriteLine("El perimetro del circulo es: " + perimetro);

         }


    
   

    static void Main(string[] args)
    {
        

        Circulo ingresaNum = new Circulo();


        Console.WriteLine("\n\nDigita el valor del radio del Circulo :  "); //metodo ingreso valor de la base
        ingresaNum.Radio = (float)Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("\n\nDigita el valor del diametro del Circulo :  "); //metodo ingreso valor de la base
        ingresaNum.Diametro = (float)Convert.ToInt32(Console.ReadLine());

        DatosNumero dato = new DatosNumero();
        dato.Area();
        dato.Perimetro();

    }
}






