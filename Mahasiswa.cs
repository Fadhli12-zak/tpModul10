using System.Text.Json.Serialization;

namespace tpMod10_103022330068
{
    public class Mahasiswa
    {
        private string nama;
        private string nim;

        public Mahasiswa()
        {
            nama = string.Empty;
            nim = string.Empty;
        }

        [JsonPropertyName("nama")]
        public string Nama
        {
            get { return nama; }
            set { nama = value; }
        }

        [JsonPropertyName("nim")]
        public string Nim
        {
            get { return nim; }
            set { nim = value; }
        }
    }
}
