using System;
using System.IO;

namespace Util
{
    public class ArquivosEPastas
    {
        public void VerificarDiretorio(string ParDir)
        {
            if (!Directory.Exists(ParDir))
            {
                Directory.CreateDirectory(ParDir);
            }
        }
    }
}
