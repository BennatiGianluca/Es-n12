using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Es_n12_consoleapp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensione = { 20, 50, 100, 1000, 50000 };
            using (StreamWriter c = new StreamWriter("stat.esv", false, Encoding.UTF8))
            {
                c.WriteLine("Algoritmo, Dimensione, Tipo");
                foreach (int dim in dimensione)
                {
                    int[] numeri = new int[dim];
                    Random random = new Random();
                    for (int i = 0; i < dim; i++) 
                        numeri[i] = random.Next();
                    Stopwatch s = new Stopwatch();
                    s.Start();
                    BubbleSort.Sort = (numeri);
                    s.Stop();
                }
            }
        }
    }
}
