using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DBapplication
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();


        }

      
        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }
        public int Insertpatient(string fname, string mint, string Lname, int ssn, DateTime Bdata, string gender,int phonenumber,string username,string password)
        {
            string query = "INSERT INTO patient (fname, mint, lname, SSN,DOB,phone_number,gender,username,password) " +
                            "Values ('" + fname + "','" + mint + "','" + Lname + "','" + ssn + "','" + Bdata + "','" + phonenumber + "','" + gender + "','" + username + "','" + password +  "');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insertappointment(string st, string end, int clinicid,int ssn,string day)
        {
            string query = "INSERT INTO appointment(starttime,endtime,clinic_id,patient_ssn,day) values ('"+st+"','"+end+"','"+clinicid+"','"+ssn+"','"+day+"');";
            return dbMan.ExecuteNonQuery(query);
        }
        public int Insertcare(int docid,int passn)
        {
            string query = "INSERT INTO care(Doctor_id,patient_ssn) values ('" + docid + "','" + passn + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDepname()
        {
            string query = "SELECT Dname FROM DeparTment ;";
            return dbMan.ExecuteReader(query);
        }
        public string SelectDepartfromdoc(int id)
        {
            string query = "select d.Dname from Department d,Doctor e where d.Dnumber=e.DNO and e.id="+2+";";
            return dbMan.Executestring(query);
        }
        public DataTable Selectdoc(int ssn)
        {
            string query = "select d.name from Doctor d , care c where c.Doctor_id=d.id and c.patient_ssn="+ssn+";";
            return dbMan.ExecuteReader(query);
        }
        public DataTable updaterate(int r,int did,int pssn)
        {
            string query = "update care set rate='"+r+"' where patient_ssn='"+pssn+"'and Doctor_id= '"+did+"';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectdocname(string d)
        {
            string query = "SELECT name FROM doctor, DeparTment where DNO=Dnumber and Dname= '" + d + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selecttopratedoctor()
        {
            string query = "SELECT d.name as 'Doctor Name',e.Dname as 'specialization', AVG(rate) as 'rate'  FROM Department e,doctor d ,care c where e.Dnumber=d.DNO and c.Doctor_id=d.id  group by d.name,e.Dname order by avg(rate) desc ;";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectschadul(string name)
        {
            string query = "SELECT starttime,endtime,day FROM doctor d,schedule s where s.doctor_id=d.id and d.name='" + name + "';";
            return dbMan.ExecuteReader(query);
        }
        public DataTable Selectappointment(string name)
        {
            string query = "SELECT a.starttime,a.endtime,a.day FROM doctor d,clinic c, appointment a where c.doctor_id=d.id and a.clinic_id=c.id and d.name='" + name + "';";
            return dbMan.ExecuteReader(query);
        }
        public int Selectclinicid(string name)
        {
            string query = "SELECT c.id FROM doctor d,clinic c where c.doctor_id=d.id and d.name='" + name + "';";
            return (int)dbMan.ExecuteScalar(query);
        }
        public int Selectdocid(string name)
        {
            string query = "SELECT d.id  FROM doctor d where d.name='" + name + "';";
            return (int)dbMan.ExecuteScalar(query);
        }

    }
}
