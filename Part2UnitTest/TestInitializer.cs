using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IdealWeightCalculatorPart
{
    [TestClass]
    public class TestInitializer
    {

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            context.WriteLine(" In Assembly Initialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {

        }

    }
}
