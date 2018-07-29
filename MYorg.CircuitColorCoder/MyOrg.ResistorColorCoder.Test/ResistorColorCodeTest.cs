using System;
using MyOrg.CircuitColorCoder.BL.Implementations;
using NUnit.Framework;
namespace MyOrg.ResistorColorCoder.Test
{
    [TestFixture]
    public class ResistorColorCodeTest
    {
        ResistorValueCalculator _Calculator { get; set; }
        [SetUp]
        public void Initialize()
        {
            _Calculator = new ResistorValueCalculator();
        }

        [TestCase("Red", "Brown", "Red", "Green", 2100)]
        [TestCase("Blue", "Orange", "Brown", "Gold", 630)]
        [TestCase("Gray", "Blue", "Gold", "Green", 8)]
        [TestCase("Brown", "Gray", "White", "Green", 18000000000)]
        [TestCase("White", "Violet", "Red", "Green", 9700)]
      
        public void CalculateResistorValue_ValidColorCodes_Check(string BandA,string BandB,string BandC,string BandD,long expectedResult)
        {
            long CalculatedVal = _Calculator.CalculateResistorValue(BandA, BandB, BandC, BandD);
            Assert.AreEqual(expectedResult, CalculatedVal);
        }
        [Test]
        public void CalculateResistorValue_InvvalidColorCodes_ShouldThrowException()
        {
            Assert.That(() => _Calculator.CalculateResistorValue("test","Brown", "Red", "Green"), Throws.Exception.TypeOf<InvalidOperationException>());
        }


        [TestCase("Brown",1)]
        [TestCase("Violet", .1)]
        [TestCase("Gray", .05)]
        [TestCase("Gold", 5)]
        public void ResistorValue_TolerenceCheck(string BandD,double ExpectedValue)
        {
            Assert.AreEqual(ExpectedValue, _Calculator.GetTolerance(BandD));
        }

      
    }
}

