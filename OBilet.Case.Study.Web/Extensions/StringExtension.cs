using System.Globalization;

namespace OBilet.Case.Study.Web.Extensions
{
    public static class StringExtension
    {
        #region Methods

        /// <summary>
        /// Parametre olarak verilen string tarih datasını gün ay ve gün ismi formatında döner.
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public static string ConvertDate(this string dateString)
        {
            DateTime date = DateTime.ParseExact(dateString, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            string dayName = date.ToString("dddd", new CultureInfo("tr-TR"));
            string day = date.Day.ToString();
            string monthName = date.ToString("MMMM", new CultureInfo("tr-TR"));

            return $"{day} {monthName} {dayName}";
        }

        /// <summary>
        /// Parametre olarak verilen string tarih datasının saat ve dakika verisini döner.
        /// </summary>
        /// <param name="dateString"></param>
        /// <returns></returns>
        public static string ExtractTime(this string dateString)
        {
            DateTime date = DateTime.ParseExact(dateString, "dd.MM.yyyy HH:mm:ss", CultureInfo.InvariantCulture);

            string time = date.ToString("HH:mm");
            return time;
        }
        #endregion
    }
}
