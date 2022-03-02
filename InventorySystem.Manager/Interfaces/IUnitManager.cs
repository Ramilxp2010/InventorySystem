using InventorySystem.Contract;
using System.Collections.Generic;

namespace InventorySystem.Manager.Interfaces
{
    public interface IUnitManager
    {
        int CreateUnit(Unit item);
        IEnumerable<Unit> GetUnits(bool showIsDelete = false);
        string UpdateUnit(Unit item);
        string DeleteUnit(Unit item);
    }
}
