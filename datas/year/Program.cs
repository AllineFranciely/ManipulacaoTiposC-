    public class DataUtil
    {
        public static void Main(string[] args)
        {
            var date = new DateTime(2022, 10, 2, 8, 35, 0);
            var yearOnly = date.Year;
            Console.WriteLine(yearOnly.ToString());
        }
    }