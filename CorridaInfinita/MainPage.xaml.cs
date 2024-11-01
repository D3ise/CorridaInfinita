namespace CorridaInfinita;

public partial class MainPage : ContentPage
{
	bool estamorto = false;
	bool estapulando = false;
	const int tempoentreframes = 25;
	int velocidade = 0;
	int velocidade1 = 0;
	int velocidade2 = 0;
	int velocidade3 = 0;
	int larguraJanela = 0;
	int alturaJanela = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	async Task Desenhar()
	{
		while (!estamorto)
		{
			GerenciaImagens();
		}
	}

	protected override void OnSizeAllocated(double w, double h)
	{
		base.OnSizeAllocated(w, h);
		CalculaVelocidade(w);
		CorrigeTamanho(w, h);
	}
	void CalculaVelocidade(double w)
	{
		velocidade = (int)(w * 0.01);
		velocidade1 = (int)(w * 0.001);
		velocidade2 = (int)(w * 0.004);
		velocidade3 = (int)(w * 0.008);
	}

	void CorrigeTamanho(double w, double h)
	{
		foreach (var a in Layer1.Children)
			(a as Image).WidthRequest = w;
		foreach (var a in Layer2.Children)
			(a as Image).WidthRequest = w;
		foreach (var a in Layer3.Children)
			(a as Image).WidthRequest = w;
		foreach (var a in Layerchao.Children)
			(a as Image).WidthRequest = w;

		Layer1.WidthRequest = w;
		Layer2.WidthRequest = w;
		Layer3.WidthRequest = w;
		Layerchao.WidthRequest = w;
	}

	void GerenciaImagens()
	{
		Layer1.TranslationX -= velocidade1;
		Layer2.TranslationX -= velocidade2;
		Layer3.TranslationX -= velocidade3;
		Layerchao.TranslationX -= velocidade;
		if (Layer1.TranslationX < -larguraJanela)
		{
			Layer1.TranslationX = 0;
			Layer2.TranslationX = 0;
			Layer3.TranslationX = 0;
			Layerchao.TranslationX = 0;
		}
	}
}

