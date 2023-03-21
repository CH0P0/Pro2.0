using OOP;

namespace TestOOP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSearch2()
        {
            ClientList<Client> clientLi = new ClientList<Client>();
            clientLi.AddClient(new Client("Juan", "Antonio", 1));
            clientLi.AddClient(new Client("Rafael", "Eduardo", 2));
            clientLi.AddClient(new Client("Andres", "Josafat", 3));
            clientLi.AddClient(new Client("Eduardo", "Manuel", 4));
            Assert.AreEqual("El cliente no pertenece a la lista", Funciones.SearchTest(clientLi, "Guille", "Man"));
        }
    }
}