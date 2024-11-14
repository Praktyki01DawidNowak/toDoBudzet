
namespace ToDoMauiClient
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ManageToDoPage), typeof(ManageToDoPage));
        }

        private object ManageToDoPage()
        {
            throw new NotImplementedException();
        }
    }
}
