using System;

namespace Generic_type__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BasketList<string> basketList = new BasketList<string>();

            BasketList<string> Lemonlist = new BasketList<string>();
            Lemonlist.Add("fruktoz");
            Lemonlist.Add("poatzyum");
            Lemonlist.Add("kalsiyum");
            Lemonlist.Add("maqneziyum");
            Lemonlist.Add("lif");
            Lemonlist.Add("mis");
            Lemonlist.Add("anythg");
            Console.WriteLine($"Count is" + " " + Lemonlist.Count);
            foreach (string item in Lemonlist.GetVitArr())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");

            BasketList<string> PineAppleList = new BasketList<string>();
            PineAppleList.Add("VitaminA");
            PineAppleList.Add("VitaminB6");
            PineAppleList.Add("VitaminC");
            PineAppleList.Add("VitaminK");
            PineAppleList.Add("VitaminE");
            Console.WriteLine($"Count is" + " " + PineAppleList.Count);
            foreach (string item in PineAppleList.GetVitArr())
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(" ");

            BasketList<string> AppleList = new BasketList<string>();
            AppleList.Add("VitaminC");
            AppleList.Add("Potazyum");
            AppleList.Add("VitaminK");
            Console.WriteLine($"Count is" + " " + AppleList.Count);
            foreach (string fruit in AppleList.GetVitArr())
            {
                Console.WriteLine(fruit);
            }
        }
    }
}
