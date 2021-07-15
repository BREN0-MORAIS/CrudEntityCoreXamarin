using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace App1.Banco
{
   public static class Constantes
    {
        public const string NomeDoArquivo = "BD.db3";

        public static string CaminhoDoBanco
        {
            get
            {
                var caminhobase = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData); 
                return Path.Combine(caminhobase, NomeDoArquivo); 
            }
        }
    }
}
