using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using assignmentone;
using NUnit.Framework;

namespace testscases
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void GetLength_Input5_Returns5()
        {
            //Arrange
            int length = 5;
            int width = 1;

            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetLength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetLength_Input4_Returns4()
        {
            //Arrange
            int length = 5;
            int width = 1;

            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetLength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetLength_Input8_Returns8()
        {
            //Arrange
            int length = 8;
            int width = 1;

            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetLength();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetLength_Input18_Returns18()
        {
            //Arrange
            int length = 18;
            int width = 1;

            int expectedResult = length;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetLength(length);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input5_Returns5()
        {
            //Arrange
            int length = 1;
            int width = 5;

            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input15_Returns15()
        {
            //Arrange
            int length = 1;
            int width = 15;

            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetWidth_Input25_Returns25()
        {
            //Arrange
            int length = 1;
            int width = 50;

            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetWidth();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input21_Returns21()
        {
            //Arrange
            int length = 1;
            int width = 21;

            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void SetWidth_Input38_Returns38()
        {
            //Arrange
            int length = 1;
            int width = 33;

            int expectedResult = width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.SetWidth(width);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input5and6_Returns22()
        {
            //Arrange
            int length = 5;
            int width = 6;

            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input9and9_Returns36()
        {
            //Arrange
            int length = 5;
            int width = 6;

            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input4and4_Returns16()
        {
            //Arrange
            int length = 4;
            int width = 4;

            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetPerimeter_Input22and2_Returns44()
        {
            //Arrange
            int length = 22;
            int width = 2;

            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetPerimeter_Input30and5_Returns70()
        {
            //Arrange
            int length = 22;
            int width = 2;

            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetPerimeter_Input40and7_Returns94()
        {
            //Arrange
            int length = 40;
            int width = 7;

            int expectedResult = 2 * (length + width);

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input6and6_Returns36()
        {
            //Arrange
            int length = 6;
            int width = 6;

            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input9and7_Returns63()
        {
            //Arrange
            int length = 9;
            int width = 7;

            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input8and7_Returns56()
        {
            //Arrange
            int length = 8;
            int width = 7;

            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }

        [Test]
        public void GetArea_Input7and7_Returns49()
        {
            //Arrange
            int length = 7;
            int width = 7;

            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetArea_Input8and4_Returns32()
        {
            //Arrange
            int length = 8;
            int width = 4;

            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [Test]
        public void GetArea_Input6and9_Returns54()
        {
            //Arrange
            int length = 6;
            int width = 9;

            int expectedResult = length * width;

            Rectangle test_Rectangle = new Rectangle(length, width);

            //Act
            int actualResult = test_Rectangle.GetArea();

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}

