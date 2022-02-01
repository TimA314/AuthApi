using AuthApi.Models;

namespace AuthApi.Services
{
    public interface IRandomData
    {
        public RandomData Create(RandomData randomData);
        public RandomData Update(RandomData randomData);
        public RandomData Get(int id);

        public List<RandomData> List();
        public bool Delete(int id);
    }
}
