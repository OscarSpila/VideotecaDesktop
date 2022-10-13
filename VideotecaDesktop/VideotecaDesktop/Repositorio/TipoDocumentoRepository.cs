using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using VideotecaDesktop.Utils;

// https://www.c-sharpcorner.com/article/restsharp-in-net-6-0/


namespace VideotecaDesktop.Repositorio
{
    internal static class TipoDocumentoRepository
    {
        /// <summary>
        /// Recupera un Tipo de Documento
        /// </summary>
        /// <param name="ID">Identificado de Tipo de Documento</param>
        /// <returns></returns>
        public static Models.TipoDocumento.Item GetById(int ID)
        {
            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO + "/" + ID, Method.Get);

            Models.TipoDocumento.Item? response = null;

            try
            {
                response = client.Get<Models.TipoDocumento.Item>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        /// <summary>
        /// Recupera todos los Tipo de Documentos
        /// </summary>
        /// <returns></returns>
        public static Models.TipoDocumento.ListTipoDocumentos GetAll()
        {
            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO, Method.Get);

            Models.TipoDocumento.ListTipoDocumentos lista = new Models.TipoDocumento.ListTipoDocumentos();

            try
            {
                lista = client.Get<Models.TipoDocumento.ListTipoDocumentos>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return lista;
        }

        /// <summary>
        /// Agrega un nuevo Tipo de Documento
        /// </summary>
        /// <param name="item">Objeto Tipo de Documento</param>
        /// <returns></returns>
        public static int Add(Models.TipoDocumento.Item item)
        {
            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO, Method.Post);
            client.UseJson();

            int result = -1;

            try
            {
                request.AddJsonBody(item);
                result = client.Post<int>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Actualiza un Tipo de Documento
        /// </summary>
        /// <param name="ID">Identificador del Documento</param>
        /// <param name="item">Objecto a Actualizar</param>
        /// <returns></returns>
        public static int Update(int ID, Models.TipoDocumento.Item item)
        {
            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO + "/" + ID, Method.Put);
            client.UseJson();

            int result = -1;

            try
            {
                request.AddJsonBody(item);
                result = client.Put<int>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        /// <summary>
        /// Borra un Tipo de Documento lógicamente
        /// </summary>
        /// <param name="ID">Identificador de Tipo de Documento</param>
        /// <returns></returns>
        public static int Delete(int ID)
        {
            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO + "/" + ID, Method.Delete);
            client.UseJson();

            int result = -1;

            try
            {
                result = client.Delete<int>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return result;
        }

        public static Models.TipoDocumento.ListTipoDocumentos GetByTipoAndDescripcion(string buscar)
        {
            string filtro = "?filters=[[\"tipo\",\"like\",\"" + buscar + "\"],[\"OR\"],[\"nombre\",\"like\",\"" + buscar + "\"]]";

            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO + "/" + filtro, Method.Get);

            Models.TipoDocumento.ListTipoDocumentos? response = null;

            try
            {
                response = client.Get<Models.TipoDocumento.ListTipoDocumentos>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public static Models.TipoDocumento.ListTipoDocumentos GetTopN(int top)
        {
            string size = "?size=" + top + "&page=0";

            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO + "/" + size, Method.Get);

            Models.TipoDocumento.ListTipoDocumentos? response = null;

            try
            {
                response = client.Get<Models.TipoDocumento.ListTipoDocumentos>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }

        public static Models.TipoDocumento.ListTipoDocumentos GetDeletes()
        {
            var client = new RestClient(Constantes.server);
            var request = new RestRequest(Constantes.END_POINT_TIPO_DOCUMENTO + "/deletes", Method.Get);

            Models.TipoDocumento.ListTipoDocumentos? response = null;

            try
            {
                response = client.Get<Models.TipoDocumento.ListTipoDocumentos>(request);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }
    }
}
