using ConsoleApp16;

List<Animal> values = new List<Animal>();
Animal cat = new Cat();
Animal horse = new Horse();
Animal dog = new Dog();
Veterinarian veterinarian = new Veterinarian();
//void GetManu()
//{
//    Console.WriteLine($"1) конь");
//    Console.WriteLine($"2) кот");
//    Console.WriteLine($"3) собака");
//}
//void Menu()
//{
//    GetManu();
//    string a = Console.ReadLine();
//    int number=int.Parse(a);
//  foreach(Animal c in values)
//    {
//        Console.WriteLine();
//        Console.WriteLine($"{c}");
//        Console.WriteLine();
//    }
//}
for (int i = 0; i < 3; i++)
{
    veterinarian.TreatAnimal(cat);
}
