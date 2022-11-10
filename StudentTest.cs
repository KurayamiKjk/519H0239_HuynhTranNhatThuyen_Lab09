using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;

namespace StudentTest
{
    [TestClass]
    public class StudentTest
    {
        [TestMethod]
        public void TestForScore8_A()
        {
            Student s = new Student();
            s.Score = 8;

            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void TestForScore7_B()
        {
            Student s = new Student();
            s.Score = 7;

            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void TestForScore5_C()
        {
            Student s = new Student();
            s.Score = 5;

            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void TestForScore3half_D()
        {
            Student s = new Student();
            s.Score = 3.5;

            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }
    }
}
