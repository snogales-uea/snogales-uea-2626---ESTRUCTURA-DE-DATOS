Console.WriteLine("2525 - ESTRUCTURA DE DATOS - UEA / SEMANA 04");

Agenda agenda = new Agenda(10); // Capacidad para 10 contactos

// Agregar contactos
agenda.AgregarContacto(new ContactoPersonal("Juan Morales", "0987654321", "Amigo"));
agenda.AgregarContacto(new ContactoProfesional("Santiago Nogales", "0991234567", "Docente UEA"));
agenda.AgregarContacto(new ContactoProfesional("David Romero", "0998901230", "Estudiante UEA"));
agenda.AgregarContacto(new ContactoPersonal("Stalin Loza", "098734343", "Familiar"));

// Ordenar Agenda
agenda.OrdenarPorNombre();

// Mostrar todos los contactos
agenda.MostrarContactos();

// Buscar un contacto
Console.WriteLine("\nBuscar contacto por nombre:");
Console.Write("Ingrese nombre a buscar: ");
string nombre = Console.ReadLine()!;
agenda.BuscarContacto(nombre);
