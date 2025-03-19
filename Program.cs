// See https://aka.ms/new-console-template for more information
class Program {
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
    public static void Main(string[] args)
    {
        SimpleDataBase<int> db = new SimpleDataBase<int>();
        db.AddNewData(12);
        db.AddNewData(34);
        db.AddNewData(56);
        db.PrintAllData();
    }
   }
