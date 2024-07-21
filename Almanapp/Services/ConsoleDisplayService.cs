namespace Almanapp.Services {
    public static class ConsoleDisplayService {

        private const string DISPLAY_DATE_PATTERN = "dd-MM";

        public static void DisplayFormattedDateInfo(DateTime date) {
            Console.WriteLine($"Offrande du " + date.ToString(DISPLAY_DATE_PATTERN) + " :");
        }
    }
}
