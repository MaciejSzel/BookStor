using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Projekcik.Views
{
    public class ZamowieniaViewBase: UserControl
    {
        static ZamowieniaViewBase()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(ZamowieniaViewBase), new FrameworkPropertyMetadata(typeof(ZamowieniaViewBase)));
        }
    }
}
