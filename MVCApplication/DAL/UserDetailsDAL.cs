using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using MVCApplication.Models;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MVCApplication.DAL
{
    public class UserDetailsDAL
    {
        private IConfiguration _config;
        public UserDetailsDAL(IConfiguration config)
        {
            _config = config;
        }
        public List<User> GetUserDetailsByUserId(string userId)
        {
            var users = new List<User>();
            SqlConnection objConn = new SqlConnection(_config["NovartisOPARConnection"]);
            objConn.Open();
            SqlCommand objCmd = new SqlCommand("select u.UserId, u.username, u.email, u.phone, uo.OparId from [User] u inner join UserOpar uo on u.UserId = uo.UserId where  u.UserId = @userid", objConn);
            objCmd.Parameters.AddWithValue("@userid", userId);
            SqlDataReader objDR = objCmd.ExecuteReader();
            while (objDR.Read())
            {
                var user = new User();
                user.UserId = Convert.ToInt32(objDR["UserId"]);
                user.UserName = Convert.ToString(objDR["username"]);
                user.EMail = Convert.ToString(objDR["email"]);
                user.Phone = Convert.ToString(objDR["Phone"]);
                user.OparId = Convert.ToInt32(objDR["OparId"]);
                users.Add(user);
            }
            return users;
        }
        //Stop doing undo
        public void ExportToExcel(ControllerBase controller, string userId)
        {
            List<User> userDetails = GetUserDetailsByUserId(userId);
            var stream = new MemoryStream();
            using (var package = new ExcelPackage(stream))
            {
                var workSheet = package.Workbook.Worksheets.Add("Sheet1");
                workSheet.Cells.LoadFromCollection(userDetails, true);
                var val = workSheet.Cells.Value;
                package.Save();
                stream = new MemoryStream(package.GetAsByteArray());
            }
            //stream.Position = 0;
            string excelName = $"UserDetails_As_On_{DateTime.Now.ToString("yyyy_MMM_dd_HH_mm_ss_fff")}.xlsx";
            FileStreamResult fs = controller.File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", excelName);
            using (var fileStream = File.Create(@"C:\data\" + excelName))
            {
                var fileStreamResult = (FileStreamResult)fs;
                fileStreamResult.FileStream.Seek(0, SeekOrigin.Begin);
                fileStreamResult.FileStream.CopyTo(fileStream);
                fileStreamResult.FileStream.Seek(0, SeekOrigin.Begin);
            }

        }
    }
}
