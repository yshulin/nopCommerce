using System;
using LinqToDB.Data;
using Nop.Core;
using Nop.Core.Data;

namespace Nop.Data
{
    public class NopDataProvider : IDataProvider
    {
        public void InitializeDatabase()
        {
        }

        /// <summary>
        /// Re-index database tables
        /// </summary>
        /// <param name="databaseName"></param>
        public virtual string ReIndexTablesCommand(string databaseName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Creates a backup of the database
        /// </summary>
        public void BackupDatabase(string fileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets command for restores the database from a backup
        /// </summary>
        /// <param name="backupFileName"></param>
        /// <returns></returns>
        public void RestoreDatabase(string backupFileName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Re-index database tables
        /// </summary>
        public void ReIndexTables()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Get the current identity value
        /// </summary>
        /// <typeparam name="T">Entity</typeparam>
        /// <returns>Integer identity; null if cannot get the result</returns>
        public int? GetTableIdent<T>() where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Set table identity (is supported)
        /// </summary>
        /// <typeparam name="T">Entity</typeparam>
        /// <param name="ident">Identity value</param>
        public void SetTableIdent<T>(int ident) where T : BaseEntity
        {
            throw new NotImplementedException();
        }

        public DataParameter GetParameter()
        {
            return new DataParameter();
        }

        public bool BackupSupported { get; } = true;

        public int SupportedLengthOfBinaryHash { get; } = 8000;
    }
}
