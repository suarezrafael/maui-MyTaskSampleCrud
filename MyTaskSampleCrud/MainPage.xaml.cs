using MyTaskSampleCrud.ViewModel;

namespace MyTaskSampleCrud;

public partial class MainPage : ContentPage
{
	public MainPage(MainViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}

}

