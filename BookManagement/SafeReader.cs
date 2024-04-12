using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;
using System.Data;

namespace BookManagement
{
    internal static  class SafeReader
    {
        public static string getSafeReader(this SqlDataReader reader, int index)
        {
            if (!reader.IsDBNull(index))
            {
                return reader.GetString(index);
            }
            return string.Empty;
        }
        public static string getSafeReader(this SqlDataReader reader, string columnName)
        {
            if (!reader.IsDBNull(columnName))
            {
                return reader.GetString(columnName);
            }
            return string.Empty;
        }
    }
}
