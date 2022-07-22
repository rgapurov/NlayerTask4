using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T>
    {
        int insert(T p);
        int update(T p);
        int delete(T p);
        List<T> List();
        T Get(int id);

    }
}
