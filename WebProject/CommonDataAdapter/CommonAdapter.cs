using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StorableObjectsContracts;

namespace CommonDataAdapter
{
    public class CommonAdapter
    {

        public bool SaveToDatabase(IStorableObject target)
        {
            throw new NotImplementedException();
        }

        public TSource RetrieveFromDatabase<TSource>(TSource source) where TSource : IRetrievableObject<TSource>
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Contains rules of storing data objects to entities
    /// </summary>
    public class StorageMapper
    {
        private CommonStore _storage;

        public StorageMapper(CommonStore storage)
        {
            _storage = storage;
        }

        public bool Store(IStorableObject target)
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// Contains different entities definitions
    /// </summary>
    public abstract class CommonStore
    {

    }

    public class TestStore : CommonStore
    {
        
    }


}
