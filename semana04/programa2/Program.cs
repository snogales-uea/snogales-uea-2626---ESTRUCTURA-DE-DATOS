Console.WriteLine("ESTRUCTURA DE DATOS - UEA / SEMANA 04");

// Crear una agenda con capacidad para 10 pacientes
AgendaTurnos agenda = new AgendaTurnos(10);

// Agregar pacientes con distintos tipos
agenda.AgregarTurno(new PacienteObraSocial("Maria Gomez", "12345678", "21/06/2025 11:15", "IESS"));
agenda.AgregarTurno(new PacienteParticular("Carlos Perez", "87654321", "21/06/2025 10:30", "Consulta general"));
agenda.AgregarTurno(new PacienteObraSocial("Ana Torres", "45678901", "21/06/2025 09:00", "Seguros Sucre"));

// Ordenar los turnos por nombre
agenda.OrdenarPorNombre();

// Mostrar todos los turnos
agenda.MostrarTurnos();
