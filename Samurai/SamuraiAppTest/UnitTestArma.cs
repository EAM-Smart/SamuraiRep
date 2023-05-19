using SamuraiApp;

namespace SamuraiAppTest;

[TestClass]
public class ArmaTests
{
    [TestMethod]
    public void TestAtacar()
    {
        //Arrange
        string nombre = "Katana";
        Letalidad letalidad = Letalidad.Alta;
        string expectedMessage = $"El samurai ataca con {nombre} ({letalidad})";
        // Act
        Arma arma = new Arma(nombre, letalidad);
        // Assert
         Assert.AreEqual(arma.Atacar(),expectedMessage);

    }
}