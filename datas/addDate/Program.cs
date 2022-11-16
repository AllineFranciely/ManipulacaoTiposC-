public class DataUtil
{
  public static void Main(string[] args)
  {
    var today = DateTime.Now;
    var duration = new TimeSpan(36, 0, 0, 0);
    var answer = today.Add(duration);

    System.Console.WriteLine("Hoje é " +today.Day +"/" +today.Month +" - " +today.DayOfWeek);
    System.Console.WriteLine("Daqui a 36 dias será "+answer.Day +"/" +answer.Month +" - " +answer.DayOfWeek);
  }
}
