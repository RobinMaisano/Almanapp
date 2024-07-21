using Almanapp.Models;
using Almanapp.Services;

DateTime today = DateTime.Now;

HttpClient client = new HttpClient();
OnlineAlmanaxService onlineAlmanax = new OnlineAlmanaxService(client);
onlineAlmanax.POC_OnlineAlmanax();

ConsoleDisplayService.DisplayFormattedDateInfo(today);

LocalAlmanaxService almanaxParcourer = new LocalAlmanaxService();
AlmanaxDay day = almanaxParcourer.FindAlmanaxDayWithDateTime(today);

Console.WriteLine(day.date);
Console.WriteLine(day.quest);

Console.ReadLine();
