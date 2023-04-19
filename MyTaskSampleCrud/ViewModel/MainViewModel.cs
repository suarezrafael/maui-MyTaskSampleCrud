using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MyTaskSampleCrud.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        IConnectivity connectivity;
        public MainViewModel(IConnectivity connectivity)
        {
            Items = new ObservableCollection<string>();
            this.connectivity = connectivity;
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        async Task Add()
        {
            if (string.IsNullOrWhiteSpace(Text))
                return;

            if(connectivity.NetworkAccess != NetworkAccess.Internet)
            {
                await Shell.Current.DisplayAlert("Alert", "No internet","OK");
                return;
            }
            // add our item
            Items.Add(Text);
            Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string item)
        {
            if(Items.Contains(item))
            Items.Remove(item);
            
        }

        [RelayCommand]
        async Task Tap(string item)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={item}");
        }
    }
}
