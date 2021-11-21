using CyberSecChallenge.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CyberSecChallenge.Dal
{
  class DalGeneric
  {
    protected readonly SqlConnection con;

    public DalGeneric()
    {
      con = new SqlConnection(ControlConnectionString.Retornar());
    }

    public int InsertEntity(string query)
    {
        try
        {
          con.Open();

          SqlCommand cmd = new SqlCommand(query, con);

          return Convert.ToInt32(cmd.ExecuteScalar());
        }
        finally
        {
          con.Close();
        }
    }

    public void GetEntity(string query, Action<SqlDataReader> treatmentQuery)
    {

      try
      {
        con.Open();
        SqlCommand cmd = new SqlCommand(query, con);
        SqlDataReader data = cmd.ExecuteReader();
        treatmentQuery(data);
        data.Close();

      }
      finally
      {
        con.Close();
      }

    }
  }
}
