using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace pemrog8
{
    // Class Person sebagai Class Utama
    public class Person
    {
        // Properties/field dari class Person
        string Name;
        int Age;

        // constructor dari class person
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        // fungsi/method yang menampilkan nama dan umur
        public void InfoPerson()
        {
            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", Name, Age);
        }
    }

    // class Karyawan berupa class turunan dari class Person
    public class Karyawan : Person
    {

        // properties/field dari class Karyawan
        public string karyawanid;
        public string subject;

        // constructor dari class Person yang dimana mengambil field dari class Person
        public Karyawan(string kid, string sbj, string name, int age) : base(name, age)
        {
            karyawanid = kid;
            subject = sbj;
        }

        // method dari class Karyawan
        public void InfoKaryawan()
        {

            Console.WriteLine("Posisi saya sebagai {0} dengan id {1}", subject, karyawanid);
        }

        // Override sebuah method dari class Person
        public void InfoPerson(string name, int age)
        {

            Console.WriteLine("Nama saya {0} dan umur saya {1} tahun", name, age);
        }

    }
}