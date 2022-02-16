using System;

namespace TrianguloDePascal
{
    class Program
    {
        int fila = 0;
        int columna = 0;
        int[,] pascal; 
        public void consultarNumero()
        {
            Console.WriteLine("- - - - - - - - - -Triangulo De Pascal- - - - - - - - - ");
            Console.WriteLine("Ingrese Un Numero");
            fila = int.Parse(Console.ReadLine()) + 1;
            columna = fila;
            pascal = new int[fila, columna];
        }

        public void contenidoPascal()
        {
            //Recorre la fila del triangulo
            for (int i = 1; i < columna; i++)
            {
                pascal[0, 0] = 1;
                pascal[i, 0] = 1;
                
                //recorre la columna del triangulo y genera el contenido
                for (int f = 1; f < columna; f++)
                {
                    pascal[i, f] = pascal[i - 1, f - 1] + pascal[i - 1, f];
                }

            }
        }

        public void imprimirPascal()
        {
            //Imprime un salto de linea en cada fila
            for (int z = 0; z < columna; z++)
            {
                Console.WriteLine("");
                //Da la forma de triangulo
                for (int j = 1; j < columna - z; j++)
                {

                    Console.Write("  ");

                }
                //Imprime los datos y quita los 0 sobrantes
                for (int x = 0; x < z+1; x++)
                {


                    Console.Write(pascal[z, x]);

                    //Ordenar Los Espacios entre numeros 
                    Console.Write(" ");
                    if (pascal[z,x] < 10)
                    {
                        Console.Write("  ");
                    }
                    else if(pascal[z,x] > 9 && pascal[z, x] < 100 )
                    {
                        Console.Write(" ");
                    }

                }
            }
        }
        static void Main(string[] args)
        {
            Program pascal = new Program();
            pascal.consultarNumero();
            pascal.contenidoPascal();
            pascal.imprimirPascal();
        }
    }
}
