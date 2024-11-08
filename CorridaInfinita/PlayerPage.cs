using CorridaInfinita;
namespace CorridaInfinita;

public delegate void Callback();
public class Player: AnimacaoPage
{
    public Player (Image a):base(a)
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

}