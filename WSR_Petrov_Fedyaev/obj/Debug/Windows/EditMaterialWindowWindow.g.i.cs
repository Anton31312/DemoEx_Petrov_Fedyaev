// Updated by XamlIntelliSenseFileGenerator 09.02.2022 22:59:42
#pragma checksum "..\..\..\Windows\EditMaterialWindowWindow.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "5870FCC583C561860D41A6670B5D09C52A81F35F99C04F78D4EE9CF7636A5415"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;
using WSR_Petrov_Fedyaev.Windows;


namespace WSR_Petrov_Fedyaev.Windows
{


    /// <summary>
    /// EditMaterialWindowWindow
    /// </summary>
    public partial class EditMaterialWindowWindow : System.Windows.Window, System.Windows.Markup.IComponentConnector
    {

        private bool _contentLoaded;

        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent()
        {
            if (_contentLoaded)
            {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/WSR_Petrov_Fedyaev;component/windows/editmaterialwindowwindow.xaml", System.UriKind.Relative);

#line 1 "..\..\..\Windows\EditMaterialWindowWindow.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);

#line default
#line hidden
        }

        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
        {
            this._contentLoaded = true;
        }

        internal System.Windows.Controls.TextBox txtNameMaterial;
        internal System.Windows.Controls.ComboBox cmbTypeMaterial;
        internal System.Windows.Controls.TextBox txtImage;
        internal System.Windows.Controls.TextBox txtCost;
        internal System.Windows.Controls.TextBox txtQtyInStorage;
        internal System.Windows.Controls.TextBox txtQtyMin;
        internal System.Windows.Controls.TextBox txtQtyInPackage;
        internal System.Windows.Controls.ComboBox cmbUnit;
        internal System.Windows.Controls.TextBox txtDiscription;
        internal System.Windows.Controls.Button btnEdit;
    }
}

