using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiShares.Models;
using CommunityToolkit.Mvvm.Input;

namespace MauiShares.ViewModels
{
    public partial class FileDetailsViewModel : ObservableObject, IQueryAttributable
    {
        [ObservableProperty]
        FileModel fileModel;

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            FileModel = (FileModel)query["Details"];
        }

        [RelayCommand]
        public async Task ShareUri()
        {
            await Share.RequestAsync(new ShareTextRequest
            {
                Uri = FileModel.link,
                Title = "Share Web Link"
            });
        }

        [RelayCommand]
        public async Task Upload()
        {
            await Shell.Current.GoToAsync("..");
        }

    }
}
