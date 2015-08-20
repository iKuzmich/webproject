using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonDataAdapter;

namespace GlobalObjects
{
    public static class Global
    {
        private static readonly object Locker = new object();

        private static T GetInterlocked<T>(ref T property, Func<T> factory)
        {
            if (property == null)
            {
                lock (Locker)
                {
                    if (property == null)
                    {
                        property = factory != null ? factory() : default(T);
                    }
                }
            }
            return property;
        }

        private static StorageMapper _mapper;
        public static StorageMapper DataMapper
        {
            get { return GetInterlocked(ref _mapper, () => new StorageMapper(DataStore)); }
        }

        private static CommonStore _store;
        public static CommonStore DataStore
        {
            get { return GetInterlocked(ref _store, () => new TestStore()); }
        }


    }

    public class Parameter<TParam>
    {
        public string Name { get; set; }
        public TParam Value { get; set; }
    }

    public class GlobalParameterSet<TParam>
    {
        private Dictionary<string, TParam> _set;

        public GlobalParameterSet()
        {
            _set = new Dictionary<string, TParam>();
        }

        public bool AddParameter<TParam>(string name, TParam value)
        {
            throw new NotImplementedException();
        }

        public TParam GetParameter<TParam>(string name)
        {
            var result =  default(TParam);
            throw new NotImplementedException();
            return result;
        }

        public TParam this[string name]
        {
            get
            {
                return _set[name];
            }
        }
    }
}
