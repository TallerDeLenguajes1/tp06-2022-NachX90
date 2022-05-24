public class Calculadora
{
    public double Resultado;
    public Calculadora(double valorInicial)
    {
        Resultado = valorInicial;
    }
    public void Sumar(double sumando)
    {
        Resultado += sumando;
    }
    public void Restar(double minuendo)
    {
        Resultado -= minuendo;
    }
    public void Multiplicar(double termino)
    {
        Resultado *= termino;
    }
    public void Dividir(double denominador)
    {
        Resultado /= denominador;
    }
    public void Limpiar()
    {
        Resultado = 0;
    }
}
