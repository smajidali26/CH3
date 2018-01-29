using CH3.Core;
using CH3.Core.Data;
using CH3.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Data
{
    /// <summary>
    /// Entity Framework startup task
    /// </summary>
    public class EfStartUpTask : IStartupTask
    {
        /// <summary>
        /// Execute
        /// </summary>
        public void Execute()
        {
            var settings = EngineContext.Current.Resolve<DataSettings>();
            if (settings != null && settings.IsValid())
            {
                var provider = EngineContext.Current.Resolve<IDataProvider>();
                if (provider == null)
                    throw new CH3Exception("No IDataProvider found");
                provider.SetDatabaseInitializer();
            }
        }

        /// <summary>
        /// Gets order of this startup task implementation
        /// </summary>
        public int Order
        {
            //ensure that this task is run first 
            get { return -1000; }
        }
    }
}
