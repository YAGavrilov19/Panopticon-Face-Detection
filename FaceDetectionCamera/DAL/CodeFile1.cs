using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using FaceDetectionCamera;

namespace FaceDetectionCamera
{
    public class LogDataRepository
    {
        private readonly string connectionString = "Server=(local);Database=Panopticon;Integrated Security=true;";
        private Form1 _form;
        public LogDataRepository()
        {
            _form=new Form1();
        }
   
        public void SaveLogs(int selectedDeviceIndex, int facesDetected, List<int> logData)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string insertQuery = "INSERT INTO CCTV_Data (CCTV_ID, Current_People, CTime, Max_People_At_Last_Hour) " +
                    "VALUES (@CCTV_ID, @Current_People, @CTime, @Max_People_At_Last_Hour)";
                using (SqlCommand command = new SqlCommand(insertQuery, connection))
                {
                    foreach (var item in logData)
                    {
                        command.Parameters.Clear();
                        command.Parameters.AddWithValue("@CCTV_ID", _form.selectedDeviceIndex);
                        command.Parameters.AddWithValue("@Current_People", _form.facesDetected); 
                        command.Parameters.AddWithValue("@CTime", DateTime.Now);
                        command.Parameters.AddWithValue("@Max_People_At_Last_Hour", _form.maxFacesDetected);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
