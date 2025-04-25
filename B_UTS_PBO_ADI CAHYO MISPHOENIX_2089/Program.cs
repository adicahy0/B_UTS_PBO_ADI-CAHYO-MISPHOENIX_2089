using System;
using System.ComponentModel.DataAnnotations;
class Nasabah
{
    public string Nama { get; set; }
    public int Saldo { get; set; }
    public string Nomor { get; set; }

    public Nasabah(string nama, int saldo, string nomor)
    {
        this.Nama = nama;
        this.Saldo = saldo;
        this.Nomor = nomor;
    }

    public void Tarik( int jumlah)
    {
        if (this.Saldo < jumlah)
        {
            Console.WriteLine("saldo kureng");
        }
        else
        {
            Console.WriteLine($"penarikan sebesar Rp. {jumlah} berhasil");
            this.Saldo = this.Saldo - jumlah ;
            Console.WriteLine("sisa saldo{");
        }
    }

    public void Setor(int jumlah)
    {
        Console.WriteLine("setor berhasil");
        this.Saldo = this.Saldo + jumlah;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Nasabah adi = new Nasabah("adi", 0, "203");
        Nasabah susi = new Nasabah("susi", 0, "101");
        int length = 99;
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine("massukan rekening:");
            string rekening = Console.ReadLine();
            if (rekening == adi.Nomor)
            {
                Console.WriteLine("1.setor");
                Console.WriteLine("2.tampilkan data");
                Console.WriteLine("3.trarik");
                Console.WriteLine("4.exit");
                string option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("jumlah :");
                    a = Console.ReadLine();
                    adi.Setor(_)
                }
            }
            if (rekening == susi.Nomor)
            {
                Console.WriteLine("1.setor");
                Console.WriteLine("2.tampilkan data");
                Console.WriteLine("3.trarik");
                Console.WriteLine("4.exit");
                string option = Console.ReadLine();
            }

        }
    }

}


// owari da
//gk tau cara buat list kak jadi stuck di login, info cara buat list biar bisa login
//??