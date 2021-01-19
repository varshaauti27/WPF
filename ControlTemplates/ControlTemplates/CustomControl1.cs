using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ControlTemplates
{
    public class CustomControl1 : Control
    {
        static CustomControl1()
        {
            DefaultStyleKeyProperty.OverrideMetadata(typeof(CustomControl1), 
                new FrameworkPropertyMetadata(typeof(CustomControl1)));
        }

        Shape _backdrop = null;

        public CustomControl1()
        {
            MouseLeftButtonDown += ChangeColor;
        }

        public override void OnApplyTemplate()
        {
            _backdrop = GetTemplateChild("PART_Backdrop") as Shape;
        }

        private void ChangeColor(object sender, MouseButtonEventArgs e)
        {
            if (_backdrop != null)
            {
                _backdrop.Fill = new SolidColorBrush(Colors.Blue);
            }
        }
    }
}
