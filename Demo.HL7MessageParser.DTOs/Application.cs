using TPM.Access.Versioning;

namespace TPM.AccessCenter.Common
{
    public class Application
    {
        static Application()
        {
            ProductVersion = System.Reflection.Assembly.GetEntryAssembly().ProductVersionWithPatch();
        }

        /// <summary>
        /// Gets or sets the product version along with patch version.
        /// </summary>
        public static readonly string ProductVersion;
    }
}
