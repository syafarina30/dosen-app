using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dosen
{ 
    internal class Dosen
{
    public int Id;
    public string Nama;
    public int Nik;
    public string Gender;
    public string Course;

    public Dosen()
    {
        this.Id = 1;
        this.Nama = "Dosen Pengampu ";
        this.Nik = 123456789;
        this.Gender = "Pria ";
        this.Course = "Pemrograman Berorientasi Objek";
    }

    public void attDosen(string nama, int nik)
    {
        this.Nama = nama;
        this.Nik = nik;
    }

    public void addCourse(string nama)
    {
        this.Course += $" , {nama} ";
    }

    public void PrintInfo()
    {
        Console.WriteLine($" ID\t\t = {this.Id} ");
        Console.WriteLine($" Nama\t\t = {this.Nama} ");
        Console.WriteLine($" NIK\t\t = {this.Nik} ");
        Console.WriteLine($" Jenis Kelamin\t = {this.Gender} ");
        Console.WriteLine($" Kursus\t\t = {this.Course} ");
    }
  }
}

