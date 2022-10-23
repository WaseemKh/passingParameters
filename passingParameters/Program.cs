using passingParameters;

int x = 1;
//Console.WriteLine($"Before calling ValByVal, x = {x}");
//method1.ValByVal(x); //value by value
//Console.WriteLine($"value -After calling ValByVal, x = {x}");
//method1.ValByref(ref x); //value by referance 
//Console.WriteLine($"Ref -After calling ValByRef, x = {x}");


referanceByvalue refByVal = new referanceByvalue();
refByVal.main();

//refByref.Main();
Console.ReadLine();



public static class method1
{
    public static void ValByVal( int x)
    {
        x++;
        Console.WriteLine("in method valbyval =="+ x);
    }

    public static void ValByref(ref int x)
    {
        x++;
        Console.WriteLine("in method valbyRef ==" + x);
    }
}




//best referance   : https://levelup.gitconnected.com/passing-parameters-to-a-net-c-method-388badb7c095