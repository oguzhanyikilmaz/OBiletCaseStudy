using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBilet.Case.Study.API.Client.Extensions
{
    public static class TExtension
    {
        #region Methods

        /// <summary>
        /// Newtonsoft kütüphanesi kullanarak ilgili objeyi Json'a çevirir.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="obj"></param>
        /// <param name="serializerSettings"></param>
        /// <returns></returns>
        public static string ToJson<T>(this T obj, JsonSerializerSettings serializerSettings = null)
        {
            try
            {
                serializerSettings = serializerSettings ?? new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore
                };

                return JsonConvert.SerializeObject(obj, serializerSettings);
            }
            catch (Exception ex)
            {
                string errMessage = $"Error in json serialization.Ex:{ex}";
                return string.Empty;
            }
        }

        /// <summary>
        /// Newtonsoft kütüphanesi kullanarak ilgili Json'ı T parametresindeki objeye çevirir.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="json"></param>
        /// <param name="serializerSettings"></param>
        /// <returns></returns>
        public static T ToObject<T>(this string json, JsonSerializerSettings serializerSettings = null)
        {
            try
            {
                serializerSettings = serializerSettings ?? new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto,
                    NullValueHandling = NullValueHandling.Ignore

                };

                return JsonConvert.DeserializeObject<T>(json, serializerSettings);
            }
            catch (Exception ex)
            {
                string errMessage = $"Error in json serialization.Ex:{ex}";

                return default(T);
            }
        }

        #endregion
    }
}
