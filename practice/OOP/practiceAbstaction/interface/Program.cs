using GameControllerLib;
class Program
{
    static void Main(string[] args)
    {
        Player player = new Player(1, "dee");
        Console.WriteLine(player.Id + " " + player.Name);
    }
}