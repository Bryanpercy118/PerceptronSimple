using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerceptronSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            float peso1, peso2;
            float umbral;
            /*
             AND   E1   E2
             1     1    1
             0     1    0
             0     0    1
             0     0    0
             */
            Random r = new Random();
            bool sw = false;
             while (!sw) {

                sw = true;
                peso1 = Convert.ToSingle(r.NextDouble()- r.NextDouble());
                peso2 = Convert.ToSingle(r.NextDouble() - r.NextDouble());
                umbral = Convert.ToSingle(r.NextDouble() - r.NextDouble());

                Console.WriteLine("----------------------");
                Console.WriteLine("Peso 1: " + peso1);
                Console.WriteLine("Peso 2: " + peso2);
                Console.WriteLine("Umbral: " + umbral);
                Console.WriteLine("----------------------");
                Console.WriteLine("E1:1 E2:1 :" + p.funcion(p.neurona(1f, 1f, peso1, peso2, umbral)));
                Console.WriteLine("E1:1 E2:0 :" + p.funcion(p.neurona(1f, 0f, peso1, peso2, umbral)));
                Console.WriteLine("E1:0 E2:1 :" + p.funcion(p.neurona(0f, 1f, peso1, peso2, umbral)));
                Console.WriteLine("E1:0 E2:0 :" + p.funcion(p.neurona(0f, 0f, peso1, peso2, umbral)));


                if (p.funcion(p.neurona(1f ,1f, peso1,peso2,umbral))!= 1)
                    {
                    sw = false; 
                }
                if (p.funcion(p.neurona(1f, 0f, peso1, peso2, umbral)) != 0)
                {
                    sw = false;
                }
                if (p.funcion(p.neurona(0f, 1f, peso1, peso2, umbral)) != 0)
                {
                    sw = false;
                }
                if (p.funcion(p.neurona(0f, 0f, peso1, peso2, umbral)) != 0)
                {
                    sw = false;
                }
                
                Console.ReadKey();
            }
        }
        float neurona(float entrada1, float entrada2, float peso1, float peso2,float umbral) 
        {
            return umbral + entrada1 * peso1 + entrada2 * peso2;
        }
        float funcion(float d)
        {
            return d > 0 ? 1 : 0;
        }

    } 

      
    
}
