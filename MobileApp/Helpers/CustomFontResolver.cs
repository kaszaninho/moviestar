using PdfSharp.Fonts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MobileApp.Helpers
{
    public class CustomFontResolver : IFontResolver
    {
        public byte[] GetFont(string faceName)
        {
            if (faceName == "Arial")
            {
                var fontStream = FileSystem.OpenAppPackageFileAsync("Arial.ttf").Result;
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
            if (familyName == "Arial")
            {
                return new FontResolverInfo("Arial");
            }
            return null;
        }
    }
}
