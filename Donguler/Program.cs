using System;
namespace Kampİntro
{

    class Program
    {

        static void Main(string[] args)
        {
           
            //array dizi
            string[] kurslar = new string[] { "yazılım geliştirme kampı", "programlama başlangıç için temel kurs", "java","python" };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("for bitti");
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }   

        }
    }
}

