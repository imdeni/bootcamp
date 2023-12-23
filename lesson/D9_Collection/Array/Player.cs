using System.Data.Common;

namespace Array;

public class Player : IPlayer
{
	public string Name { get; }
	public int Id { get; }
	public Player(int id, string name) 
	{
		Name = name;
		Id = id;
	}
}