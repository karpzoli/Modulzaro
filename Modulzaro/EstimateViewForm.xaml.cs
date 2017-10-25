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

namespace Modulzaro
{
    /// <summary>
    /// Interaction logic for EstimateViewForm.xaml
    /// </summary>
    public partial class EstimateViewForm : Window
    {
        EstimateViewModel _vm;

        public EstimateViewForm()
        {
            InitializeComponent();
            _vm = new EstimateViewModel(); 
            DataContext = _vm;
        }

        private void DifficultySelectedCBox(object sender, DependencyPropertyChangedEventArgs e)
        {            
            //EstimateViewForm estimateForm = new EstimateViewForm { DataContext = vm };            
            //var LanguageList = _vm.LanguageList;
            //if (estimateForm.DialogResult == true)
            //{
            //    LanguageList.Add(vm.Language);
            //    vm.Save();
            //}
        }
    }
}
