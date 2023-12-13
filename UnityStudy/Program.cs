using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace UnityStudy
{

    class Program
    {
        public static List<Item> items = new List<Item>();
        const int loofCount = 10;
        static Random random = new Random();
        public struct Item
        {
            public uint index;
            public string color;
            public double price;
            public int quantity;


            public static double PriceRange()
            {
                double price = random.Next(50, 801) + random.NextDouble();
                return price;
            }

            public static int QuantityRange()
            {
                int qt = random.Next(2, 11);
                return qt;
            }

            public static string ColorResult()
            {
                string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Purple" };
                int randomindex = random.Next(0, colors.Length);
                return colors[randomindex];
            }
        }

        static void Init()
        {
            Console.WriteLine("원본");
            for (uint i = 1; i < loofCount + 1; i++)
            {
                Item myItem = new Item
                { index = i, color = Item.ColorResult(), price = Item.PriceRange(), quantity = Item.QuantityRange() };
                items.Add(myItem);
            }
            foreach (var item in items)
            {
                Console.WriteLine($"Index: {item.index}, Price: {item.price:F2}, Color: {item.color}, Quantity: {item.quantity}");
            }
            Console.WriteLine("작업1");
            List<Item> task1List = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                Item copyItem = items[i];
                float ratio = 1 / copyItem.quantity;
                copyItem.quantity--;
                copyItem.price *= (1 + ratio); 
                task1List.Add(copyItem);
            }

            foreach (var item in task1List)
            {
                Console.WriteLine($"Index: {item.index}, Price: {item.price:F2}, Color: {item.color}, Quantity: {item.quantity}");
            }

            Console.WriteLine("작업2");
            List<Item> sortedItem = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                sortedItem.Add(items[i]);
            }
            List<Item> task2List = sortedItem.OrderBy(x => x.color).ThenBy(x => x.price).ThenBy(x => x.quantity).ToList<Item>();

            foreach (var item in task2List)
            {
                Console.WriteLine($"Index: {item.index}, Price: {item.price:F2}, Color: {item.color}, Quantity: {item.quantity}");
            }

            Console.WriteLine("작업3");
            List<Item> sortedByColor = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                sortedByColor.Add(items[i]);
            }
            List<Item> task3List = sortedByColor.OrderBy(x => x.color).ToList<Item>();
            for (int i = 0; i < task3List.Count; i++)
            {
                double avg = task3List.Where(condition => condition.color == task3List[i].color).Average(item => item.price);
                Console.WriteLine($"Color: {task3List[i].color}, AVG: {avg}");
            }
            Console.WriteLine("검산");
            foreach (var item in task3List)
            {
                Console.WriteLine($"Index: {item.index}, Price: {item.price:F2}, Color: {item.color}, Quantity: {item.quantity}");
            }

            Console.WriteLine("작업4");

            List<Item> task4List = new List<Item>();
            for (int i = 0; i < items.Count; i++)
            {
                task4List.Add(items[i]);
            }
            //task4List.CopyTo()
            int result = task4List.IndexOf(task4List[2]);
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Init();
        }
    }
}
