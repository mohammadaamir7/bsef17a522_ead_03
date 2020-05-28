﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pharmacy_management.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Database1")]
	public partial class FerozsonsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void Insertferozson(ferozson instance);
    partial void Updateferozson(ferozson instance);
    partial void Deleteferozson(ferozson instance);
    #endregion
		
		public FerozsonsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["Database1ConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public FerozsonsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FerozsonsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FerozsonsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public FerozsonsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<ferozson> ferozsons
		{
			get
			{
				return this.GetTable<ferozson>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ferozsons")]
	public partial class ferozson : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _trademark;
		
		private string _generic;
		
		private string _cure;
		
		private string _potency;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OntrademarkChanging(string value);
    partial void OntrademarkChanged();
    partial void OngenericChanging(string value);
    partial void OngenericChanged();
    partial void OncureChanging(string value);
    partial void OncureChanged();
    partial void OnpotencyChanging(string value);
    partial void OnpotencyChanged();
    #endregion
		
		public ferozson()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_trademark", DbType="VarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string trademark
		{
			get
			{
				return this._trademark;
			}
			set
			{
				if ((this._trademark != value))
				{
					this.OntrademarkChanging(value);
					this.SendPropertyChanging();
					this._trademark = value;
					this.SendPropertyChanged("trademark");
					this.OntrademarkChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_generic", DbType="VarChar(50)")]
		public string generic
		{
			get
			{
				return this._generic;
			}
			set
			{
				if ((this._generic != value))
				{
					this.OngenericChanging(value);
					this.SendPropertyChanging();
					this._generic = value;
					this.SendPropertyChanged("generic");
					this.OngenericChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cure", DbType="VarChar(50)")]
		public string cure
		{
			get
			{
				return this._cure;
			}
			set
			{
				if ((this._cure != value))
				{
					this.OncureChanging(value);
					this.SendPropertyChanging();
					this._cure = value;
					this.SendPropertyChanged("cure");
					this.OncureChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_potency", DbType="VarChar(50)")]
		public string potency
		{
			get
			{
				return this._potency;
			}
			set
			{
				if ((this._potency != value))
				{
					this.OnpotencyChanging(value);
					this.SendPropertyChanging();
					this._potency = value;
					this.SendPropertyChanged("potency");
					this.OnpotencyChanged();
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
