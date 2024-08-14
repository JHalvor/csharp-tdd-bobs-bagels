using tdd_bobs_bagels.CSharp.Main;

namespace csharp_tdd_bobs_bagels.tests
{
    [TestFixture]
    public class BasketTest
    {
        [Test]
        public void TestAddProduct()
        {
            Basket basket = new Basket();
            bool expected = true;
            bool result = basket.AddProduct("Test");
            Assert.IsTrue(expected);
            Assert.That(result, Is.True);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestRemoveProduct()
        {
            Basket basket = new Basket();
            basket.AddProduct("Test");
            bool expected = true;

            bool result = basket.RemoveProduct();

            Assert.IsTrue(expected);
            Assert.That(result, Is.True);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}


