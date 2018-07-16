using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain;
using Abp.Domain.Repositories;
using Abp.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static DeptManage.DeptManageConsts;

namespace DeptManage.TaskManage
{
    /// <summary>
    /// 部门工作任务
    /// </summary>
    [Table("Task", Schema = "dbo")]
    public class Task : Entity<Guid>
    {
        /// <summary>
        /// 任务名称
        /// </summary>
        [DisplayName("任务名称")]
        [Column("TaskName")]
        public virtual string TaskName { get; set; }
        /// <summary>
        /// 任务编号
        /// </summary>
        [DisplayName("任务编号")]
        [Column("TaskID")]
        public virtual string TaskID { get; set; }
        /// <summary>
        /// 任务描述
        /// </summary>
        [DisplayName("内容")]
        [Column("Description")]
        public virtual string Description { get; set; }
        /// <summary>
        /// 工作步骤
        /// </summary>
        [DisplayName("步骤")]
        [Column("Steps")]
        public virtual string Steps { get; set; }
        /// <summary>
        /// 计划开始
        /// </summary>
        [DisplayName("计划开始")]
        [Column("ScheduleStart")]
        public virtual DateTime ScheduleStart { get; set; }
        /// <summary>
        /// 计划完成
        /// </summary>
        [DisplayName("计划完成")]
        [Column("ScheduleFinish")]
        public virtual DateTime ScheduleFinish { get; set; }
        /// <summary>
        /// 实际开始
        /// </summary>
        [DisplayName("实际开始")]
        [Column("RealStart")]
        public virtual DateTime RealStart { get; set; }
        /// <summary>
        /// 实际完成
        /// </summary>
        [DisplayName("实际完成")]
        [Column("RealFinish")]
        public virtual DateTime RealFinish { get; set; }
        /// <summary>
        /// 责任人
        /// </summary>
        [DisplayName("责任人")]
        [Column("Responsible")]
        public virtual HR.Employee Responsible { get; set; }
        /// <summary>
        /// 执行人
        /// </summary>
        [DisplayName("执行人")]
        [Column("Executor")]
        public virtual List<HR.Employee> Executor { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        [DisplayName("备注")]
        [Column("Memo")]
        public virtual string Memo { get; set; }
        /// <summary>
        /// 任务状态
        /// </summary>
        [DisplayName("任务状态")]
        [Column("Status")]
        public virtual TaskStatus Status{get;set;}
    }
}
