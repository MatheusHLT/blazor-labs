using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoFinal.Client.Services;

public class MediaService
{
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }

    public double? Media { get; private set; }

    public string Situacao { get; private set; } = "";

    public void CalcularMedia()
    {
        if (Nota1 < 0 || Nota1 > 10 || Nota2 < 0 || Nota2 > 10)
        {
            Media = null;
            Situacao = "Digite notas válidas entre 0 e 10!";
            return;
        }

        Media = (Nota1 + Nota2) / 2;

        if (Media >= 7.0)
        {
            Situacao = "Aprovado!";
        }
        else
        {
            Situacao = "Reprovado!";
        }
    }
}
