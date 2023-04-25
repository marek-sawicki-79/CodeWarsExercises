using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NativeWelcome
{
    public static class Kata
    {
        public static string Greet(string language)
        {
            Dictionary<string, string> nation = new Dictionary<string, string>()
            {
                {"english", "Welcome"},
                {"czech", "Vitejte"},
                {"danish", "Velkomst"},
                {"dutch", "Welkom"},
                {"estonian", "Tere tulemast"},
                {"finnish", "Tervetuloa"},
                {"flemish", "Welgekomen"},
                {"french", "Bienvenue"},
                {"german", "Willkommen"},
                {"irish", "Failte"},
                {"italian", "Benvenuto"},
                {"latvian", "Gaidits"},
                {"lithuanian", "Laukiamas"},
                {"polish", "Witamy"},
                {"spanish", "Bienvenido"},
                {"swedish", "Valkommen"},
                {"welsh", "Croeso"}
            };
            string result = "";
            if (nation.ContainsKey(language))
            {
                result = nation[language];
            }
            else if (!nation.ContainsKey(language))
            {
                result = "Welcome";
            }
            return result;
        }
    }
}
