using CH3.Core.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CH3.Core.Domain;

namespace CH3.Services.Installation
{
    /// <summary>
    /// Code first installation service
    /// </summary>
    public partial class CodeFirstInstallationService : IInstallationService
    {
        #region Fields

        private readonly IRepository<UserLogin> _userLoginRepository;

        #endregion

        #region Ctor

        public CodeFirstInstallationService(IRepository<UserLogin> userLoginRepository)
        {
            this._userLoginRepository = userLoginRepository;
        }

        #endregion

        #region Utilities
        

        protected virtual void InstallUserLogin()
        {
            var userLogin = new UserLogin
            {
                Username = "admin",
                Password = "123",
                PasswordHash = "assss",
                CreatedBy =1,
                CreatedDate = DateTime.Now,
                Active = true,
                IsDeleted=false
                
            };

            _userLoginRepository.Insert(userLogin);
        }
        
        #endregion

        #region Methods

        /// <summary>
        /// Install data
        /// </summary>
        /// <param name="defaultUserEmail">Default user email</param>
        /// <param name="defaultUserPassword">Default user password</param>
        /// <param name="installSampleData">A value indicating whether to install sample data</param>
        public virtual void InstallData(string defaultUserEmail,
            string defaultUserPassword, bool installSampleData = true)
        {
            InstallUserLogin();
        }

        #endregion
    }
}
