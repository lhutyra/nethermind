﻿using NUnit.Framework;

namespace Ethereum.VM.Test
{
    internal class PushDupSwapTests : VMTestBase
    {
        [TestCaseSource(nameof(LoadTests), new object[] {"PushDupSwapTest"})]
        public void Test(VirtualMachineTest test)
        {
            RunTest(test);
        }
    }
}