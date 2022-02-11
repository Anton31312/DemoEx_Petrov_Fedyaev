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
using WSR_Petrov_Fedyaev.Windows;
using WSR_Petrov_Fedyaev.EF;


namespace WSR_Petrov_Fedyaev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Material> materialList = new List<Material>();
        List<string> listSort = new List<string>() { "Сортировка", "Наименование по возрастанию", "Наименование по убыванию", "Остаток по возрастанию", "Остаток по убыванию",
                                                     "Стоимость по возрастанию", "Стоимость по убыванию"};
        List<string> listFilter = new List<string>() { "Фильтрация", "Краска", "Резина", "Силикон" };
        public MainWindow()
        {
            InitializeComponent();
            AppData.entities = new EF.Entities();
            SortComboBox.ItemsSource = listSort;
            SortComboBox.SelectedIndex = 0;
            FilterComboBox.ItemsSource = listFilter;
            FilterComboBox.SelectedIndex = 0;

            Filter();
        }

        private void Filter()
        {
            materialList = AppData.entities.Material.ToList();
            materialList = materialList.
                            Where(i => i.NameMaterial.ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();

            switch (FilterComboBox.SelectedIndex)
            {
                case 0:
                    materialList = materialList.OrderBy(i => i.ID).ToList();
                    break;
                case 1:
                    materialList = materialList.Where(i => i.TypeMaterial.ID.Equals(2)).ToList();
                    break;
                case 2:
                    materialList = materialList.Where(i => i.TypeMaterial.ID.Equals(1)).ToList();
                    break;
                case 3:
                    materialList = materialList.Where(i => i.TypeMaterial.ID.Equals(3)).ToList();
                    break;
                default:
                    materialList = materialList.OrderBy(i => i.ID).ToList();
                    break;
            }

            switch (SortComboBox.SelectedIndex)
            {
                case 0:
                    materialList = materialList.OrderBy(i => i.ID).ToList();
                    break;
                case 1:
                    materialList = materialList.OrderBy(i => i.NameMaterial).ToList();
                    break;
                case 2:
                    materialList = materialList.OrderByDescending(i => i.NameMaterial).ToList();
                    break;
                case 3:
                    materialList = materialList.OrderBy(i => i.Qty).ToList();
                    break;
                case 4:
                    materialList = materialList.OrderByDescending(i => i.Qty).ToList();
                    break;
                case 5:
                    materialList = materialList.OrderBy(i => i.Cost).ToList();
                    break;
                case 6:
                    materialList = materialList.OrderByDescending(i => i.Cost).ToList();
                    break;
                default:
                    materialList = materialList.OrderBy(i => i.ID).ToList();
                    break;
            }
            MaterialListView.ItemsSource = materialList;
        }

        private void btnFAQ_Click(object sender, RoutedEventArgs e)
        {

        }


        private void AddMaterialButton_Click(object sender, RoutedEventArgs e)
        {
            AddEditMaterialWindow addEditMaterialWindow = new AddEditMaterialWindow();
            this.Opacity = 0.4;
            addEditMaterialWindow.ShowDialog();
            Filter();
            this.Opacity = 1;
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();

        }

        private void SortComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();

        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();

        }


        //Edit material
        private void MaterialListView_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var editMaterial = new EF.Material();

            if (MaterialListView.SelectedItem is EF.Material)
            {
                editMaterial = MaterialListView.SelectedItem as EF.Material;
            }

            AddEditMaterialWindow addEditMaterialWindow = new AddEditMaterialWindow(editMaterial);
            this.Opacity = 0.4;
            addEditMaterialWindow.ShowDialog();
            MaterialListView.ItemsSource = AppData.entities.Material.ToList();
            Filter();
            this.Opacity = 1;
        }

        //Delete material
        private void MaterialListView_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Delete || e.Key == Key.Back)
            {
                if (MaterialListView.SelectedItem is EF.Material)
                {
                    try
                    {
                        var item = MaterialListView.SelectedItem as EF.Material;
                       
                        var resultClick = MessageBox.Show("Вы уверены?", "Подтвердите удаление", MessageBoxButton.YesNo, MessageBoxImage.Question);
                        if (resultClick == MessageBoxResult.Yes)
                        {
                            AppData.entities.Material.Remove(item);
                            AppData.entities.SaveChanges();
                            MessageBox.Show("Материал успешно удален!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                            Filter();
                        }
                    }                 
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString());
                    }
                }
            }
        }
    }
}
