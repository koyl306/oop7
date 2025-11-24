using System;

namespace _7pr
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<Animal> animals = new GenericList<Animal>();

            animals.AddHead(new Animal("Кнопа", "Кішка"));
            animals.AddHead(new Animal("Рекс", "Собака"));
            animals.AddHead(new Animal("Веніамін", "Папуга"));
    
            Console.WriteLine("Список тварин:");
            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
    
            Console.WriteLine();
            string searchName = "Кнопа";
            Animal found = animals.FindFirstOccurrence(searchName);
            if (found != null)
                Console.WriteLine($"Знайдено: {found}");
            else
                Console.WriteLine($"{searchName} не знайдено");
    
            Console.ReadKey();
        }
    }
}