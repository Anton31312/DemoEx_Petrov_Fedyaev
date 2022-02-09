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
using WSR_Petrov_Fedyaev.EF;
using WSR_Petrov_Fedyaev.ClassHelper;

namespace WSR_Petrov_Fedyaev.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditMaterialPage.xaml
    /// </summary>
    public partial class EditMaterialPage : Page
    {
        public EditMaterialPage(Material material)
        {
            InitializeComponent();
            Material material1 = new Material();
            cmbTypeMaterial.SelectedIndex = material1.IDTypeMaterial - 1;
            cmbTypeMaterial.SelectedValuePath = "ID";
            cmbTypeMaterial.DisplayMemberPath = "NameTypeMaterial";
            cmbTypeMaterial.ItemsSource = AppData.entities.TypeMaterial.ToList();

            cmbUnit.SelectedIndex = material1.IDUnit - 1;
            cmbUnit.SelectedValuePath = "ID";
            cmbUnit.DisplayMemberPath = "NameUnit";
            cmbUnit.ItemsSource = AppData.entities.Unit.ToList();

            MaterialClass materialClass = new MaterialClass();

            materialClass.ID = material1.ID;

            txtNameMaterial.Text = material1.NameMaterial;
            txtImage.Text = material1.Image;
            txtCost.Text = material1.Cost.ToString();
            txtQtyInStorage.Text = material1.Qty.ToString();
            txtQtyMin.Text = material1.MinQty.ToString();
            txtQtyInPackage.Text = material1.QtyInPackage.ToString();
            txtDiscription.Text = material1.Description;

        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                MaterialClass materialClass = new MaterialClass();

                IEnumerable<Material> materials = AppData.entities.Material.Where(i => i.ID == materialClass.ID).AsEnumerable().
                    Select(i =>
                    {
                        i.NameMaterial = txtNameMaterial.Text;
                        if (string.IsNullOrWhiteSpace(txtImage.Text))
                        {
                            i.Image = "";
                        }
                        else
                        {
                            i.Image = txtImage.Text;
                        }
                        i.Cost = Convert.ToDecimal(txtCost.Text);
                        i.Qty = Convert.ToInt32(txtQtyInStorage.Text);
                        i.MinQty = Convert.ToInt32(txtQtyMin.Text);
                        i.QtyInPackage = Convert.ToInt32(txtQtyInPackage.Text);
                        if (string.IsNullOrWhiteSpace(txtDiscription.Text))
                        {
                            i.Description = "";
                        }
                        else
                        {
                            i.Description = txtDiscription.Text;
                        }
                        i.IDTypeMaterial = (int)cmbTypeMaterial.SelectedValue;
                        i.IDUnit = (int)cmbUnit.SelectedValue;

                        return i;
                    });
                foreach (Material mtrl in materials)
                {
                    AppData.entities.Entry(mtrl).State = System.Data.Entity.EntityState.Modified;
                }
                AppData.entities.SaveChanges();
                MessageBox.Show("Данные успешно изменены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                FrameClass.frameMain.Navigate(new MaterialPage());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            
        }
    }
}
