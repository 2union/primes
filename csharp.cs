class Program
{
    static void Main()
    {
        var primesCount = Enumerable.Range(2, 250001).Aggregate(
            0, (current, n) => current+(IsPrime(n) ? 1 : 0));
        Console.WriteLine(primesCount.ToString());
    }

    private static bool IsPrime(int n)
    {
        var a = 2;
        while (a <= Math.Sqrt(n))
        {
            if (n % a < 1)
                return false;
            a++;
        }
        return (n > 1) ? true : false;
    }
}