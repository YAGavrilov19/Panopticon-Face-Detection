using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FaceDetectionCamera
{
    public class DataAccessLayer
    {

        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LURBL7S\\SQLEXPRESS;Initial Catalog=Panopticon;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        public DataAccessLayer(){
            cmd.Connection = conn;
         
        }

        public void InsertData(string deviceName,  DateTime timeOfDetection, int roomNumber, int faces)
        {
            DateTime time = timeOfDetection;
            string format = "yyyy-MM-dd HH:mm:ss";
            string query = "INSERT INTO CCTVCurrentData VALUES('" + deviceName + "'," + roomNumber + "," + faces + ",'" + time.ToString(format) + "')";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteById(int idToDelete)
        {
            string query = "DELETE CCTVCurrentData WHERE Id=" + idToDelete;
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void DeleteAll()
        {
            string query = "DELETE FROM CCTVCurrentData";
            cmd.CommandText = query;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void UpdateById(int id, string cctvId, int roomNumber, int currentPeople)
        {
            DateTime time = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "UPDATE CCTVCurrentData SET CCTVId='" + cctvId + "',RoomNumber=" + roomNumber + ",CurrentPeople=" + currentPeople + ", DetectionDateTime='" + time.ToString(format) + "' WHERE Id=" + id;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable DisplayData()
        {
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM CCTVCurrentData";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }
}
