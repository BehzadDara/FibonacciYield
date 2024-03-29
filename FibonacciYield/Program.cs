foreach (var number in GenerateFibonacciSequence())
{
    if (number > 100)
        break;

    Console.WriteLine(number);
}

static IEnumerable<int> GenerateFibonacciSequence()
{
    int a = 0, b = 1;

    while (true)
    {
        // Yield the current Fibonacci number
        yield return a;

        // Calculate the next Fibonacci number
        (a,b) = (b, a + b);
    }
}