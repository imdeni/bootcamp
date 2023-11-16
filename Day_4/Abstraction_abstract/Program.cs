//Abstraction
//Abstract class
class Program {
	static void Main() {
		RumahMewah rm = new RumahMewah();
		RumahBiasa rb = new RumahBiasa();
		RumahSederhana rs = new RumahSederhana();
		
		Rumah rumah = rb;
		rumah.BukaPintu(); 
		//parent rumah buka pintu telah di override oleh child rumah biasa, maka output yg di gunakan ialah milik child
		
		// rumah.BukaGarasi();
		// rumah.BukaJendela();
	}
}
//abstract parent
abstract class Rumah
{
	public readonly int i;
	public void BukaJendela() {
		"Buka jendela".Dump();
	}
	public virtual void BukaGarasi() {
		"Keatas".Dump();
	}
	//abstract method
	public abstract void BukaPintu();
}
//child inheritance from parent
class RumahMewah : Rumah
{
	//override data parent ketika method child terpanggil
	public override void BukaPintu() {
		"Keatas".Dump();
	}
}
//child inheritance from parent
class RumahBiasa : Rumah

{
	public override void BukaPintu()
	{
		"Kedepan".Dump();
	}
}
//child inheritance from parent
class RumahSederhana : Rumah
{
	public override void BukaPintu()
	{
		"Gorden".Dump();
	}
}

public static class IniExtension
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}