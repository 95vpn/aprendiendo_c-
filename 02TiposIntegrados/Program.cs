// See https://aka.ms/new-console-template for more information
using _02TiposIntegrados;

int? i = null;
byte a = 0b1111_1111;
long k = 0xAFD12;
decimal d = 1/300m;
float f = 1/300f;
double g = 1/300d;
bool bandera = true;
char c = 'a';
var s = true;

int result = Example.SumaLambda(1, 2);

Console.WriteLine($"eL RESULTADO ES  {result}");

Console.WriteLine("Hello, World!");
Console.WriteLine("el valor de i es {0}", i);
Console.WriteLine("el valor de a es {0}", a);
Console.WriteLine("el valor de k es {0:X}", k);
Console.WriteLine("Valores con punto flotante");
Console.WriteLine("El valor de d es {0}", d);
Console.WriteLine("El valor de f es {0}", f);
Console.WriteLine("El valor de g es {0}", g);
Console.WriteLine(bandera);
Console.WriteLine(c);
Console.WriteLine("Valores tipo Var");
Console.WriteLine("El valor de s es {0} de tipo {1}", s, s.GetType());

Console.ReadKey();
