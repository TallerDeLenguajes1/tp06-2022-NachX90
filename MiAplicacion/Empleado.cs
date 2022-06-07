public enum Cargos
{
    Auxiliar,
    Administrativo,
    Ingeniero,
    Especialista,
    Investigador
}

public class Empleado
{
    public string? Nombre;
    public string? Apellido;
    public DateTime FechaDeNacimiento;
    public char EstadoCivil;                    // s, c, d, v
    public char Genero;                         // m, f
    public DateTime FechaDeIngresoALaEmpresa;
    public double SueldoBasico;
    public Cargos Cargo;
    public int Antiguedad()
    {
        DateTime FechaActual = DateTime.Now;
        if (FechaDeIngresoALaEmpresa.Month >= FechaActual.Month && FechaDeIngresoALaEmpresa.Day > FechaActual.Day)
        {
            return (FechaActual.Year - FechaDeIngresoALaEmpresa.Year - 1);
        }
        else
        {
            return (FechaActual.Year - FechaDeIngresoALaEmpresa.Year);
        }
    }
    public int Edad()
    {
        DateTime FechaActual = DateTime.Now;
        if (FechaDeNacimiento.Month >= FechaActual.Month && FechaDeNacimiento.Day > FechaActual.Day)
        {
            return (FechaActual.Year - FechaDeNacimiento.Year - 1);
        }
        else
        {
            return (FechaActual.Year - FechaDeNacimiento.Year);
        }
    }
    public int AñosParaJubilacion()
    {
        int años = Genero == 'm' ? 65 : 60;
        años -= Edad();
        return años <= 0 ? 0 : años;
    }
    public double Salario()
    {
        double Adicional = Antiguedad() < 20 ? (SueldoBasico * 0.01 * Antiguedad()) : (SueldoBasico * 0.25);
        Adicional *= Cargo == Cargos.Especialista || Cargo == Cargos.Ingeniero ? 1.5 : 1;
        Adicional += EstadoCivil == 'c' ? 15000 : 0;
        return SueldoBasico + Adicional;
    }
    public void MostrarEmpleado()
    {
        Console.WriteLine($"\tApellido y Nombre:\t{Apellido}, {Nombre}");
        Console.WriteLine($"\tFecha de nacimiento:\t{FechaDeNacimiento.ToShortDateString()}");
        Console.WriteLine($"\tEstado civil:\t\t{EstadoCivil}");
        Console.WriteLine($"\tGénero:\t\t\t{Genero}");
        Console.WriteLine($"\tFecha de ingreso:\t{FechaDeIngresoALaEmpresa.ToShortDateString()}");
        Console.WriteLine($"\tSueldo Básico:\t\t$ {SueldoBasico}");
        Console.WriteLine($"\tCargo:\t\t\t{Cargo.ToString()}");
        Console.WriteLine($"\tAntigüedad:\t\t{Antiguedad()} años");
        Console.WriteLine($"\tEdad:\t\t\t{Edad()} años");
        Console.WriteLine($"\tAños para jubilación:\t{AñosParaJubilacion()} años");
        Console.WriteLine($"\tSalario:\t\t$ {Salario()}");
    }
}