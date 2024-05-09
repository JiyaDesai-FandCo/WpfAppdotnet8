using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppdotnet8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            ClassLibrarydotnetStandard2.Class1 c = new ClassLibrarydotnetStandard2.Class1();
            this.Title = c.LibraryFunctionToGetPackageName();
        }


     

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            // trying calling WPFFunctionToGetPackageName()
            // After you have changed OS target to windows 10 from Project properties
            this.Title = WPFFunctionToGetPackageName();
        }

        public string WPFFunctionToGetPackageName()
        {
            // Will not work until you set OS target Window 10

            //Windows.ApplicationModel.Package package = Windows.ApplicationModel.Package.Current;
            //var Packageversion = new Version(package.Id.Version.Major, package.Id.Version.Minor, package.Id.Version.Build);
            //var PackageDisplayName = package.DisplayName;
            //var PackageUniqueName = package.Id.Name;
            //return (string.Format("{0} - {1}", PackageDisplayName, Packageversion.ToString()));
            return "";
        }
    }
}