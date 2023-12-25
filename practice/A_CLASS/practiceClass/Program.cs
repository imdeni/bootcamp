using MahasiswaLib;
class Program
{
    private static void Main(string[] args)
    {
        Mahasiswa mahasiswa = new Mahasiswa(1, "Dee", true, 20);
        mahasiswa.GetId().Dumps();
        mahasiswa.GetNama().Dumps();
        if (mahasiswa.GetSex() == true)
        { "Laki-Laki".Dumps(); }
        else
        { "Perempuan".Dumps(); };
        mahasiswa.GetUmur().Dumps();
    }
}