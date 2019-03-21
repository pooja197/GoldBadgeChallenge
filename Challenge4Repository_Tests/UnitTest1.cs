using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenge4;

namespace Challenge4Repository_Tests
{
    [TestClass]
    public class UnitTest1
    {
        private BadgeRepository _badgeRepo = new BadgeRepository();
        [TestMethod]
        public void TestMethod1()
        {
            Badge badge = new Badge();
            _badgeRepo.AddBadgeToList(badge);

            var actual = _badgeRepo.GetBadgeList().Count;
            var expected = 1;
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void RemoveFromList()
        {
            Badge badge = new Badge();
            Badge _badge = new Badge();
            badge.BadgeID = 1;
            _badgeRepo.AddBadgeToList(badge);
            _badgeRepo.AddBadgeToList(_badge);
            _badgeRepo.RemoveBadge(1);

        }

    }
}
