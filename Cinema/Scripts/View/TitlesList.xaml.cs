using Cinema.Scripts.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace Cinema.Scripts.View
{
    /// <summary>
    /// Логика взаимодействия для TitlesList.xaml
    /// </summary>
    public partial class TitlesList : UserControl
    {
        public TitlesList()
        {
            InitializeComponent();
        }

        public static DependencyProperty SourceProperty = DependencyProperty.Register("ItemsSource", typeof(List<TitleInfo>), typeof(TitlesList), new PropertyMetadata(null));

        public List<TitleInfo> ItemsSource
        {
            get
            {
                return (List<TitleInfo>)GetValue(SourceProperty);
            }
            set
            {
                SetValue(SourceProperty, value);
            }
        }

    }
}
