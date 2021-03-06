// using Xunit;
// namespace FrenchNumberToWord.Objects
// {
//   public class NumberTranslatorTest
//   {
//     [Fact]
//     public void Translate_For0_zéro()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "zéro";
//       //Act
//       string result = testTranslator.Translate(0);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For7_sept()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "sept";
//       //Act
//       string result = testTranslator.Translate(7);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For18_dixhuit()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "dix-huit";
//       //Act
//       string result = testTranslator.Translate(18);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For50_cinquante()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "cinquante";
//       //Act
//       string result = testTranslator.Translate(50);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For54_cinquanteQuatre()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "cinquante-quatre";
//       //Act
//       string result = testTranslator.Translate(54);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For41_quaranteEtUn()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "quarante et un";
//       //Act
//       string result = testTranslator.Translate(41);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For78_soixanteDixHuit()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "soixante-dix-huit";
//       //Act
//       string result = testTranslator.Translate(78);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For91_quatreVingtOnze()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "quatre-vingt-onze";
//       //Act
//       string result = testTranslator.Translate(91);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For500_cinqCents()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "cinq cents";
//       //Act
//       string result = testTranslator.Translate(500);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For110_centDix()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "cent dix";
//       //Act
//       string result = testTranslator.Translate(110);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For332_troisCentsTrenteDeux()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "trois cents trente-deux";
//       //Act
//       string result = testTranslator.Translate(332);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For5001_cinqMilleUn()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "cinq mille un";
//       //Act
//       string result = testTranslator.Translate(5001);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For1000000_unMillion()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "un million";
//       //Act
//       string result = testTranslator.Translate(1000000);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For450000000_quatreCentCinquanteMillions()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "quatre cents cinquante millions";
//       //Act
//       string result = testTranslator.Translate(450000000);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//     [Fact]
//     public void Translate_For666555444333_seeExpectedResult()
//     {
//       //Arrange
//       NumberTranslator testTranslator = new NumberTranslator();
//       string expectedResult = "cinq cents cinquante-cinq millions de quatre cents quarante-quatre mille trois cents trente-trois";
//       //Act
//       string result = testTranslator.Translate(555444333);
//       //Assert
//       Assert.Equal(expectedResult, result);
//     }
//   }
// }
