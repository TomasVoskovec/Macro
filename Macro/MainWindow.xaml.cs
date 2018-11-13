using Microsoft.CodeAnalysis.CSharp.Scripting;
using Microsoft.CodeAnalysis.Scripting;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace Macro
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            claculate();
        }

        async void claculate()
        {
            string file = File.ReadAllText(@"../../script.txt");

            try
            {
                result.Content = await CSharpScript.EvaluateAsync(file);
            }
            catch (CompilationErrorException e)
            {
                result.Content = string.Join(Environment.NewLine, e.Diagnostics);
            }
        }

        private void calculate_click(object sender, RoutedEventArgs e)
        {
            //calculate();
        }
    }
}
