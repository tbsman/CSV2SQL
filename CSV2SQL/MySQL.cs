using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV2SQL
{
    class MySQL : SQLSystem
    {
        public override String Create(String tablename, String[] fields)
        {
            String Statement = "CREATE TABLE `" + tablename + "` (" + Environment.NewLine;
            Statement += "`id` INT(10) NOT NULL AUTO_INCREMENT PRIMARY KEY";
            for (int i = 0; i < fields.Length; i++)
            {

                Statement += ",\n `" + fields[i] + "` VARCHAR(200) NOT NULL";
            }
            Statement += "\nPRIMARY KEY (`id`));";

            return Statement;
        }
        public override string Insert(string tablename, string[] values)
        {
            
            String Statement = "INSERT INTO `" + tablename + "` VALUES(null";
            
            for (int i = 0; i < values.Length; i++)
            {
                Statement += ", '" + values[i] + "'";
            }
            Statement += ");\n";

            return Statement;
        }
    }
}
