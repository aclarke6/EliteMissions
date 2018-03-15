using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elite_Missions.Model.ModelTests
{
    public static class AssertExtension
    {
        public static T Throws<T>(Action expressionUnderTest,
                                  string errorMessage = "Expected exception has not been thrown by target of invocation."
                                 ) where T : Exception
        {
            try
            {
                expressionUnderTest();
            }
            catch (T exception)
            {
                return exception;
            }

            Assert.Fail(errorMessage);
            return null;
        }

        public static T Throws<T>(Action expressionUnderTest,
                                  string exceptionMessage = "",
                                  string errorMessage = "Expected exception has not been thrown by target of invocation."
                                 ) where T : Exception
        {
            try
            {
                expressionUnderTest();
            }
            catch (T exception)
            {
                Assert.AreEqual(exceptionMessage, exception.Message,"Invalid Exception Message.");
                return exception;
            }

            Assert.Fail(errorMessage);
            return null;
        }
    }

}
