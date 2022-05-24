Console.WriteLine("Ejercicio 1: Calculadora");
int seguir, operacion;
double valorInicial, valorACalcular;
Calculadora calc = new Calculadora(0);
Console.Write("Ingrese el valor inicial: ");
calc.Resultado = double.Parse(Console.ReadLine());
do
{
    do
    {
        Console.WriteLine("1. Sumar\n2. Restar\n3. Multiplicar\n4. Dividir\n5. Limpiar\n6. Salir");
        Console.Write("Ingrese la operación a ejecutar: ");
        operacion = int.Parse(Console.ReadLine());
    } while (operacion < 1 && operacion > 6);
    if (operacion < 6)
    {
        seguir = 1;
        Console.Write("Ingrese el valor a operar: ");
        valorACalcular = double.Parse(Console.ReadLine());
        switch (operacion)
        {
            case 1:
                calc.Sumar(valorACalcular);
                break;
            case 2:
                calc.Restar(valorACalcular);
                break;
            case 3:
                calc.Multiplicar(valorACalcular);
                break;
            case 4:
                calc.Dividir(valorACalcular);
                break;
            case 5:
                calc.Limpiar();
                break;
            default:
                break;
        }
        Console.WriteLine(calc.Resultado);
    }
    else
    {
        seguir = 0;
        Console.WriteLine("Gracias por utilizar");
    }
} while (seguir == 1);