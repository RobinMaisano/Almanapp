using Almanapp.Properties;

namespace Almanapp.Repository {
    public class DataRepository {
        public byte[] LoadJsonResourceAsBytes() {
            return Resources.almanax_data;
        }
    }
}
