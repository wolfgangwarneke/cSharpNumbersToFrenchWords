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
    [Fact]
    public void Translate_For50_cinquante()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "cinquante";
      //Act
      string result = testTranslator.Translate(50);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Translate_For54_cinquanteQuatre()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "cinquante-quatre";
      //Act
      string result = testTranslator.Translate(54);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    [Fact]
    public void Translate_For41_quaranteEtUn()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "quarante et un";
      //Act
      string result = testTranslator.Translate(41);
      //Assert
      Assert.Equal(expectedResult, result);
    }
    public void Translate_For78_soixanteDixHuit()
    {
      //Arrange
      NumberTranslator testTranslator = new NumberTranslator();
      string expectedResult = "soixante-dix-huit";
      //Act
      string result = testTranslator.Translate(78);
      //Assert
      Assert.Equal(expectedResult, result);
    }
  }
}
