﻿using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskSampleCrud.ViewModel
{
    [QueryProperty("Text","Text")]
    public partial class DetailViewModel : ObservableObject
    {
        [ObservableProperty]
        public string text;

        [RelayCommand]
        async Task GoBack()
        {
            await Shell.Current.GoToAsync("..");
        }
    }
}
