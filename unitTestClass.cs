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
          
            var result = Program.GetLetterKeypad("def", 2);

           
            Assert.Equal("e", result);
        }
        
       [Fact]
public void ProcessChoice_ZeroPress_ReturnsInvalidInput()
{
   
    Program.ProcessChoice("0"); 

    
    Assert.Equal("invalid input", Console.ReadLine());  
}


    }
}

