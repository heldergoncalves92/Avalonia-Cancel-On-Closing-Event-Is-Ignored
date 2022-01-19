using System;
using System.Diagnostics;
using System.Threading;
using System.Timers;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Threading;

namespace Avalonia.NETCoreApp
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            AvaloniaXamlLoader.Load(this);
            Closing += (sender, args) => args.Cancel = true;
        }


        private static DataObject global;

        private void Button_OnClick(object? sender, RoutedEventArgs e)
        {
            Console.WriteLine("Button Clicked!!");

            try
            {
                Dispatcher.UIThread.MainLoop(CancellationToken.None);    
            } catch (Exception s) {
                Console.WriteLine(s.Message);
            }
            
           
        }
    }
}