Console.WriteLine("2525 - ESTRUCTURA DE DATOS - UEA / SEMANA 06");

/*
2.  Invertir una lista enlazada:
    Implementar un método dentro de la Implementar un método dentro de la lista enlazada q 
    lista enlazada que permita invertir los datos ue permita invertir los datos
    almacenados en una lista enlazada, es decir que almacenados en una lista enlazada, 
    es decir que el primer elemento pase a ser el último y el primer elemento pase a ser el último y el
    último pase a ser el primero, que el segundo sea el penúltimo y el penúltimo pase a ser el
    segundo y así segundo y así sucesivamente.
*/

ListaEnlazada lista = new ListaEnlazada();

// Agregamos algunos elementos a la lista
lista.Agregar(1);
lista.Agregar(2);
lista.Agregar(3);
lista.Agregar(4);
lista.Agregar(5);

Console.WriteLine("Lista original:");
lista.Mostrar();

// Invertimos la lista
lista.Invertir();

Console.WriteLine("Lista invertida:");
lista.Mostrar();