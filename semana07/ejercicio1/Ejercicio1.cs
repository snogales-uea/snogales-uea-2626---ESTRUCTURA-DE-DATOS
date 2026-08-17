using System;
using System.Collections.Generic;

class Ejercicio1
{
    public static bool EstaBalanceada(string expresion)
    {
        Stack<char> pila = new Stack<char>();

        foreach (char caracter in expresion)
        {
            // Si es un paréntesis, llave o corchete de apertura, lo empuja a la pila
            if (caracter == '(' || caracter == '{' || caracter == '[')
            {
                pila.Push(caracter);
            }
            // Si es uno de cierre, verifica que coincida con el último abierto
            else if (caracter == ')' || caracter == '}' || caracter == ']')
            {
                if (pila.Count == 0)
                {
                    return false; // Hay un cierre sin apertura correspondiente
                }

                char tope = pila.Pop();

                if (!EsParCoincidente(tope, caracter))
                {
                    return false; // No coinciden los tipos de apertura y cierre
                }
            }
        }

        // Al final, la pila debe estar vacía si todo está balanceado
        return pila.Count == 0;
    }

    // Método auxiliar para verificar si los pares coinciden
    private static bool EsParCoincidente(char apertura, char cierre)
    {
        return (apertura == '(' && cierre == ')') ||
               (apertura == '{' && cierre == '}') ||
               (apertura == '[' && cierre == ']');
    }
}
