int dato1 = 16;
string dato2 = "25kg";
int resultado;

try
{
    resultado = dato1 + Convert.ToInt32(dato2);
    Console.WriteLine(resultado);
}
catch (Exception e)
{
    Console.WriteLine("Lo sentimos no se pudo realizar la operación solicitada");
}
