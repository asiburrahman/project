using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAL
{
    class BaseClass
    {
        protected string Error;

        public string _Error
        {
            get { return Error; }
        }

        protected SqlConnection ConnectionInSql = new SqlConnection("Data Source=localhost;Initial Catalog=Blood_Bank;Integrated Security=True");

        protected bool Connection()
        {
            if (DataReader != null && !DataReader.IsClosed)
                DataReader.Close();

            if (ConnectionInSql.State == ConnectionState.Open)
                return true;

            try
            {
                ConnectionInSql.Open();
                return true;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }

            return false;
        }

        protected bool ExecuteNq(SqlCommand command)
        {
            if (!Connection())
                return false;
            try
            {
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {

                Error = ex.Message;
            }
            return false;
        }

        protected SqlCommand DataBaseHide { get; set; }

        protected SqlCommand CommandBuilder(string sql)
        {
            SqlCommand command = new SqlCommand();
            command.Connection = ConnectionInSql;
            command.CommandText = sql;
            return command;
        }

        public string Search { get; set; }
        public SqlDataReader DataReader { get; set; }
        protected DataSet ExicuteDataSet(SqlCommand command)
        {
            if (!Connection())
                return null;

            SqlDataAdapter dataAdd = new SqlDataAdapter(command);
            DataSet dataSet = new DataSet();
            dataAdd.Fill(dataSet);
            return dataSet;
        }
    }
}
