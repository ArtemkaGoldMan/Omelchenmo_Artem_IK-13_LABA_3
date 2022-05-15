using System;

namespace Laba3
{
    class Drib
    {
        public double Chyseln { get; set; }
        public double Znamenn { get; set; }
        public string znak { get; set; }
        public static string MakeDrib(Chyslo chyslo, Znak znak)
        {
            return znak.znak + (chyslo.Chyseln / chyslo.Znamenn).ToString();
            
        }
        public static double Plus(double Drib1, double Drib2)
        {
            return Drib1 + Drib2;
        }
        public static double Minus(double Drib1, double Drib2)
        {
            return Drib1 - Drib2;
        }
        public static double Mnozenia(double Drib1, double Drib2)
        {
            return Drib1 * Drib2;
        }
        public static double dilenia(double Drib1, double Drib2)
        {
            return Drib1 / Drib2;
        }

    }
    class Chyslo : Drib
    {
        
        public Chyslo(int Chyselnyk,int Znamennyk)
        {
            Chyseln = Chyselnyk;
            Znamenn = Znamennyk;

        }
       
    }
    class Znak:Drib
    {
        
        public Znak(string zn)
        {
            this.znak = zn;
        }
    }
  
    class Program
    {
        public static void Main(string[] args)
        {
            Chyslo chyslo1 = new Chyslo(1,2);
            Znak znak1 = new Znak("-");
            double Drib1 = Double.Parse(Drib.MakeDrib(chyslo1,znak1));
            Console.WriteLine("Drib1= " + Drib1);

            Chyslo chyslo2 = new Chyslo(5, 7);
            Znak znak2 = new Znak("-");
            double Drib2 = Double.Parse(Drib.MakeDrib(chyslo2, znak2));
            Console.WriteLine("Drib2= " + Drib2);

            Console.WriteLine("Plus = "+ Drib.Plus( Drib1, Drib2));
            Console.WriteLine("Minus = " + Drib.Minus(Drib1, Drib2));
            Console.WriteLine("Mnozenia = " + Drib.Mnozenia(Drib1, Drib2));
            Console.WriteLine("Dilenia = " + Drib.dilenia(Drib1, Drib2));
        }
       
    }
}
