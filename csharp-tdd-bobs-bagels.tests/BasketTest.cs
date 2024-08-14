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

            bool result = basket.AddProduct("Very specific bagle");

            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestRemoveProduct()
        {
            Basket basket = new Basket();
            basket.AddProduct("Very specific bagle");
            bool expected = true;

            bool result = basket.RemoveProduct("Very specific bagle");

            Assert.IsTrue(result);
            Assert.That(result, Is.True);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestAddProductWhenBacketIsFull()
        {
            Basket basket = new Basket();
            basket.AddProduct("Very specific bagle");
            basket.AddProduct("Very long Banana");
            basket.AddProduct("Very good Bread");
            bool expected = false;
           
            bool result = basket.AddProduct("Very strange apple");

            Assert.IsFalse(result);
            Assert.That(result, Is.False);
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}


