using NUnit.Framework;
using System;
using Unit_Tests;

namespace UnitTests.UnitTests
{
    [TestFixture]
    class WordsTests
    {

        private Words _words;

        [SetUp]
        public void SetUp()
        {
            _words = new Words();
        }

        [Test]
        [TestCase("Chmu","rka","Chmurka")]
        [TestCase("Kot","Pies","KotPies")]
        public void ConCatenator_WhenCalled_ShouldReturnConcat(String word1, String word2, String words) 
        {
            var result = _words.ConCatenator(word1, word2);
            Assert.That(result, Is.EqualTo(words));
        
        }

        [Test]
        public void ConCatenator_WhenCalled_ShouldThrowArgumentException() 
        {
            Assert.That(() => _words.ConCatenator("slowo", null), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void WordStretcher_WhenCalled_ShouldReturnWordToUpper() 
        {
            var result = _words.WordStretcher("ala ma kota");
            Assert.That(result, Is.EqualTo("ALA MA KOTA"));
        
        }

        [Test]
        public void WordStretcher_WhenCalled_ShouldThorwArgumentException() 
        {
            Assert.That(() => _words.WordStretcher(null), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void WordShrinker_WhenCalled_ShouldReturnWordToLower() 
        {
            var result = _words.WordShrinker("ELA MA PSA");
            Assert.That(result, Is.EqualTo("ela ma psa"));
        }

        [Test]
        public void WordShrinker_WhenCalled_ShouldThrowArgumentException() 
        {
            Assert.That(() => _words.WordShrinker(null), Throws.Exception.TypeOf<ArgumentException>());
        }

        [Test]
        public void WordToList_WhenCalled_ShouldAddWordToList() 
        {
            _words.WordList.Add("Hello");
            _words.WordList.Add("World!");

            Assert.That("Hello", Is.EqualTo(_words.WordList[0]));
            Assert.That("World!", Is.EqualTo(_words.WordList[1]));
        }

        [Test]
        public void WordToList_WhenCalled_ShouldThrowArgumentException() 
        {
            Assert.That(() => _words.WordToList(null), Throws.Exception.TypeOf<ArgumentException>());

        }

        [Test]
        public void FindWordIndexInList_WhenCalled_ShouldReturnIndedx() 
        {
            _words.WordList.Add("Hello");
            _words.WordList.Add("World!");

            Assert.That(0, Is.EqualTo(_words.FindWordIndexInList("Hello")));
            Assert.That(1, Is.EqualTo(_words.FindWordIndexInList("World!")));
        }

        [Test]
        public void FindWordIndexInList_WhenCalled_ShouldThrowArgumentException() 
        {
            Assert.That(() => _words.FindWordIndexInList(null), Throws.Exception.TypeOf<ArgumentException>());

        }


    }
}
