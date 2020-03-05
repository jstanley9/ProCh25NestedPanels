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

namespace WpfApp1
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

        private void FileExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MouseEnterExitArea(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Exit the Application";
        }

        private void MouseEnterToolsHitsArea(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Show Spelling Suggestions";
        }

        private void MouseLeaveArea(object sender, MouseEventArgs e)
        {
            statBarText.Text = "Ready";
        }

        private void ToolsSpellingHints_Click(object sender, RoutedEventArgs e)
        {

        }


    }
}
