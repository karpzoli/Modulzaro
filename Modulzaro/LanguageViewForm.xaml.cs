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
    /// Interaction logic for LanguageFormView.xaml
    /// </summary>
    public partial class LanguageFormView : Window
    {
        public LanguageFormView()
        {
            InitializeComponent();
        }

        private void SubmitButton(object sender, RoutedEventArgs e)
        {
            var languageformVM = (LanguangeFormViewModel)DataContext;
            DialogResult = true;
            Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            DialogResult = true;
        }
    }
}
