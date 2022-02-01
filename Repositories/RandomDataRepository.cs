using AuthApi.Models;

namespace AuthApi.Repositories
{
    public class RandomDataRepository
    {
        public static List<RandomData> RandomData = new()
        {
            new() { Id = 1, Name = "Something", Description = "Some lengthy Description" }
        };
    }
}
