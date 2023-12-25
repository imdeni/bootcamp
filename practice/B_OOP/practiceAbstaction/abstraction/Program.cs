using KamarLib;
class Program {
	static void Main() {
		KamarMewah rm = new KamarMewah();
		KamarBiasa rb = new KamarBiasa();
		KamarSederhana rs = new KamarSederhana();
		
		Kamar kamar = rb;
		kamar.Kebersihan();
	}
}
public static class Extensions
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}