namespace Birulo;

public partial class GridPrincipal : ContentPage
{
	public GridPrincipal()
	{
		InitializeComponent();
	}

    private void CounterBtn_Clicked(object sender, EventArgs e)
    {

    }

    private void FlyoutPageBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new FlyoutPageDemo());
    }

    private void ContentPage_Clicked(object sender, EventArgs e)
    {
        //
       
    }

    private void TabbletPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new TabbletPageDemo());
    }

    private void StackLayoutPage_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new StackLayoutDemo());
    }

    private void GridPageDemo_Clicked(object sender, EventArgs e)
    {
          Navigation.PushAsync(new GridPageDemonstracao());

    }

    private void AbsolutLayoutDemo_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AbsoluteLayoutDemo());

    }

    private void FlexLayout_Clicked(object sender, EventArgs e)
    {
        //
        Navigation.PushAsync(new FlexLayout());
    }
}