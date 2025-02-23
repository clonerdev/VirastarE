//
// System.Data.SQLite.SqliteDataAdapter.cs
//
// Represents a set of data commands and a database connection that are used 
// to fill the DataSet and update the data source.
//
// Author(s): Everaldo Canuto  <everaldo_canuto@yahoo.com.br>
//
// Copyright (C) 2004  Everaldo Canuto
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System.Data.Common;

namespace System.Data.SQLite
{
    /// <summary>
    /// Represents a set of data commands and a database connection that are used 
    /// to fill the <see cref="DataSet">DataSet</see> and update the data source.
    /// </summary>
    [System.ComponentModel.DesignerCategory("")]
    public class SQLiteDataAdapter : DbDataAdapter
    {
        #region Public Events
        /// <summary>
        /// Occurs during <see cref="DbDataAdapter.Update">Update</see> after a 
        /// command is executed against the data source. The attempt to update 
        /// is made, so the event fires.
        /// </summary>
        public event SqliteRowUpdatedEventHandler RowUpdated;
        /// <summary>
        /// Occurs during <see cref="DbDataAdapter.Update">Update</see> before a 
        /// command is executed against the data source. The attempt to update 
        /// is made, so the event fires.
        /// </summary>
        public event SQLiteRowUpdatingEventHandler RowUpdating;
        #endregion
        #region Contructors
        /// <summary>
        /// Initializes a new instance of the <see cref="SqliteDataAdapter">SqliteDataAdapter</see> class.
        /// </summary>
        public SQLiteDataAdapter()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqliteDataAdapter">SqliteDataAdapter</see> class 
        /// with the specified SqliteCommand as the SelectCommand property.
        /// </summary>
        /// <param name="selectCommand"></param>
        public SQLiteDataAdapter(DbCommand selectCommand)
        {
            SelectCommand = selectCommand;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqliteDataAdapter">SqliteDataAdapter</see> class 
        /// with a SelectCommand and a SqliteConnection object.
        /// </summary>
        /// <param name="selectCommandText"></param>
        /// <param name="connection"></param>
        public SQLiteDataAdapter(string selectCommandText, SQLiteConnection connection)
        {
            DbCommand cmd = connection.CreateCommand();
            cmd.CommandText = selectCommandText;
            SelectCommand = cmd;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqliteDataAdapter">SqliteDataAdapter</see> class 
        /// with a SelectCommand and a connection string.
        /// </summary>
        /// <param name="selectCommandText"></param>
        /// <param name="connectionString"></param>
        public SQLiteDataAdapter(string selectCommandText, string connectionString) : this(selectCommandText, new SQLiteConnection(connectionString))
        {
        }
        #endregion
        #region Protected Methods
        /// <summary>
        /// Initializes a new instance of the <see cref="RowUpdatedEventArgs">RowUpdatedEventArgs</see> class.
        /// </summary>
        /// <param name="dataRow">The DataRow used to update the data source.</param>
        /// <param name="command">The IDbCommand executed during the Update.</param>
        /// <param name="statementType">Whether the command is an UPDATE, INSERT, DELETE, or SELECT statement.</param>
        /// <param name="tableMapping">A DataTableMapping object.</param>
        /// <returns></returns>
        protected override RowUpdatedEventArgs CreateRowUpdatedEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
        {
            return new SQLiteRowUpdatedEventArgs(dataRow, command, statementType, tableMapping);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="dataRow">The DataRow used to update the data source.</param>
        /// <param name="command">The IDbCommand executed during the Update.</param>
        /// <param name="statementType">Whether the command is an UPDATE, INSERT, DELETE, or SELECT statement.</param>
        /// <param name="tableMapping">A DataTableMapping object.</param>
        /// <returns></returns>
        protected override RowUpdatingEventArgs CreateRowUpdatingEvent(DataRow dataRow, IDbCommand command, StatementType statementType, DataTableMapping tableMapping)
        {
            return new SQLiteRowUpdatingEventArgs(dataRow, command, statementType, tableMapping);
        }

        /// <summary>
        /// Raises the RowUpdated event of a Sqlite data provider.
        /// </summary>
        /// <param name="args">A RowUpdatedEventArgs that contains the event data.</param>
        protected override void OnRowUpdating(RowUpdatingEventArgs args)
        {
            if (RowUpdating != null)
                RowUpdating(this, args);
        }

        /// <summary>
        /// Raises the RowUpdating event of Sqlite data provider.
        /// </summary>
        /// <param name="args">An RowUpdatingEventArgs that contains the event data.</param>
        protected override void OnRowUpdated(RowUpdatedEventArgs args)
        {
            if (RowUpdated != null)
                RowUpdated(this, args);
        }
        #endregion
    }
}
