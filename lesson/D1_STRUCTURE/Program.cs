//General
class Program 
{
	static void Main() 
	{
		Cat pokari = new Cat();
		pokari.colour = "yellow";
		pokari.Eat();
		pokari.isMale = true;

		bool result1 = pokari.isMale;
		string result2 = pokari.colour;
		Console.WriteLine(result1);
		Console.WriteLine(result2);
		
		Cat jiji = new Cat();
		jiji.colour = "Black";
		
		bool result3 = jiji.isMale;
		string result4 = jiji.colour;
		Console.WriteLine(result3);
		Console.WriteLine(result4);
		
		Cat coki = new Cat();
		coki.colour = "white";
		
		Cat tompel = new Cat();
		tompel.colour = "grey";
	}
}
class Cat //Blueprint
{
	//Variable / Field
	public string colour="black";
	public int age=0;
	public bool isMale=true;
	public float weight=0;
	
	//Constructor
	// public Cat(string colour) 
	// {
	// 	this.colour = colour;
	// }
	
	//Method / Function
	public void Eat() 
	{
		Console.WriteLine("Eat");
	}
	public void Sleep() 
	{
		Console.WriteLine("Sleep");
	}
	public void Chaos() 
	{
		Console.WriteLine("Chaos");
	}
	public void Meow() 
	{
		Console.WriteLine("Meow");
	}
}
