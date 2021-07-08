namespace _2kod.ViewModels
{
    using System.Reactive;

    using Avalonia;
    using Avalonia.Controls.ApplicationLifetimes;

    using ReactiveUI;

    public sealed class MainWindowViewModel : ViewModelBase
    {
        private bool isStackPanelEnabled;

        public MainWindowViewModel()
        {
            CloseWindowContextCommand = ReactiveCommand.Create(ExecuteCloseWindowContext);
            OpenNavigationBarCommand = ReactiveCommand.Create(ExecuteOpenNavigationBar);
        }

        public bool IsStackPanelEnabled
        {
            get => this.isStackPanelEnabled;
            private set => this.RaiseAndSetIfChanged(ref this.isStackPanelEnabled, value);
        }

        public ReactiveCommand<Unit, Unit> CloseWindowContextCommand { get; }

        public ReactiveCommand<Unit, Unit> OpenNavigationBarCommand { get; }

        private static void ExecuteCloseWindowContext()
        {
            if (Application.Current.ApplicationLifetime is IClassicDesktopStyleApplicationLifetime applicationLifetime)
            {
                applicationLifetime.Shutdown();
            }
        }

        private void ExecuteOpenNavigationBar()
        {
            IsStackPanelEnabled = !IsStackPanelEnabled;
        }
    }
}
