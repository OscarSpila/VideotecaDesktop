using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotecaDesktop.Utils
{
    internal class Constantes
    {
        public const string server = "http://localhost:8080";

        const string api = "api";
        const string version_v1 = "v1";
        const string URL_BASE_V1 = "/" + api + "/" + version_v1 + "/";

        public const string END_POINT_TIPO_DOCUMENTO = URL_BASE_V1 + "tipodocumento";
    }
}
