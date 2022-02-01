using AuthApi.Models;
using AuthApi.Repositories;

namespace AuthApi.Services
{
    public class RandomDataService : IRandomData
    {
        public RandomData Create(RandomData randomData)
        {
            randomData.Id = RandomDataRepository.RandomData.Count + 1;
            RandomDataRepository.RandomData.Add(randomData);
            return randomData;
        }

        public RandomData Update(RandomData newRandomData)
        {
            var oldRandomData = RandomDataRepository.RandomData.FirstOrDefault(o => o.Id == newRandomData.Id);

            if (oldRandomData == null) return null;

            oldRandomData.Name = newRandomData.Name;
            oldRandomData.Description = newRandomData.Description;

            return newRandomData;
        }

        public RandomData Get(int id)
        {
            var randomData = RandomDataRepository.RandomData.FirstOrDefault(o => o.Id == id);
            if (randomData == null) return null;
            return randomData;
        }

        public List<RandomData> List()
        {
            var randomData = RandomDataRepository.RandomData;
            return randomData;
        }

        public bool Delete(int id)
        {
            var oldRandomData = RandomDataRepository.RandomData.FirstOrDefault(o => o.Id == id);

            if (oldRandomData is null) return false;

            RandomDataRepository.RandomData.Remove(oldRandomData);
            return true;
        }


    }
}
