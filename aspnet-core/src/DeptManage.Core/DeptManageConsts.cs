using System.ComponentModel;

namespace DeptManage
{
    public class DeptManageConsts
    {
        public const string LocalizationSourceName = "DeptManage";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;

        /// <summary>
        /// 员工状态/类型
        /// </summary>
        public enum EmployeeStatus
        {
            [Description("正式员工")]
            Employeed='A',
            [Description("江汉公司")]
            JiangHan='J',
            [Description("天元公司")]
            TianYuan='T',
            [Description("物业公司")]
            WuYe='W',
            [Description("退休")]
            Retired='B',
            [Description("中部人才")]
            AuxiliaryEmployment = 'H',
            [Description("离职")]
            Leave ='L'
        }

        /// <summary>
        /// 任务状态
        /// </summary>
        public enum TaskStatus
        {
            [Description("未安排")]
            UnAssigned='U',
            [Description("已安排")]
            Assigned='A',
            [Description("进行中")]
            Running='R',
            [Description("已完成")]
            Finished='F',
            [Description("已终止")]
            Teminated='T',
            [Description("已删除")]
            Deleted='D'
        }
        /// <summary>
        /// 检测空值
        /// </summary>
        /// <param name="inputStr">输入字符串</param>
        /// <returns>为空返回false，不为空返回true</returns>
        public static bool AssertNullOrEmpty(string inputStr)
        {
            bool result = true;

            if (inputStr is null || string.Empty == inputStr)
                result = false;

            return result;
        }
    }
}
