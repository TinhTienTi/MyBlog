using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using System.Configuration;
namespace BlogSpot.Models.DB
{
    public class DBConst
    {
        public static string linkDBBlogSpot = ConfigurationManager.ConnectionStrings["dbBlogSpot"].ToString();
        private const string DbBlogSpot = "BlogSpot.dbo.";
        // Lấy thông tin.
        public static string GetInfoUsers = DbBlogSpot + "GetInfoUsers";
    }
}