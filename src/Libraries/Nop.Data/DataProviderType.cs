using System.Runtime.Serialization;

namespace Nop.Data.Data
{
    /// <summary>
    /// Represents data provider type enumeration
    /// </summary>
    public enum DataProviderType
    {
        /// <summary>
        /// Unknown
        /// </summary>
        [EnumMember(Value = "")]
        Unknown,

        /// <summary>
        /// MS SQL Server
        /// </summary>
        [EnumMember(Value = "SqlServer")]
        SqlServer,

        /// <summary>
        /// Firebird
        /// </summary>
        [EnumMember(Value = "Firebird")]
        Firebird,

        /// <summary>
        /// MySQL
        /// </summary>
        [EnumMember(Value = "MySql")]
        MySql,

        /// <summary>
        /// Oracle
        /// </summary>
        [EnumMember(Value = "Oracle")]
        Oracle,

        /// <summary>
        /// PostgreSQL
        /// </summary>
        [EnumMember(Value = "PostgreSQL")]
        PostgreSQL,

        /// <summary>
        /// SQLite
        /// </summary>
        [EnumMember(Value = "SQLite")]
        SQLite
    }
}