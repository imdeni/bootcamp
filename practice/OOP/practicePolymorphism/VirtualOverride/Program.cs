using AnimalLib;
class Program
{
    private static void Main(string[] args)
    {
        Animal animal=new();
        animal.MakeSound();

        Cat cat=new();
        cat.MakeSound();

        Dog dog=new();
        dog.MakeSound();
    }
}