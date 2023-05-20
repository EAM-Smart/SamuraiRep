namespace SamuraiApp.Tests
{
    [TestClass]
    public class SamuraiTests
    {
        [TestMethod]
        public void AgregarArma_DebeAgregarArmaALaLista()
        {
            // Arrange
            Samurai samurai = new Samurai("Miyamoto");
            Arma arma = new Arma("Katana", Letalidad.Alta);

            // Act
            var result = samurai.AgregarArma(arma.Nombre, arma.Letalidad);

            // Assert
            Assert.IsTrue(result);
            Console.WriteLine(arma.Nombre);
            foreach(Arma a in samurai.Armas)
            {
                if (a.Nombre.Equals(arma.Nombre) && a.Letalidad==a.Letalidad)
                {
                        Assert.IsTrue(result); 
                }
            }
            
        }

        [TestMethod]
        public void AtacarConArmas_DebeRetornarMensajeDeAtaqueConArmas()
        {
            // Arrange
            var samurai = new Samurai("Miyamoto");
            samurai.AgregarArma("Katana", Letalidad.Alta);
            samurai.AgregarArma("Wakizashi", Letalidad.Media);
            samurai.AgregarArma("Tanto", Letalidad.Baja);

            // Act
            var result = samurai.AtacarConArmas();

            // Assert
            StringAssert.Contains(result, "El samurai Miyamoto ataca con sus armas:");
            StringAssert.Contains(result, "Katana (Alta)");
            StringAssert.Contains(result, "Wakizashi (Media)");
            StringAssert.Contains(result, "Tanto (Baja)");
        }

        [TestMethod]
        public void MontarCaballo_SiTieneCaballo_DebeRetornarMensajeDeMontarCaballo()
        {
            // Arrange
            var samurai = new Samurai("Miyamoto");
            samurai.Caballo = new Caballo("Kage");

            // Act
            var result = samurai.MontarCaballo();

            // Assert
            StringAssert.Contains(result, "El samurai Miyamoto monta su caballo Kage");
           
        }

        [TestMethod]
        public void MontarCaballo_SiNoTieneCaballo_DebeRetornarMensajeDeNoTieneCaballo()
        {
            // Arrange
            var samurai = new Samurai("Miyamoto");

            // Act
            var result = samurai.MontarCaballo();

            // Assert
            StringAssert.Contains(result, "El samurai Miyamoto no tiene un caballo");
        }
    }
}
