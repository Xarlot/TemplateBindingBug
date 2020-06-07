using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Documents;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;

// The Custom Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234235

namespace App9 {
    public sealed class CustomControl1 : Control {
        public static readonly DependencyProperty TestProperty = DependencyProperty.Register("Test", typeof(DateTime), typeof(CustomControl1), new PropertyMetadata(DateTime.Now));

        public DateTime Test {
            get => (DateTime)GetValue(TestProperty);
            set => SetValue(TestProperty, value);
        }

        public CustomControl1() {
            this.DefaultStyleKey = typeof(CustomControl1);
        }
    }
}
