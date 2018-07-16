using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain;
using Abp.Domain.Entities;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeptManage.HR
{
    /// <summary>
    /// 部门员工
    /// </summary>
    [Table("Employee",Schema ="DeptManage")]
    public class Employee:Entity<Guid>
    {
        /// <summary>
        /// 员工编号
        /// </summary>
        [DisplayName("员工编号")]
        [Column("员工编号")]
        public virtual int EmployeeCode { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        [DisplayName("姓名")]
        [Column("姓名")]
        public virtual String Name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        [DisplayName("性别")]
        [Column("性别")]
        public virtual String Gender { get; set; }
        /// <summary>
        /// 年龄
        /// </summary>
        [DisplayName("年龄")]
        [Column("年龄")]
        public virtual int Age { get; set; }
        /// <summary>
        /// 出生年月
        /// </summary>
        [DisplayName("出生年月")]
        [Column("出生年月")]
        public virtual DateTime Birthdate { get; set; }
        /// <summary>
        /// 人员状态
        /// </summary>
        [DisplayName("人员状态")]
        [Column("人员状态")]
        public virtual DeptManageConsts.EmployeeStatus Status { get; set; }

        /// <summary>
        /// 员工对象转换成字符串
        /// </summary>
        /// <returns>员工姓名</returns>
        public override string ToString()
        {
            return this.Name;
        }
    }
}
