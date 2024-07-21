using Almanapp.Models;
using Almanapp.Services;
using Almanapp.Services.Interfaces;

namespace Almanapp.Tests.Services {
    [TestFixture]
    internal class LocalAlmanaxServiceTest : IAlmanaxServiceTest {

        private Almanax almanax = new Almanax();
        IAlmanaxService almanaxParcourer;

        [OneTimeSetUp]
        public void Init() {
            AlmanaxDay almanaxDay01 = new AlmanaxDay("01-01", "bonus 01-01", "quest 01-01");
            AlmanaxDay almanaxDay02 = new AlmanaxDay("01-02", "bonus 01-02", "quest 01-02");
            almanax.days = new List<AlmanaxDay> { almanaxDay01, almanaxDay02 };
            almanaxParcourer = new LocalAlmanaxService(almanax);
        }

        [Test]
        public void FindAlmanaxDayWithDateTime_ShouldReturnFirstDay_If01_01() {
            DateTime dateTime = new DateTime(2020, 01, 01);
            AlmanaxDay resultDay = almanaxParcourer.FindAlmanaxDayWithDateTime(dateTime);

            Assert.That(resultDay.date, Is.EqualTo("01-01"));
        }

        [Test]
        public void FindAlmanaxDayWithDateTime_ShouldReturnSecondDay_If01_02() {
            DateTime dateTime = new DateTime(2020, 01, 02);
            AlmanaxDay resultDay = almanaxParcourer.FindAlmanaxDayWithDateTime(dateTime);

            Assert.That(resultDay.date, Is.EqualTo("01-02"));
        }

        [Test]
        public void FindAlmanaxDayWithDateTime_ShouldThrowException_IfAlmanaxDaysEmpty() {
            DateTime dateTime = DateTime.Now;
            List<AlmanaxDay> emptyDays = new List<AlmanaxDay>();
            almanax.days = emptyDays;

            Assert.Throws(typeof(ArgumentNullException), () => almanaxParcourer.FindAlmanaxDayWithDateTime(dateTime));

            Init();
        }
    }
}
