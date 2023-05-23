using techChallengeApi.Controllers;
using techChallengeApi.Data;
using techChallengeApi.Repositories;
using techChallengeApi.Repositories.Interfaces;

namespace techChallengeApiTest
{
    public class VarietyTest
    {
       

        

        [Fact]
        public void Test1()
        {
            var seller = new VarietyController(IVariety);

        }
    }
}