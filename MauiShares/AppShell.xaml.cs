using MauiShares.Views;

namespace MauiShares
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("fileDetails", typeof(FileDetailsView));
        }
    }
}
