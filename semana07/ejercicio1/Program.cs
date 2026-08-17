/*
Verificación de paréntesis balanceados en una expresión matemática
Implemente un programa que determine si los paréntesis, 
llaves y corchetes en una expresión matemática están correctamente balanceados.
Ejemplo:
Entrada: {7 + (8 * 5) - [(9 - 7) + (4 + 1)]}
Salida esperada: Fórmula balanceada.
*/

Console.WriteLine("2526 - ESTRUCTURA DE DATOS - UEA / SEMANA 07");

Console.WriteLine("Ingrese una expresión matemática:");
string expresion = Console.ReadLine();

if (Ejercicio1.EstaBalanceada(expresion))
{
    Console.WriteLine("Fórmula balanceada.");
}
else
{
    Console.WriteLine("Fórmula NO balanceada.");
}