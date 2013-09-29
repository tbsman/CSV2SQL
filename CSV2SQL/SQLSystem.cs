using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV2SQL
{
    abstract class SQLSystem
    {
        public abstract String Create(String tableName, String[] fields);

        public abstract String Insert(String tablename, String[] values);
    }
}
