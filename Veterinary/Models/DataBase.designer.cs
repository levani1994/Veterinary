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

namespace Veterinary.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Veterinary")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertCategory(Category instance);
    partial void UpdateCategory(Category instance);
    partial void DeleteCategory(Category instance);
    partial void InsertTopic(Topic instance);
    partial void UpdateTopic(Topic instance);
    partial void DeleteTopic(Topic instance);
    partial void InsertNotConfirmedUser(NotConfirmedUser instance);
    partial void UpdateNotConfirmedUser(NotConfirmedUser instance);
    partial void DeleteNotConfirmedUser(NotConfirmedUser instance);
    partial void InsertConfirmedUser(ConfirmedUser instance);
    partial void UpdateConfirmedUser(ConfirmedUser instance);
    partial void DeleteConfirmedUser(ConfirmedUser instance);
    partial void InsertFood(Food instance);
    partial void UpdateFood(Food instance);
    partial void DeleteFood(Food instance);
    partial void InsertCare(Care instance);
    partial void UpdateCare(Care instance);
    partial void DeleteCare(Care instance);
    #endregion
		
		public DataBaseDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["VeterinaryConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Category> Categories
		{
			get
			{
				return this.GetTable<Category>();
			}
		}
		
		public System.Data.Linq.Table<Topic> Topics
		{
			get
			{
				return this.GetTable<Topic>();
			}
		}
		
		public System.Data.Linq.Table<NotConfirmedUser> NotConfirmedUsers
		{
			get
			{
				return this.GetTable<NotConfirmedUser>();
			}
		}
		
		public System.Data.Linq.Table<ConfirmedUser> ConfirmedUsers
		{
			get
			{
				return this.GetTable<ConfirmedUser>();
			}
		}
		
		public System.Data.Linq.Table<Food> Foods
		{
			get
			{
				return this.GetTable<Food>();
			}
		}
		
		public System.Data.Linq.Table<Care> Cares
		{
			get
			{
				return this.GetTable<Care>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Category")]
	public partial class Category : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _CategoryName;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCategoryNameChanging(string value);
    partial void OnCategoryNameChanged();
    #endregion
		
		public Category()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CategoryName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string CategoryName
		{
			get
			{
				return this._CategoryName;
			}
			set
			{
				if ((this._CategoryName != value))
				{
					this.OnCategoryNameChanging(value);
					this.SendPropertyChanging();
					this._CategoryName = value;
					this.SendPropertyChanged("CategoryName");
					this.OnCategoryNameChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Topics")]
	public partial class Topic : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _TopicName;
		
		private string _Category;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnTopicNameChanging(string value);
    partial void OnTopicNameChanged();
    partial void OnCategoryChanging(string value);
    partial void OnCategoryChanged();
    #endregion
		
		public Topic()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TopicName", DbType="NVarChar(255) NOT NULL", CanBeNull=false)]
		public string TopicName
		{
			get
			{
				return this._TopicName;
			}
			set
			{
				if ((this._TopicName != value))
				{
					this.OnTopicNameChanging(value);
					this.SendPropertyChanging();
					this._TopicName = value;
					this.SendPropertyChanged("TopicName");
					this.OnTopicNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Category", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Category
		{
			get
			{
				return this._Category;
			}
			set
			{
				if ((this._Category != value))
				{
					this.OnCategoryChanging(value);
					this.SendPropertyChanging();
					this._Category = value;
					this.SendPropertyChanged("Category");
					this.OnCategoryChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.NotConfirmedUser")]
	public partial class NotConfirmedUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Surname;
		
		private string _BirthDate;
		
		private string _DogBreed;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _CreateDate;
		
		private string _ConfirmationCode;
		
		private string _RequestIp;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnBirthDateChanging(string value);
    partial void OnBirthDateChanged();
    partial void OnDogBreedChanging(string value);
    partial void OnDogBreedChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnConfirmationCodeChanging(string value);
    partial void OnConfirmationCodeChanged();
    partial void OnRequestIpChanging(string value);
    partial void OnRequestIpChanged();
    #endregion
		
		public NotConfirmedUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int ID
		{
			get
			{
				return this._ID;
			}
			set
			{
				if ((this._ID != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._ID = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogBreed", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DogBreed
		{
			get
			{
				return this._DogBreed;
			}
			set
			{
				if ((this._DogBreed != value))
				{
					this.OnDogBreedChanging(value);
					this.SendPropertyChanging();
					this._DogBreed = value;
					this.SendPropertyChanged("DogBreed");
					this.OnDogBreedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ConfirmationCode", DbType="NVarChar(32) NOT NULL", CanBeNull=false)]
		public string ConfirmationCode
		{
			get
			{
				return this._ConfirmationCode;
			}
			set
			{
				if ((this._ConfirmationCode != value))
				{
					this.OnConfirmationCodeChanging(value);
					this.SendPropertyChanging();
					this._ConfirmationCode = value;
					this.SendPropertyChanged("ConfirmationCode");
					this.OnConfirmationCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequestIp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string RequestIp
		{
			get
			{
				return this._RequestIp;
			}
			set
			{
				if ((this._RequestIp != value))
				{
					this.OnRequestIpChanging(value);
					this.SendPropertyChanging();
					this._RequestIp = value;
					this.SendPropertyChanged("RequestIp");
					this.OnRequestIpChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.ConfirmedUser")]
	public partial class ConfirmedUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _Name;
		
		private string _Surname;
		
		private string _BirthDate;
		
		private string _DogBreed;
		
		private string _Email;
		
		private string _Password;
		
		private System.DateTime _CreateDate;
		
		private string _RequestIp;
		
		private string _Token;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnSurnameChanging(string value);
    partial void OnSurnameChanged();
    partial void OnBirthDateChanging(string value);
    partial void OnBirthDateChanged();
    partial void OnDogBreedChanging(string value);
    partial void OnDogBreedChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    partial void OnCreateDateChanging(System.DateTime value);
    partial void OnCreateDateChanged();
    partial void OnRequestIpChanging(string value);
    partial void OnRequestIpChanged();
    partial void OnTokenChanging(string value);
    partial void OnTokenChanged();
    #endregion
		
		public ConfirmedUser()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Surname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Surname
		{
			get
			{
				return this._Surname;
			}
			set
			{
				if ((this._Surname != value))
				{
					this.OnSurnameChanging(value);
					this.SendPropertyChanging();
					this._Surname = value;
					this.SendPropertyChanged("Surname");
					this.OnSurnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_BirthDate", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BirthDate
		{
			get
			{
				return this._BirthDate;
			}
			set
			{
				if ((this._BirthDate != value))
				{
					this.OnBirthDateChanging(value);
					this.SendPropertyChanging();
					this._BirthDate = value;
					this.SendPropertyChanged("BirthDate");
					this.OnBirthDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DogBreed", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string DogBreed
		{
			get
			{
				return this._DogBreed;
			}
			set
			{
				if ((this._DogBreed != value))
				{
					this.OnDogBreedChanging(value);
					this.SendPropertyChanging();
					this._DogBreed = value;
					this.SendPropertyChanged("DogBreed");
					this.OnDogBreedChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Email
		{
			get
			{
				return this._Email;
			}
			set
			{
				if ((this._Email != value))
				{
					this.OnEmailChanging(value);
					this.SendPropertyChanging();
					this._Email = value;
					this.SendPropertyChanged("Email");
					this.OnEmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Password
		{
			get
			{
				return this._Password;
			}
			set
			{
				if ((this._Password != value))
				{
					this.OnPasswordChanging(value);
					this.SendPropertyChanging();
					this._Password = value;
					this.SendPropertyChanged("Password");
					this.OnPasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CreateDate", DbType="DateTime NOT NULL")]
		public System.DateTime CreateDate
		{
			get
			{
				return this._CreateDate;
			}
			set
			{
				if ((this._CreateDate != value))
				{
					this.OnCreateDateChanging(value);
					this.SendPropertyChanging();
					this._CreateDate = value;
					this.SendPropertyChanged("CreateDate");
					this.OnCreateDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RequestIp", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string RequestIp
		{
			get
			{
				return this._RequestIp;
			}
			set
			{
				if ((this._RequestIp != value))
				{
					this.OnRequestIpChanging(value);
					this.SendPropertyChanging();
					this._RequestIp = value;
					this.SendPropertyChanged("RequestIp");
					this.OnRequestIpChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Token", DbType="NVarChar(50)")]
		public string Token
		{
			get
			{
				return this._Token;
			}
			set
			{
				if ((this._Token != value))
				{
					this.OnTokenChanging(value);
					this.SendPropertyChanging();
					this._Token = value;
					this.SendPropertyChanged("Token");
					this.OnTokenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Food")]
	public partial class Food : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _PedigreeAdult;
		
		private string _Achiever;
		
		private string _Bella;
		
		private string _Tesco;
		
		private string _Puppy_Chow;
		
		private string _Solid_Gold;
		
		private string _Carna4;
		
		private string _PedigreeBig;
		
		private string _PedigreeSmall;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void OnPedigreeAdultChanging(string value);
    partial void OnPedigreeAdultChanged();
    partial void OnAchieverChanging(string value);
    partial void OnAchieverChanged();
    partial void OnBellaChanging(string value);
    partial void OnBellaChanged();
    partial void OnTescoChanging(string value);
    partial void OnTescoChanged();
    partial void OnPuppy_ChowChanging(string value);
    partial void OnPuppy_ChowChanged();
    partial void OnSolid_GoldChanging(string value);
    partial void OnSolid_GoldChanged();
    partial void OnCarna4Changing(string value);
    partial void OnCarna4Changed();
    partial void OnPedigreeBigChanging(string value);
    partial void OnPedigreeBigChanged();
    partial void OnPedigreeSmallChanging(string value);
    partial void OnPedigreeSmallChanged();
    #endregion
		
		public Food()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PedigreeAdult", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string PedigreeAdult
		{
			get
			{
				return this._PedigreeAdult;
			}
			set
			{
				if ((this._PedigreeAdult != value))
				{
					this.OnPedigreeAdultChanging(value);
					this.SendPropertyChanging();
					this._PedigreeAdult = value;
					this.SendPropertyChanged("PedigreeAdult");
					this.OnPedigreeAdultChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Achiever", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Achiever
		{
			get
			{
				return this._Achiever;
			}
			set
			{
				if ((this._Achiever != value))
				{
					this.OnAchieverChanging(value);
					this.SendPropertyChanging();
					this._Achiever = value;
					this.SendPropertyChanged("Achiever");
					this.OnAchieverChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Bella", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Bella
		{
			get
			{
				return this._Bella;
			}
			set
			{
				if ((this._Bella != value))
				{
					this.OnBellaChanging(value);
					this.SendPropertyChanging();
					this._Bella = value;
					this.SendPropertyChanged("Bella");
					this.OnBellaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tesco", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Tesco
		{
			get
			{
				return this._Tesco;
			}
			set
			{
				if ((this._Tesco != value))
				{
					this.OnTescoChanging(value);
					this.SendPropertyChanging();
					this._Tesco = value;
					this.SendPropertyChanged("Tesco");
					this.OnTescoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Puppy Chow]", Storage="_Puppy_Chow", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Puppy_Chow
		{
			get
			{
				return this._Puppy_Chow;
			}
			set
			{
				if ((this._Puppy_Chow != value))
				{
					this.OnPuppy_ChowChanging(value);
					this.SendPropertyChanging();
					this._Puppy_Chow = value;
					this.SendPropertyChanged("Puppy_Chow");
					this.OnPuppy_ChowChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Solid Gold]", Storage="_Solid_Gold", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Solid_Gold
		{
			get
			{
				return this._Solid_Gold;
			}
			set
			{
				if ((this._Solid_Gold != value))
				{
					this.OnSolid_GoldChanging(value);
					this.SendPropertyChanging();
					this._Solid_Gold = value;
					this.SendPropertyChanged("Solid_Gold");
					this.OnSolid_GoldChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Carna4", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string Carna4
		{
			get
			{
				return this._Carna4;
			}
			set
			{
				if ((this._Carna4 != value))
				{
					this.OnCarna4Changing(value);
					this.SendPropertyChanging();
					this._Carna4 = value;
					this.SendPropertyChanged("Carna4");
					this.OnCarna4Changed();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PedigreeBig", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string PedigreeBig
		{
			get
			{
				return this._PedigreeBig;
			}
			set
			{
				if ((this._PedigreeBig != value))
				{
					this.OnPedigreeBigChanging(value);
					this.SendPropertyChanging();
					this._PedigreeBig = value;
					this.SendPropertyChanged("PedigreeBig");
					this.OnPedigreeBigChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PedigreeSmall", DbType="NVarChar(64) NOT NULL", CanBeNull=false)]
		public string PedigreeSmall
		{
			get
			{
				return this._PedigreeSmall;
			}
			set
			{
				if ((this._PedigreeSmall != value))
				{
					this.OnPedigreeSmallChanging(value);
					this.SendPropertyChanging();
					this._PedigreeSmall = value;
					this.SendPropertyChanged("PedigreeSmall");
					this.OnPedigreeSmallChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Care")]
	public partial class Care : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _id;
		
		private string _juxzh_Truelove;
		
		private string _Basics_Dog_Leashe;
		
		private string _pet_and_cuddle;
		
		private string _BWOGUE_Seat_Belts;
		
		private string _Pet_Gear_Carrier;
		
		private string _WIGZI_Dual;
		
		private string _LOVESAKI_Car_Seat;
		
		private string _Dog_Training_Collar;
		
		private string _GoTags;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnidChanging(int value);
    partial void OnidChanged();
    partial void Onjuxzh_TrueloveChanging(string value);
    partial void Onjuxzh_TrueloveChanged();
    partial void OnBasics_Dog_LeasheChanging(string value);
    partial void OnBasics_Dog_LeasheChanged();
    partial void Onpet_and_cuddleChanging(string value);
    partial void Onpet_and_cuddleChanged();
    partial void OnBWOGUE_Seat_BeltsChanging(string value);
    partial void OnBWOGUE_Seat_BeltsChanged();
    partial void OnPet_Gear_CarrierChanging(string value);
    partial void OnPet_Gear_CarrierChanged();
    partial void OnWIGZI_DualChanging(string value);
    partial void OnWIGZI_DualChanged();
    partial void OnLOVESAKI_Car_SeatChanging(string value);
    partial void OnLOVESAKI_Car_SeatChanged();
    partial void OnDog_Training_CollarChanging(string value);
    partial void OnDog_Training_CollarChanged();
    partial void OnGoTagsChanging(string value);
    partial void OnGoTagsChanged();
    #endregion
		
		public Care()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int id
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[juxzh Truelove]", Storage="_juxzh_Truelove", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string juxzh_Truelove
		{
			get
			{
				return this._juxzh_Truelove;
			}
			set
			{
				if ((this._juxzh_Truelove != value))
				{
					this.Onjuxzh_TrueloveChanging(value);
					this.SendPropertyChanging();
					this._juxzh_Truelove = value;
					this.SendPropertyChanged("juxzh_Truelove");
					this.Onjuxzh_TrueloveChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Basics Dog Leashe]", Storage="_Basics_Dog_Leashe", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Basics_Dog_Leashe
		{
			get
			{
				return this._Basics_Dog_Leashe;
			}
			set
			{
				if ((this._Basics_Dog_Leashe != value))
				{
					this.OnBasics_Dog_LeasheChanging(value);
					this.SendPropertyChanging();
					this._Basics_Dog_Leashe = value;
					this.SendPropertyChanged("Basics_Dog_Leashe");
					this.OnBasics_Dog_LeasheChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[pet and cuddle]", Storage="_pet_and_cuddle", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string pet_and_cuddle
		{
			get
			{
				return this._pet_and_cuddle;
			}
			set
			{
				if ((this._pet_and_cuddle != value))
				{
					this.Onpet_and_cuddleChanging(value);
					this.SendPropertyChanging();
					this._pet_and_cuddle = value;
					this.SendPropertyChanged("pet_and_cuddle");
					this.Onpet_and_cuddleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[BWOGUE Seat Belts]", Storage="_BWOGUE_Seat_Belts", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string BWOGUE_Seat_Belts
		{
			get
			{
				return this._BWOGUE_Seat_Belts;
			}
			set
			{
				if ((this._BWOGUE_Seat_Belts != value))
				{
					this.OnBWOGUE_Seat_BeltsChanging(value);
					this.SendPropertyChanging();
					this._BWOGUE_Seat_Belts = value;
					this.SendPropertyChanged("BWOGUE_Seat_Belts");
					this.OnBWOGUE_Seat_BeltsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Pet Gear Carrier]", Storage="_Pet_Gear_Carrier", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Pet_Gear_Carrier
		{
			get
			{
				return this._Pet_Gear_Carrier;
			}
			set
			{
				if ((this._Pet_Gear_Carrier != value))
				{
					this.OnPet_Gear_CarrierChanging(value);
					this.SendPropertyChanging();
					this._Pet_Gear_Carrier = value;
					this.SendPropertyChanged("Pet_Gear_Carrier");
					this.OnPet_Gear_CarrierChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[WIGZI Dual]", Storage="_WIGZI_Dual", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string WIGZI_Dual
		{
			get
			{
				return this._WIGZI_Dual;
			}
			set
			{
				if ((this._WIGZI_Dual != value))
				{
					this.OnWIGZI_DualChanging(value);
					this.SendPropertyChanging();
					this._WIGZI_Dual = value;
					this.SendPropertyChanged("WIGZI_Dual");
					this.OnWIGZI_DualChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[LOVESAKI Car Seat]", Storage="_LOVESAKI_Car_Seat", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string LOVESAKI_Car_Seat
		{
			get
			{
				return this._LOVESAKI_Car_Seat;
			}
			set
			{
				if ((this._LOVESAKI_Car_Seat != value))
				{
					this.OnLOVESAKI_Car_SeatChanging(value);
					this.SendPropertyChanging();
					this._LOVESAKI_Car_Seat = value;
					this.SendPropertyChanged("LOVESAKI_Car_Seat");
					this.OnLOVESAKI_Car_SeatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Dog Training Collar]", Storage="_Dog_Training_Collar", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Dog_Training_Collar
		{
			get
			{
				return this._Dog_Training_Collar;
			}
			set
			{
				if ((this._Dog_Training_Collar != value))
				{
					this.OnDog_Training_CollarChanging(value);
					this.SendPropertyChanging();
					this._Dog_Training_Collar = value;
					this.SendPropertyChanged("Dog_Training_Collar");
					this.OnDog_Training_CollarChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GoTags", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string GoTags
		{
			get
			{
				return this._GoTags;
			}
			set
			{
				if ((this._GoTags != value))
				{
					this.OnGoTagsChanging(value);
					this.SendPropertyChanging();
					this._GoTags = value;
					this.SendPropertyChanged("GoTags");
					this.OnGoTagsChanged();
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
