using PdfSharp.Fonts;
using System.Collections;

namespace MobileApp.Helpers
{
    public class CustomFontResolver : IFontResolver
    {
        private Hashtable hashtable = new Hashtable
        {
            { "OpenSansRegular", "OpenSans-Regular.ttf"},
            { "OpenSansSemibold", "OpenSans-Semibold.ttf"},
            { "Arial", "Arial.ttf" },
            { "RajdhaniBold", "Rajdhani-Bold.ttf"},
            { "RajdhaniLight", "Rajdhani-Light.ttf" },
            { "RajdhaniMedium", "Rajdhani-Medium.ttf"},
            { "Rajdhani", "Rajdhani-Regular.ttf"},
            { "RajdhaniSemiBold", "Rajdhani-SemiBold.ttf"}
        };

        public byte[] GetFont(string faceName)
        {
            if (hashtable.ContainsKey(faceName))
            {
                var fontStream = FileSystem.OpenAppPackageFileAsync((string)hashtable[faceName]).GetAwaiter().GetResult();
                using (var memoryStream = new MemoryStream())
                {
                    fontStream.CopyTo(memoryStream);
                    return memoryStream.ToArray();
                }
            }
            return null;
        }

        public FontResolverInfo ResolveTypeface(string familyName, bool isBold, bool isItalic)
        {
            if (hashtable.ContainsKey(familyName))
            {
                return new FontResolverInfo(familyName);
            }
            return null;
        }
    }
}
