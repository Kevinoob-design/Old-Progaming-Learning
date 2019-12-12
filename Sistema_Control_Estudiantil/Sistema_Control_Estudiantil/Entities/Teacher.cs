using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Control_Estudiantil.Entities
{

    //Teacher_ID varstring(7)
    //Name varstring(MAX)
    //Last_Name varstring(MAX)
    //Date_Of_Admission string
    //Primary_Number varstring(11)
    //Secondary_Number varstring(11)
    //Contact_Email varstring(MAX)

    public class Teacher
    {
        private string      _Teacher_ID             { get;  set; }
        private string      _Name                   { get;  set; }
        private string      _Last_Name              { get;  set; }
        private string    _Date_Of_Admission      { get;  set; }
        private string      _Primary_Number         { get;  set; }
        private string      _Secondary_Number       { get;  set; }
        private string      _Contact_Email          { get;  set; }
        private string    _Date_Of_Birth          { get; set; }
        private string         _Place_Of_Birth         { get; set; }
        private string         _Document_ID            { get; set; }
        private string        _Gender                 { get; set; }
        private string         _Addrress_ID            { get; set; }

        public string      Teacher_ID               { get { return _Teacher_ID; }}
        public string      Name                     { get { return _Name; }}
        public string      Last_Name                { get { return _Last_Name; }}
        public string    Date_Of_Admission        { get { return _Date_Of_Admission; }}
        public string      Primary_Number           { get { return _Primary_Number; }}
        public string      Secondary_Number         { get { return _Secondary_Number; }}
        public string      Contact_Email            { get { return _Contact_Email; }}
        public  string   Date_Of_Birth            { get { return _Date_Of_Birth; } }
        public string         Place_Of_Birth           { get { return _Place_Of_Birth; } }
        public string         Document_ID              { get { return _Document_ID; } }
        public string        Gender                   { get { return _Gender; } }
        public string         Addrress_ID              { get { return _Addrress_ID; } }

        public Teacher(string ID, string name, string last_Name,
            string DoA, string pNumber, string sNumber,
            string eMail, string DOB, string POB, string documentID, string G, string address)
        {
            _Teacher_ID             =   ID;
            _Name                   =   name;
            _Last_Name              =   last_Name;
            _Date_Of_Admission      =   DoA;
            _Primary_Number         =   pNumber;
            _Secondary_Number       =   sNumber;   
            _Contact_Email          =   eMail;
            _Date_Of_Birth          =   DOB;
            _Place_Of_Birth         =   POB;
            _Document_ID            =   documentID;
            _Gender                 =   G;
            _Addrress_ID            =   address;
        }
    }
}
