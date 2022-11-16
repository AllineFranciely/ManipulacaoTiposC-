public class DataUtil
{
  public static void Main(string[] rgs)
  {
    var date = new DateTime(2022, 10, 2, 8, 35, 0);
    var dayOnly = date.Day;
    Console.WriteLine(dayOnly.ToString());
  }
}
