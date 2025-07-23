using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MauiShares.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiShares.ViewModels
{
    public partial class DashboardViewModel : ObservableObject
    {
        [ObservableProperty]
        bool isBusy;

        FileUploadService _service;
        public DashboardViewModel(FileUploadService service)
        {
            _service = service;
        }

        [RelayCommand]
        public async Task UploadFile(PickOptions options)
        {
            try
            {
                if(IsBusy)
                {
                    return;
                }
                var result = await FilePicker.Default.PickAsync(options);
                if (result != null)
                {
                    var path = result.FullPath;
                    IsBusy = true;

                    var file = await _service.UploadFile(path);

                    if(file != null)
                    {
                        var navigationParameter = new Dictionary<string, object>
                        {
                            { "Details", file }
                        };
                        await Shell.Current
                            .GoToAsync("fileDetails", navigationParameter);
                    }

                }
                
            }
            catch (Exception ex)
            {
                // The user canceled or something went wrong
            }    
            finally
            {
                IsBusy = false;
            }
        }
    }
}
