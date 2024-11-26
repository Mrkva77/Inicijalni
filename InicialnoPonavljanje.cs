using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicijalnoPonavljanje
{
    internal class Program
    {
        //7. Broj prim brojeva manjih od 100:
        static bool JePrim(int broj)
        {
            if (broj < 2) return false;
            for (int i = 2; i <= Math.Sqrt(broj); i++)
            {
                if (broj % i == 0) return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            //1.Program za dijeljenje i ostatak:

            int a = 100, b = 3;
            int x = a / b;
            int y = a % b;

            Console.WriteLine($"a dijeljeno s b je {x} i ostatak {y}"); */

            //2. Program za zamjenu razmaka s '_':
            /* Console.Write("Unesite niz znakova: ");
           string unos = Console.ReadLine();

           string rezultat = unos.Replace(' ', '_');

           Console.WriteLine("Niz nakon zamjene razmaka: " + rezultat); */

            //3.Program za izračunavanje prosjeka četiri varijable:
            /* int a = 10, b = 7;
          double c = 12.5, d = 16.7;

          double prosjek = (a + b + c + d) / 4;

          Console.WriteLine($"Prosječna vrijednost je: {prosjek}"); */

            //4. Provjera stranica pravokutnog trokuta:

            /* Console.Write("Unesite stranice trokuta (x, y, z): ");
           int x = int.Parse(Console.ReadLine());
           int y = int.Parse(Console.ReadLine());
           int z = int.Parse(Console.ReadLine());

           if (x <= 0 || y <= 0 || z <= 0)
           {
               Console.WriteLine("Stranice moraju biti veće od 0.");
               return;
           }

           if (x * x + y * y == z * z || x * x + z * z == y * y || y * y + z * z == x * x)
           {
               Console.WriteLine("Trokut je pravokutan.");
           }
           else
           {
               Console.WriteLine("Trokut nije pravokutan.");
           }
           */

            //5. Provjera ispravnosti URL adrese:

            /* Console.Write("Unesite URL adresu: ");
            string url = Console.ReadLine();

            if (url.StartsWith("www.") && url.EndsWith(".hr"))
            {
                int dotPos = url.IndexOf('.', 4);
                if (dotPos != -1 && dotPos < url.Length - 3)
                {
                    Console.WriteLine("URL adresa je ispravna.");
                }
                else
                {
                    Console.WriteLine("URL adresa nije ispravna.");
                }
            }
            else
            {
                Console.WriteLine("URL adresa nije ispravna.");
            }
            */

            //6. Izračunavanje sume reda 1/3 + 1/9 + 1/27 + ...:

            /* Console.Write("Unesite broj članova reda: ");
           int n = int.Parse(Console.ReadLine());

           double suma = 0;
           for (int i = 1; i <= n; i++)
           {
               suma += 1.0 / Math.Pow(3, i);
           }
           

            Console.WriteLine($"Suma reda je: {suma}"); */

            //7. Broj prim brojeva manjih od 100:
            /* int brojPrimBrojeva = 0;
            for (int i = 2; i < 100; i++)
            {
                if (JePrim(i))
                {
                    brojPrimBrojeva++;
                }
            }
            

            Console.WriteLine($"Broj prim brojeva manjih od 100 je: {brojPrimBrojeva}"); */

            //8. Izračunavanje n-tog člana Fibonaccijevog niza:

            /* Console.Write("Unesite broj n: ");
            int n = int.Parse(Console.ReadLine());

            int a = 0, b = 1, temp;

            if (n == 1)
            {
                Console.WriteLine($"Fibonaccijev broj je: {a}");
            }
            else if (n == 2)
            {
                Console.WriteLine($"Fibonaccijev broj je: {b}");
            }
            else
            {
                for (int i = 3; i <= n; i++)
                {
                    temp = a + b;
                    a = b;
                    b = temp;
                }
                Console.WriteLine($"Fibonaccijev broj je: {b}");
            }
            */

            //9. Sortiranje niza i ispisivanje članova:

            /* Console.Write("Unesite broj članova niza: ");
            int n = int.Parse(Console.ReadLine());

            int[] niz = new int[n];
            Console.WriteLine("Unesite članove niza: ");
            for (int i = 0; i < n; i++)
            {
                niz[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(niz);  // sortiranje niza

            Console.WriteLine("Niz nakon sortiranja: " + string.Join(" ", niz)); */
        }
    }
}
