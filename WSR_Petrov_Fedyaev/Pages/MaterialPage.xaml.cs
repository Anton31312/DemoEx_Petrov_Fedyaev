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

namespace WSR_Petrov_Fedyaev.Pages
{
    /// <summary>
    /// Логика взаимодействия для MaterialPage.xaml
    /// </summary>
    public partial class MaterialPage : Page
    {
        List<Material> materialList = new List<Material>();
        List<string> listSort = new List<string>() { "Сортировка", "По убыванию", "По возрастанию"};
        List<string> listFilter = new List<string>() { "Фильтрация", "По наименованию", "По стоимости", "По остатку на складе"};

        public MaterialPage()
        {
            InitializeComponent();

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
                            Where(i => i.NameMaterial.ToLower().Contains(TextBoxSearch.Text.ToLower()) ||
                            i.Cost.ToString().Contains(TextBoxSearch.Text.ToLower()) ||
                            i.Qty.ToString().Contains(TextBoxSearch.Text.ToLower())).ToList();


            if (SortComboBox.SelectedIndex == 1)
            {
                switch (FilterComboBox.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        materialList = materialList.OrderByDescending(i => i.NameMaterial).ToList();
                        break;
                    case 2:
                        materialList = materialList.OrderByDescending(i => i.Cost).ToList();
                        break;
                    case 3:
                        materialList = materialList.OrderByDescending(i => i.Qty).ToList();
                        break;

                    default:
                        materialList = materialList.OrderByDescending(i => i.NameMaterial).ToList();
                        break;
                }
            }
            else
            {
                switch (FilterComboBox.SelectedIndex)
                {
                    case 0:
                        break;
                    case 1:
                        materialList = materialList.OrderBy(i => i.NameMaterial).ToList();
                        break;
                    case 2:
                        materialList = materialList.OrderBy(i => i.Cost).ToList();
                        break;
                    case 3:
                        materialList = materialList.OrderBy(i => i.Qty).ToList();
                        break;

                    default:
                        materialList = materialList.OrderBy(i => i.NameMaterial).ToList();
                        break;
                }
            }
            MaterialListView.ItemsSource = materialList;
        }




        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frameMain.Navigate(new EditMaterialPage((sender as Button).DataContext as Material));
        }

        private void CmbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Filter();
        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filter();
        }
    }
}
