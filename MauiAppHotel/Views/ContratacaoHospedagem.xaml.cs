namespace MauiAppHotel.Views;

public partial class ContratacaoHospedagem : ContentPage
{
	public ContratacaoHospedagem()
	{
		InitializeComponent();
	}

    private   void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
             Navigation.PushAsync(new sobre ());

        }
        catch (Exception ex)
        {
            DisplayAlert("Ops, algo errado", ex.Message, "Ok");
        }

    }

 }
