using Almanapp.Repository;

namespace Almanapp.Tests.Repository {
    [TestFixture]
    public class DataRepositoryTest {

        private DataRepository dataDirectory;

        [OneTimeSetUp]
        public void Init() {
            dataDirectory = new DataRepository();
        }

        [Test]
        public void LoadJsonResourceAsBytes_ShouldReturnByteArray() {
            var result = dataDirectory.LoadJsonResourceAsBytes();
            Assert.That(result is byte[], Is.True);
        }
    }
}
