using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day10
{
    class Karatavas
    {
        public void Burti()
        {
            Console.WriteLine("_____________");
            Ievade();
            Console.WriteLine("Ievadiet burtu vai 'iziet' lai beigtu spēli");
            string vards = "programmesana";
            char[] burti = vards.ToCharArray();
            char[] stripinas = new char[13] { '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', '-', };
            String ievaditaisBurts = Console.ReadLine();
            char ievaditaisSimbols = Convert.ToChar(ievaditaisBurts);

            for (int i = 0; i < burti.Length; i++)
            { if(burti[i] == ievaditaisSimbols)
                {
                    Console.WriteLine(burti[i]);
                }
                else
                {
                    burti[i] = stripinas[i];
                }
              
                Console.Write(burti[i]);
            }
            Console.ReadLine();
           
        }

        private char Ievade()
        {
            Console.WriteLine("Ievadiet burtu vai 'iziet' lai beigtu spēli");
            string simboli = Console.ReadLine();
            char result = Convert.ToChar(simboli);
            return result;

        }
       
    }
}
