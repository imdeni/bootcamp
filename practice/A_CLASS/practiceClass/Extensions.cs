namespace MahasiswaLib;

static class Extensions{
    public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
    public static void Dumps(this object x) 
	{
		Console.Write(x.ToString()+" ");
	}
}