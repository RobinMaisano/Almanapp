using Almanapp.Models;
using Almanapp.Services.Interfaces;

namespace Almanapp.Services {
    public class LocalAlmanaxService : IAlmanaxService {

        public static string RESEARCH_DATE_PATTERN = "MM-dd";
        private Almanax almanax;

        public LocalAlmanaxService() {
            DataService dataService = new DataService();
            almanax = dataService.GetAlmanaxDataFromResource();
        }

        public LocalAlmanaxService(Almanax almanax) {
            this.almanax = almanax;
        }

        public AlmanaxDay FindAlmanaxDayWithDateTime(DateTime dateTime) {
            AssertAlmanaxDaysNotEmpty();

            foreach (var day in almanax.days) {
                if (dateTime.ToString(RESEARCH_DATE_PATTERN).Equals(day.date)) {
                    return day;
                }
            }
            return null;
        }

        private void AssertAlmanaxDaysNotEmpty() {
            if (almanax.days is null or []) {
                throw new ArgumentNullException();
            }
        }
    }
}
