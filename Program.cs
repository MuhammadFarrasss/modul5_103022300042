
class SimpleDataBase<T> {
        private List<T> storeData;
        private List<DateTime> inputDate;

        public SimpleDataBase()
        {
            storeData = new List<T>();
            inputDate = new List<DateTime>();
        }
        public void AddNewData(T data)
        {
            storeData.Add(data);
            inputDate.Add(DateTime.Now);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storeData.Count; i++)
            {
                Console.WriteLine("Data " + i + " berisi: " + storeData[i] + ", yang disimpan pada waktu UTC: " + inputDate[i]);
            }
        }
    }

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
  class Program {
    private static void Main(String[] args)
    {
        PemrosesData pemroses = new PemrosesData();
        float terbesar = pemroses.DapatkanNilaiTerbesar(1, 2, 3);
        Console.WriteLine(terbesar);
      SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
    }
}

