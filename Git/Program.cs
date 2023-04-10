using System;
using System.Runtime.InteropServices;

namespace Dosen
{ 
        internal class Program
        {
            static void Main(string[] args)
            {
                Dosen dosen = new Dosen();

                Console.WriteLine("Default Dosen Pengampu: ");
                Console.WriteLine("________");
                dosen.PrintInfo();

                Console.WriteLine("\nMasukkan Nama dan NIK Dosen baru: ");
                Console.WriteLine("____________");
                dosen.attDosen(Console.ReadLine(), Convert.ToInt32(Console.ReadLine()));
                dosen.PrintInfo();

                Console.WriteLine("\nMasukkan Mata Kuliah Baru:");
                Console.WriteLine("__________");
                dosen.addCourse(Console.ReadLine());
                dosen.PrintInfo();

                Console.ReadLine();
            }

        }
    }
