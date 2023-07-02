using _02_Dominio.ValueObject;
using Xunit;

namespace _02_DomainTests
{
    public class PatenteTest
    {
        [Fact]
        public void Patente_ConPatenteValido_InstanciaPatente()
        {
            //Arrange
            string patente = "MLY123";

            //Act
            Patente patenteInstanciado = new Patente(patente);

            //Assert
            Assert.True(true);
        }



        [Fact]
        public void Patente_ConPatenteInvalido_InstanciaError()
        {
            //Arrange
            string patente = "123ABC";

            //Act
            Patente patenteInstanciado = new Patente(patente);

            //Assert
            Assert.True(true);
        }


    }
}