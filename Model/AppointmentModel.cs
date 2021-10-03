using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital_Information_Management_System.Model
{
    class AppointmentModel
    {
        public string A_ID { get; set; }
        public string U_ID { get; set; }
        public string CREATED_BY { get; set; }
        public string M_ID { get; set; }
        public string STATUS { get; set; }
        public string APPROVED_BY { get; set; }
        public string REASON { get; set; }
        public string App_No { get; set; }
        public DateTime Date { get; set; }
    }
}
