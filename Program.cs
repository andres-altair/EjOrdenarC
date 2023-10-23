using EjerOrdenarC;
namespace EjerOrdenarC
{
    class program
    {
        static public void Main(string[] args)
        {
            int i, j, k;
            i = solicitarNumero();
            j = solicitarNumero();
            k = solicitarNumero();

            if (i >= j & i >= k)
            {
                if (j >= k)
                {
                    Console.WriteLine("Orden: " + i + j + k);
                }
                else
                {
                    Console.WriteLine("Orden: " + i + k + j);
                }
            }
            else if (j >= i & j >= k)
            {
                if (i >= k)
                {
                    Console.WriteLine("Orden: " + j + i + k);
                }
                else
                {
                    Console.WriteLine("Orden: " + j + k + i);
                }
            }
            else if (k >= i & k >= j)
            {
                if (i >= j)
                {
                    Console.WriteLine("Orden: " + k + i + j);
                }
                else
                {
                    Console.WriteLine("Orden: " + k + j + i);
                }
            }

        }

        static private int solicitarNumero()
        {
            int numero;

            Console.WriteLine("Escriba un número: ");
            numero = Convert.ToInt32(Console.ReadLine());

            return numero;
        }
    }
}
    
