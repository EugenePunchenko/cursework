using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kursach2020
{
    interface IDictStruct<T>
    {
        void Add(string key,T data);
        void Remove(string key);
    }
}
