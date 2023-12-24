class Program
{
    private static void Main(string[] args)
    {
        OverloadingOfCalculator o = new OverloadingOfCalculator();
        int resultInt = o.Add(1 , 1);
        float resultFloat = o.Add(1.1f , 1.1f);
        string resultString = o.Add("HELLO " , "WORLD");
        Console.WriteLine(resultInt);
        Console.WriteLine(resultFloat);
        Console.WriteLine(resultString);
    }
}