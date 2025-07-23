using MauiShares.ViewModels;

namespace MauiShares.Views;

public partial class FileDetailsView : ContentPage
{
	public FileDetailsView(FileDetailsViewModel fileDetailsViewModel)
	{
		InitializeComponent();
		BindingContext = fileDetailsViewModel;
	}
}