using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
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

namespace mdk_lab9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }
        static string Encoding(string зашифрованноеСлово, Dictionary<char, char> словарь)
        {
            string recoded = "";
            foreach (char буква in зашифрованноеСлово)
            {
                if (словарь.ContainsKey(буква))
                {
                    recoded += словарь[буква];
                }
                else
                {
                    recoded += буква; // Если буквы нет в словаре, оставляем ее как есть.
                }
            }
            return recoded;
        }
        Dictionary<char, char> dic1 = new Dictionary<char, char>()
{ {'z', 'a' },
 {'y', 'b' },
 {'x', 'c' },
 {'w', 'd' },
 {'u', 'e' },
 {'v', 'f' },
 {'t', 'g' },
 {'s', 'h' },
 {'r', 'i' },
 {'q', 'j' },
 {'p', 'k' },
 {'o', 'l' },
 {'n', 'm' },
 {'m', 'n' },
 {'l', 'o' },
 {'k', 'p' },
 {'j', 'q' },
 {'i', 'r' },
 {'h', 's' },
 {'g', 't' },
 {'f', 'v' },
 {'e', 'u' },
 {'d', 'w' },
 {'c', 'x' },
 {'b', 'y' },
 {'a', 'z' }
};

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ResultText.Text = "";
            string codedstring = codedtxt.Text;
            codedtxt.Text = "";
            string encoded = Encoding(codedstring, dic1);
            ResultText.Text = encoded;
        }
    }
}