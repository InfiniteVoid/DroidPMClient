﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DroidPMClient
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="locationawarepm_db")]
	public partial class DataClassesDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCommandItem(CommandItem instance);
    partial void UpdateCommandItem(CommandItem instance);
    partial void DeleteCommandItem(CommandItem instance);
    #endregion
		
		public DataClassesDataContext() : 
				base(global::DroidPMClient.Properties.Settings.Default.locationawarepm_dbConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClassesDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CommandItem> CommandItems
		{
			get
			{
				return this.GetTable<CommandItem>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="locationawarepm.CommandItem")]
	public partial class CommandItem : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _id;
		
		private System.DateTimeOffset ___createdAt;
		
		private System.Nullable<System.DateTimeOffset> ___updatedAt;
		
		private System.Data.Linq.Binary ___version;
		
		private string _command;
		
		private string _password;
		
		private string _username;
		
		private string _workgoup;
		
		private string _workgoup_state;
		
		private string _auth_level;
		
		private string _firstname;
		
		private string _lastname;
		
		private string _computername;
		
		private string _terminateprocess;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(string value);
    partial void OnidChanged();
    partial void On__createdAtChanging(System.DateTimeOffset value);
    partial void On__createdAtChanged();
    partial void On__updatedAtChanging(System.Nullable<System.DateTimeOffset> value);
    partial void On__updatedAtChanged();
    partial void On__versionChanging(System.Data.Linq.Binary value);
    partial void On__versionChanged();
    partial void OncommandChanging(string value);
    partial void OncommandChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnusernameChanging(string value);
    partial void OnusernameChanged();
    partial void OnworkgoupChanging(string value);
    partial void OnworkgoupChanged();
    partial void Onworkgoup_stateChanging(string value);
    partial void Onworkgoup_stateChanged();
    partial void Onauth_levelChanging(string value);
    partial void Onauth_levelChanged();
    partial void OnfirstnameChanging(string value);
    partial void OnfirstnameChanged();
    partial void OnlastnameChanging(string value);
    partial void OnlastnameChanged();
    partial void OncomputernameChanging(string value);
    partial void OncomputernameChanged();
    partial void OnterminateprocessChanging(string value);
    partial void OnterminateprocessChanged();
    #endregion
		
		public CommandItem()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true, UpdateCheck=UpdateCheck.Never)]
		public string id
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((this._id != value))
				{
					this.OnidChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("id");
					this.OnidChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[__createdAt]", Storage="___createdAt", DbType="DateTimeOffset NOT NULL", UpdateCheck=UpdateCheck.Never)]
		public System.DateTimeOffset @__createdAt
		{
			get
			{
				return this.___createdAt;
			}
			set
			{
				if ((this.___createdAt != value))
				{
					this.On__createdAtChanging(value);
					this.SendPropertyChanging();
					this.___createdAt = value;
					this.SendPropertyChanged("__createdAt");
					this.On__createdAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[__updatedAt]", Storage="___updatedAt", DbType="DateTimeOffset", UpdateCheck=UpdateCheck.Never)]
		public System.Nullable<System.DateTimeOffset> @__updatedAt
		{
			get
			{
				return this.___updatedAt;
			}
			set
			{
				if ((this.___updatedAt != value))
				{
					this.On__updatedAtChanging(value);
					this.SendPropertyChanging();
					this.___updatedAt = value;
					this.SendPropertyChanged("__updatedAt");
					this.On__updatedAtChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[__version]", Storage="___version", AutoSync=AutoSync.Always, DbType="rowversion NOT NULL", CanBeNull=false, IsDbGenerated=true, IsVersion=true, UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary @__version
		{
			get
			{
				return this.___version;
			}
			set
			{
				if ((this.___version != value))
				{
					this.On__versionChanging(value);
					this.SendPropertyChanging();
					this.___version = value;
					this.SendPropertyChanged("__version");
					this.On__versionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_command", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string command
		{
			get
			{
				return this._command;
			}
			set
			{
				if ((this._command != value))
				{
					this.OncommandChanging(value);
					this.SendPropertyChanging();
					this._command = value;
					this.SendPropertyChanged("command");
					this.OncommandChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_username", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string username
		{
			get
			{
				return this._username;
			}
			set
			{
				if ((this._username != value))
				{
					this.OnusernameChanging(value);
					this.SendPropertyChanging();
					this._username = value;
					this.SendPropertyChanged("username");
					this.OnusernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workgoup", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string workgoup
		{
			get
			{
				return this._workgoup;
			}
			set
			{
				if ((this._workgoup != value))
				{
					this.OnworkgoupChanging(value);
					this.SendPropertyChanging();
					this._workgoup = value;
					this.SendPropertyChanged("workgoup");
					this.OnworkgoupChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_workgoup_state", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string workgoup_state
		{
			get
			{
				return this._workgoup_state;
			}
			set
			{
				if ((this._workgoup_state != value))
				{
					this.Onworkgoup_stateChanging(value);
					this.SendPropertyChanging();
					this._workgoup_state = value;
					this.SendPropertyChanged("workgoup_state");
					this.Onworkgoup_stateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_auth_level", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string auth_level
		{
			get
			{
				return this._auth_level;
			}
			set
			{
				if ((this._auth_level != value))
				{
					this.Onauth_levelChanging(value);
					this.SendPropertyChanging();
					this._auth_level = value;
					this.SendPropertyChanged("auth_level");
					this.Onauth_levelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstname", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string firstname
		{
			get
			{
				return this._firstname;
			}
			set
			{
				if ((this._firstname != value))
				{
					this.OnfirstnameChanging(value);
					this.SendPropertyChanging();
					this._firstname = value;
					this.SendPropertyChanged("firstname");
					this.OnfirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastname", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string lastname
		{
			get
			{
				return this._lastname;
			}
			set
			{
				if ((this._lastname != value))
				{
					this.OnlastnameChanging(value);
					this.SendPropertyChanging();
					this._lastname = value;
					this.SendPropertyChanged("lastname");
					this.OnlastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_computername", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string computername
		{
			get
			{
				return this._computername;
			}
			set
			{
				if ((this._computername != value))
				{
					this.OncomputernameChanging(value);
					this.SendPropertyChanging();
					this._computername = value;
					this.SendPropertyChanged("computername");
					this.OncomputernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_terminateprocess", DbType="NVarChar(MAX)", UpdateCheck=UpdateCheck.Never)]
		public string terminateprocess
		{
			get
			{
				return this._terminateprocess;
			}
			set
			{
				if ((this._terminateprocess != value))
				{
					this.OnterminateprocessChanging(value);
					this.SendPropertyChanging();
					this._terminateprocess = value;
					this.SendPropertyChanged("terminateprocess");
					this.OnterminateprocessChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
