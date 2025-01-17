using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesLib
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class DataTableAttribute : Attribute
    {
        public string TableName { get; }
        public DataTableAttribute(string tableName) => TableName = tableName;
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class DataColumnAttribute : Attribute
    {
        public string ColumnName { get; }
        public DataColumnAttribute(string columnName) => ColumnName = columnName;
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class KeyColumnAttribute : Attribute
    {
        public KeyColumnAttribute() { }
    }

    [AttributeUsage(AttributeTargets.Property, Inherited = false)]
    public class UnMappedAttribute : Attribute
    {
        public UnMappedAttribute() { }
    }
}
