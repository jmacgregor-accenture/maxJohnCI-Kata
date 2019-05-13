using CIKataBackEnd.WebApi.Domain;
using Shouldly;
using Xunit;

namespace CIKataBackEnd.Tests
{
    public class BusinessLogicServiceShould
    {
        [Fact]
        public void ReturnSuccessfulMessage()
        {
            var businessLogicService = new BusinessLogicService();

            var result = businessLogicService.MakeUpValue();
            
            result.ShouldContain("successful");
        }
    }
}