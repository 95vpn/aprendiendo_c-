namespace _02TiposIntegrados;

internal class Example
{
    //public static int Suma(int a, int b)
    //{
    //    return a + b;
    //}

    public static Func<int, int, int> SumaLambda = (a, b) => a + b;
}
