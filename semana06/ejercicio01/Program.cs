Console.WriteLine("2526 - ESTRUCTURA DE DATOS - UEA / SEMANA 06");
/*
1.  Función que calcule el número de elementos de una lista:
    La idea de este algoritmo es bastante sencilla, lo que tendremos que hacer para ver la longitud de
    una lista es simplemente recorrer la lista hasta el final e ir contando el número de saltos.
    El principal motivo por el que deberíamos implementar es que nos es que nos permite aprender y 
    comprender permite aprender y comprender
    el manejo de los nodos.
*/

ListaEnlazada lista = new ListaEnlazada();

// Agregamos elementos a la lista
lista.Agregar(10);
lista.Agregar(20);
lista.Agregar(30);
lista.Agregar(40);
lista.Agregar(50);
lista.Agregar(60);
lista.Agregar(70);
lista.Agregar(80);

lista.Mostrar();

// Calculamos la longitud
int longitud = lista.CalcularLongitud();
Console.WriteLine("La longitud de la lista es: " + longitud);