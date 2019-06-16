using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    class Doner : BaseClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BloodGroup { get; set; }
        public string FbId { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public DateTime LastDonate { get; set; }


        public bool Insert()
        {
            DataBaseHide = CommandBuilder(@"insert into Donar (name, blood_group, fb_id, mobile, address, last_donate)
                                        values(@name, @blood_group, @fb_id, @mobile, @address, @last_donate)");
            DataBaseHide.Parameters.AddWithValue("@name", Name);
            DataBaseHide.Parameters.AddWithValue("@blood_group", BloodGroup);
            DataBaseHide.Parameters.AddWithValue("@fb_id", FbId);
            DataBaseHide.Parameters.AddWithValue("@mobile", Mobile);
            DataBaseHide.Parameters.AddWithValue("@address", Address);
            DataBaseHide.Parameters.AddWithValue("@last_donate", LastDonate);
            return ExecuteNq(DataBaseHide);
        }

        public bool Delete(string ids = "")
        {
            if (ids == "")
            {
                DataBaseHide = CommandBuilder(@"delete from Donar where id = @id");
                DataBaseHide.Parameters.AddWithValue("@id", Id);
            }
            else
            {
                DataBaseHide = CommandBuilder(@"delete from Donar where id in (" + ids + ")");
            }
            return ExecuteNq(DataBaseHide);
        }

        public bool Update()
        {
            DataBaseHide = CommandBuilder(@"update Donar set name = @name, 
                                          blood_group = @blood_group, 
                                          fb_id = @fb_id, 
                                          mobile = @mobile,
                                          address = @address,
                                          last_donate = @last_donate
                                          where id = @id");
            DataBaseHide.Parameters.AddWithValue("@id", Id);
            DataBaseHide.Parameters.AddWithValue("@name", Name);
            DataBaseHide.Parameters.AddWithValue("@blood_group", BloodGroup);
            DataBaseHide.Parameters.AddWithValue("@fb_id", FbId);
            DataBaseHide.Parameters.AddWithValue("@mobile", Mobile);
            DataBaseHide.Parameters.AddWithValue("@address", Address);
            DataBaseHide.Parameters.AddWithValue("@last_donate", LastDonate);
            return ExecuteNq(DataBaseHide);
        }

        public bool SelectById()
        {
            DataBaseHide = CommandBuilder(@"select id, name, blood_group, fb_id, mobile, address, last_donate from Donar where id = @id");
            DataBaseHide.Parameters.AddWithValue("@id", Id);

            if (!Connection())
                return false;

            DataReader = DataBaseHide.ExecuteReader();
            while (DataReader.Read())
            {
                Id = Convert.ToInt32(DataReader["id"]);
                Name = DataReader["name"].ToString();
                BloodGroup = DataReader["blood_group"].ToString();
                FbId = DataReader["fb_id"].ToString();
                Mobile = DataReader["mobile"].ToString();
                Address = DataReader["address"].ToString();
                LastDonate = Convert.ToDateTime(DataReader["last_donate"]);
                return true; 
            }
            return false;
            
        }

        public DataSet Select()
        {
            DataBaseHide = CommandBuilder(@"select id, name, blood_group, fb_id, mobile, address, last_donate from Donar");
            if (!string.IsNullOrEmpty(Search))
            {
                DataBaseHide.CommandText += " where Donar.name like @search or " +
                                            "Donar.blood_group like @search or " +
                                            "Donar.fb_id like @search or " +
                                            "Donar.mobile like @search or " +
                                            "donar.address like @search";
                DataBaseHide.Parameters.AddWithValue("@search", "%" + Search + "%");
            }
            return ExicuteDataSet(DataBaseHide);
        }
    }
}
