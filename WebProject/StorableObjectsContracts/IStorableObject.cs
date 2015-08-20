using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorableObjectsContracts
{
    public interface IStorableObject
    {
        bool StoreToDb();
    }
}
