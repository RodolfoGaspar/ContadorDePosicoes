using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContadorDePosicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...\n");

            Console.WriteLine("Digite a quantidade total de posições do arquivo:");
            string total = Console.ReadLine();
            Console.WriteLine(string.Format("Valor digitado: {0}", total));

            Console.WriteLine("Confirma? (S/N)");
            if (Console.ReadLine().ToString().ToUpper().Equals("S"))
            {
                if (Convert.ToInt32(total) >= 10)
                {
                    int a = 0;
                    for (int i = 1; i != Convert.ToInt32(total); i++)
                    {
                        Console.Write(i);
                        if (i == 9)
                        {
                            i = 0;
                            Console.Write(i);
                            a++;
                        }

                        if (a == Convert.ToInt32(total) / 10)
                        {
                            Console.WriteLine();
                            var aa = -10;
                            for (int ii = 0; ii != 10; ii++)
                            {
                                Console.Write(ii);                                
                                aa++;
                                if (aa == 0)
                                {
                                    aa = -10;
                                    ii++;
                                }
                                else
                                { ii--; }
                            }
                            break;
                        }
                    }

                }
            }

            Console.ReadKey();
        }
    }
}
