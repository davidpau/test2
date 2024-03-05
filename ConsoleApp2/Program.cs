// See https://aka.ms/new-console-template for more information
List<int> intList = new List<int>();
var bonus = new { note = "You won!" };

Console.WriteLine("Hello, World!");

(double Sum, int Count) t2 = (4.5, 3);
Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");

//Output:
//Sum of 3 elements is 4.5.
int[] mynums = [1, 6, 9, 11, -5];

var blah = FindMinAndMax(mynums);

Console.WriteLine($"myMine = {blah.minnum} and myMax = {blah.maxnum}");

await DoSomeWork();
Console.WriteLine("This is another statement");

var blaha = new A();
blaha.PrintA();

var blahb = new B();
blahb.PrintA();


Console.WriteLine("About to launch a task...");
_ = Task.Run(() =>
{
    var iterations = 0;
    for (int ctr = 0; ctr < int.MaxValue; ctr++)
        iterations++;
    Console.WriteLine("Completed looping operation...");
    //throw new InvalidOperationException();
});
Console.WriteLine("Task is running...");
await Task.Delay(5000);
Console.WriteLine("Exiting after 5 second delay");

Console.ReadKey();

(int minnum, int maxnum) FindMinAndMax(int[] inputs)
{
    var min = int.MaxValue;
    var max = int.MinValue;

    foreach (var i in inputs)
    {
        if (i < min)
        {
            min = i;
        }
        if (i > max)
        {
            max = i;
        }
    }

    return (min, max);
}

async Task<int> DoSomeWork()
{
    var client = new HttpClient();
    byte[] content = await client.GetByteArrayAsync("https://learn.microsoft.com/");

    Console.WriteLine($"{nameof(DoSomeWork)}: Finished downloading.");
    return content.Length;
}


public class A
{
    public string strA = "string a, class a";

    public virtual void PrintA()
    {
        Console.WriteLine($"strA = {strA}");
    }

}

public class B : A
{
    public string strB = "string b, class b";

    public override void PrintA()
    {
        base.PrintA();
        Console.WriteLine($"strB = {strA}");
    }
}

public class C : B
{
    public override void PrintA()
    {
        base.PrintA();
    }
}