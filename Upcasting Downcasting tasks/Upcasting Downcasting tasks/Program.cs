
using System.Reflection;

namespace Upcasting_Downcasting_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruit[] basket = new Fruit[]
            {
                new Apple { Price = 9, Sort = "Golden Ahmed", VitaminA = 10, VitaminB = 9 },
                new Pineapple {Price = 12, Sort = "Smooth Cayenne", VitaminD = 4, VitaminE = 6},
                new Orange {Price = 10, Sort = "Salustiana", VitaminC = 8},
            };

            foreach (var fruit in basket)
            {
                Type type = fruit.GetType();
                Console.WriteLine(type.Name + " type:");

                foreach(FieldInfo field in type.GetFields(BindingFlags.Public | BindingFlags.Instance))
                {
                    Console.WriteLine($"{field.Name} {field.GetValue(fruit)}");
                }



            }


        }
    }
}