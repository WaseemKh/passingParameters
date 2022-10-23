using passingParameters;

int x = 1;
Console.WriteLine($"Before calling ValByVal, x = {x}");
method1.ValByVal( x); //value by value
//method1.ValByVal(ref x); //value by referance 
Console.WriteLine($"After calling ValByVal, x = {x}");



refByref.Main();
Console.ReadLine();



public static class method1
{
    public static void ValByVal(int x)
    {
        x++;
        Console.WriteLine("x =="+ x);
    }

    
}

