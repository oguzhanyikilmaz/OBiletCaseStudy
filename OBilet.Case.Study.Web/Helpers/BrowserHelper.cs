namespace OBilet.Case.Study.Web.Helpers
{
    public static class BrowserHelper
    {
        #region Methods

        /// <summary>
        /// Mevcut istekteki browser hakkında bilgi döner.
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public static (string Name, string Version) GetBrowserInfo(string userAgent)
        {
            // Tarayıcı bilgilerini userAgent string'inden çıkaran basit bir örnek
            if (userAgent.Contains("Chrome"))
            {
                var version = userAgent.Split(new string[] { "Chrome/" }, StringSplitOptions.None)[1].Split(' ')[0];
                return ("Chrome", version);
            }
            else if (userAgent.Contains("Firefox"))
            {
                var version = userAgent.Split(new string[] { "Firefox/" }, StringSplitOptions.None)[1];
                return ("Firefox", version);
            }
            else if (userAgent.Contains("Safari") && !userAgent.Contains("Chrome"))
            {
                var version = userAgent.Split(new string[] { "Version/" }, StringSplitOptions.None)[1].Split(' ')[0];
                return ("Safari", version);
            }
            else if (userAgent.Contains("Edge"))
            {
                var version = userAgent.Split(new string[] { "Edge/" }, StringSplitOptions.None)[1].Split(' ')[0];
                return ("Edge", version);
            }
            else if (userAgent.Contains("OPR") || userAgent.Contains("Opera"))
            {
                var version = userAgent.Contains("OPR") ? userAgent.Split(new string[] { "OPR/" }, StringSplitOptions.None)[1].Split(' ')[0] : userAgent.Split(new string[] { "Opera/" }, StringSplitOptions.None)[1].Split(' ')[0];
                return ("Opera", version);
            }
            else if (userAgent.Contains("MSIE") || userAgent.Contains("Trident"))
            {
                var version = userAgent.Contains("MSIE") ? userAgent.Split(new string[] { "MSIE " }, StringSplitOptions.None)[1].Split(';')[0] : userAgent.Split(new string[] { "rv:" }, StringSplitOptions.None)[1].Split(')')[0];
                return ("Internet Explorer", version);
            }

            return ("Unknown", "Unknown");
        }
        #endregion
    }
}
