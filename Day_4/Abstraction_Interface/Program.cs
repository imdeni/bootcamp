using System;
//Abstract Parent Child Implementation
abstract class A
{
	public abstract void MethodA();
}
abstract class B : A
{
	public abstract void MethodB();
}
abstract class C :B 
{
	public override void MethodA()
	{
		throw new NotImplementedException();
	}
	public override void MethodB()
	{
		throw new NotImplementedException();
	}
	
}
