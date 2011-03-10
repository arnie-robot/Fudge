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
using System.Windows.Shapes;
using System.Threading;

namespace Fudge
{
    public partial class FudgeWindow : Window
    {
        public FudgeWindow()
        {
            InitializeComponent();
            this.HostValue.Focus();
        }

        private void FudgeButton_Click(object sender, RoutedEventArgs e)
        {
            this.GlobalTabs.SelectedItem = this.GlobalTabs.Items[1];
        }

        private void FudgeIt1_Click(object sender, RoutedEventArgs e)
        {
            string value = this.Set1Input1.Text;
            if (this.Set1Input2.Text.Length > 0)
            {
                value += ";" + this.Set1Input2.Text;
            }
            if (this.Set1Input3.Text.Length > 0)
            {
                value += ";" + this.Set1Input3.Text;
            }
            if (this.Set1Input4.Text.Length > 0)
            {
                value += ";" + this.Set1Input4.Text;
            }
            if (this.Set1Input5.Text.Length > 0)
            {
                value += ";" + this.Set1Input5.Text;
            }
            this.send(value);
        }

        private void FudgeIt2_Click(object sender, RoutedEventArgs e)
        {
            string value = this.Set2Input1.Text;
            if (this.Set2Input2.Text.Length > 0)
            {
                value += ";" + this.Set2Input2.Text;
            }
            if (this.Set2Input3.Text.Length > 0)
            {
                value += ";" + this.Set2Input3.Text;
            }
            if (this.Set2Input4.Text.Length > 0)
            {
                value += ";" + this.Set2Input4.Text;
            }
            if (this.Set2Input5.Text.Length > 0)
            {
                value += ";" + this.Set2Input5.Text;
            }
            this.send(value);
        }

        private void FudgeIt3_Click(object sender, RoutedEventArgs e)
        {
            string value = this.Set3Input1.Text;
            if (this.Set3Input2.Text.Length > 0)
            {
                value += ";" + this.Set3Input2.Text;
            }
            if (this.Set3Input3.Text.Length > 0)
            {
                value += ";" + this.Set3Input3.Text;
            }
            if (this.Set3Input4.Text.Length > 0)
            {
                value += ";" + this.Set3Input4.Text;
            }
            if (this.Set3Input5.Text.Length > 0)
            {
                value += ";" + this.Set3Input5.Text;
            }
            this.send(value);
        }

        private void FudgeIt4_Click(object sender, RoutedEventArgs e)
        {
            string value = this.Set4Input1.Text;
            if (this.Set4Input2.Text.Length > 0)
            {
                value += ";" + this.Set4Input2.Text;
            }
            if (this.Set4Input3.Text.Length > 0)
            {
                value += ";" + this.Set4Input3.Text;
            }
            if (this.Set4Input4.Text.Length > 0)
            {
                value += ";" + this.Set4Input4.Text;
            }
            if (this.Set4Input5.Text.Length > 0)
            {
                value += ";" + this.Set4Input5.Text;
            }
            this.send(value);
        }

        private void FudgeIt5_Click(object sender, RoutedEventArgs e)
        {
            string value = this.Set5Input1.Text;
            if (this.Set5Input2.Text.Length > 0)
            {
                value += ";" + this.Set5Input2.Text;
            }
            if (this.Set5Input3.Text.Length > 0)
            {
                value += ";" + this.Set5Input3.Text;
            }
            if (this.Set5Input4.Text.Length > 0)
            {
                value += ";" + this.Set5Input4.Text;
            }
            if (this.Set5Input5.Text.Length > 0)
            {
                value += ";" + this.Set5Input5.Text;
            }
            this.send(value);
        }

        private void send(string str)
        {
            OutputThread oThread = new OutputThread(this.HostValue.Text, int.Parse(this.PortValue.Text), str);
            Thread t = new Thread(new ThreadStart(oThread.process));
            t.Start();
        }

        private void ConfigKeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.FudgeButton_Click(sender, e);
            }
        }


        private void FudgeKeyUp1(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.FudgeIt1_Click(sender, e);
            }
        }

        private void FudgeKeyUp2(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.FudgeIt2_Click(sender, e);
            }
        }

        private void FudgeKeyUp3(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.FudgeIt3_Click(sender, e);
            }
        }

        private void FudgeKeyUp4(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.FudgeIt4_Click(sender, e);
            }
        }

        private void FudgeKeyUp5(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                this.FudgeIt5_Click(sender, e);
            }
        }
    }
}
