using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class DayTest
    {
        private Day day;
        private string hari;

        [SetUp]
        public void Init()
        {
            day = new Day();
        }

        [Test]
        public void NameOfDayTest()
        {
            Assert.AreEqual(hari = "Senin", day.NameOfDay(1));
            Assert.AreEqual(hari = "Selasa", day.NameOfDay(2));
            Assert.AreEqual(hari = "Rabu", day.NameOfDay(3));
            Assert.AreEqual(hari = "Kamis", day.NameOfDay(4));
            Assert.AreEqual(hari = "Jum'at", day.NameOfDay(5));
            Assert.AreEqual(hari = "Sabtu", day.NameOfDay(6));
            Assert.AreEqual(hari = "Minggu", day.NameOfDay(7));
        }
    }

    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void TestUserValid()
        {
            Assert.AreEqual(true, user.IsValidUser("admin", "admin"));
        }
    }
}
