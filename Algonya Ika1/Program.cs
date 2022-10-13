using System;

namespace algo_ika
{
    class Program
    {
        // array int dengan ukuran 33
        private int[] ika = new int[33];

        // variabel int untuk menyimpan banyaknya data
        private int n;

        // untuk menerima masukan
        private void read()
        {
            // menerima angka untuk menentukan banyaknya data
            while (true)
            {
                Console.Write("masukkan banyaknya elemen: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 33)
                    break;
                else
                    Console.WriteLine("punyai maksimal 33 elemen");
            }
            Console.WriteLine("masukkan elemen");

            // memasukkan elemen
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                ika[i] = Int32.Parse(s1);
            }
        }
        public void display()
        {
            // menampilkan elemen yang tersusun
            Console.WriteLine("element yang telah tersusun");
            for (int IC = 0; IC < n; IC++)
            {
                Console.WriteLine(ika[IC]);
            }
            Console.WriteLine("");
        }
        public void BubbleSortArray()
        {
            for (int i = 1; i < n; i++)
            {
                for (int IC = 0; IC < n - i; IC++)
                {
                    if (ika[IC] < ika[IC + 1])
                    {
                        // Tukar elemen
                        int temp;
                        temp = ika[IC];
                        ika[IC] = ika[IC + 1];
                        ika[IC + 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            // memanggil fungsi
            Program myList = new Program();
            myList.read();
            myList.BubbleSortArray();
            myList.display();

            // Exit
            Console.Read();
        }
    }
}