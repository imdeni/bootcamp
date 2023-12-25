class Program {
	static void Main() {		
		Child c = new Child();
		Parent p = c;
		Child child = (Child)p;
		child.MethodParent();
		child.MethodChild();
	}
}
public class Parent {
	public void MethodParent() {
		"MethodParent".Dump();
	}
}
public class Child : Parent
{
	public void MethodChild()
	{
		"MethodChild".Dump();
	}
}
public static class Extensions
{
	public static void Dump(this object x) 
	{
		Console.WriteLine(x.ToString());
	}
}