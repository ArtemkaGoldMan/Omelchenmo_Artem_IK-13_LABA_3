using System;

namespace LabaProgaAssist
{
    class Program
    {
        static void Main(string[] args)
        {
            Drib drib1 = new Drib(1 ,2,'-');

            Drib drib2 = new Drib(1, 2, '+');

            drib1.WriteDrib();
            drib2.WriteDrib();
            drib1.Multiplication(drib2);
            drib1.Division(drib2 );
            drib1.Minus(drib2);
            drib1.Plus(drib2);

        }
        
    }

    class Number
    {
        public double Value { get; set; }
        public Number(double numb)
        {
            this.Value = numb;
        }
    }

    class Znak
    {
        public char Value { get; set; }
        public Znak(char numb)
        {
            this.Value = numb;
        }
    }

    class Drib
    {

        public Znak Znak;
        public Number Chiselnyk;
        public Number Znamenyk;
        
        public Drib(double chyselnyk, double znamennyk, char znak )
        {
            this.Chiselnyk = new Number (chyselnyk);
            this.Znamenyk = new Number(znamennyk);
            this.Znak = new Znak(znak);
        }

        public void WriteDrib()
        {
            Console.WriteLine(Znak.Value.ToString()+""+Chiselnyk.Value+"/"+Znamenyk.Value);
        }
        public void Multiplication(Drib drib2)
        {
            if(Znak.Value != drib2.Znak.Value)
            {
                Console.WriteLine("-"+(Chiselnyk.Value*drib2.Chiselnyk.Value)+"/"+(Znamenyk.Value*drib2.Znamenyk.Value)+" = "+ (-1*(Chiselnyk.Value * drib2.Chiselnyk.Value)/(Znamenyk.Value * drib2.Znamenyk.Value)));
            }
            else
            {
                Console.WriteLine("Multiplication " + (Chiselnyk.Value * drib2.Chiselnyk.Value) + "/" + (Znamenyk.Value * drib2.Znamenyk.Value) + " = " +(Chiselnyk.Value * drib2.Chiselnyk.Value)/(Znamenyk.Value * drib2.Znamenyk.Value));
            }
        }

        public void Division(Drib drib2)
        {
            if (Znak.Value != drib2.Znak.Value)
            {
                Console.WriteLine("-" + (Chiselnyk.Value * drib2.Znamenyk.Value) + "/" + (Znamenyk.Value * drib2.Chiselnyk.Value) + " = " + (-1 * (Chiselnyk.Value * drib2.Znamenyk.Value) / (Znamenyk.Value * drib2.Chiselnyk.Value)));
            }
            else
            {
                Console.WriteLine("Division "+ (Chiselnyk.Value * drib2.Znamenyk.Value) + "/" + (Znamenyk.Value * drib2.Chiselnyk.Value) + " = " + (Chiselnyk.Value * drib2.Znamenyk.Value) / (Znamenyk.Value * drib2.Chiselnyk.Value));
            }
        }

        public void Plus(Drib drib2)
        {
            int znak1;
            
            if(Znak.Value == '-')
            {
                znak1 = -1;
            }
            else
            {
                znak1 = 1;
            }
            int znak2;
            if (drib2.Znak.Value == '-')
            {
                znak2 = -1;
            }
            else
            {
                znak2 = 1;
            }
            Console.WriteLine("Plus " + ((znak1* Chiselnyk.Value* drib2.Znamenyk.Value) +(znak2* drib2.Chiselnyk.Value*Znamenyk.Value))/(Znamenyk.Value*drib2.Znamenyk.Value));
        }

        public void Minus(Drib drib2)
        {
            int znak1;
            int znak2;
            if (Znak.Value == '-')
            {
                znak1 = -1;
            }
            else
            {
                znak1 = 1;
            }
            if (drib2.Znak.Value == '-')
            {
                znak2 = -1;
            }
            else
            {
                znak2 = 1;
            }
            Console.WriteLine("Minus "+ ((znak1 * Chiselnyk.Value * drib2.Znamenyk.Value) - (znak2 * drib2.Chiselnyk.Value * Znamenyk.Value)) / (Znamenyk.Value * drib2.Znamenyk.Value));
        }
    }
}
