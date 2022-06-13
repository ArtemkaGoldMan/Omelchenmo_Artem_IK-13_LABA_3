using System;
using System.Collections.Generic;

namespace LABA3
{
    public class Coffee
    {
       
        public string NameOfCoffee { get; set; }
        public string SortofCoffee { get; set; }
        public int weightOfCoffe { get; set; }
        public string PhysicCondition { get; set; }
        public int PriceForKg { get; set; }
        public int weightOfPack { get; set; }
        
      

    }
    public class Arabica : Coffee
    {
        public Arabica(string name, string condition, int weihhtcoffe, int weightpack, int price)
        {
            NameOfCoffee = name;
            SortofCoffee = "Арабiка";
            weightOfCoffe = weihhtcoffe;
            PhysicCondition = condition;
            PriceForKg = price;
            weightOfPack = weightpack;
        }

    }
    public class Canephora : Coffee
    {
        public Canephora(string name, string condition, int weihhtcoffe, int weightpack, int price)
        {
            NameOfCoffee = name;
            SortofCoffee = "Канефора";
            weightOfCoffe = weihhtcoffe;
            PhysicCondition = condition;
            PriceForKg = price;
            weightOfPack = weightpack;
        }
    }
    public class Liberica : Coffee
    {
        public Liberica(string name, string condition, int weihhtcoffe, int weightpack, int price)
        {
            NameOfCoffee = name;
            SortofCoffee = "Лiберiка";
            weightOfCoffe = weihhtcoffe;
            PhysicCondition = condition;
            PriceForKg = price;
            weightOfPack = weightpack;
        }
    }
    public class Other : Coffee
    {
        public Other(string name, string condition, int weihhtcoffe, int weightpack, int price)
        {
            NameOfCoffee = name;
            SortofCoffee = "Iнший";
            weightOfCoffe = weihhtcoffe;
            PhysicCondition = condition;
            PriceForKg = price;
            weightOfPack = weightpack;
        }
    }
    public class VanOfCoffe
    {
        List<Coffee> CoffeVan = new List<Coffee>();
        public void AddCoffeToVan(Coffee pack)
        {
            CoffeVan.Add(pack);
        }
        public void sortofweight()
        {
            Console.WriteLine(new String('-', 50));
            CoffeVan.Sort((x, y) => (x.weightOfCoffe + x.weightOfPack) > (y.weightOfCoffe + y.weightOfPack) ? -1 : 1);
            Console.WriteLine("Sort coffee by weight");
            foreach (var obj in CoffeVan)
                Console.WriteLine(obj.SortofCoffee + " " + (obj.weightOfCoffe + obj.weightOfPack) + " KG");
            CoffeVan.Sort((x, y) => (x.weightOfCoffe + x.weightOfPack) > (y.weightOfCoffe + y.weightOfPack) ? 1 : -1);
            Console.WriteLine(new String('-', 50));
        }
        public void FindNeededOne()
        {
            Console.WriteLine("list of sorts: Арабiка, Канефора, Лiберiка, Iнший   (Choose one)");
            string name = Console.ReadLine();

            Console.WriteLine("list of condition: Мелена, Зерно, Банка, Пакет   (Choose one)");
            string condition = Console.ReadLine();

            Console.WriteLine("Choose weight (down and up)");
            int down = Int32.Parse(Console.ReadLine());
            int up = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Choose price (down and up)");
            int downP = Int32.Parse(Console.ReadLine());
            int upP = Int32.Parse(Console.ReadLine());

            foreach (var obj in CoffeVan)
            {
                if (obj.SortofCoffee == name)
                {
                    if (obj.PhysicCondition == condition)
                    {
                        if (obj.weightOfCoffe > down && obj.weightOfCoffe < up)
                        {
                            if (obj.PriceForKg > downP && obj.PriceForKg < upP)
                            {
                                Console.WriteLine($"Name:{obj.NameOfCoffee}, Sort:{obj.SortofCoffee}, Price for Kg:{obj.PriceForKg},Weight{obj.weightOfCoffe}, Full price: {obj.PriceForKg * obj.weightOfCoffe}");
                            }
                        }
                    }
                }
            }
            Console.WriteLine(new String('-', 50));
        }
        public void sortofPrice()
        {
            Console.WriteLine(new String('-', 50));
            CoffeVan.Sort((x, y) => x.PriceForKg > y.PriceForKg ? -1 : 1);
            Console.WriteLine("Sort coffee by price");
            foreach (var obj in CoffeVan)
                Console.WriteLine(obj.NameOfCoffee + " " + obj.SortofCoffee + " " + obj.PriceForKg + " $");
            CoffeVan.Sort((x, y) => x.PriceForKg > y.PriceForKg ? 1 : -1);
            Console.WriteLine(new String('-', 50));
        }

    }

    class Program
    {
        public static void Main()
        {
            Arabica pack1 = new Arabica("Арабiка Номер 1", "Мелена", 20, 1, 40);
            Arabica pack2 = new Arabica("Найлiпше кофе"  , "Зерно ", 10, 1, 100);
            Canephora pack3 = new Canephora("Топова Канефора", "Банка", 15, 1, 35);
            Canephora pack4 = new Canephora("Канефора з Фори", "Пакет", 50, 3, 160);
            Liberica pack5 = new Liberica("Смакак", "Мелена", 20, 1, 30);
            Liberica pack6 = new Liberica("Лiбер Мана", "Зерно", 18, 1, 47);
            Other pack7 = new Other("Дешева Шляпа", "Банка", 5, 1, 10);
            Other pack8 = new Other("NoNAme", "Пакет", 30, 1, 75);

            var CofeeVan = new VanOfCoffe();
            CofeeVan.AddCoffeToVan(pack1);
            CofeeVan.AddCoffeToVan(pack2);
            CofeeVan.AddCoffeToVan(pack3);
            CofeeVan.AddCoffeToVan(pack4);
            CofeeVan.AddCoffeToVan(pack5);
            CofeeVan.AddCoffeToVan(pack6);
            CofeeVan.AddCoffeToVan(pack7);
            CofeeVan.AddCoffeToVan(pack8);
            CofeeVan.FindNeededOne();
            CofeeVan.sortofweight();
            CofeeVan.sortofPrice();


        }
       
    }
}
