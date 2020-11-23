using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropDragRects.UserControls
{
	/// <summary>
	/// Interaction logic for RectTextUserControl.xaml
	/// </summary>
	public partial class RectTextUserControl : UserControl, INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		protected void NotifyPropertyChanged(string name)
		{
			if (PropertyChanged != null)
				PropertyChanged(this, new PropertyChangedEventArgs(name));
		}

		public RectTextUserControl()
		{
			InitializeComponent();
			DataContext = this;
		}

		private string _count;

		public string Count
		{
			get { return _count; }
			set
			{ 
				_count = value;
				NotifyPropertyChanged("Count");
			}
		}

		private SolidColorBrush _textColour;

		public SolidColorBrush TextColour
		{
			get { return _textColour; }
			set { _textColour = value; }
		}

		private SolidColorBrush _rectColour;

		public SolidColorBrush RectColour
		{
			get { return _rectColour; }
			set { _rectColour = value; }
		}


	}
}
