
int a = 1;

Change(ref a);

Console.WriteLine(a + " a-nin deyeri");

static void Change(ref int a)
{
    a += 1;
};



int b;

Vurma(out b, 7);

Console.WriteLine(b + " b-nin deyeri");
static void Vurma(out int b, int customer)
{
    b = 2;
    b *= customer;

}

//overload///

static int FindMax(int a, int b, int c)
{
    int max = 0;

    if (a > b)
    {
        max = a;
    }
    else {
        max = b;
    }

    if (c>max)
    {
        return c;
    }

    return max;
}

static int FindMax2(int a, int b, int c, int d)
{
    int max = FindMax(a, b, c);
    if (d > max)
    {
        return d;
    }
    return max;

}

static int FindMax3(int a, int b, int c, int d, int e)
{

    int max = FindMax2(a, b, c, d);
    if (e > max)
    {
        return e;
    }

    return max;
}

Console.WriteLine(FindMax(2, 5, 8) + " ilk 3 u ededden boyuyu");
Console.WriteLine(FindMax2(2, 5, 8,9)+ " ilk 4 ededden boyuyu");
Console.WriteLine(FindMax3(2, 5, 8,9,22)+ " ilk 5 ededden boyuyu");