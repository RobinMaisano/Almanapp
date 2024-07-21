using Almanapp.Models;
using Almanapp.Services;
using Almanapp.Services.Interfaces;

DateTime today = DateTime.Now;

IAlmanaxService almanax = new LocalAlmanaxService();

AlmanaxDay day = almanax.FindAlmanaxDayWithDateTime(today);

ConsoleDisplayService.DisplayDateInfo(today);
ConsoleDisplayService.DisplayAlmanaxDayInfo(day);

Console.ReadLine();
