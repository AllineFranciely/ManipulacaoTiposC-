public class DataUtil
{
  public static void Main(string[] args)
  {
    var dataType = DateTime.Now;
    Console.WriteLine(dataType.GetType());
  }

  public string getTimeNow()
  {
    return "O momento de tempo atual é " +DateTime.Now;
  }
}
