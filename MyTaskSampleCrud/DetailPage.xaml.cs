using MyTaskSampleCrud.ViewModel;

namespace MyTaskSampleCrud;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}