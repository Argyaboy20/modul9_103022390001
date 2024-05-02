using System.Numerics;
using System.Runtime.CompilerServices;

namespace modul9_103022390001
{

    public class Mahasiswa
    {
        public String Nama { get; set; }
        public String NIM { get; set; }
        public int Year { get; set; }
        public List<String> Course { get; set; }

        public Mahasiswa(String Nama, String NIM, int year, List<String> Course)
        {
            this.Nama = Nama;
            this.NIM = NIM;
            this.Year = year;
            this.Course = Course;
        }
    }


   
}   

