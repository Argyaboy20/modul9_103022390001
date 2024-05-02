using Microsoft.AspNetCore.Mvc;

namespace modul9_103022390001.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> mahasiswaList = new List<Mahasiswa>()
        {
        new Mahasiswa ("Farras","103022390001", 2022, new List<string> {"KPL", "Sistem Operasi", "Jaringan Komunikasi dan Data"}),
        new Mahasiswa ("Arinza","103022390008", 2022, new List<string> {"KPL", "Sistem Operasi", "Jaringan Komunikasi dan Data"}),
        new Mahasiswa ("Soraya","103022390005", 2022, new List<string> {"KPL", "Sistem Operasi", "Jaringan Komunikasi dan Data"}),

        };
        [HttpGet(Name = "Mahasiswa")]
        public IEnumerable<Mahasiswa> Get()
        {
            return mahasiswaList;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return mahasiswaList[id];
        }

        [HttpPost]
        public void post([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswaList.Add(mahasiswa);
        }

        [HttpDelete]
        public void delete(int id)
        {
            mahasiswaList.RemoveAt(id);
        }

    }

}
