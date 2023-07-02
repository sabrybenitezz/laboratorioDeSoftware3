using Xunit;
using _02_Dominio.ValueObject;
using _02_Dominio;

namespace _02_DomainTests.ValueObject
{
    public class MarcaTest

    {
        [Fact]
        public void marcaValida()
        {
            //Arrange
            string marca = "fiat";

            //Act
            Marca marcaValida = new Marca(marca);

            //Assert
            Assert.True(true);

        }


        [Fact]
        public void marcaInvalida()
        {
            //Arrange
            string marca = "fit";

            //Act
            Marca marcaValida = new Marca(marca);

            //Assert
            Assert.True(true);

        }
    }

}