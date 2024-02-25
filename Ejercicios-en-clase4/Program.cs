int si;
int no = 0;
for(int i = 1; i <= 20; i++)
{
    si = i % 2;
    if(si == 0)
    {
        Console.WriteLine("{0}-", i);
    }
}
Console.WriteLine();

for (int x = 1; x <= 10; x++)
{
    no = no + x;
    Console.WriteLine("El resultado de la suma es: " + no);
}

//Enunciado 2

Console.WriteLine();
int pipi;
int hola = 0;
do
{
    Console.Write("Ingrese numeros para sumar positivos para sumar y un negativo para salir: ");
    pipi = Convert.ToInt32(Console.ReadLine());
    if (pipi >= 0)
    {
        hola = hola + pipi;
    }
}while(pipi > 0 );
Console.WriteLine("La suma de los numeros ingresados es: "+ hola);
Console.WriteLine();
int w = 0;
int divi7, divi11;
do
{
    w++;
    divi7 = 7 % w;
    divi11 = 11 % w;
}while(divi7 != 0 && divi11 != 0);
Console.WriteLine("El numero divisible entre 7 y 11 es: " + w);

//Hola mi Diego como anda, bien gracias y usted, pero no comio o si comio