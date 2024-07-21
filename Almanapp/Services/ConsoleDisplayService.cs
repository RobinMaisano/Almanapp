using Almanapp.Models;

namespace Almanapp.Services {
    public static class ConsoleDisplayService {

        private const string DISPLAY_DATE_PATTERN = "dd-MM";

        public static void DisplayDateInfo(DateTime date) {
            Console.WriteLine("Offrande du " + date.ToString(DISPLAY_DATE_PATTERN));
        }

        public static void DisplayAlmanaxDayInfo(AlmanaxDay day) {
            Console.WriteLine("Ramener : " + day.quest);
            Console.WriteLine("Bonus : " + day.bonus);
        }
    }
}
