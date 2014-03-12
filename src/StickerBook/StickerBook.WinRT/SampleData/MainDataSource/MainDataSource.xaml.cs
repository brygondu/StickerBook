﻿//      *********    DO NOT MODIFY THIS FILE     *********
//      This file is regenerated by a design tool. Making
//      changes to this file can cause errors.
namespace Blend.SampleData.MainDataSource
{
	using System; 
	using System.ComponentModel;

// To significantly reduce the sample data footprint in your production application, you can set
// the DISABLE_SAMPLE_DATA conditional compilation constant and disable sample data at runtime.
#if DISABLE_SAMPLE_DATA
	internal class MainDataSource { }
#else

	public class MainDataSource : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		public MainDataSource()
		{
			try
			{
				Uri resourceUri = new Uri("ms-appx:/SampleData/MainDataSource/MainDataSource.xaml", UriKind.RelativeOrAbsolute);
				Windows.UI.Xaml.Application.LoadComponent(this, resourceUri);
			}
			catch
			{
			}
		}

		private Players _Players = new Players();

		public Players Players
		{
			get
			{
				return this._Players;
			}
		}
	}

	public class PlayersItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}

		private Windows.UI.Xaml.Media.ImageSource _Photo = null;

		public Windows.UI.Xaml.Media.ImageSource Photo
		{
			get
			{
				return this._Photo;
			}

			set
			{
				if (this._Photo != value)
				{
					this._Photo = value;
					this.OnPropertyChanged("Photo");
				}
			}
		}

		private bool _WasDiscovered = false;

		public bool WasDiscovered
		{
			get
			{
				return this._WasDiscovered;
			}

			set
			{
				if (this._WasDiscovered != value)
				{
					this._WasDiscovered = value;
					this.OnPropertyChanged("WasDiscovered");
				}
			}
		}

		private Clues _Clues = new Clues();

		public Clues Clues
		{
			get
			{
				return this._Clues;
			}
		}
	}

	public class CluesItem : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}

		private string _Value = string.Empty;

		public string Value
		{
			get
			{
				return this._Value;
			}

			set
			{
				if (this._Value != value)
				{
					this._Value = value;
					this.OnPropertyChanged("Value");
				}
			}
		}

		private string _Name = string.Empty;

		public string Name
		{
			get
			{
				return this._Name;
			}

			set
			{
				if (this._Name != value)
				{
					this._Name = value;
					this.OnPropertyChanged("Name");
				}
			}
		}
	}

	public class Clues : System.Collections.ObjectModel.ObservableCollection<CluesItem>
	{ 
	}

	public class Players : System.Collections.ObjectModel.ObservableCollection<PlayersItem>
	{ 
	}
#endif
}