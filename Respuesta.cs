using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultarArchivosConsole
{
    class Respuesta
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public Data[] Data { get; set; }
        public int Rows { get; set; }
    }
}
