﻿//Overriding
class Program
{
	static void Main()
	{
		Animal animal = new();
		animal.MakeSound();
		
		Cat cat = new();
		cat.MakeSound();
		
		animal = cat;
		animal.MakeSound();
	}
}
class Animal
{
	public virtual void MakeSound()
	{
		"Animal MakeSound".Dump();
	}
}
class Cat : Animal
{
	public override void MakeSound()
	{
		"Meow...".Dump();
	}
}
class Dog : Animal
{
	public override void MakeSound()
	{
		"Woof!...".Dump();
	}
}
class Bird : Animal
{
	public override void MakeSound()
	{
		"Chip...".Dump();
	}
}
class Ant : Animal { }

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}



