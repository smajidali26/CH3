using CH3.Core.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CH3.Services.Tasks
{
    /// <summary>
    /// Represents task manager
    /// </summary>
    public partial class TaskManager
    {
        #region Consts

        /// <summary>
        /// Schedule task path
        /// </summary>
        public const string ScheduleTaskPath = "scheduletask/runtask";
        private const int _notRunTasksInterval = 60 * 30; //30 minutes

        #endregion

        #region Fields

        private readonly List<TaskThread> _taskThreads = new List<TaskThread>();

        #endregion

        #region Ctor

        private TaskManager()
        {
        }

        #endregion

        #region Methods

        /// <summary>
        /// Initializes the task manager
        /// </summary>
        public void Initialize()
        {
           
            
        }

        /// <summary>
        /// Starts the task manager
        /// </summary>
        public void Start()
        {
           
        }

        /// <summary>
        /// Stops the task manager
        /// </summary>
        public void Stop()
        {
            foreach (var taskThread in _taskThreads)
            {
                taskThread.Dispose();
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the task mamanger instance
        /// </summary>
        public static TaskManager Instance { get; } = new TaskManager();

        /// <summary>
        /// Gets a list of task threads of this task manager
        /// </summary>
        public IList<TaskThread> TaskThreads => new ReadOnlyCollection<TaskThread>(_taskThreads);

        #endregion
    }
}
