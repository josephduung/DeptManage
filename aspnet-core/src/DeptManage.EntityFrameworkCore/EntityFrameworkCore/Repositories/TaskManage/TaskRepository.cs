using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Abp.EntityFrameworkCore;
using DeptManage.TaskManage;

namespace DeptManage.EntityFrameworkCore.Repositories
{
    public class TaskRepository : DeptManageRepositoryBase<Task, Guid>, ITaskRepository
    {
        public List<Task> SearchByName(string taskName)
        {
            if(DeptManageConsts.AssertNullOrEmpty(taskName))
            {
                var query = GetAll();

                query = query.Where(
                    task => task.TaskName.Contains(taskName)
                    );

                return query
                    .OrderBy(task => task.ScheduleFinish)
                    .ToList();
            }
            else
            {
                return new List<Task>();
            }
        }

        public List<Task> SearchByResponsiblePeople(string employeeName)
        {
            if(DeptManageConsts.AssertNullOrEmpty(employeeName))
            {
                var query = GetAll();

                query = query.Where(
                    task=>task.Responsible.Name==employeeName
                    );

                return query
                    .OrderBy(task => task.ScheduleFinish)
                    .ToList();
            }
            else
            {
                return new List<Task>();
            }
        }

        public List<Task> GetAllRunning()
        {
            var query = GetAll();

            query = query.Where(
                task => (
                    task.Status != DeptManageConsts.TaskStatus.Deleted &&
                    task.Status != DeptManageConsts.TaskStatus.Finished &&
                    task.Status != DeptManageConsts.TaskStatus.Teminated &&
                    task.Status != DeptManageConsts.TaskStatus.UnAssigned
                )
                );

            return query
                .OrderBy(task => task.ScheduleFinish)
                .ToList();
        }

        public TaskRepository(IDbContextProvider<DeptManageDbContext> provider)
            : base(provider)
        {

        }
    }
}
