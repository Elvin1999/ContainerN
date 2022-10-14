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
using System.Windows.Threading;

namespace WpfContainers
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            timer= new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(5);
            timer.Tick += Timer_Tick;
          //  timer.Start();
        }
        public int X { get; set; } = 1;
        private void Timer_Tick(object? sender, EventArgs e)
        {
            //mylabel.RenderTransform = new SkewTransform()
            //{
            //    AngleY = X
            //};
            ++X;
        }

        private void mylabel_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            timer.Start();
        }
    }
}
