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
  }
}
