using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Mvvm;

namespace HelloPrismUnityContainer.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        public DelegateCommand AlertCommand { get; }
        public InteractionRequest<INotification> AlertRequest { get; } = new InteractionRequest<INotification>();

        private string _input;
        public string Input
        {
            get => _input;
            set
            {
                SetProperty(ref _input, value);
            }
        }

        public MainWindowViewModel()
        {
            AlertCommand = new DelegateCommand(() => AlertRequest.Raise(new Notification { Title = "Alert !", Content = Input }));
        }
    }
}
