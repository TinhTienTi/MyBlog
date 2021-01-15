using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Dapper;
using BlogSpot.Models.Parameters;
using System.Data;
using System.Data.SqlClient;

namespace BlogSpot.Models.DB
{
    public class Users 
    {
        public static List<PramUserInfo> GetInfo(ParamGet model)
        {
            using(IDbConnection conn = new SqlConnection(DBConst.linkDBBlogSpot))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                return conn.Query< PramUserInfo>
                   (
                        DBConst.GetInfoUsers, 
                        new { UserID = model.ID }, 
                        commandType: CommandType.StoredProcedure
                    ).ToList();
            }
        }
    }
}