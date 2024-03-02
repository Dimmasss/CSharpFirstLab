using SukailoCSharp01.ViewModels;
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

namespace SukailoCSharp01.Views
{
    /// <summary>
    /// Interaction logic for HoroscopViews.xaml
    /// </summary>
    public partial class HoroscopViews : UserControl
    {
        private HoroscopViewModels _modelView;
        public HoroscopViews()
        {
            InitializeComponent();
            DataContext = _modelView = new HoroscopViewModels();
        }
    }
}
