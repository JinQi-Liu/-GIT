using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.Service.DAO.Auth
{
    public class AuthGroupEmployeeInfoDAO
    {
        public DataTable GetAllEmployee()
        {
            string sql = @"SELECT [ID]
                              ,[Name]
                          FROM[WMP].[dbo].[HR_EmployeeInfo]";
            return SqlHelper.ExecuteDataset(SqlHelper.configuration, CommandType.Text, sql).Tables[0];
        }
    }
}
