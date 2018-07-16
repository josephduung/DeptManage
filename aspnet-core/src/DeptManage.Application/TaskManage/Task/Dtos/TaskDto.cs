using System;
using System.Collections.Generic;
using System.Text;
using Abp.Application.Services.Dto;

namespace DeptManage.TaskManage.Dtos
{
    public class TaskDto : EntityDto<Guid>
    {
        public string TaskName { get; set; }
        public string TaskID { get; set; }
        public string Description { get; set; }
        public string Steps { get; set; }
        public DateTime ScheduleStart { get; set; }
        public DateTime ScheduleFinish { get; set; }
        public DateTime RealStart { get; set; }
        public DateTime RealFinish { get; set; }
        public HR.Employee Responsible { get; set; }
        public List<HR.Employee> Executor { get; set; }
        public string Memo { get; set; }
        public DeptManageConsts.TaskStatus Status { get; set; }

        public override string ToString()
        {
            string result = string.Empty;

            result = string.Format(
                "任务ID={0},任务名称={1},计划完成={2},责任人={3},状态={4}",
                TaskID,
                TaskName,
                ScheduleFinish.ToLongDateString(),
                Responsible.Name,
                Status.ToString()
                );

            return result;
        }
    }
}
