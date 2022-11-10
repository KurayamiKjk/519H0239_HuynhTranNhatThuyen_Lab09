using Microsoft.VisualStudio.TestTools.UnitTesting;
using StudentServiceLib;
using System;

namespace StudentServiceTest
{
    [TestClass]
    public class ServiceTest
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void PassingNull_Return_NullReferenceException()
        {
            StudentService sv = new StudentService();
            Student s = null;
            sv.addStudent(s);

        }
        [TestMethod]
        public void AddIdStudent_Exist_ReturnFail()
        {
            StudentService sv = new StudentService();
            Student s = new Student();
            s.Id = 001;
            s.Name = "Thuyen";
            s.Age = 18;
            Boolean isTrue = sv.addStudent(s);
            Assert.IsTrue(isTrue);

        }
    }
}
