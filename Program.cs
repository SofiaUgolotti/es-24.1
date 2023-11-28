using es_24._1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        Console.WriteLine("inserisci lato quadrato");
        float lato= float.Parse (Console.ReadLine());   
        Quadrato quadrato = new Quadrato();
        quadrato.Lato = lato;
        float superficie = quadrato.CalcolaSuperficie();
        Console.WriteLine($"la superficie del quadrato con lato {lato} è: {superficie}");
        Console.ReadLine ();
    }
}
