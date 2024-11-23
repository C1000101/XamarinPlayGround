using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HelloWorld.Droid.Presistence;
using HelloWorld.Persistence;
using SQLite;
using System.IO;

using Xamarin.Forms;

[assembly: Dependency(typeof(SQLiteDb))]

namespace HelloWorld.Droid.Presistence
{
	public class SQLiteDb : ISQLiteDb
	{
		public SQLiteAsyncConnection GetConnection()
		{
			var documentPath = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer);
			var path = Path.Combine(documentPath, "MySQLite.db3");
			return new SQLiteAsyncConnection(path);
		}

	}
}