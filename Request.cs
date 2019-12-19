using System;
using System.Collections.Generic;
using System.Text;

namespace ConsultarArchivosConsole
{
    class Request
    {
        public int ListId { get; set; }
        public int FatherItemId { get; set; }
        public Header header { get; set; }
    }
}
