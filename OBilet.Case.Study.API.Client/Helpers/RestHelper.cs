using Newtonsoft.Json;
using OBilet.Case.Study.API.Client.Extensions;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Helpers
{
    public class RestHelper
    {
        #region FieldsAndProps
        private string baseurl = "";
        #endregion

        #region Ctors
        public RestHelper(string baseurl)
        {
            this.baseurl = baseurl;
        }
        #endregion

        #region Methods

        #region PublicMethods

        /// <summary>
        /// RestSharp kullanarak parametrelere göre istek yapar.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="query"></param>
        /// <param name="method"></param>
        /// <param name="model"></param>
        /// <param name="errorMethod"></param>
        /// <returns></returns>
        public T Execute<T>(string query, Method method, object model, string errorMethod) where T : new()
        {

            RestClient client = new RestClient(baseurl);
            var request = new RestRequest(query, method);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", GetAuth());


            string json = model.ToJson();

            if (model != null)
            {
                request.RequestFormat = DataFormat.Json;
                request.AddParameter("application/json", json, ParameterType.RequestBody);
            }

            var response = client.Execute(request);

            if (response.StatusCode == HttpStatusCode.OK)
            {
                try
                {
                    T result = response.Content.ToObject<T>(); //JsonConvert.DeserializeObject<T>(response.Content);

                    return result;
                }
                catch (Exception ex)
                {

                    return default(T);
                }
            }
            else
            {
                return default(T);
            }
        }
        #endregion

        #region PrivateMethods

        /// <summary>
        /// İstek atılacak olan API'ye Auth işlemlerini yapıp geriye ilgili Auth bilgilerini döner.
        /// </summary>
        /// <returns></returns>
        private string GetAuth()
        {
            return "Basic JEcYcEMyantZV095WVc3G2JtVjNZbWx1";
        }
        #endregion

        #endregion
    }
}
