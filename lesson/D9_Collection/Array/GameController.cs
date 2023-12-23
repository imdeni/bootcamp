namespace Array;

public class GameController
{
	IPlayer[] players;
	int count = 0;
	public GameController() 
	{
		players = new Player[4];
	}
	public bool AddPlayer(IPlayer p) 
	{
		//... check if player already added before
		players[count] = p;
		count++;
		return true;
	}
	public IPlayer GetPlayer(int index) 
	{
		return players[index];
	}
}
