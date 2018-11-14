using Microsoft.CodeAnalysis;
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
            peopleFromScript();
        }

        /*void createPeople()
        {
            people.Add(new Person("Klara"));
            people.Add(new Person("Pavel"));
            people.Add(new Person("Ivana"));
            people.Add(new Person("Ivan"));

            peopleFromScript();
        }*/

        async void peopleFromScript()
        {
            string file = File.ReadAllText(@"../../addPerson.txt");

            Character character = new Character(10, 100, 25);

            Globals persons = new Globals(people);

            var metadata = MetadataReference.CreateFromFile(typeof(Person).Assembly.Location);

            try
            {
                await CSharpScript.RunAsync(
                file,
                options: ScriptOptions.Default.WithReferences(metadata),
                globals: persons
                );
            }
            catch (CompilationErrorException e)
            {
                result.Content = string.Join(Environment.NewLine, e.Diagnostics);
            }
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
            claculate();
        }
    }
}
