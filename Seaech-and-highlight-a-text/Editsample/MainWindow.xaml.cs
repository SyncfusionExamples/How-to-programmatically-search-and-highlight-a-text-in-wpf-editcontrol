using Syncfusion.Windows.Edit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Editsample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Edit1.DocumentLanguage = Languages.CSharp;
            Edit1.DocumentSource = "../../Source.cs";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Getting the string to find the text
            Edit1.FindOptions.FindText = "BusinessObject";

            for (int i = 0; i < Edit1.Lines.Count; i++)
            {
                //Check whether Lines collection contains the required string
                if (Edit1.Lines[i].Text.Contains(Edit1.FindOptions.FindText))
                {
                    string pat = @"" + Edit1.FindOptions.FindText;
                    Regex r = new Regex(pat, RegexOptions.IgnoreCase);
                    Match m = r.Match(Edit1.Lines[i].Text);
                    //Get the string index and length
                    Edit1.SelectLines(i, i, m.Index, m.Index + m.Length);
                    MessageBox.Show("Current position:\n" + "Linenumber=" + Edit1.LineNumber + "\nCursorindex=" + m.Index);
                }
            }
        }
    }
}
