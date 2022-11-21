 static bool IsPrimeNumber(uint n)
{
    var result = true;

    if (n > 1)
    {
        for (var i = 2u; i < n; i++)
        {
            if (n % i == 0)
            {
                result = false;
                break;
            }
        }
    }
    else
    {
        result = false;
    }

    return result;
}