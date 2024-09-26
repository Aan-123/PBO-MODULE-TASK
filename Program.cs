public class Hewan
{
    public string Nama;
    public int Umur;

    public Hewan(string nama, int umur)
    {
        Nama = nama;
        Umur = umur;
    }

    public virtual string Suara()
    {
        return "Hewan ini bersuara";
    }

    public virtual string InfoHewan()
    {
        return $"Nama: {Nama}, Umur: {Umur} tahun";
    }
}

public class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahKaki) : base(nama, umur)
    {
        JumlahKaki = jumlahKaki;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Jumlah Kaki: {JumlahKaki}";
    }
}

public class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangTubuh) : base(nama, umur)
    {
        PanjangTubuh = panjangTubuh;
    }

    public override string InfoHewan()
    {
        return base.InfoHewan() + $", Panjang Tubuh: {PanjangTubuh}";
    }
}

public class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return base.Suara();
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa ini mengaum dengan keras: RRRAAAWWWW!!!!!");
    }
}

public class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahKaki) : base(nama, umur, jumlahKaki) { }

    public override string Suara()
    {
        return "Gajah mengeluarkan suara seperti suara terompet: TRRROOOTTTTTT!!!!!";
    }
}

public class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Suara Ular mendesis: SSSSTSTTTTT!!!!!";
    }

    public void Merayap()
    {
        Console.WriteLine("Ular berjalan dengan cara merayap");
    }
}

public class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangTubuh) : base(nama, umur, panjangTubuh) { }

    public override string Suara()
    {
        return "Buaya menggeram: NGGGRRRRR KIW KIW!!!!!";
    }
}

public class KebunBinatang
{
    private List<Hewan> koleksiHewan = new List<Hewan>();

    public void TambahHewan(Hewan hewan)
    {
        koleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in koleksiHewan)
        {
            Console.WriteLine(hewan.InfoHewan());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        KebunBinatang kebun = new KebunBinatang();

        Singa singa = new Singa("EL-LEON", 5, 4);
        Gajah gajah = new Gajah("ELMERR", 10, 4);
        Ular ular = new Ular("KOBRAYYY", 2, 3.5);
        Reptil reptil = new Buaya("BROYOOOO", 6, 4.2);
        Buaya buaya = new Buaya("BROYOOOO", 6, 4.2);

        kebun.TambahHewan(singa);
        kebun.TambahHewan(gajah);
        kebun.TambahHewan(ular);
        kebun.TambahHewan(buaya);

        kebun.DaftarHewan();

        Console.WriteLine(singa.Suara());
        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());
        Console.WriteLine(buaya.Suara());

        singa.Mengaum();
        ular.Merayap();

        Console.WriteLine(gajah.Suara());
        Console.WriteLine(ular.Suara());

        singa.Mengaum();

        Console.WriteLine(singa.InfoHewan());

        ular.Merayap();

        Console.WriteLine(reptil.Suara());
    }
}
