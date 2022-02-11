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
using WSR_Petrov_Fedyaev.ClassHelper;
using WSR_Petrov_Fedyaev.EF;
using WSR_Petrov_Fedyaev.Windows;

namespace WSR_Petrov_Fedyaev.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        List<Material> materialList = new List<Material>();
        List<string> listSort = new List<string>() { "Сортировка", "Наименование по возрастанию", "Наименование по убыванию", "Остаток по возрастанию", "Остаток по убыванию", 
                                                     "Стоимость по возрастанию", "Стоимость по убыванию"};
        List<string> listFilter = new List<string>() { "Фильтрация", "Краска", "Резина", "Силикон" };

        public MaterialPage()
        {
            InitializeComponent();

            SortComboBox.ItemsSource = listSort;
            SortComboBox.SelectedIndex = 0;         
            FilterComboBox.ItemsSource = listFilter;
            FilterComboBox.SelectedIndex = 0;

            Filter();


        }

        private void CheckQty()
        {
           materialList = AppData.entities.Material.ToList();

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


        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }

        private void FilterComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            EF.Material material = new Material();
            AddEditMaterialWindow addEditMaterialWindow = new AddEditMaterialWindow(material);
            this.Opacity = 0.4;
            addEditMaterialWindow.ShowDialog();
            this.Opacity = 1;
        }
    }
}
