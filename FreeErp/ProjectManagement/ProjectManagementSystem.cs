using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FreeErp.ProjectManagement
{
    enum TaskType
    {
        NORMAL,MILESTONE
    }

    class ProjectManagementSystem
    {

    }

    class Project
    {
        public Task task { get; set; }

    }

    class Task
    {
        public int Duration { set; get; }
        public DateTime EarlyStart { get; set; }
        public DateTime EarlyFinish { get; set; }
        public DateTime LateStart { get; set; }
        public DateTime LateFinish { get; set; }
        public List<Task> Subtasks { get; set; }
        public TaskType taskType { get; set; }
    }

}
