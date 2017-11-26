using CameraBazar.Data.Models;

namespace CameraBazar.Web.Infrastructure.Extensions
{
    public static class EnumExtensions
    {
        public static string ToDispalyName(this LightMetering lightMetering)
        {
            if (lightMetering == LightMetering.CenterWeighted)
            {
                return "Center-Weighted";
            }

            return lightMetering.ToString();
        }
    }
}
