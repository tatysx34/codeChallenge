using Xunit;

namespace codeChallengeParent
{
    public class unitTestClass
    {
        [Fact]
        public void GetLetterKeypad_ThreePressesOfSeven_ReturnsR()
        {

            var result = Program.GetLetterKeypad("pqrs", 3);


            Assert.Equal("r", result);
        }

        [Fact]
        public void GetLetterKeypad_TwoPressesOfThree_ReturnsE()
        {
            // Act
            var result = Program.GetLetterKeypad("def", 2);

           
            Assert.Equal("e", result);
        }
        [Fact]
    public void GetLetterKeypad_ExcessivePress_ReturnsInvalidInput()
    {
       
        var result = Program.GetLetterKeypad("abc", 5);

       
        Assert.Equal("Invalid input.", result);
    }
       


    }
}

