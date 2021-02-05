using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using InventorySystem;
using InventorySystem.Api;
using InventorySystem.Contract;
using InventorySystem.Core;
using InventorySystem.DataAccess;
using InventorySystem.DataAccess.Implementation;
using InventorySystem.DataAccess.Interfaces;
using Moq;
using Moq.EntityFramework;
using Unity;

namespace UnitTests
{
    public class TestFixture : IDisposable
    {
        public TestFixture()
        {
            RootContainer.Container.RegisterInstance<WarehouseForm>(new WarehouseForm());

            var fakeDbContext = new Mock<InventoryContext>();
            fakeDbContext.Setup(x => x.Set<Unit>())
                .Returns(new FakeDbSet<Unit>()
                {
                    new Unit()
                    {
                        Id = 1,
                        Name = "A"
                    },
                    new Unit()
                    {
                        Id = 2,
                        Name = "B"
                    },
                    new Unit()
                    {
                        Id = 3,
                        Name = "C", 
                        IsDelete = true
                    }
                });


            RootContainer.Container.RegisterInstance(fakeDbContext.Object);
            RootContainer.Container.RegisterType(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            var inventorySystemApiMock = new Mock<IInventorySystemApi>();

        }

        public void Dispose()
        {
        }
    }
    public class FakeDbSet<T> : DbSet<T>, IDbSet<T> where T : class
    {
        ObservableCollection<T> _data;
        IQueryable _query;

        public FakeDbSet()
        {
            _data = new ObservableCollection<T>();
            _query = _data.AsQueryable();
        }

        public virtual T Find(params object[] keyValues)
        {
            throw new NotImplementedException("Derive from FakeDbSet<T> and override Find");
        }

        public override T Add(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Remove(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Attach(T item)
        {
            _data.Add(item);
            return item;
        }

        public T Detach(T item)
        {
            _data.Remove(item);
            return item;
        }

        public T Create()
        {
            return Activator.CreateInstance<T>();
        }

        public TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, T
        {
            return Activator.CreateInstance<TDerivedEntity>();
        }

        public ObservableCollection<T> Local
        {
            get { return _data; }
        }

        Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return _query.Provider; }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }
    }
}
