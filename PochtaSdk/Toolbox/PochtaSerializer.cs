using Newtonsoft.Json;
using Restub.Toolbox;

namespace PochtaSdk.Toolbox
{
    internal class PochtaSerializer : NewtonsoftSerializer
    {
        /// <inheritdoc/>
        protected override JsonSerializerSettings CreateJsonSerializerSettings()
        {
            var settings = base.CreateJsonSerializerSettings();
            settings.NullValueHandling = NullValueHandling.Ignore;
            return settings;
        }
    }
}
