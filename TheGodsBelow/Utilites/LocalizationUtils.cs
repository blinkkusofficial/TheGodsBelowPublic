using Terraria.Localization;

namespace TheGodsBelow.Utilites
{
    public partial class TheGodsBelowUtils
    {
        public static LocalizedText GetText(string key)
        {
            return Language.GetOrRegister("Mods.TheGodsBelow." + key);
        }

        public static string GetTextValue(string key)
        {
            return Language.GetTextValue("Mods.TheGodsBelow." + key);
        }
    }
}
