#pragma warning disable CS8603 // Possible null reference return.

namespace MahasiswaLib;

public class Mahasiswa{
    public int idMahasiswa;
    public string? namaMahasiswa;
    public bool isMale;
    public int umurMahasiswa;
    public Mahasiswa(int idMahasiswa,string namaMahasiswa,bool isMale,int umurMahasiswa){
        this.idMahasiswa=idMahasiswa;
        this.namaMahasiswa=namaMahasiswa;
        this.umurMahasiswa=umurMahasiswa;
        this.isMale=isMale;
    }
    public int GetId(){
        return idMahasiswa;
    }
    public string GetNama(){
        return namaMahasiswa;
    }
    public bool GetSex(){
        return isMale;
    }
    public int GetUmur(){
        return umurMahasiswa;
    }
    
}