using CH3.Core;
using CH3.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Data
{
    /// <summary>
    /// Entity Framework data provider manager
    /// </summary>
    public partial class EfDataProviderManager : BaseDataProviderManager
    {
        /// <summary>
        /// Ctor
        /// </summary>
        /// <param name="settings">Data settings</param>
        public EfDataProviderManager(DataSettings settings) : base(settings)
        {
        }

        /// <summary>
        /// Load data provider
        /// </summary>
        /// <returns>Data provider</returns>
        public override IDataProvider LoadDataProvider()
        {
            var providerName = Settings.DataProvider;
            if (string.IsNullOrWhiteSpace(providerName))
                throw new CH3Exception("Data Settings doesn't contain a providerName");

            switch (providerName.ToLowerInvariant())
            {
                case "sqlserver":
                    return new SqlServerDataProvider();
                default:
                    throw new CH3Exception($"Not supported dataprovider name: {providerName}");
            }
        }
    }
}
