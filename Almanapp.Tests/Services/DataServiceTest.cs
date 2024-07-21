using Almanapp.Services;

namespace Almanapp.Tests.Services {
    [TestFixture]
    public class DataServiceTest {

        private DataService dataService;

        [OneTimeSetUp]
        public void Init() {
            dataService = new DataService();
        }
    }
}