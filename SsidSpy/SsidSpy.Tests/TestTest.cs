using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SsidSpy.Tests
{
    [TestClass]
    public class TestTest
    {
        [TestMethod]
        public void ����ͨ������()
        {
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void ���ӱ��ȿ���()
        {
            var cup = new SsidSpy.Models.Cup {
                CupType = 1,
                Color = Models.Color.Black
            };
            for (int i = 1; i <= 10; i++)
            {
                cup.Drink();
            }
            Assert.AreEqual(cup.Percent(),0);
        }
    }
}
