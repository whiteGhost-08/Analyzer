﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Dashboard
{
    public class AppTheme
    {

        public static void ChangeTheme( Uri themeuri )
        {
            ResourceDictionary Theme = new() { Source = themeuri };

            App.Current.Resources.MergedDictionaries.Add( Theme );
        }
    }
}
