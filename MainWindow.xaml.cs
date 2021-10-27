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

namespace OpenWorkBar
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Mini_Click(object sender, RoutedEventArgs e)
        {
            // это увеличивает или уменьшает экран
            this.WindowState = WindowState.Minimized;
        }

        private void ToolBar_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left) //проверяет какая кнопка нажата прежде чем дать команду на перемещения окна
                DragMove();

        }

        private void Maxi_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
                this.WindowState = WindowState.Maximized;
            else this.WindowState = WindowState.Normal;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
        //скрывает панель TestSteps
        private void AddNewPanelSteps_Click(object sender, RoutedEventArgs e)
        {
            if (TestSteps.Visibility == Visibility.Hidden)
                TestSteps.Visibility = Visibility.Visible;
            else
                TestSteps.Visibility = Visibility.Hidden;
        }
        //скрывает панель TestPlan
        private void AddNewPanelPlan_Click(object sender, RoutedEventArgs e)
        {
            if (TestPlan.Visibility == Visibility.Collapsed)
                TestPlan.Visibility = Visibility.Visible;
            else
                TestPlan.Visibility = Visibility.Collapsed;
        }


    }
}
    
    


