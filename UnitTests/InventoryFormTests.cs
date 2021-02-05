using InventorySystem;
using Xunit;
using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTests
{
    public class InventoryFormTests
    {
        public TestFixture testFixture;
        public InventoryFormTests() 
        {
            testFixture = new TestFixture();
        }

        [Fact]
        public void Test1() 
        {
            InventoryForm form = new InventoryForm();
            Assert.NotNull(form);
        }
    }
}
