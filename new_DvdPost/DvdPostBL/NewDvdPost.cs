// 
//  ____  _     __  __      _        _ 
// |  _ \| |__ |  \/  | ___| |_ __ _| |
// | | | | '_ \| |\/| |/ _ \ __/ _` | |
// | |_| | |_) | |  | |  __/ || (_| | |
// |____/|_.__/|_|  |_|\___|\__\__,_|_|
//
// Auto-generated from new_dvdpost on 2011-07-13 11:59:15Z.
// Please visit http://code.google.com/p/dblinq2007/ for more information.
//
namespace Data
{
	using System;
	using System.ComponentModel;
	using System.Data;
#if MONO_STRICT
	using System.Data.Linq;
#else   // MONO_STRICT
	using DbLinq.Data.Linq;
	using DbLinq.Vendor;
#endif  // MONO_STRICT
	using System.Data.Linq.Mapping;
	using System.Diagnostics;
	
	
	public partial class NewDVdPost : DataContext
	{
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		#endregion
		
		
		public NewDVdPost(string connectionString) : 
				base(connectionString)
		{
			this.OnCreated();
		}
		
		public NewDVdPost(string connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public NewDVdPost(IDbConnection connection, MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			this.OnCreated();
		}
		
		public Table<Actors> Actors
		{
			get
			{
				return this.GetTable<Actors>();
			}
		}
		
		public Table<ActorsMovies> ActorsMovies
		{
			get
			{
				return this.GetTable<ActorsMovies>();
			}
		}
		
		public Table<Directors> Directors
		{
			get
			{
				return this.GetTable<Directors>();
			}
		}
		
		public Table<Languages> Languages
		{
			get
			{
				return this.GetTable<Languages>();
			}
		}
		
		public Table<LanguagesProducts> LanguagesProducts
		{
			get
			{
				return this.GetTable<LanguagesProducts>();
			}
		}
		
		public Table<MovieDescriptions> MovieDescriptions
		{
			get
			{
				return this.GetTable<MovieDescriptions>();
			}
		}
		
		public Table<Movies> Movies
		{
			get
			{
				return this.GetTable<Movies>();
			}
		}
		
		public Table<MovieTypes> MovieTypes
		{
			get
			{
				return this.GetTable<MovieTypes>();
			}
		}
		
		public Table<ProductDisks> ProductDisks
		{
			get
			{
				return this.GetTable<ProductDisks>();
			}
		}
		
		public Table<ProductDVdStatus> ProductDVdStatus
		{
			get
			{
				return this.GetTable<ProductDVdStatus>();
			}
		}
		
		public Table<ProductDVdWhere> ProductDVdWhere
		{
			get
			{
				return this.GetTable<ProductDVdWhere>();
			}
		}
		
		public Table<ProductQualities> ProductQualities
		{
			get
			{
				return this.GetTable<ProductQualities>();
			}
		}
		
		public Table<Products> Products
		{
			get
			{
				return this.GetTable<Products>();
			}
		}
		
		public Table<ProductsSubtitles> ProductsSubtitles
		{
			get
			{
				return this.GetTable<ProductsSubtitles>();
			}
		}
		
		public Table<ProductStatus> ProductStatus
		{
			get
			{
				return this.GetTable<ProductStatus>();
			}
		}
		
		public Table<ProductSupports> ProductSupports
		{
			get
			{
				return this.GetTable<ProductSupports>();
			}
		}
		
		public Table<ProductTypes> ProductTypes
		{
			get
			{
				return this.GetTable<ProductTypes>();
			}
		}
		
		public Table<Studios> Studios
		{
			get
			{
				return this.GetTable<Studios>();
			}
		}
		
		public Table<Subtitles> Subtitles
		{
			get
			{
				return this.GetTable<Subtitles>();
			}
		}
	}
	
	#region Start MONO_STRICT
#if MONO_STRICT

	public partial class NewDVdPost
	{
		
		public NewDVdPost(IDbConnection connection) : 
				base(connection)
		{
			this.OnCreated();
		}
	}
	#region End MONO_STRICT
	#endregion
#else     // MONO_STRICT
	
	public partial class NewDVdPost
	{
		
		public NewDVdPost(IDbConnection connection) : 
				base(connection, new DbLinq.MySql.MySqlVendor())
		{
			this.OnCreated();
		}
		
		public NewDVdPost(IDbConnection connection, IVendor sqlDialect) : 
				base(connection, sqlDialect)
		{
			this.OnCreated();
		}
		
		public NewDVdPost(IDbConnection connection, MappingSource mappingSource, IVendor sqlDialect) : 
				base(connection, mappingSource, sqlDialect)
		{
			this.OnCreated();
		}
	}
	#region End Not MONO_STRICT
	#endregion
#endif     // MONO_STRICT
	#endregion
	
	[Table(Name="new_dvdpost.actors")]
	public partial class Actors : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _birthday;
		
		private System.DateTime _createdAt;
		
		private string _description;
		
		private uint _id;
		
		private string _name;
		
		private string _picture;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBirthdayChanged();
		
		partial void OnBirthdayChanging(string value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Actors()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_birthday", Name="birthday", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if (((_birthday == value) 
							== false))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(145)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.actors_movies")]
	public partial class ActorsMovies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private uint _actorID;
		
		private System.DateTime _createdAt;
		
		private uint _movieID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnActorIDChanged();
		
		partial void OnActorIDChanging(uint value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ActorsMovies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_actorID", Name="actor_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ActorID
		{
			get
			{
				return this._actorID;
			}
			set
			{
				if ((_actorID != value))
				{
					this.OnActorIDChanging(value);
					this.SendPropertyChanging();
					this._actorID = value;
					this.SendPropertyChanged("ActorID");
					this.OnActorIDChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_movieID", Name="movie_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((_movieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.directors")]
	public partial class Directors : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _awards;
		
		private string _birthday;
		
		private System.DateTime _createdAt;
		
		private string _description;
		
		private uint _id;
		
		private string _name;
		
		private string _picture;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAwardsChanged();
		
		partial void OnAwardsChanging(string value);
		
		partial void OnBirthdayChanged();
		
		partial void OnBirthdayChanging(string value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Directors()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_awards", Name="awards", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Awards
		{
			get
			{
				return this._awards;
			}
			set
			{
				if (((_awards == value) 
							== false))
				{
					this.OnAwardsChanging(value);
					this.SendPropertyChanging();
					this._awards = value;
					this.SendPropertyChanged("Awards");
					this.OnAwardsChanged();
				}
			}
		}
		
		[Column(Storage="_birthday", Name="birthday", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Birthday
		{
			get
			{
				return this._birthday;
			}
			set
			{
				if (((_birthday == value) 
							== false))
				{
					this.OnBirthdayChanging(value);
					this.SendPropertyChanging();
					this._birthday = value;
					this.SendPropertyChanged("Birthday");
					this.OnBirthdayChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(45)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.languages")]
	public partial class Languages : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private string _short;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnShortChanged();
		
		partial void OnShortChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Languages()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_short", Name="short", DbType="varchar(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Short
		{
			get
			{
				return this._short;
			}
			set
			{
				if (((_short == value) 
							== false))
				{
					this.OnShortChanging(value);
					this.SendPropertyChanging();
					this._short = value;
					this.SendPropertyChanged("Short");
					this.OnShortChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.languages_products")]
	public partial class LanguagesProducts : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _languageID;
		
		private uint _productID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(uint value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public LanguagesProducts()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_productID", Name="product_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.movie_descriptions")]
	public partial class MovieDescriptions : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private string _award;
		
		private System.DateTime _createdAt;
		
		private string _description;
		
		private uint _languageID;
		
		private uint _movieID;
		
		private string _name;
		
		private string _picture;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnAwardChanged();
		
		partial void OnAwardChanging(string value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDescriptionChanged();
		
		partial void OnDescriptionChanging(string value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(uint value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnPictureChanged();
		
		partial void OnPictureChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public MovieDescriptions()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_award", Name="award", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Award
		{
			get
			{
				return this._award;
			}
			set
			{
				if (((_award == value) 
							== false))
				{
					this.OnAwardChanging(value);
					this.SendPropertyChanging();
					this._award = value;
					this.SendPropertyChanged("Award");
					this.OnAwardChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_description", Name="description", DbType="text", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Description
		{
			get
			{
				return this._description;
			}
			set
			{
				if (((_description == value) 
							== false))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieID", Name="movie_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((_movieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(70)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_picture", Name="picture", DbType="varchar(70)", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public string Picture
		{
			get
			{
				return this._picture;
			}
			set
			{
				if (((_picture == value) 
							== false))
				{
					this.OnPictureChanging(value);
					this.SendPropertyChanging();
					this._picture = value;
					this.SendPropertyChanged("Picture");
					this.OnPictureChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.movies")]
	public partial class Movies : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private System.Nullable<uint> _directorID;
		
		private System.Nullable<uint> _diskID;
		
		private uint _id;
		
		private uint _imdBID;
		
		private uint _movieTypeID;
		
		private string _name;
		
		private uint _productFicheTypeID;
		
		private System.Nullable<uint> _saIsoNid;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDirectorIDChanged();
		
		partial void OnDirectorIDChanging(System.Nullable<uint> value);
		
		partial void OnDiskIDChanged();
		
		partial void OnDiskIDChanging(System.Nullable<uint> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnIMDbIDChanged();
		
		partial void OnIMDbIDChanging(uint value);
		
		partial void OnMovieTypeIDChanged();
		
		partial void OnMovieTypeIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnProductFicheTypeIDChanged();
		
		partial void OnProductFicheTypeIDChanging(uint value);
		
		partial void OnSaIsoNIDChanged();
		
		partial void OnSaIsoNIDChanging(System.Nullable<uint> value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Movies()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_directorID", Name="director_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> DirectorID
		{
			get
			{
				return this._directorID;
			}
			set
			{
				if ((_directorID != value))
				{
					this.OnDirectorIDChanging(value);
					this.SendPropertyChanging();
					this._directorID = value;
					this.SendPropertyChanged("DirectorID");
					this.OnDirectorIDChanged();
				}
			}
		}
		
		[Column(Storage="_diskID", Name="disk_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> DiskID
		{
			get
			{
				return this._diskID;
			}
			set
			{
				if ((_diskID != value))
				{
					this.OnDiskIDChanging(value);
					this.SendPropertyChanging();
					this._diskID = value;
					this.SendPropertyChanged("DiskID");
					this.OnDiskIDChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_imdBID", Name="imdb_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint IMDbID
		{
			get
			{
				return this._imdBID;
			}
			set
			{
				if ((_imdBID != value))
				{
					this.OnIMDbIDChanging(value);
					this.SendPropertyChanging();
					this._imdBID = value;
					this.SendPropertyChanged("IMDbID");
					this.OnIMDbIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieTypeID", Name="movie_type_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieTypeID
		{
			get
			{
				return this._movieTypeID;
			}
			set
			{
				if ((_movieTypeID != value))
				{
					this.OnMovieTypeIDChanging(value);
					this.SendPropertyChanging();
					this._movieTypeID = value;
					this.SendPropertyChanged("MovieTypeID");
					this.OnMovieTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(145)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_productFicheTypeID", Name="product_fiche_type_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductFicheTypeID
		{
			get
			{
				return this._productFicheTypeID;
			}
			set
			{
				if ((_productFicheTypeID != value))
				{
					this.OnProductFicheTypeIDChanging(value);
					this.SendPropertyChanging();
					this._productFicheTypeID = value;
					this.SendPropertyChanged("ProductFicheTypeID");
					this.OnProductFicheTypeIDChanged();
				}
			}
		}
		
		[Column(Storage="_saIsoNid", Name="saison_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> SaIsoNID
		{
			get
			{
				return this._saIsoNid;
			}
			set
			{
				if ((_saIsoNid != value))
				{
					this.OnSaIsoNIDChanging(value);
					this.SendPropertyChanging();
					this._saIsoNid = value;
					this.SendPropertyChanged("SaIsoNID");
					this.OnSaIsoNIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.movie_types")]
	public partial class MovieTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public MovieTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_disks")]
	public partial class ProductDisks : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private int _boxID;
		
		private uint _boxPoS;
		
		private System.DateTime _createdAt;
		
		private uint _dvDID;
		
		private uint _productID;
		
		private uint _status;
		
		private System.DateTime _updatedAt;
		
		private uint _whereID;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnBoxIDChanged();
		
		partial void OnBoxIDChanging(int value);
		
		partial void OnBoxPOsChanged();
		
		partial void OnBoxPOsChanging(uint value);
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDVdIDChanged();
		
		partial void OnDVdIDChanging(uint value);
		
		partial void OnProductIDChanged();
		
		partial void OnProductIDChanging(uint value);
		
		partial void OnStatusChanged();
		
		partial void OnStatusChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		
		partial void OnWhereIDChanged();
		
		partial void OnWhereIDChanging(uint value);
		#endregion
		
		
		public ProductDisks()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_boxID", Name="box_id", DbType="int(10)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public int BoxID
		{
			get
			{
				return this._boxID;
			}
			set
			{
				if ((_boxID != value))
				{
					this.OnBoxIDChanging(value);
					this.SendPropertyChanging();
					this._boxID = value;
					this.SendPropertyChanged("BoxID");
					this.OnBoxIDChanged();
				}
			}
		}
		
		[Column(Storage="_boxPoS", Name="box_pos", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint BoxPOs
		{
			get
			{
				return this._boxPoS;
			}
			set
			{
				if ((_boxPoS != value))
				{
					this.OnBoxPOsChanging(value);
					this.SendPropertyChanging();
					this._boxPoS = value;
					this.SendPropertyChanged("BoxPOs");
					this.OnBoxPOsChanged();
				}
			}
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_dvDID", Name="dvd_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint DVdID
		{
			get
			{
				return this._dvDID;
			}
			set
			{
				if ((_dvDID != value))
				{
					this.OnDVdIDChanging(value);
					this.SendPropertyChanging();
					this._dvDID = value;
					this.SendPropertyChanged("DVdID");
					this.OnDVdIDChanged();
				}
			}
		}
		
		[Column(Storage="_productID", Name="product_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductID
		{
			get
			{
				return this._productID;
			}
			set
			{
				if ((_productID != value))
				{
					this.OnProductIDChanging(value);
					this.SendPropertyChanging();
					this._productID = value;
					this.SendPropertyChanged("ProductID");
					this.OnProductIDChanged();
				}
			}
		}
		
		[Column(Storage="_status", Name="status", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint Status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((_status != value))
				{
					this.OnStatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("Status");
					this.OnStatusChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_whereID", Name="where_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint WhereID
		{
			get
			{
				return this._whereID;
			}
			set
			{
				if ((_whereID != value))
				{
					this.OnWhereIDChanging(value);
					this.SendPropertyChanging();
					this._whereID = value;
					this.SendPropertyChanged("WhereID");
					this.OnWhereIDChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_dvd_status")]
	public partial class ProductDVdStatus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductDVdStatus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_dvd_where")]
	public partial class ProductDVdWhere : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductDVdWhere()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_qualities")]
	public partial class ProductQualities : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private uint _id;
		
		private string _name;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		#endregion
		
		
		public ProductQualities()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.products")]
	public partial class Products : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private System.Nullable<System.DateTime> _dateEnd;
		
		private System.Nullable<System.DateTime> _dateStart;
		
		private uint _id;
		
		private uint _movieID;
		
		private System.Nullable<uint> _oldProductsID;
		
		private System.Nullable<uint> _productQualityID;
		
		private uint _productStatusID;
		
		private uint _productSupportID;
		
		private System.Nullable<uint> _studioID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnDateEndChanged();
		
		partial void OnDateEndChanging(System.Nullable<System.DateTime> value);
		
		partial void OnDateStartChanged();
		
		partial void OnDateStartChanging(System.Nullable<System.DateTime> value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnMovieIDChanged();
		
		partial void OnMovieIDChanging(uint value);
		
		partial void OnOldProductsIDChanged();
		
		partial void OnOldProductsIDChanging(System.Nullable<uint> value);
		
		partial void OnProductQualityIDChanged();
		
		partial void OnProductQualityIDChanging(System.Nullable<uint> value);
		
		partial void OnProductStatusIDChanged();
		
		partial void OnProductStatusIDChanging(uint value);
		
		partial void OnProductSupportIDChanged();
		
		partial void OnProductSupportIDChanging(uint value);
		
		partial void OnStudioIDChanged();
		
		partial void OnStudioIDChanging(System.Nullable<uint> value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Products()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_dateEnd", Name="date_end", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateEnd
		{
			get
			{
				return this._dateEnd;
			}
			set
			{
				if ((_dateEnd != value))
				{
					this.OnDateEndChanging(value);
					this.SendPropertyChanging();
					this._dateEnd = value;
					this.SendPropertyChanged("DateEnd");
					this.OnDateEndChanged();
				}
			}
		}
		
		[Column(Storage="_dateStart", Name="date_start", DbType="datetime", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<System.DateTime> DateStart
		{
			get
			{
				return this._dateStart;
			}
			set
			{
				if ((_dateStart != value))
				{
					this.OnDateStartChanging(value);
					this.SendPropertyChanging();
					this._dateStart = value;
					this.SendPropertyChanged("DateStart");
					this.OnDateStartChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_movieID", Name="movie_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint MovieID
		{
			get
			{
				return this._movieID;
			}
			set
			{
				if ((_movieID != value))
				{
					this.OnMovieIDChanging(value);
					this.SendPropertyChanging();
					this._movieID = value;
					this.SendPropertyChanged("MovieID");
					this.OnMovieIDChanged();
				}
			}
		}
		
		[Column(Storage="_oldProductsID", Name="oldproducts_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> OldProductsID
		{
			get
			{
				return this._oldProductsID;
			}
			set
			{
				if ((_oldProductsID != value))
				{
					this.OnOldProductsIDChanging(value);
					this.SendPropertyChanging();
					this._oldProductsID = value;
					this.SendPropertyChanged("OldProductsID");
					this.OnOldProductsIDChanged();
				}
			}
		}
		
		[Column(Storage="_productQualityID", Name="product_quality_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> ProductQualityID
		{
			get
			{
				return this._productQualityID;
			}
			set
			{
				if ((_productQualityID != value))
				{
					this.OnProductQualityIDChanging(value);
					this.SendPropertyChanging();
					this._productQualityID = value;
					this.SendPropertyChanged("ProductQualityID");
					this.OnProductQualityIDChanged();
				}
			}
		}
		
		[Column(Storage="_productStatusID", Name="product_status_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductStatusID
		{
			get
			{
				return this._productStatusID;
			}
			set
			{
				if ((_productStatusID != value))
				{
					this.OnProductStatusIDChanging(value);
					this.SendPropertyChanging();
					this._productStatusID = value;
					this.SendPropertyChanged("ProductStatusID");
					this.OnProductStatusIDChanged();
				}
			}
		}
		
		[Column(Storage="_productSupportID", Name="product_support_id", DbType="int unsigned", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductSupportID
		{
			get
			{
				return this._productSupportID;
			}
			set
			{
				if ((_productSupportID != value))
				{
					this.OnProductSupportIDChanging(value);
					this.SendPropertyChanging();
					this._productSupportID = value;
					this.SendPropertyChanged("ProductSupportID");
					this.OnProductSupportIDChanged();
				}
			}
		}
		
		[Column(Storage="_studioID", Name="studio_id", DbType="int unsigned", AutoSync=AutoSync.Never)]
		[DebuggerNonUserCode()]
		public System.Nullable<uint> StudioID
		{
			get
			{
				return this._studioID;
			}
			set
			{
				if ((_studioID != value))
				{
					this.OnStudioIDChanging(value);
					this.SendPropertyChanging();
					this._studioID = value;
					this.SendPropertyChanged("StudioID");
					this.OnStudioIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.products_subtitles")]
	public partial class ProductsSubtitles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _languageID;
		
		private uint _productDetailID;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnLanguageIDChanged();
		
		partial void OnLanguageIDChanging(uint value);
		
		partial void OnProductDetailIDChanged();
		
		partial void OnProductDetailIDChanging(uint value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductsSubtitles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_languageID", Name="language_id", DbType="int unsigned", IsPrimaryKey=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint LanguageID
		{
			get
			{
				return this._languageID;
			}
			set
			{
				if ((_languageID != value))
				{
					this.OnLanguageIDChanging(value);
					this.SendPropertyChanging();
					this._languageID = value;
					this.SendPropertyChanged("LanguageID");
					this.OnLanguageIDChanged();
				}
			}
		}
		
		[Column(Storage="_productDetailID", Name="product_detail_id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ProductDetailID
		{
			get
			{
				return this._productDetailID;
			}
			set
			{
				if ((_productDetailID != value))
				{
					this.OnProductDetailIDChanging(value);
					this.SendPropertyChanging();
					this._productDetailID = value;
					this.SendPropertyChanged("ProductDetailID");
					this.OnProductDetailIDChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_status")]
	public partial class ProductStatus : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductStatus()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_supports")]
	public partial class ProductSupports : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductSupports()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.product_types")]
	public partial class ProductTypes : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public ProductTypes()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.studios")]
	public partial class Studios : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Studios()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[Table(Name="new_dvdpost.subtitles")]
	public partial class Subtitles : System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		private static System.ComponentModel.PropertyChangingEventArgs emptyChangingEventArgs = new System.ComponentModel.PropertyChangingEventArgs("");
		
		private System.DateTime _createdAt;
		
		private uint _id;
		
		private string _name;
		
		private string _short;
		
		private System.DateTime _updatedAt;
		
		#region Extensibility Method Declarations
		partial void OnCreated();
		
		partial void OnCreatedAtChanged();
		
		partial void OnCreatedAtChanging(System.DateTime value);
		
		partial void OnIDChanged();
		
		partial void OnIDChanging(uint value);
		
		partial void OnNameChanged();
		
		partial void OnNameChanging(string value);
		
		partial void OnShortChanged();
		
		partial void OnShortChanging(string value);
		
		partial void OnUpdatedAtChanged();
		
		partial void OnUpdatedAtChanging(System.DateTime value);
		#endregion
		
		
		public Subtitles()
		{
			this.OnCreated();
		}
		
		[Column(Storage="_createdAt", Name="created_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime CreatedAt
		{
			get
			{
				return this._createdAt;
			}
			set
			{
				if ((_createdAt != value))
				{
					this.OnCreatedAtChanging(value);
					this.SendPropertyChanging();
					this._createdAt = value;
					this.SendPropertyChanged("CreatedAt");
					this.OnCreatedAtChanged();
				}
			}
		}
		
		[Column(Storage="_id", Name="id", DbType="int unsigned", IsPrimaryKey=true, IsDbGenerated=true, AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public uint ID
		{
			get
			{
				return this._id;
			}
			set
			{
				if ((_id != value))
				{
					this.OnIDChanging(value);
					this.SendPropertyChanging();
					this._id = value;
					this.SendPropertyChanged("ID");
					this.OnIDChanged();
				}
			}
		}
		
		[Column(Storage="_name", Name="name", DbType="varchar(45)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				if (((_name == value) 
							== false))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[Column(Storage="_short", Name="short", DbType="varchar(5)", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public string Short
		{
			get
			{
				return this._short;
			}
			set
			{
				if (((_short == value) 
							== false))
				{
					this.OnShortChanging(value);
					this.SendPropertyChanging();
					this._short = value;
					this.SendPropertyChanged("Short");
					this.OnShortChanged();
				}
			}
		}
		
		[Column(Storage="_updatedAt", Name="updated_at", DbType="datetime", AutoSync=AutoSync.Never, CanBeNull=false)]
		[DebuggerNonUserCode()]
		public System.DateTime UpdatedAt
		{
			get
			{
				return this._updatedAt;
			}
			set
			{
				if ((_updatedAt != value))
				{
					this.OnUpdatedAtChanging(value);
					this.SendPropertyChanging();
					this._updatedAt = value;
					this.SendPropertyChanged("UpdatedAt");
					this.OnUpdatedAtChanged();
				}
			}
		}
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			System.ComponentModel.PropertyChangingEventHandler h = this.PropertyChanging;
			if ((h != null))
			{
				h(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(string propertyName)
		{
			System.ComponentModel.PropertyChangedEventHandler h = this.PropertyChanged;
			if ((h != null))
			{
				h(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
