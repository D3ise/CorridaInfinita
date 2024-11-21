using CorridaInfinita;
using FFImageLoading.Maui;
namespace CorridaInfinita;

public delegate void Callback();
public class Player: AnimacaoPage
{
    public Player (CachedImageView a):base(a)
    {
        for (int i=0; i<=11; ++i)
         Animacao1.Add($"a{i.ToString("D2")}.png");

        SetAnimacaoAtual(1);
    }
    public void Die ()
    {
        loop=false;
        SetAnimacaoAtual(2);
    }
    public void Run ()
    {
        loop=true;
        SetAnimacaoAtual(1);
        Play();
    }
    public void MoveY(int s)
    {
        imageView.TranslationY +=s;
    }

    public double GetY()
    {
        return imageView.TranslationY;
    }
    
    public void SetY(double a)
    {
        imageView.TranslationY = a;
    }

}