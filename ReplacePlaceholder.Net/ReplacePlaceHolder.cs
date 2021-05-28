using System;
using System.Text.RegularExpressions;

namespace ReplacePlaceholder.Net
{
    public static class ReplacePlaceHolder
    {
       /// <summary>
       /// Placeholder repacement : ${Name}
       /// Example: "{FirstName} {LastName}"
       /// </summary>
       /// <param name="data">data</param>
       /// <param name="template">template string</param>
       /// <returns>replaced string</returns>
        public static string ReplacePlaceholder(object data,string template)
        {
            try
            {
                string result = new string(template.ToCharArray());

                var allProperties = data.GetType().GetProperties();
                foreach (var item in allProperties)
                {
                    var regex = new Regex(@"{" + item.Name + @"}");
                    result = regex.Replace(result, item.GetValue(data).ToString());
                }

                return result;
            }
            catch (Exception ex)
            {

                throw ;
            }
        }
    }
}
