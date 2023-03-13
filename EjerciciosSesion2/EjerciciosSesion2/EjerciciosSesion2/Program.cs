using System.Drawing;
using System.Linq.Expressions;
using System.Net;
using System.Runtime.Intrinsics.Arm;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;



Console.WriteLine("Seleccione número de 1 al 3 del ejercicio que quiere validar");
int optionSelected = int.Parse(Console.ReadLine());

do
{

    switch (optionSelected)
    {
        case 1:
            Option1();
            break;
        case 2:
            Option2();
            break;
        case 3:
            Option3();
            break;
        default:
            // code block
            break;
    }
    Console.WriteLine("");
    Console.WriteLine("***");
    Console.WriteLine("***");
    Console.WriteLine("***");
    Console.WriteLine("Seleccione número de 1 al 3 del ejercicio que quiere validar", Color.Purple);
    optionSelected = int.Parse(Console.ReadLine());

} while (optionSelected >= 1);


static void Option1()
{
    /*Valida opcion*/
    Console.WriteLine("Escrba su nombre");
    string? name = Console.ReadLine();

    Console.WriteLine("Escrba su apellido");
    string? lastName = Console.ReadLine();

    Console.WriteLine("Escrba su edad");
    string? age = Console.ReadLine();

    Console.WriteLine("Sabe programar? Digite  si ó no");
    string knowsProgram = Console.ReadLine();


    Console.WriteLine("Nombre: {0} , Apellido: {1}, edad: {2} , Sabe programaar: {3}", name, lastName, age, knowsProgram);
}

static void Option2()
{
    Coche co = new Coche
    {
        puertas = 4,
        ruedas = 4,
        marca = "Hyundai",
        vigente = true
    };

    Mesa me = new Mesa
    {
        peso = 1.75m,
        largo = 1.6m,
        material = "Madera",
        color = "red",
    };

    Console.WriteLine("puertas: {0} , ruedas: {1}, marca: {2} , vigente: {3}", co.puertas, co.ruedas, co.marca, co.vigente);

    Console.WriteLine("peso: {0} , largo: {1}, material: {2} , color: {3}", me.peso, me.largo, me.material, me.color);

}

static void Option3()
{
    Console.WriteLine("Ingrese numero a evaluar: ");
    int number = int.Parse(Console.ReadLine());
    string numberEvaluated = (number >= 18 ? "Mayor/igual" : "Menor/igual");
    Console.WriteLine("Número ingresado es {0} y es {1} a 18", number, numberEvaluated);
   
    Console.WriteLine(" "); 
    Console.WriteLine(" ");
    Console.WriteLine("Ingrese caracter a evaluar: ");
    char valueCaracter = char.Parse(Console.ReadLine());
    string valueCaracterEvaluated = (valueCaracter == 'a' ? "Es igual" : "No es igual");
    Console.WriteLine("Letra ingresada es {0} y es {1} a 'a'", valueCaracter, valueCaracterEvaluated);

    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Valida dos condiciones and: ");
    int valueInt = int.Parse(Console.ReadLine());
    string valueIntEvaluated = (valueInt > 10 && valueInt <5 ? "Verdadero" : "Falso");
    Console.WriteLine("Numero ingresado {0} es mayor a 10 y menor que 5. Comprobacion:{1} ", valueInt, valueIntEvaluated);


    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine("Valida dos condiciones or: ");
    int valueInt1 = int.Parse(Console.ReadLine());
    string valueIntEvaluated1 = (valueInt1 > 100 || valueInt1 < 1000 ? "Verdadero" : "Falso");
    Console.WriteLine("Numero ingresado {0} es mayor a 100 ó menor que 1000. Comprobacion:{1} ", valueInt1, valueIntEvaluated1);



  

}

public class Coche
{
    public int puertas;
    public int ruedas;
    public string marca;
    public string ITV;
    public bool vigente;

}

public class Mesa
{
    public decimal peso;
    public decimal largo;
    public string material;
    public string color;
}