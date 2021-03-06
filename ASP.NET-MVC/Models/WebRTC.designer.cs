﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRTCExperiment.Models
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="WebRTCData")]
	public partial class WebRTCDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSDPMessage(SDPMessage instance);
    partial void UpdateSDPMessage(SDPMessage instance);
    partial void DeleteSDPMessage(SDPMessage instance);
    partial void InsertCandidatesTable(CandidatesTable instance);
    partial void UpdateCandidatesTable(CandidatesTable instance);
    partial void DeleteCandidatesTable(CandidatesTable instance);
    partial void InsertFeedback(Feedback instance);
    partial void UpdateFeedback(Feedback instance);
    partial void DeleteFeedback(Feedback instance);
    #endregion
		
		public WebRTCDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["WebRTCDataConnectionString"].ConnectionString, mappingSource)
        {
			OnCreated();
		}
		
		public WebRTCDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WebRTCDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SDPMessage> SDPMessages
		{
			get
			{
				return this.GetTable<SDPMessage>();
			}
		}
		
		public System.Data.Linq.Table<CandidatesTable> CandidatesTables
		{
			get
			{
				return this.GetTable<CandidatesTable>();
			}
		}
		
		public System.Data.Linq.Table<Feedback> Feedbacks
		{
			get
			{
				return this.GetTable<Feedback>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SDPMessage")]
	public partial class SDPMessage : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Room;
		
		private string _Users;
		
		private System.DateTime _EventDate;
		
		private string _SDP;
		
		private string _FromUser;
		
		private string _Type;
		
		private bool _IsRoomFull;
		
		private bool _Done;
		
		private string _RoomToken;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnRoomChanging(string value);
    partial void OnRoomChanged();
    partial void OnUsersChanging(string value);
    partial void OnUsersChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    partial void OnSDPChanging(string value);
    partial void OnSDPChanged();
    partial void OnFromUserChanging(string value);
    partial void OnFromUserChanged();
    partial void OnTypeChanging(string value);
    partial void OnTypeChanged();
    partial void OnIsRoomFullChanging(bool value);
    partial void OnIsRoomFullChanged();
    partial void OnDoneChanging(bool value);
    partial void OnDoneChanged();
    partial void OnRoomTokenChanging(string value);
    partial void OnRoomTokenChanged();
    #endregion
		
		public SDPMessage()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				if ((this._Room != value))
				{
					this.OnRoomChanging(value);
					this.SendPropertyChanging();
					this._Room = value;
					this.SendPropertyChanged("Room");
					this.OnRoomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Users", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Users
		{
			get
			{
				return this._Users;
			}
			set
			{
				if ((this._Users != value))
				{
					this.OnUsersChanging(value);
					this.SendPropertyChanging();
					this._Users = value;
					this.SendPropertyChanged("Users");
					this.OnUsersChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SDP", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string SDP
		{
			get
			{
				return this._SDP;
			}
			set
			{
				if ((this._SDP != value))
				{
					this.OnSDPChanging(value);
					this.SendPropertyChanging();
					this._SDP = value;
					this.SendPropertyChanged("SDP");
					this.OnSDPChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromUser", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FromUser
		{
			get
			{
				return this._FromUser;
			}
			set
			{
				if ((this._FromUser != value))
				{
					this.OnFromUserChanging(value);
					this.SendPropertyChanging();
					this._FromUser = value;
					this.SendPropertyChanged("FromUser");
					this.OnFromUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Type
		{
			get
			{
				return this._Type;
			}
			set
			{
				if ((this._Type != value))
				{
					this.OnTypeChanging(value);
					this.SendPropertyChanging();
					this._Type = value;
					this.SendPropertyChanged("Type");
					this.OnTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IsRoomFull", DbType="Bit NOT NULL")]
		public bool IsRoomFull
		{
			get
			{
				return this._IsRoomFull;
			}
			set
			{
				if ((this._IsRoomFull != value))
				{
					this.OnIsRoomFullChanging(value);
					this.SendPropertyChanging();
					this._IsRoomFull = value;
					this.SendPropertyChanged("IsRoomFull");
					this.OnIsRoomFullChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Done", DbType="Bit NOT NULL")]
		public bool Done
		{
			get
			{
				return this._Done;
			}
			set
			{
				if ((this._Done != value))
				{
					this.OnDoneChanging(value);
					this.SendPropertyChanging();
					this._Done = value;
					this.SendPropertyChanged("Done");
					this.OnDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_RoomToken", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string RoomToken
		{
			get
			{
				return this._RoomToken;
			}
			set
			{
				if ((this._RoomToken != value))
				{
					this.OnRoomTokenChanging(value);
					this.SendPropertyChanging();
					this._RoomToken = value;
					this.SendPropertyChanged("RoomToken");
					this.OnRoomTokenChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CandidatesTable")]
	public partial class CandidatesTable : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Candidate;
		
		private string _Label;
		
		private string _Room;
		
		private string _FromUser;
		
		private bool _Done;
		
		private System.DateTime _EventDate;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnCandidateChanging(string value);
    partial void OnCandidateChanged();
    partial void OnLabelChanging(string value);
    partial void OnLabelChanged();
    partial void OnRoomChanging(string value);
    partial void OnRoomChanged();
    partial void OnFromUserChanging(string value);
    partial void OnFromUserChanged();
    partial void OnDoneChanging(bool value);
    partial void OnDoneChanged();
    partial void OnEventDateChanging(System.DateTime value);
    partial void OnEventDateChanged();
    #endregion
		
		public CandidatesTable()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Candidate", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Candidate
		{
			get
			{
				return this._Candidate;
			}
			set
			{
				if ((this._Candidate != value))
				{
					this.OnCandidateChanging(value);
					this.SendPropertyChanging();
					this._Candidate = value;
					this.SendPropertyChanged("Candidate");
					this.OnCandidateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Label", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Label
		{
			get
			{
				return this._Label;
			}
			set
			{
				if ((this._Label != value))
				{
					this.OnLabelChanging(value);
					this.SendPropertyChanging();
					this._Label = value;
					this.SendPropertyChanged("Label");
					this.OnLabelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Room", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Room
		{
			get
			{
				return this._Room;
			}
			set
			{
				if ((this._Room != value))
				{
					this.OnRoomChanging(value);
					this.SendPropertyChanging();
					this._Room = value;
					this.SendPropertyChanged("Room");
					this.OnRoomChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FromUser", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string FromUser
		{
			get
			{
				return this._FromUser;
			}
			set
			{
				if ((this._FromUser != value))
				{
					this.OnFromUserChanging(value);
					this.SendPropertyChanging();
					this._FromUser = value;
					this.SendPropertyChanged("FromUser");
					this.OnFromUserChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Done", DbType="Bit NOT NULL")]
		public bool Done
		{
			get
			{
				return this._Done;
			}
			set
			{
				if ((this._Done != value))
				{
					this.OnDoneChanging(value);
					this.SendPropertyChanging();
					this._Done = value;
					this.SendPropertyChanged("Done");
					this.OnDoneChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDate", DbType="DateTime NOT NULL")]
		public System.DateTime EventDate
		{
			get
			{
				return this._EventDate;
			}
			set
			{
				if ((this._EventDate != value))
				{
					this.OnEventDateChanging(value);
					this.SendPropertyChanging();
					this._EventDate = value;
					this.SendPropertyChanged("EventDate");
					this.OnEventDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Feedback")]
	public partial class Feedback : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _ID;
		
		private string _Name;
		
		private string _Message;
		
		private System.DateTime _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDChanging(int value);
    partial void OnIDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMessageChanging(string value);
    partial void OnMessageChanged();
    partial void OnDateChanging(System.DateTime value);
    partial void OnDateChanged();
    #endregion
		
		public Feedback()
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Message", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Message
		{
			get
			{
				return this._Message;
			}
			set
			{
				if ((this._Message != value))
				{
					this.OnMessageChanging(value);
					this.SendPropertyChanging();
					this._Message = value;
					this.SendPropertyChanged("Message");
					this.OnMessageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="DateTime NOT NULL")]
		public System.DateTime Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
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
