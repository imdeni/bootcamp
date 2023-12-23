partial class Program //internal
{
    private static void Encapsulation() //private
    {
        Console.WriteLine("Hello, World!");
        Angka i = new Angka(2);
        Console.WriteLine(i.a);
    }
}
internal class Angka{
    public int a;
    public Angka(int a){
        this.a=a;
    }
}