// criar classes

public class Televisao

// float = numero quebrado
{
    public Televisao(float tamanho)
    {
        Tamanho = tamanho;   
    }

// set = não permitir edição
    public float Tamanho { get; }
    public int Resolucao { get; set;}
    public int Volume { get; set;}
    public int Canal { get; set;}
    public bool Estado { get; set;}

    public void aumentarVolume()
    {
        Volume = Volume + 1;
    }


}