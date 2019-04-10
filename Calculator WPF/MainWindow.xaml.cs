using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

using System.Collections;


namespace testApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DoubleAnimation da = new DoubleAnimation(360, 0, new Duration(TimeSpan.FromSeconds(9)));
            RotateTransform rt = new RotateTransform();
            calc1.RenderTransform = rt;
            calc1.RenderTransformOrigin = new Point(0.5, 0.5);
            da.RepeatBehavior = RepeatBehavior.Forever;
            rt.BeginAnimation(RotateTransform.AngleProperty, da);
            
            // Set an icon using code 
            Uri iconUri = new Uri("apico.png", UriKind.RelativeOrAbsolute);
            this.Icon = BitmapFrame.Create(iconUri);

        }

        private void seven_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "7";
        }

        private void eight_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "8";
        }

        private void nine_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "9";
        }

        private void four_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "4";
        }

        private void five_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "5";
        }

        private void six_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "6";
        }

        private void one_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "1";
        }

        private void two_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "2";
        }

        private void three_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "3";
        }

        private void zero_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "0";
        }

        private void point_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + ".";
        }

        private void clear_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = "";
        }

        private void result_Click(object sender, RoutedEventArgs e)
        {
            if (screen.Text != "")
            {
                Type scriptType = Type.GetTypeFromCLSID(Guid.Parse("0E59F1D5-1FBE-11D0-8FF2-00A0D10038BC"));

                dynamic obj = Activator.CreateInstance(scriptType, false);
                obj.Language = "javascript";
                string str = null;
                try
                {
                    var res = obj.Eval(screen.Text);
                    str = Convert.ToString(res);
                    screen.Text = screen.Text + "=" + str;
                }
                catch (SystemException)
                {
                    screen.Text = "Syntax Error";
                }
            }

        }

        private void lPar_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "(";
        }

        private void rPar_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + ")";
        }

        private void sum_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "+";
        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "-";
        }

        private void mult_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "*";
        }

        private void divide_Click(object sender, RoutedEventArgs e)
        {
            screen.Text = screen.Text + "/";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(screen.Text != "")
                screen.Text = screen.Text.Remove(screen.Text.Length - 1);
        }

    }
}
