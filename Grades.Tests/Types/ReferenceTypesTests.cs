using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades.Tests.Types
{
    [TestClass]
    public class TypeTests
    {

        [TestMethod]
        public void UsingArrays()
        {
            float[] grades;
            grades = new float[3];

            AddGrades(grades);

            Assert.AreEqual(89.1f, grades[1]);

        }

        private void AddGrades(float[] grades)
        {
            grades[1] = 89.1f;
        }

        [TestMethod]
        public void UppercaseString()
        {
            string name = "scott";
            name = name.ToUpper();

            Assert.AreEqual("SCOTT", name);

        }

        [TestMethod]
        public void ValueTypesPassByValue()
        {
            int x = 58;
            IncrementNumber(x);
            Assert.AreEqual(58, x);
        }

        private void IncrementNumber(int number)
        {
            number += 1;
             
        }
        [TestMethod]
        public void ReferencePassByValue()
        {
            GradeBook book1 = new GradeBook();
            GradeBook book2 = book1;

            GiveBookName(book2);
            Assert.AreEqual("A Gradebook", book1.Name);

        }

        private void GiveBookName(GradeBook book)
        {
            book.Name = "A Gradebook";
        }

        [TestMethod]
        public void IntVariablesHoldAValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
            Assert.AreNotEqual(x1, x2);
            
        }

        [TestMethod]
        public void StringComparisons()
        {
            string name1 = "Sussette";
            string name2 = "sussette";

            bool result = String.Equals(name1, name2, StringComparison.InvariantCultureIgnoreCase);
            Assert.IsTrue(result);

        }

       

        [TestMethod]
        public void VariablesHoldAReference ()
        {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1.Name = "Sussette's Gradebook";

            Assert.AreEqual(g1.Name, g2.Name);

        }
    }
}
