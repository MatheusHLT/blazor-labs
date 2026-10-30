using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Client.Services;

public class SorteioService
{
    public int? NumeroSorteado { get; private set; }

    private readonly Random Gerador = new Random();

    public void SortearNumero()
    {
        NumeroSorteado = Gerador.Next(1, 101);
    }
}