namespace Almanapp.Tests.Services {
    public interface IAlmanaxServiceTest {

        public void FindAlmanaxDayWithDateTime_ShouldReturnFirstDay_If01_01();

        public void FindAlmanaxDayWithDateTime_ShouldReturnSecondDay_If01_02();

        public void FindAlmanaxDayWithDateTime_ShouldThrowException_IfAlmanaxDaysEmpty();
    }
}
