using System;
using Xunit;

namespace PhoneBookTests
{
    public class RecordTests
    {

        [Fact]
        public void NewRecord()
        {
            string expectedVal = "1- louy Alsadi 1234567890";
            string actualVal = "";
            actualVal = PhoneBookAbstract.Record.CreateRecord(1, "louy Alsadi", "1234567890");
            Assert.Equal(expectedVal, actualVal);
        }

    }
}
