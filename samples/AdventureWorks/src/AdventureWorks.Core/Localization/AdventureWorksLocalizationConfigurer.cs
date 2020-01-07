using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace AdventureWorks.Localization
{
    public static class AdventureWorksLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(AdventureWorksConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(AdventureWorksLocalizationConfigurer).GetAssembly(),
                        "AdventureWorks.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
