namespace CorridaInfinita;

public partial class MainPage : ContentPage
{
    int velocidade = 10;
	int larguraJanela=0;

	public MainPage()
	{
		InitializeComponent();
	}

	async Task Desenhar()
	{
       GerenciaImagens();
	}

	void GerenciaImagens ()
	{
		fundo.TranslationX-= velocidade;
		fundopredio.TranslationX-= velocidade;
		fundoparque.TranslationX-= velocidade;
		chao.TranslationX-= velocidade;
		animal.TranslationX-= velocidade;
		if (fundo.TranslationX<-larguraJanela)
		{
			fundo.TranslationX=0;
			fundopredio.TranslationX=0;
			fundoparque.TranslationX=0;
			chao.TranslationX=0;
			animal.TranslationX=0;
			
		}
	}
}

