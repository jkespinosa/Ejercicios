// See https://aka.ms/new-console-template for more information
Console.WriteLine("Jessica Espinosa");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Ingrese una hora");
var Hour = Console.ReadLine();
Console.WriteLine("La hora ingresada manualmente es: {0}", Hour);
Console.WriteLine("");
Console.WriteLine("");

var SystemHour = DateTime.Now.Hour;
var SystemMinute = DateTime.Now.Minute;

Console.WriteLine("La hora del sistema es: {0}:{1}", SystemHour, SystemMinute);
