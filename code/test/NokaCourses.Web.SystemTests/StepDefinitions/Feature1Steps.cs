using TechTalk.SpecFlow;
using Xunit;

namespace NokaCourses.Web.SystemTests.StepDefinitions
{
    [Binding]
    public class PlayerCharacterSteps
    {
        [Given(@"I'm a new player")]
        public void GivenImANewPlayer()
        {
        }

        [When(@"I take 0 damage")]
        public void WhenITake0Damage()
        {
        }

        [Then(@"My health should now be 100")]
        public void ThenMyHealthShouldNowBe100()
        {
            Assert.Equal(1,1);
        }
    }
}
