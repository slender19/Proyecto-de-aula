using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    interface Implementacion<T>
    {
        T find(int id);
        List<T> findAll();
        bool save(T model);
        bool update(T model);
        bool delete(T model);
    }
}
