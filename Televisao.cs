using System;

public class Televisao
{
    private const int CanalMinimo = 1;
    private const int CanalMaximo = 520;

    private const int VolumeMinimo = 0;
    private const int VolumeMaximo = 100;

    private int canalAtual;
    private int volumeAtual;
    private bool mudo;

    public Televisao()
    {
        canalAtual = CanalMinimo;
        volumeAtual = 50; // valor padrão
        mudo = false;
    }


    public void Ligar(int canalInicial, int volumeInicial)
    {
        IrParaCanal(canalInicial);
        DefinirVolume(volumeInicial);
        Console.WriteLine($"\nTV ligada no canal {canalAtual} com volume {volumeAtual}");
    }

    public void IrParaCanal(int numeroCanal)
    {
        if (numeroCanal >= CanalMinimo && numeroCanal <= CanalMaximo)
        {
            canalAtual = numeroCanal;
        }
        else
        {
            canalAtual = CanalMinimo;
            Console.WriteLine("⚠ Número de canal inválido. Canal definido para 1.");
        }
    }


    public void DefinirVolume(int novoVolume)
    {
        if (novoVolume >= VolumeMinimo && novoVolume <= VolumeMaximo)
        {
            volumeAtual = novoVolume;
        }
        else
        {
            volumeAtual = 50;
            Console.WriteLine("Volume inválido. Volume definido para 50.");
        }
    }

    public void MostrarStatus()
    {
        Console.WriteLine($"Canal: {canalAtual} | Volume: {(mudo ? "MUDO" : volumeAtual)}");
    }
}

public class Program
{
    public static void Main()
    {
        Televisao tv = new Televisao();

        Console.WriteLine("== Bem-vindo à TV ==");

        Console.Write("Digite o canal inicial (1 a 520): ");
        int canalInicial = int.TryParse(Console.ReadLine(), out int c) ? c : 1;

        Console.Write("Digite o volume inicial (0 a 100): ");
        int volumeInicial = int.TryParse(Console.ReadLine(), out int v) ? v : 50;

        tv.Ligar(canalInicial, volumeInicial);
        tv.MostrarStatus();
    }
}
