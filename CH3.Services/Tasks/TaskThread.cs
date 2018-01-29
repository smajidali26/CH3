using CH3.Core.Infrastructure;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CH3.Services.Tasks
{
    /// <summary>
    /// Represents task thread
    /// </summary>
    public partial class TaskThread : IDisposable
    {
        #region Fields

        private Timer _timer;
        private bool _disposed;
        private readonly Dictionary<string, string> _tasks;
        private static readonly string _scheduleTaskUrl;

        #endregion

        #region Ctors

        

        internal TaskThread()
        {
            this._tasks = new Dictionary<string, string>();
            this.Seconds = 10 * 60;
        }

        #endregion

        #region Utilities

        
        #endregion

        #region Methods

        /// <summary>
        /// Disposes the instance
        /// </summary>
        public void Dispose()
        {
            if (_timer != null && !_disposed)
            {
                lock (this)
                {
                    _timer.Dispose();
                    _timer = null;
                    _disposed = true;
                }
            }
        }

        /// <summary>
        /// Inits a timer
        /// </summary>
       

        

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the interval in seconds at which to run the tasks
        /// </summary>
        public int Seconds { get; set; }

        /// <summary>
        /// Get or sets a datetime when thread has been started
        /// </summary>
        public DateTime StartedUtc { get; private set; }

        /// <summary>
        /// Get or sets a value indicating whether thread is running
        /// </summary>
        public bool IsRunning { get; private set; }

        /// <summary>
        /// Gets the interval (in milliseconds) at which to run the task
        /// </summary>
        public int Interval
        {
            get
            {
                //if somebody entered more than "2147483" seconds, then an exception could be thrown (exceeds int.MaxValue)
                var interval = Seconds * 1000;
                if (interval <= 0)
                    interval = int.MaxValue;
                return interval;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the thread would be run only once (on application start)
        /// </summary>
        public bool RunOnlyOnce { get; set; }

        #endregion
    }
}
