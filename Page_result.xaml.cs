namespace Exercise_1_1;

public partial class Page_result : ContentPage
{
	public Page_result(){
		InitializeComponent();
        txt_result.Text=Mathematical_operations.operation();
    }
}