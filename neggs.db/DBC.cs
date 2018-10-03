namespace neggs.db
{
	using System;
	using System.Configuration;
	using System.Data;
	using System.Data.Common;

	/// <summary>
	/// DBC の概要の説明です
	/// </summary>
	public partial class DBC
	{

		protected string configName = "neggsDB";

		protected string errorMessage = "データベース接続の生成に失敗しました。";

		protected DbConnection con = null;

		protected DbTransaction trans = null;

		protected ConnectionStringSettings settings = null;

		public string ConnectionString
		{
			get
			{
				return (settings == null) ? string.Empty : settings.ConnectionString;
			}
		}

		public string ProviderName
		{
			get
			{
				return (settings == null) ? string.Empty : settings.ProviderName;
			}
		}

		public DBC()
		{
			this.CreateConnection(configName);
		}

		public DBC(string configurationName)
		{
			this.CreateConnection(configurationName);
		}

		public DBC(string connectionString, string providerName)
		{
			this.CreateConnection(connectionString, providerName);
		}

		protected void CreateConnection(string configurationName)
		{
			LogingSQL("CreateConnection");
			settings = ConfigurationManager.ConnectionStrings[configurationName];
			if (settings != null)
			{
				DbProviderFactory provider = DbProviderFactories.GetFactory(settings.ProviderName);
				if (provider != null)
				{
					con = provider.CreateConnection();
					con.ConnectionString = settings.ConnectionString;
				}
			}

			if (con == null)
			{
				throw new Exception(errorMessage);
			}
		}

		protected void CreateConnection(string connectionString, string providerName)
		{
			LogingSQL("CreateConnection");
			settings = new ConnectionStringSettings(configName, connectionString, providerName);
			if (settings != null)
			{
				DbProviderFactory provider = DbProviderFactories.GetFactory(settings.ProviderName);
				if (provider != null)
				{
					con = provider.CreateConnection();
					con.ConnectionString = settings.ConnectionString;
				}
			}

			if (con == null)
			{
				throw new Exception(errorMessage);
			}
		}

		public void Open()
		{
			LogingSQL("Open");
			con.Open();
		}

		public void Dispose()
		{
			LogingSQL("Dispose");
			if (trans != null)
			{
				trans.Rollback();
				trans.Dispose();
				trans = null;
			}
			con.Close();
			con.Dispose();
		}

		public object ExecuteScalar(string CommandText)
		{
			LogingSQL("ExecuteScalar", CommandText);
			DbCommand com = con.CreateCommand();
			if (trans != null)
			{
				com.Transaction = trans;
			}
			com.CommandText = CommandText;
			com.CommandType = CommandType.Text;

			return com.ExecuteScalar();
		}

		public DbDataReader ExecuteReader(string CommandText)
		{
			LogingSQL("ExecuteReader", CommandText);
			DbCommand com = con.CreateCommand();
			if (trans != null)
			{
				com.Transaction = trans;
			}
			com.CommandText = CommandText;
			com.CommandType = CommandType.Text;

			return com.ExecuteReader();
		}

		public int ExecuteNonQuery(String CommandText)
		{
			LogingSQL("ExecuteNonQuery", CommandText);
			DbCommand com = con.CreateCommand();
			if (trans != null)
			{
				com.Transaction = trans;
			}
			com.CommandText = CommandText;
			com.CommandType = CommandType.Text;
			return com.ExecuteNonQuery();
		}

		public DbCommand CreateCommand()
		{
			DbCommand com = con.CreateCommand();
			if (trans != null)
			{
				com.Transaction = trans;
			}
			com.CommandType = CommandType.Text;
			return com;
		}

		public void BeginTransaction()
		{
			if (trans != null)
			{
				trans.Rollback();
				trans.Dispose();
				trans = null;
			}
			trans = con.BeginTransaction();
		}

		public void Rollback()
		{
			if (trans != null)
			{
				trans.Rollback();
				trans.Dispose();
				trans = null;
			}
		}

		public void Commit()
		{
			if (trans != null)
			{
				trans.Commit();
				trans.Dispose();
				trans = null;
			}
		}

		public void LogingSQL(string SendFunction, string SendSql = "")
		{
			System.Diagnostics.Debug.WriteLine($"{SendFunction}\t{SendSql}");
		}

	}
}
