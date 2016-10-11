using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace LittleAppication
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class CoffeePage : Page
    {
        private string _roast;
        private string _sweener;
        private string _cream;


        public CoffeePage()
        {
            this.InitializeComponent();
        }

        private void Roasr_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _roast = selected.Text;
            displayResult();
        }

        private void Cream_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _cream = selected.Text;
            displayResult();
        }

        private void Sweetener_Click(object sender, RoutedEventArgs e)
        {
            var selected = (MenuFlyoutItem)sender;
            _sweener = selected.Text;
            displayResult();
        }
        private void displayResult()
        {if(_roast == "None" || string.IsNullOrEmpty(_roast))
            {
                ResulTextBlock.Text = "None";
                return;
            }
            ResulTextBlock.Text = _cream +" "  + _sweener + " " + _roast;
            if(_cream!= "None"&& !string.IsNullOrEmpty(_cream))
            {
                ResulTextBlock.Text += "+" + _cream;
              
            }
            if (_sweener != "None" && !string.IsNullOrEmpty(_sweener))
            {
                ResulTextBlock.Text += "+" + _sweener;

            }
        }
    }
}
