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

namespace Powers.Todo.templates
{
    /// <summary>
    /// TodoItemControl.xaml 的交互逻辑
    /// </summary>
    public partial class TodoItemControl : UserControl
    {
        public TodoItemControl()
        {
            InitializeComponent();
        }

        public ImageSource ImageSource { get; set; }

        public string ContentText { get; set; }

        public CornerRadius CornerRadius { get; set; } = new CornerRadius(10);
    }
}