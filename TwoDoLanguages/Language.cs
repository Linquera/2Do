using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TwoDoInterfaces;
using TwoDoUtils;

namespace TwoDoLanguages
{
    public class Language : ITwoDoLanguage
    {
        public enum LanguageTypes { English, Portuguese, notDefined }
        private static ITwoDoLanguage instance;
        public static ITwoDoLanguage Instance
        {
            get
            {
                if (instance == null)
                {
                    SetLanguage(StringToLanguage(IniFile.Instance.IniReadValue("Options", "Language")));
                }
                return instance;
            }
        }

        public static void SetLanguage(LanguageTypes language)
        {            
            switch (language)
            {
                case LanguageTypes.notDefined:
                case LanguageTypes.English:
                    instance = new English();
                    break;

                case LanguageTypes.Portuguese:
                    instance = new Portuguese();
                    break;                
            }
        }

        public static LanguageTypes StringToLanguage(string language)
        {
            switch (language)
            {
                case "en-EU":
                    return LanguageTypes.English;
                case "pt-BR":
                    return LanguageTypes.Portuguese;
            }
            return LanguageTypes.notDefined;
        }

        public static string LanguageToString(LanguageTypes language)
        {
            switch (language)
            {
                case LanguageTypes.English:
                    return "en-EU";
                case LanguageTypes.Portuguese:
                    return "pt-BR";
            }
            return "";
        }

        public string Character { get { return instance.Character; } }
    }
}
