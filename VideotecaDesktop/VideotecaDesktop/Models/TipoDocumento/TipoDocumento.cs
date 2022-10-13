using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideotecaDesktop.Models.TipoDocumento
{

    public partial class ListTipoDocumentos
    {
        [JsonProperty("items", Required = Required.Always)]
        public List<Item> Items { get; set; }

        [JsonProperty("page", Required = Required.Always)]
        public long Page { get; set; }

        [JsonProperty("size", Required = Required.Always)]
        public long Size { get; set; }

        [JsonProperty("max_page", Required = Required.Always)]
        public long MaxPage { get; set; }

        [JsonProperty("total_pages", Required = Required.Always)]
        public long TotalPages { get; set; }

        [JsonProperty("total", Required = Required.Always)]
        public long Total { get; set; }

        [JsonProperty("last", Required = Required.Always)]
        public bool Last { get; set; }

        [JsonProperty("first", Required = Required.Always)]
        public bool First { get; set; }

        [JsonProperty("visible", Required = Required.Always)]
        public long Visible { get; set; }
    }

    public partial class Item
    {
        public static readonly int MAX_LENGTH_TIPO = 3;
        public static readonly int MAX_LENGTH_DESCRIPCION = 45;

        [JsonProperty("ID", Required = Required.Always)]
        public long Id { get; set; }

        [JsonProperty("CreatedAt", Required = Required.Always)]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonProperty("UpdatedAt", Required = Required.Always)]
        public DateTimeOffset? UpdatedAt { get; set; }

        [JsonProperty("DeletedAt", Required = Required.AllowNull)]
        public DateTimeOffset? DeletedAt { get; set; }

        [JsonProperty("tipo", Required = Required.Always)]
        public string Tipo { get; set; }

        [JsonProperty("nombre", Required = Required.Always)]
        public string Nombre { get; set; }
    }

    public partial class ListTipoDocumentos
    {
        public static ListTipoDocumentos FromJson(string json) => JsonConvert.DeserializeObject<ListTipoDocumentos>(json, VideotecaDesktop.Models.TipoDocumento.Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ListTipoDocumentos self) => JsonConvert.SerializeObject(self, VideotecaDesktop.Models.TipoDocumento.Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}
