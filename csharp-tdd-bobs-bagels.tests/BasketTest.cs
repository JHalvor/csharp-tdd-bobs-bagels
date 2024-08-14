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
        }

        [Test]
        public void TestRemoveProduct()
        {
            Basket basket = new Basket();
            basket.AddProduct("Very specific bagle");
            bool expected = true;

            bool result = basket.RemoveProduct("Very specific bagle");

            Assert.That(result, Is.True);
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

            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void TestChangeBasketSize()
        {
            Basket basket = new Basket();
            bool expectedAddBeforeSizeIncrease = false;
            bool expectedSizeIncrease = true;
            bool expectedSizeDecreaseWhenFull = false;
            bool expectedSizeDecreaseWhenNotFull = true;

            basket.AddProduct("Very specific bagle");
            basket.AddProduct("Very long Banana");
            basket.AddProduct("Very good Bread");


            bool resultAddBeforeSizeIncrease = basket.AddProduct("Very strange apple");
            bool resultSizeIncrease = basket.ChangeSize(4);

            basket.AddProduct("Very good coffee");

            bool resultSizeDecreaseWhenFull = basket.ChangeSize(3);

            basket.RemoveProduct("Very good coffee");

            bool resultSizeDecreaseWhenNotFull = basket.ChangeSize(3);

            Assert.That(resultAddBeforeSizeIncrease, Is.EqualTo(expectedAddBeforeSizeIncrease));
            Assert.That(resultSizeIncrease, Is.EqualTo(expectedSizeIncrease));
            Assert.That(resultSizeDecreaseWhenFull, Is.EqualTo(expectedSizeDecreaseWhenFull));
            Assert.That(resultSizeDecreaseWhenNotFull, Is.EqualTo(expectedSizeDecreaseWhenNotFull));
        }

        [Test]
        public void TestRemoveProductThatDoesntExist()
        {
            Basket basket = new Basket();
            basket.AddProduct("Very specific bagle");
            bool expected = false;

            bool result = basket.RemoveProduct("Not very specific bagle");

            Assert.That(result, Is.EqualTo(expected));
        }
    }
}


