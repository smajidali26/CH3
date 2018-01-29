using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH3.Data.Mapping
{
    public partial class CH3EntityTypeConfiguration<T> : EntityTypeConfiguration<T> where T : class
    {
        /// <summary>
        /// Ctor
        /// </summary>
        protected CH3EntityTypeConfiguration()
        {
            PostInitialize();
        }

        /// <summary>
        /// Developers can override this method in custom partial classes
        /// in order to add some custom initialization code to constructors
        /// </summary>
        protected virtual void PostInitialize()
        {

        }
    }
}
