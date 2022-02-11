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
using System.Windows.Shapes;
using WSR_Petrov_Fedyaev.ClassHelper;
using WSR_Petrov_Fedyaev.EF;

namespace WSR_Petrov_Fedyaev.Windows
{
    /// <summary>
    /// Логика взаимодействия для EditMaterialWindowWindow.xaml
    /// </summary>
    public partial class AddEditMaterialWindow : Window
    {
        EF.Material editMaterial = new EF.Material();

        bool isEdit = true;

        public AddEditMaterialWindow()
        {
            InitializeComponent();

            cmbTypeMaterial.ItemsSource = AppData.entities.TypeMaterial.ToList();
            cmbTypeMaterial.DisplayMemberPath = "NameTypeMaterial";
            cmbTypeMaterial.SelectedIndex = 0;

            cmbUnit.ItemsSource = AppData.entities.Unit.ToList();
            cmbUnit.DisplayMemberPath = "NameUnit";
            cmbUnit.SelectedIndex = 0;

            isEdit = false;
        }

        public AddEditMaterialWindow(EF.Material material)
        {
            InitializeComponent();
            //Completion ComboBox
            cmbTypeMaterial.ItemsSource = AppData.entities.TypeMaterial.ToList();
            cmbTypeMaterial.DisplayMemberPath = "NameTypeMaterial";

            cmbUnit.ItemsSource = AppData.entities.Unit.ToList();
            cmbUnit.DisplayMemberPath = "NameUnit";

            //Edit Title and Content Button
            TitleTextBlock.Text = "Изменение данные материала";
            btnEdit.Content = "Изменить";

            //Passing values to fields
            editMaterial = material;

            cmbTypeMaterial.SelectedIndex = editMaterial.IDTypeMaterial - 1;
            cmbUnit.SelectedIndex = editMaterial.IDUnit - 1;
            txtNameMaterial.Text = editMaterial.NameMaterial;
            txtImage.Text = editMaterial.Image;
            txtCost.Text = editMaterial.Cost.ToString();
            txtQtyInStorage.Text = editMaterial.Qty.ToString();
            txtQtyMin.Text = editMaterial.MinQty.ToString();
            txtQtyInPackage.Text = editMaterial.QtyInPackage.ToString();
            txtDiscription.Text = editMaterial.Description;

            isEdit = true;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            //Validation
            #region
            if (string.IsNullOrWhiteSpace(txtNameMaterial.Text))
            {
                MessageBox.Show("Поле «Название материала» не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtCost.Text))
            {
                MessageBox.Show("Поле «Стоимость» не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQtyInStorage.Text))
            {
                MessageBox.Show("Поле «Количество на складе» не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQtyMin.Text))
            {
                MessageBox.Show("Поле «Минимальное количество» не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtQtyInPackage.Text))
            {
                MessageBox.Show("Поле «Количество в упаковке» не должно быть пустым", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (txtNameMaterial.Text.Length > 100)
            {
                MessageBox.Show("В поле «Название материала» недопустимое количество символов", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtImage.Text))
            {
                txtImage.Text = "/materials/picture.png";
            }
            #endregion

            if (isEdit)
            {
                //Edit material
                try
                {
                    editMaterial.NameMaterial = txtNameMaterial.Text;
                    editMaterial.IDTypeMaterial = cmbTypeMaterial.SelectedIndex + 1;
                    editMaterial.Image = txtImage.Text;
                    editMaterial.Cost = Convert.ToDecimal(txtCost.Text);
                    editMaterial.Qty = Convert.ToInt32(txtQtyInStorage.Text);
                    editMaterial.MinQty = Convert.ToInt32(txtQtyMin.Text);
                    editMaterial.QtyInPackage = Convert.ToInt32(txtQtyInPackage.Text);
                    editMaterial.IDUnit = cmbUnit.SelectedIndex + 1;
                    editMaterial.Description = txtDiscription.Text;

                    AppData.entities.SaveChanges();
                    MessageBox.Show("Данные успешно изменены!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }
            else
            {
                //Add new material
                try
                {
                    var resultClick = MessageBox.Show("Вы уверены?", "Подтвердите добавление", MessageBoxButton.YesNo, MessageBoxImage.Question);
                    if (resultClick == MessageBoxResult.Yes)
                    {
                        editMaterial.NameMaterial = txtNameMaterial.Text;
                        editMaterial.IDTypeMaterial = cmbTypeMaterial.SelectedIndex + 1;
                        editMaterial.Image = txtImage.Text;
                        editMaterial.Cost = Convert.ToDecimal(txtCost.Text);
                        editMaterial.Qty = Convert.ToInt32(txtQtyInStorage.Text);
                        editMaterial.MinQty = Convert.ToInt32(txtQtyMin.Text);
                        editMaterial.QtyInPackage = Convert.ToInt32(txtQtyInPackage.Text);
                        editMaterial.IDUnit = cmbUnit.SelectedIndex + 1;
                        editMaterial.Description = txtDiscription.Text;

                        AppData.entities.Material.Add(editMaterial);
                        AppData.entities.SaveChanges();
                        MessageBox.Show("Материал успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                        this.Close();
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