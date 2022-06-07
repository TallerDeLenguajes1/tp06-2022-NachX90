Console.WriteLine("Ejercicio 2: Administración de Personal");

Empleado Empleado1 = new Empleado();
Empleado1.Nombre = "Juan Manuel";
Empleado1.Apellido = "Suárez";
Empleado1.FechaDeNacimiento = new DateTime(1992, 04, 15);
Empleado1.EstadoCivil = 's';
Empleado1.Genero = 'm';
Empleado1.FechaDeIngresoALaEmpresa = new DateTime(2009, 08, 22);
Empleado1.SueldoBasico = 65000;
Empleado1.Cargo = Cargos.Ingeniero;

Empleado Empleado2 = new Empleado();
Empleado2.Nombre = "María Marta";
Empleado2.Apellido = "López";
Empleado2.FechaDeNacimiento = new DateTime(1987, 09, 22);
Empleado2.EstadoCivil = 'c';
Empleado2.Genero = 'f';
Empleado2.FechaDeIngresoALaEmpresa = new DateTime(2010, 01, 05);
Empleado2.SueldoBasico = 65000;
Empleado2.Cargo = Cargos.Administrativo;

Empleado Empleado3 = new Empleado();
Empleado3.Nombre = "Fernando Miguel";
Empleado3.Apellido = "Morales";
Empleado3.FechaDeNacimiento = new DateTime(1985, 12, 10);
Empleado3.EstadoCivil = 'c';
Empleado3.Genero = 'm';
Empleado3.FechaDeIngresoALaEmpresa = new DateTime(2007, 08, 22);
Empleado3.SueldoBasico = 65000;
Empleado3.Cargo = Cargos.Auxiliar;

double TotalDeSalarios = Empleado1.Salario() + Empleado2.Salario() + Empleado3.Salario();

Console.WriteLine($"Monto total de Salarios:\t$ {TotalDeSalarios}");

Console.WriteLine("Empleado más próximo a jubilarse:");
if (Empleado1.Antiguedad() > Empleado2.Antiguedad() && Empleado1.Antiguedad() > Empleado3.Antiguedad())
{
    Empleado1.MostrarEmpleado();
}
else
{
    if (Empleado2.Antiguedad() > Empleado3.Antiguedad())
    {
        Empleado2.MostrarEmpleado();
    }
    else
    {
        Empleado3.MostrarEmpleado();
    }
}
