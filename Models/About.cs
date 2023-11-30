using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escobar_AppApuntes.Models
{
    internal class About
    {
        public string Title => AppInfo.Name;
        public string Version => AppInfo.VersionString;
        public string MoreInfoUrl => "https://www.youtube.com/watch?v=dQw4w9WgXcQ";
        public string Message => "This app is written in XAML and C# with .NET MAUI.";
    }
}
