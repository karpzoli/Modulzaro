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

namespace Modulzaro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window        
    {
        LanguageViewModel _vm;

        public MainWindow()
        {
            InitializeComponent();
            _vm = new LanguageViewModel(); //a fő ablakban használandó adatok
            DataContext = _vm;
        }

        private void NewLanguageButton(object sender, RoutedEventArgs e)
        {
            LanguangeFormViewModel vm = new LanguangeFormViewModel(new Language()) { IsNew = true };
            LanguageFormView languageForm = new LanguageFormView { DataContext = vm };
            languageForm.ShowDialog();
            var LanguageList = _vm.LanguageList;
            if (languageForm.DialogResult == true)
            {
                LanguageList.Add(vm.Language);
                vm.Save();
            }
        }

        private void EditLanguageButton(object sender, RoutedEventArgs e)
        {
            if (_vm.SelectLanguage != null)
            {
                LanguangeFormViewModel vm = new LanguangeFormViewModel(_vm.SelectLanguage);
                LanguageFormView LanguageForm = new LanguageFormView { DataContext = vm };
                LanguageForm.ShowDialog();
            }
        }

        private void EstimateButton(object sender, RoutedEventArgs e)
        {
                EstimateViewModel vm = new EstimateViewModel();
                EstimateViewForm reatmentForm = new EstimateViewForm { DataContext = vm };
                reatmentForm.ShowDialog();

        }
    }
}
