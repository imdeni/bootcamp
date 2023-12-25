
using KamarLib;
class KamarMewah : Kamar
{
	public override void Kebersihan() {
		"Sangat bersih".Dump();
	}
}
class KamarBiasa : Kamar
{
	public override void Kebersihan()
	{
		"Lumayan bersih".Dump();
	}
}
class KamarSederhana : Kamar
{
	public override void Kebersihan()
	{
		"Biasa saja".Dump();
	}
}