using InventorySystem.Manager;
using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace UnitTests
{
    public class GuideManagerTests
    {
        public TestFixture testFixture;
        public GuideManagerTests()
        {
            testFixture = new TestFixture();
        }

        [Theory]
        [InlineData(true, 3)]
        [InlineData(false, 2)]
        public void GuideManagerTests_GetUnits_CountEqualExpect(bool isShowDelete, int expectResult)
        {
            GuideManager manager = new GuideManager();
            var units = manager.GetUnits(isShowDelete);

            var actual = units.Count();

            Assert.Equal(expectResult, actual);
        }

        [Theory]
        [InlineData(true, 4)]
        [InlineData(false, 3)]
        public void GuideManagerTests_CreateUnit_CountEqualExpect(bool isShowDelete, int expectResult)
        {
            GuideManager manager = new GuideManager();

            manager.CreateUnit(new InventorySystem.Contract.Unit() { Id = 4, Name = "D"});
            var units = manager.GetUnits(isShowDelete);

            var actual = units.Count();

            Assert.Equal(expectResult, actual);
        }

        [Fact]
        public void GuideManagerTests_CreateUnit_CheckAddedUnit()
        {
            GuideManager manager = new GuideManager();

            var unit = new InventorySystem.Contract.Unit() { Id = 4, Name = "D" };
            var actualId = manager.CreateUnit(unit);

            var units = manager.GetUnits();
            var actual = units.FirstOrDefault(x => x.Id == unit.Id);

            Assert.Equal(unit.Id, actualId);
            Assert.Equal(unit.Id, actual.Id);
            Assert.Equal(unit.Name, actual.Name);
        }
    }
}
