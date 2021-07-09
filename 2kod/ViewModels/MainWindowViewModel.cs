namespace _2kod.ViewModels
{
    using System.Reactive;

    using Avalonia;
    using Avalonia.Controls.ApplicationLifetimes;

    using AvaloniaEdit;
    using AvaloniaEdit.Document;

    using ReactiveUI;
    using ReactiveUI.Fody.Helpers;

    public sealed class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CloseWindowContextCommand = ReactiveCommand.Create(ExecuteCloseWindowContext);
            OpenNavigationBarCommand = ReactiveCommand.Create(ExecuteOpenNavigationBar);

            Document = new TextDocument();
        }

        [Reactive]
        public bool IsStackPanelEnabled { get; set; }

        [Reactive]
        public TextDocument Document { get; set; }

        public ReactiveCommand<Unit, Unit> CloseWindowContextCommand { get; }

        public ReactiveCommand<Unit, Unit> OpenNavigationBarCommand { get; }

        private static void ExecuteCloseWindowContext()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime applicationLifetime)
            {
                applicationLifetime.Shutdown();
            }
        }

        private void ExecuteOpenNavigationBar() => IsStackPanelEnabled = !IsStackPanelEnabled;
    }
}
