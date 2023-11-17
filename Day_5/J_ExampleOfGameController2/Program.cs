﻿//GameController
class GameController {
	Tile[] tiles = new Tile[54];
	// * It will make the Tiles configuration 
	// * depend on user concern
	public GameController(Tile[] tiles) {
		this.tiles = tiles;
	}
	// ! (Warning) It will make the Tiles configuration fixed
	public GameController()
	{
		tiles = new Tile[]{
			new City(),
			new Company(),
			new Jail()
		};
	}
	public void CallTypeAction(int index) {
		string type = tiles[index].type;
		switch type
	}
}
class Program {
	static void Main()
	{
		// * User defined Tiles configuration
		Tile[] tiles = new Tile[]{
			new City(),
			new Company(),
			new Jail()
		};
		GameController game = new GameController(tiles);
	}
}
class Tile {
	public readonly string type;
	public readonly string description;
	public readonly string name;
}
class City : Tile 
{
	public void Build() 
	{
		//Buy
	}
}
class Company : Tile {
	public void Buy() 
	{
		//Buy
	}
 }
class Jail : Tile {
	public void Roll() 
	{
		//Buy
	}
 }