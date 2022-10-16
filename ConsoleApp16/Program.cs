using ConsoleApp16;

Animal cat = new Cat();
Animal horse = new Horse();
Animal dog = new Dog();
Veterinarian veterinarian = new Veterinarian();
List<Animal> animal = new List<Animal>() {cat,dog,horse};

for (int i = 0; i < 3; i++)
{
    veterinarian.TreatAnimal(animal[i]);
}
