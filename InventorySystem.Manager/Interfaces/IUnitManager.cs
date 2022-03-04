using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IUnitManager
    {
        int CreateUnit(Unit item);
        IEnumerable<Unit> GetUnits(bool showIsDelete = false);
        void UpdateUnit(Unit item);
        void DeleteUnit(Unit item);
    }
}
