using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace IdealWeightCalculator.Tests
{
    [TestClass]
    public class WeightCalculatorTests

    {
        public TestContext TestContext { get; set; }



        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            context.WriteLine(" In Class Initialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {

        }

        [TestInitialize]
        public void TestInitialize()
        {
            TestContext.WriteLine(" In Test Initialize");

        }


        [TestCleanup]
        public void TestCleanup()
        {

        }



        [TestMethod]
        [DescriptionAttribute("if the ideal body wight "
            +"of a man with 180 cm in height is equals to 72.5")]
        [Owner("IbraheamMatar")]
        [Priority(1)]
        [TestCategory("WightCategory")]
        public void GetIdealBodyWeight_Sex_M_And_Height_180_Return_72_5()
        {
            WeightCalculator sut = new WeightCalculator
            {
                
                Sex = 'm',
                Hight = 180

            };

            double actual = sut.GetIdealBodyWeight();
            double expected = 72.5;


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void GetIdealBodyWeight_WithSex_W_And_Height_180_Return_65()
        {
            WeightCalculator sut = new WeightCalculator
            {

                Sex = 'w',
                Hight = 180

            };

            double actual = sut.GetIdealBodyWeight();
            double expected = 65;


            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void GetIdealBodyWeight_WithBadSex_W_And_Height_180_Return_Throw_Exception()
        {
            WeightCalculator sut = new WeightCalculator
            {

                Sex = 'r',
                Hight = 180

            };

            double actual = sut.GetIdealBodyWeight();
            double expected = 0;


            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        [DescriptionAttribute("this test is about using some Assert methods" )]
        [Owner("IbraheamMatar")]
        [Priority(2)]
        [TestCategory("AsertCategory")]
        public void Asert_Tests()
        {
            //Assert.AreEqual(100, 100);
            //Assert.AreNotEqual(100, 90);

            //WeightCalculator c1 = new WeightCalculator();
            //WeightCalculator c2 = c1;

            //Assert.AreSame(c1, c2);

            //WeightCalculator c3 = new WeightCalculator();
            //WeightCalculator c4 = new WeightCalculator();

            //Assert.AreNotSame(c3, c4);

            WeightCalculator calculator = new WeightCalculator();

            Assert.IsInstanceOfType(calculator, typeof(WeightCalculator));

            calculator = null;

            Assert.IsNull(calculator);

            Assert.IsTrue(100 == 90 + 10);

        }

        [TestMethod]
        [DescriptionAttribute("this test is about using some StringAsert methods")]
        [Owner("IbraheamMatar")]
        [Priority(2)]
        [TestCategory("AsertCategory")]
        public void StringAsert_Tests()
        {
            string greeting = "Hello world";

            StringAssert.Contains(greeting, "Hello");
            greeting.Should().Contain("world");

            StringAssert.StartsWith(greeting, "He");

            StringAssert.EndsWith(greeting, "ld");


        }


        [TestMethod]
        [DescriptionAttribute("this test is about using some CollectionAssert methods")]
        [Owner("IbraheamMatar")]
        [Priority(2)]
        [TestCategory("AsertCategory")]
        [Ignore]
        public void CollectionAssert_Tests()
        {
            List<string> names = new List<string>() {"Ali","Hamid","Ibraheam","Kamal" };

            CollectionAssert.AllItemsAreNotNull(names);
            CollectionAssert.Contains(names, "Ibraheam");
            CollectionAssert.AllItemsAreInstancesOfType(names, typeof(string));


        }

        [TestMethod]
        [DescriptionAttribute("this test is about using some FluentAssertions methods")]
        [Owner("IbraheamMatar")]
        [Priority(3)]
        [TestCategory("AsertCategory")]
        [Timeout(3000)]
        public void FluentAssertions_Tests()
        {
            string actual = "Ibraheam Matar";
            actual.Should().StartWith("Ib").And.EndWith("ar");

            int number = 9;

            number.Should().BeGreaterThan(8);
            number.Should().BeLessThan(10);

            List<string> names = new List<string>() { "Ibraheam", "Kamal" };

            names.Should().HaveCount(2);
            names.Should().NotBeEmpty();


        }



        [TestMethod]
        public void GetIdealBodyWeightFromDataSource_WithGoodInputs_Returns_Correct_Results()
        {
            WeightCalculator weightCalculator = new WeightCalculator(); 

            List<double> actual = weightCalculator.GetIdealBodyWeightFromDataSource();
            double[] expected = { 62.5, 62.75, 74 };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
