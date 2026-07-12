using System;
using System.Diagnostics;

namespace Microsoft.Phone.Shell
{
    public enum IdleDetectionMode
    {
        Enabled = 0,
        Disabled = 1
    }

    public sealed class PhoneApplicationService
    {
        private static readonly PhoneApplicationService CurrentInstance = new();

        public static PhoneApplicationService Current => CurrentInstance;

        public IdleDetectionMode ApplicationIdleDetectionMode { get; set; }
    }
}

namespace Microsoft.Phone.Tasks
{
    public enum MarketplaceContentType
    {
        Applications = 0,
        Music = 1,
        ApplicationsAndGames = 1
    }

    public sealed class MarketplaceDetailTask
    {
        public MarketplaceContentType ContentType { get; set; }

        public void Show()
        {
        }
    }

    public sealed class WebBrowserTask
    {
        public string URL { get; set; }

        public void Show()
        {
            if (string.IsNullOrWhiteSpace(URL))
            {
                return;
            }

            try
            {
                string url = Uri.UnescapeDataString(URL);
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
            catch
            {
            }
        }
    }
}
