﻿using Kata.ShoppingCart.Domain;
using Moq;
using NUnit.Framework;

namespace Kata.ShoppingCart.Unit.Tests
{
    [TestFixture]
    class CheckoutPriceFinderTests
    {
        [Test]
        public void ShouldRetrieveCorrectPriceForOneItem()
        {
            var priceFinder = new Mock<IPriceFinder>();
            var subject = new Checkout(new Mock<IDiscounter>().Object, priceFinder.Object);
            subject.Scan("A");

            priceFinder.Verify(v => v.PriceFor(It.IsAny<string>()));
        }

        [Test]
        public void ShouldFindPriceForItemPassedIn()
        {
            var priceFinder = new Mock<IPriceFinder>();
            var item = "a";
            new Checkout(new Mock<IDiscounter>().Object, priceFinder.Object).Scan(item);
            priceFinder.Verify(v => v.PriceFor(item));
        }

        [Test]
        public void ShouldRetrieveCorrectPriceForMultipleItems()
        {
            var priceFinder = new Mock<IPriceFinder>();
            var subject = new Checkout(new Mock<IDiscounter>().Object, priceFinder.Object);
            var items = "AB";

            subject.Scan(items);

            priceFinder.Verify(v => v.PriceFor(It.IsAny<string>()), Times.Exactly(items.Length));
        }

        [Test]
        public void ShouldAddDiscountToDiscountDictionary()
        {
            var priceFinder = new Mock<IPriceFinder>();
            var checkout = new Checkout(new Mock<IDiscounter>().Object, priceFinder.Object);

            checkout.Scan("A");
            
        }

        //[Test]
        //public void ShouldReturnCorrectCorrectTotalForItemA()
        //{
        //    var checkOut = new Checkout(new Discounter(), new PriceFinder());
        //    checkOut.Scan("A");
        //    Assert.AreEqual(checkOut.Total(), 80);
        //}

        
        
    }
}
