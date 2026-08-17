Console.WriteLine("un programa que gestione el registro de un estudiante con los siguientes datos:\nID, nombres, apellidos, dirección y tres números de teléfono.\nLos números de teléfono deben almacenarse utilizando un array.");

string[] ltelefono = ["0991111111", "0992222222", "0993333333", "0998888801"];
Estudiante estudiante = new Estudiante(101, "Carlos", "Torres", "Puyo, Av. Principal 123", ltelefono);
estudiante.MostrarInformacion();