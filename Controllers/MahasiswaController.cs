using Microsoft.AspNetCore.Mvc;

namespace tpMod10_103022330068
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class MahasiswaController : ControllerBase
    {
        private static readonly List<Mahasiswa> daftarMahasiswa;

        static MahasiswaController()
        {
            daftarMahasiswa = new List<Mahasiswa>
            {
                new Mahasiswa { Nama = "Fadhli Muhammad Dzaki", Nim = "103022330068" },
                new Mahasiswa { Nama = "Fauzul Akbar", Nim = "103022300102" },
                new Mahasiswa { Nama = "Gilang Tirta Kesumah", Nim = "103022330068" },
                new Mahasiswa { Nama = "Haafizd Alhabib Azwir", Nim = "103022330089" },
                new Mahasiswa { Nama = "Hafidz Musyafa Azmin", Nim = "103022300162" }
            };
        }

        [HttpGet]
            [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<Mahasiswa>))]
        public IActionResult Get()
        {
            return Ok(daftarMahasiswa);
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan");

            return daftarMahasiswa[index];
        }

        [HttpPost]
        public ActionResult<List<Mahasiswa>> Post(Mahasiswa mahasiswaBaru)
        {
            daftarMahasiswa.Add(mahasiswaBaru);
            return daftarMahasiswa;
        }

        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> Delete(int index)
        {
            if (index < 0 || index >= daftarMahasiswa.Count)
                return NotFound("Mahasiswa tidak ditemukan");

            daftarMahasiswa.RemoveAt(index);
            return daftarMahasiswa;
        }
    }
}
