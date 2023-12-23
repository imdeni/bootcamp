using Array;

class Program 
{
	static void Main() 
	{
		int[] myArray = new int[10];
		int[] myArray2 = { 1, 2, 3, 4 };

		myArray[0] = 10;
		myArray[1] = 11;

		int sizeOfArray = myArray.Length;

		GameController game = new();
		Player player1 = new(1, "Kinara");
		Player player2 = new(2, "Yusuf");

		game.AddPlayer(player1);
		game.AddPlayer(player2);

		// Player playerfirst = game.GetPlayer(0);
		// Player playersecond = game.GetPlayer(1);
		Console.WriteLine(game.GetPlayer(0).Name);
		Console.WriteLine(game.GetPlayer(1).Name);
		
		int[] numbers = { 1, 3, 4, 9, 2 };
		numbers = numbers.Except(new int[]{4}).ToArray();

	}	
}
