using RPG;
using System;
using NUnit.Framework;

namespace Test.Library
{
    public class ItemTest
    {
        [Test]
        public void UntrimedName(){
            const string untrimedName = "  Daga  ";
            const string expectedName = "Daga";
            Weapon daga = new Weapon(untrimedName, 10, false);
            Assert.That(expectedName, Is.EqualTo(daga.Name));
        }

        [Test]
        public void ValidName(){
            const string untrimedName = "  ";
            const string expectedName = "Arma";
            Weapon daga = new Weapon(untrimedName, 10, false);
            Assert.That(expectedName, Is.EqualTo(daga.Name));
        }
    }    
}