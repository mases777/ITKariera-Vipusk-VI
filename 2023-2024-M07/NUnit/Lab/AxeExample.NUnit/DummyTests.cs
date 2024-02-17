using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace AxeExample.NUnit
{
    public class DummyTests
    {
        [Test]
        public void DummyAxeLosesHealthAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(0, dummy.Health, "Dummy Health Does Not Change After Attack.");
        }

        [Test]
        public void DeadDummyThrowsExeption()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 1);

            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.That(ex.Message, Is.EqualTo("Dummy is dead."));
        }

        [Test]
        public void DeadDummyGivesExperiense()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(1, 50);

            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
            Assert.AreEqual(50, dummy.GiveExperience(), "Dead Dummy Does Not Gives Experience.");
        }

        [Test]
        public void LiveDummyDoesNotGivesExperiense()
        {
            Axe axe = new Axe(1, 100);
            Dummy dummy = new Dummy(10, 50);

            axe.Attack(dummy);

            var ex = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
            Assert.That(ex.Message, Is.EqualTo("Target is not dead."));
        }
    }
}
