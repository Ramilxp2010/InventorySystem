using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess.Interfaces;
using InventorySystem.Manager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;

namespace InventorySystem.Manager.Implementations
{
    public class UnitManager : IUnitManager
    {
        private IGenericRepository<Unit> _unitRepository;

        public UnitManager()
        {
            _unitRepository = RootContainer.Instance.Container.Resolve<IGenericRepository<Unit>>();
        }

        public IEnumerable<Unit> GetUnits(bool showIsDelete = false)
        {
            if (showIsDelete)
            {
                return _unitRepository.Get();
            }
            else
            {
                return _unitRepository.Get().Where(x => x.IsDelete == null || x.IsDelete == false);
            }
        }

        public int CreateUnit(Unit item)
        {
            return _unitRepository.Create(item).Id;
        }

        public void UpdateUnit(Unit item)
        {
            _unitRepository.Update(item);
        }

        public void DeleteUnit(Unit item)
        {
            var relatives = _productRepository.Get(x => x.UnitId == item.Id);
            if (relatives.Any())
            {
                item.IsDelete = true;
                UpdateUnit(item);
            }
            else
            {
                _unitRepository.Remove(item);
            }
        }

    }
}
