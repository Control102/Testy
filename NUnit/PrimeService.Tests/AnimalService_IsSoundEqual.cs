#region Sample_FirstTest
using NUnit.Framework;
using Prime.Services;
using System;

namespace Prime.UnitTests.Services
{
    //TEST Animal class
    [TestFixture]
    public class AnimalService_IsSoundEqual
    {
        private Cat _cat;
        private Dog _dog;

        [SetUp]
        public void SetUp()
        {
            _cat = new Cat();
            _dog = new Dog();
        }

        [Test]
        public void Cat_MakeSounds_ReturnEqual()
        {
            var result = _cat.MakeSound();

            Assert.AreEqual(result, "meow meow");
        }

        [Test]
        public void Cat_MakeSounds_ReturnNotEqual()
        {
            var result = _cat.MakeSound();

            Assert.AreNotEqual(result, "moo moo");
        }

        [Test]
        public void Dog_MakeSounds_ReturnEqual()
        {
            var result = _dog.MakeSound();

            Assert.AreEqual(result, "woof woof");
        }

        [Test]
        public void Dog_MakeSounds_ReturnNotEqual()
        {
            var result = _dog.MakeSound();
            Assert.AreNotEqual(result, "moo moo");
        }
        #endregion
    }
}
