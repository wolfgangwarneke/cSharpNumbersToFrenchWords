using Xunit;
namespace FrenchNumberToWord
{
  public class NumberTranslatorTest
  {
    [Fact]
    public void Translate_For0_zéro()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "zéro";
      //Act
      string result = testTranslator.Translate(0);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Translate_For7_sept()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "sept";
      //Act
      string result = testTranslator.Translate(7);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Translate_For18_dixhuit()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "dix-huit";
      //Act
      string result = testTranslator.Translate(18);
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
