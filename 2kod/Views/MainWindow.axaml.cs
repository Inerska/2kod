using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace _2kod.Views
{
    using System;

    using Avalonia.Threading;

    using ReactiveUI;

    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            TextBox leftMwc = this.Get<TextBox>("LeftMainWritableContent");
            DispatcherTimer.RunOnce(() => leftMwc.Focus(), TimeSpan.FromMilliseconds(1));
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
