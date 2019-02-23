using NUnit.Framework;
using Problems;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
           Program p = new Program();
            string result = p.Prefix("hello");
             string result2 = p.Prefix("");
             string result3 = p.Prefix("what    ...  did you say?? ");
             string result4 = p.Prefix("Gibson");
             string result5 = p.Prefix("who are you??");
             string result6 = p.Prefix("  fun ");

            Assert.AreEqual("5,1:hello",result);
              Assert.AreEqual("0,0:",result2);
              Assert.AreEqual("27,5:what    ...  did you say?? ",result3);
               Assert.AreEqual("6,1:Gibson",result4);
                Assert.AreEqual("13,3:who are you??",result5);
                 Assert.AreEqual("6,1:  fun ",result6);
        }

    }
}   