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
        public void ���ӱ��ȿ�����()
        {
            var �ҵ�ˮ�� = new SsidSpy.Models.���� {
                �������� = 1,
                ������ɫ = Models.��ɫ.��ɫ
            };
            for (int i = 1; i <= 10; i++)
            {
                �ҵ�ˮ��.����һ��();
            }
            Assert.AreEqual(�ҵ�ˮ��.ˮ��(),0);
        }
    }
}
    
