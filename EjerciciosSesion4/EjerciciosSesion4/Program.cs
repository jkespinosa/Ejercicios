using System.Drawing;

Console.WriteLine("Ingrese número a multiplicar:");
int NumberToMultiply = int.Parse(Console.ReadLine());
WhileMethod();
DoMethod();
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("");
Console.WriteLine("Ingrese Ancho");

int NumberAncho = int.Parse(Console.ReadLine());
Console.WriteLine("Ingrese Alto");

int NumberAlto = int.Parse(Console.ReadLine());

Console.WriteLine("Con relleno? 1/2");

int NumberIsRelleno = int.Parse(Console.ReadLine());

ForMethod(NumberAncho, NumberAlto, NumberIsRelleno);
void WhileMethod()
{

    int n = 1;
    while (n <= 10)
    {
        int NumberTotal = n * NumberToMultiply;
        Console.WriteLine("{0} * {1} = {2}", n, NumberToMultiply, NumberTotal);
        n++;
    }
}

void DoMethod()
{

    int NumberToValidate = 0;
    int NumberPositive = 0;
    int NumberNegative = 0;

    string IsPosiOrNegat;
    do
    {
        Console.WriteLine("\n");

        Console.WriteLine("Ingrese número a validar si es + ó -:");
        Console.WriteLine("Presiona 0 Si quiere salir del ciclo...");

        NumberToValidate = int.Parse(Console.ReadLine());

        if (NumberToValidate == 0) break;

        if (NumberToValidate < 0)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            IsPosiOrNegat = "Negativo";
            NumberNegative = NumberNegative + 1;
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Green;
            IsPosiOrNegat = "Positivo";
            NumberPositive = NumberPositive + 1;
        }

        Console.WriteLine("El número {0} es {1}", NumberToValidate, IsPosiOrNegat);
        Console.ResetColor();

        Console.WriteLine("Contador de +: {0}", NumberNegative);
        Console.WriteLine("Contador de -: {0}", NumberPositive);


        NumberToValidate++;
    } while (NumberToValidate != 0);

}


void ForMethod(int ancho, int alto, int isRelleno)
{

    for (int i = 1; i <= alto; i++)
    {
        for (int ii = 1; ii <= ancho; ii++)
        {
            Console.Write("*");
        }
        Console.WriteLine("");
    }
}
