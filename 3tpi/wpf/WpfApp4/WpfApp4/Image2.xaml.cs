﻿using System;
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
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Logika interakcji dla klasy Image2.xaml
    /// </summary>
    public partial class Image2 : Window
    {
        public Image2()
        {
            InitializeComponent();
            Duze.Source = new BitmapImage(new Uri(imgPath, UriKind.Relative));
        }
    }
}
