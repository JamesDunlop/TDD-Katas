﻿using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace TDD_Katas_project.The_CalcStats_Kata
{
    [TestFixture]
    [Category("The CalcStats Kata")]
    public class CalcStatTest
    {
        #region Private Methods
        private static IList<int> List(params int[] numbers)
        {
            return numbers.ToList();
        }
        #endregion

        #region Tests
        [Test]
        public void CanFindMinumValue()
        {
            Assert.That("-2", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Minimum)));
        }
        [Test]
        public void CanFindMaximumValue()
        {
            Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));
        }
        [Test]
        public void CanGetElementCount()
        {
            Assert.That("10", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.ElementCount)));
        }
        [Test]
        public void CanGetAverageOfSeries()
        {
            Assert.That("13.1", Is.EqualTo(CalcStat.NumberStats(List(1, -1, 2, -2, 6, 9, 15, -2, 92, 11), CalcStat.CalcStatKeys.Average)));
        }
        #endregion
    }
}
