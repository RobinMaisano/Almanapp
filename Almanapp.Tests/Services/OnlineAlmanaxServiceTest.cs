using Almanapp.Models;
using Almanapp.Services;
using Almanapp.Services.Interfaces;

namespace Almanapp.Tests.Services {
    [TestFixture]
    internal class OnlineAlmanaxServiceTest : IAlmanaxServiceTest {

        private IAlmanaxService onlineAlmanaxService;

        [OneTimeSetUp]
        public void Init() {
            onlineAlmanaxService = new OnlineAlmanaxService(new HttpClient());
        }

        [Test]
        public void FindAlmanaxDayWithDateTime_ShouldReturnFirstDay_If01_01() {
            DateTime dateTime = new DateTime(2020, 01, 01);
            AlmanaxDay resultDay = onlineAlmanaxService.FindAlmanaxDayWithDateTime(dateTime);

            Assert.That(resultDay.date, Is.EqualTo("01-01"));
        }

        //[Test]
        public void FindAlmanaxDayWithDateTime_ShouldReturnSecondDay_If01_02() {
            throw new NotImplementedException();
        }

        //[Test]
        public void FindAlmanaxDayWithDateTime_ShouldThrowException_IfAlmanaxDaysEmpty() {
            throw new NotImplementedException();
        }
    }
}
