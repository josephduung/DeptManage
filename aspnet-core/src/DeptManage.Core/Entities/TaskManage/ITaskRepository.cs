using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Repositories;

namespace DeptManage.TaskManage
{
    public interface ITaskRepository:IRepository<Task,Guid>
    {
        /// <summary>
        /// 通过任务名称模糊查询任务
        /// </summary>
        /// <param name="taskName">任务名称</param>
        /// <returns>任务清单</returns>
        List<Task> SearchByName(String taskName);
        /// <summary>
        /// 通过人名查询任务
        /// </summary>
        /// <param name="employeeName">员工姓名</param>
        /// <returns>任务清单</returns>
        List<Task> SearchByResponsiblePeople(String employeeName);
        /// <summary>
        /// 获取所有执行中任务清单
        /// </summary>
        /// <returns>任务清单</returns>
        List<Task> GetAllRunning();
    }
}
