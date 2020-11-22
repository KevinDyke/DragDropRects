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

		private new void MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
		{
			Rectangle rect = sender as Rectangle;
			DataObject dataObj = new DataObject(rect.Fill);
			DragDrop.DoDragDrop(rect, dataObj, DragDropEffects.Move);
		}

		private void Target_Drop(object sender, DragEventArgs e)
		{
			SolidColorBrush scb = (SolidColorBrush)e.Data.GetData(typeof(SolidColorBrush));
			Target.Fill = scb;

			Rectangle sender_count = sender as Rectangle;
		}

		private void TextRectangleUserControl_Loaded(object sender, RoutedEventArgs e)
		{

		}
	}
}
