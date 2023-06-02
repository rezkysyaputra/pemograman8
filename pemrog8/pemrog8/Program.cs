using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pemrog8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("<Class utama>");
            // Object dari class Person dengan memakai constructor
            Person person1 = new Person("Rahmat budiman", 19);
            // Memanggil method dari class Person
            person1.InfoPerson();

            Console.WriteLine("================================");

            Console.WriteLine("<Class turunan>");
            // Object dari class Karyawan dengan memakai constructor
            Karyawan karyawan1 = new Karyawan("11223344", "Manager", "Asep samsudin", 22);
            // Memanggil method yang sudah di override dari class Person ke class Karyawan
            karyawan1.InfoPerson();
            // Memanggil method dari class Karyawan
            karyawan1.InfoKaryawan();
            
            Console.ReadKey();
        }

    }
}