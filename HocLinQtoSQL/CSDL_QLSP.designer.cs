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

namespace HocLinQtoSQL
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CSDL_QLSP")]
	public partial class CSDL_QLSPDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertSanPham(SanPham instance);
    partial void UpdateSanPham(SanPham instance);
    partial void DeleteSanPham(SanPham instance);
    partial void InsertDanhMuc(DanhMuc instance);
    partial void UpdateDanhMuc(DanhMuc instance);
    partial void DeleteDanhMuc(DanhMuc instance);
    #endregion
		
		public CSDL_QLSPDataContext() : 
				base(global::HocLinQtoSQL.Properties.Settings.Default.CSDL_QLSPConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public CSDL_QLSPDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSDL_QLSPDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSDL_QLSPDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public CSDL_QLSPDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<SanPham> SanPhams
		{
			get
			{
				return this.GetTable<SanPham>();
			}
		}
		
		public System.Data.Linq.Table<DanhMuc> DanhMucs
		{
			get
			{
				return this.GetTable<DanhMuc>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.SanPham")]
	public partial class SanPham : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaSanPham;
		
		private string _TenSanPham;
		
		private System.Nullable<int> _DonGia;
		
		private System.Nullable<int> _MaDanhMuc;
		
		private EntityRef<DanhMuc> _DanhMuc;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaSanPhamChanging(int value);
    partial void OnMaSanPhamChanged();
    partial void OnTenSanPhamChanging(string value);
    partial void OnTenSanPhamChanged();
    partial void OnDonGiaChanging(System.Nullable<int> value);
    partial void OnDonGiaChanged();
    partial void OnMaDanhMucChanging(System.Nullable<int> value);
    partial void OnMaDanhMucChanged();
    #endregion
		
		public SanPham()
		{
			this._DanhMuc = default(EntityRef<DanhMuc>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaSanPham", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaSanPham
		{
			get
			{
				return this._MaSanPham;
			}
			set
			{
				if ((this._MaSanPham != value))
				{
					this.OnMaSanPhamChanging(value);
					this.SendPropertyChanging();
					this._MaSanPham = value;
					this.SendPropertyChanged("MaSanPham");
					this.OnMaSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenSanPham", DbType="NChar(250)")]
		public string TenSanPham
		{
			get
			{
				return this._TenSanPham;
			}
			set
			{
				if ((this._TenSanPham != value))
				{
					this.OnTenSanPhamChanging(value);
					this.SendPropertyChanging();
					this._TenSanPham = value;
					this.SendPropertyChanged("TenSanPham");
					this.OnTenSanPhamChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_DonGia", DbType="Int")]
		public System.Nullable<int> DonGia
		{
			get
			{
				return this._DonGia;
			}
			set
			{
				if ((this._DonGia != value))
				{
					this.OnDonGiaChanging(value);
					this.SendPropertyChanging();
					this._DonGia = value;
					this.SendPropertyChanged("DonGia");
					this.OnDonGiaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="Int")]
		public System.Nullable<int> MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					if (this._DanhMuc.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMaDanhMucChanging(value);
					this.SendPropertyChanging();
					this._MaDanhMuc = value;
					this.SendPropertyChanged("MaDanhMuc");
					this.OnMaDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_DanhMuc", ThisKey="MaDanhMuc", OtherKey="MaDanhMuc", IsForeignKey=true)]
		public DanhMuc DanhMuc
		{
			get
			{
				return this._DanhMuc.Entity;
			}
			set
			{
				DanhMuc previousValue = this._DanhMuc.Entity;
				if (((previousValue != value) 
							|| (this._DanhMuc.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._DanhMuc.Entity = null;
						previousValue.SanPhams.Remove(this);
					}
					this._DanhMuc.Entity = value;
					if ((value != null))
					{
						value.SanPhams.Add(this);
						this._MaDanhMuc = value.MaDanhMuc;
					}
					else
					{
						this._MaDanhMuc = default(Nullable<int>);
					}
					this.SendPropertyChanged("DanhMuc");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.DanhMuc")]
	public partial class DanhMuc : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _MaDanhMuc;
		
		private string _TenDanhMuc;
		
		private EntitySet<SanPham> _SanPhams;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMaDanhMucChanging(int value);
    partial void OnMaDanhMucChanged();
    partial void OnTenDanhMucChanging(string value);
    partial void OnTenDanhMucChanged();
    #endregion
		
		public DanhMuc()
		{
			this._SanPhams = new EntitySet<SanPham>(new Action<SanPham>(this.attach_SanPhams), new Action<SanPham>(this.detach_SanPhams));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MaDanhMuc", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int MaDanhMuc
		{
			get
			{
				return this._MaDanhMuc;
			}
			set
			{
				if ((this._MaDanhMuc != value))
				{
					this.OnMaDanhMucChanging(value);
					this.SendPropertyChanging();
					this._MaDanhMuc = value;
					this.SendPropertyChanged("MaDanhMuc");
					this.OnMaDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TenDanhMuc", DbType="NChar(250)")]
		public string TenDanhMuc
		{
			get
			{
				return this._TenDanhMuc;
			}
			set
			{
				if ((this._TenDanhMuc != value))
				{
					this.OnTenDanhMucChanging(value);
					this.SendPropertyChanging();
					this._TenDanhMuc = value;
					this.SendPropertyChanged("TenDanhMuc");
					this.OnTenDanhMucChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="DanhMuc_SanPham", Storage="_SanPhams", ThisKey="MaDanhMuc", OtherKey="MaDanhMuc")]
		public EntitySet<SanPham> SanPhams
		{
			get
			{
				return this._SanPhams;
			}
			set
			{
				this._SanPhams.Assign(value);
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
		
		private void attach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = this;
		}
		
		private void detach_SanPhams(SanPham entity)
		{
			this.SendPropertyChanging();
			entity.DanhMuc = null;
		}
	}
}
#pragma warning restore 1591
