using System;
using Xunit;
using LeapYear;
using System.IO;

namespace LeapYear.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(3)]
        [InlineData(5)]
        [InlineData(100)]
        [InlineData(300)]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void Not_leap_year(int year)
        {
            bool actual = Program.IsLeapYear(year);
            bool expected = false;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(4)]
        [InlineData(116)]
        [InlineData(1600)]
        [InlineData(2000)]
        [InlineData(2104)]
        public void Is_leap_year(int year)
        {
            bool actual = Program.IsLeapYear(year);
            bool expected = true;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1700")]
        [InlineData("1800")]
        [InlineData("1900")]
        [InlineData("2100")]
        public void Not_Leap_Year_Strings(string yearAsString)
        {
            string actual = Program.IsLeapYear_With_Strings(yearAsString);
            string expected = "nay";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("1600")]
        [InlineData("2000")]
        [InlineData("2104")]
        public void Is_Leap_Year_Strings(string yearAsString)
        {
            string actual = Program.IsLeapYear_With_Strings(yearAsString);
            string expected = "yay";
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("0")]
        [InlineData("1")]
        [InlineData("2")]
        [InlineData("3")]
        [InlineData("4")]
        [InlineData("5")]
        [InlineData("116")]
        [InlineData("100")]
        [InlineData("300")]
        public void Is_Before_1582_Strings(string yearAsString)
        {
            string actual = Program.IsLeapYear_With_Strings(yearAsString);
            string expected = "The leap year function only applies to years from 1582.";
            Assert.Equal(expected, actual);
        }
    }
}
