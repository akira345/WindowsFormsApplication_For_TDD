using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication_For_TDD;
namespace UnitTestProject1
{

      
    [TestClass]
    public class UnitTest1
    {
        Date d;

        [Owner("Akira345")]
        [Description("西暦和暦変換メソッドのテスト")]

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void 引数の範囲外チェック()
        {
            //引数が範囲を超えていた場合、ArgumentOutOfRangeExceptionを発生させる
            string ret = string.Empty;
            ret = d.cnv_to_jpn(1800, 10, 01);
        }
        [TestMethod]
        public void 明治チェック()
        {
            //明治：1868年9月8日～1912年7月30日
            string ret = string.Empty;
            ret = d.cnv_to_jpn(1868, 9, 8);
            Assert.AreEqual(ret, "明治1年9月8日");
            ret = d.cnv_to_jpn(1912, 7, 30);
            Assert.AreEqual(ret, "明治45年7月30日");
        }
        [TestMethod]
        public void 大正チェック()
        {
            //大正：1912年7月31日～1926年12月25日
            string ret = string.Empty;
            ret = d.cnv_to_jpn(1912, 7, 31);
            Assert.AreEqual(ret, "大正1年7月31日");
            ret = d.cnv_to_jpn(1926, 12, 25);
            Assert.AreEqual(ret, "大正15年12月25日");
        }
        [TestMethod]
        public void 昭和チェック()
        {
            //昭和：1926年12月26日～1989年1月7日
            string ret = string.Empty;
            ret = d.cnv_to_jpn(1926, 12, 26);
            Assert.AreEqual(ret, "昭和1年12月26日");
            ret = d.cnv_to_jpn(1989, 1, 7);
            Assert.AreEqual(ret, "昭和64年1月7日");
        }
        [TestMethod]
        public void 平成チェック()
        {
            //平成：1989年1月8日～
            string ret = string.Empty;
            ret = d.cnv_to_jpn(1989, 1, 8);
            Assert.AreEqual(ret, "平成1年1月8日");
            ret = d.cnv_to_jpn(2012, 11, 20);
            Assert.AreEqual(ret, "平成24年11月20日");
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void 日付が正しくない場合チェック()
        {
           
            string ret = string.Empty;
            ret = d.cnv_to_jpn(2012, 2, 31);
        }
        [TestInitialize]
        public void setup()
        {
             d = new Date();
        }

    }
}
