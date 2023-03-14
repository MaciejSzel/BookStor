using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Projekcik.Views
{
    public class CustomerViewBase: UserControl
    {
        static CustomerViewBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomerViewBase), new FrameworkPropertyMetadata(typeof(CustomerViewBase)));
        }
    }
}
