using Animal_cat;
using Animal_dog;
class Program 
{
	static void Main() 
	{
		Cat pokari = new Cat();
		pokari.colour="Yellow";
		Console.WriteLine("pokari colour "+pokari.colour);
				
		Cat jiji = new Cat();
		jiji.colour="red";
		Console.WriteLine("jiji colour "+jiji.colour);
		
		Dog dogi = new Dog();
		dogi.colour="blue";
		Console.WriteLine("dog dogi colour "+dogi.colour);
		
		pokari.Eat();
		pokari.Sleep();
		pokari.Chaos();
		pokari.Meow();
		
	}
}

