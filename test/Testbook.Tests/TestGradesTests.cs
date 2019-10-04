using System;
using Xunit;

namespace Testbook.Tests
{
    public class TestGradesTests
    {
        [Fact]
        public void test1()
        {
            //arrange
            var testGradesTest1 = createTests();
            //act
            double average = testGradesTest1.average();
            
            //assert
            Assert.Equal(84.6, average, 1);
        }

        [Fact]
        public void test2()
        {
            //arrange
            var testGradesTest2 = createTests();
            //act
            double lowScore = testGradesTest2.lowScore();
            //assert
            Assert.Equal(74.4, lowScore,1);
        }

        [Fact]
        public void test3()
        {
            //arrange
            var testGradesTest3 = createTests();
            //act
            double highScore = testGradesTest3.highScore();
            //assert
            Assert.Equal(90.4, highScore,1);
        }

        public TestGrades createTests()
        {
            var testGrades = new TestGrades("");
            testGrades.scores.Add(89.1);
            testGrades.scores.Add(90.4);
            testGrades.scores.Add(74.4);
            return testGrades;
        }
    }
}