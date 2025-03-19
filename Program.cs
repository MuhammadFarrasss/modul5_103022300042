// See https://aka.ms/new-console-template for more information
class PemrosesData { 
    public T DapatkanNilaiTerbesar<T>(T data1, T data2, T data3) {
        dynamic nilai1 = (dynamic)data1;
        dynamic nilai2 = (dynamic)data2;
        dynamic nilai3 = (dynamic)data3;

        dynamic nilaiMax = nilai1;
        if (nilai2 > nilaiMax)
        {
            nilaiMax = nilai2;
        }
        if (nilai3 > nilaiMax)
        {
            nilaiMax = nilai3;
        }
        return nilaiMax;
    }
    private static void Main(String[] args)
    {
        PemrosesData pemroses = new PemrosesData();
        float terbesar = pemroses.DapatkanNilaiTerbesar(1, 2, 3);
        Console.WriteLine(terbesar);
    }
}