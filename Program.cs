
using EjercicioHerencia;

ConvertirMetros convertirMetros= new ConvertirMetros(); 

Console.Write("Ingrese la cantidad de metros a convertir: ");
double metros= Convert.ToDouble(Console.ReadLine());

convertirMetros.Imprimir(metros);