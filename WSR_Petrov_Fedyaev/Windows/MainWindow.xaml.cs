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
using WSR_Petrov_Fedyaev.ClassHelper;
using WSR_Petrov_Fedyaev.Pages;
using WSR_Petrov_Fedyaev.Windows;


namespace WSR_Petrov_Fedyaev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppData.entities = new EF.Entities();
            FrameClass.frameMain = frmMain;

            frmMain.Navigate(new MaterialPage());
        }

        private void btnFAQ_Click(object sender, RoutedEventArgs e)
        {

        }


        private void AddMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditMaterialWindow addEditMaterialWindow = new AddEditMaterialWindow();
            this.Opacity = 0.4;
            addEditMaterialWindow.ShowDialog();
            this.Opacity = 1;
        }
    }
}
