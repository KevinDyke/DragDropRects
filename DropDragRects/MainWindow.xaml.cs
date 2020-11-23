using DropDragRects.UserControls;
using System;
using System.Collections.Generic;
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

namespace DropDragRects
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private RectTextUserControl _rectText;

		public RectTextUserControl RectText
		{
			get { return _rectText; }
			set { _rectText = value; }
		}

		private new void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			RectText = sender as RectTextUserControl;

			RectTextUserControl rectText = sender as RectTextUserControl;
			DataObject dataObj = new DataObject(rectText.RectColour);
			DragDrop.DoDragDrop(rectText, dataObj, DragDropEffects.Move);
		}

		private void Target_Drop(object sender, DragEventArgs e)
		{
			RectTextUserControl rt = RectText;
			int count = Int32.Parse(rt.Count);
			count++;
			rt.Count = count.ToString();

			SolidColorBrush scb = (SolidColorBrush)e.Data.GetData(typeof(SolidColorBrush));
			Target.Fill = scb;
		}

		private void ResetTarget_Click(object sender, RoutedEventArgs e)
		{
			Target.Fill = Brushes.Black;
		}

		
	}
}
