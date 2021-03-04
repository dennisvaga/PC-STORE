using System.Data.SqlClient;
using System.Data;
using System;

namespace PC_STORE
{
    class Employees
    {
        public DataTable GetEmployee()//מושך את כל העובדים
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_employee", null);
            db.CloseConnection();
            return tab;
        }
        //מכניס עובד לטבלה
        public void InsertEmployee(int id, string username, string firstname, string lastname, string password, string tel, string email)
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@id", SqlDbType.Int),
                new SqlParameter("@username", SqlDbType.VarChar, 20),
                new SqlParameter("@first_name", SqlDbType.VarChar, 50),
                new SqlParameter("@last_name", SqlDbType.VarChar, 50),
                new SqlParameter("@pass", SqlDbType.VarChar, 20),
                new SqlParameter("@tel", SqlDbType.VarChar, 20),
                new SqlParameter("@email", SqlDbType.VarChar, 20)
            };
            parameters[0].Value = id;
            parameters[1].Value = username;
            parameters[2].Value = firstname;
            parameters[3].Value = lastname;
            parameters[4].Value = password;
            parameters[5].Value = tel;
            parameters[6].Value = email;

            db.SetData("spr_insert_employee", parameters);
            db.CloseConnection();
        }
        //מעדכן עובד
        public void UpdateEmployee(string username, string firstname, string lastname, string password, string tel, string email, int uid)
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@username", SqlDbType.VarChar, 20),
                new SqlParameter("@first_name", SqlDbType.VarChar, 50),
                new SqlParameter("@last_name", SqlDbType.VarChar, 50),
                new SqlParameter("@pass", SqlDbType.VarChar, 20),
                new SqlParameter("@tel", SqlDbType.VarChar, 20),
                new SqlParameter("@email", SqlDbType.VarChar, 20),
                new SqlParameter("@id", SqlDbType.Int)
            };
            parameters[0].Value = username;
            parameters[1].Value = firstname;
            parameters[2].Value = lastname;
            parameters[3].Value = password;
            parameters[4].Value = tel;
            parameters[5].Value = email;
            parameters[6].Value = uid;

            db.SetData("spr_update_employee", parameters);
            db.CloseConnection();
        }

        public void DeleteEmployee(int emp_id)//מוחק את העובד
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = emp_id
            };
            db.SetData("spr_delete_employee", parameters);
            db.CloseConnection();
        }

        public void InsertEmployeeStartShift(int workerid, DateTime startshift)//מכניס תחילת משמרת של העובד
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@workerid", SqlDbType.Int),
                new SqlParameter("@startshift", SqlDbType.DateTime)
            };
            parameters[0].Value = workerid;
            parameters[1].Value = startshift;
    
            db.SetData("spr_insert_startshift", parameters);
            db.CloseConnection();
        }

        public void InsertEmployeeEndShift(int shiftid, DateTime endshift)//מכניס סוף משמרת של העובד
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters =
            {
                new SqlParameter("@endshift", SqlDbType.DateTime),
                new SqlParameter("@shiftid", SqlDbType.Int)
            };
            parameters[0].Value = shiftid;
            parameters[1].Value = endshift;
           
            db.SetData("spr_insert_endshift", parameters);
            db.CloseConnection();
        }

        public int GetEmployeeLastEnterShiftID(int emp_id)//מושך את הקוד משמרת של העובד שעבד אחרון
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = emp_id
            };
            DataTable tab = db.GetData("spr_get_employee_last_entershiftID", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return 0;
            return Convert.ToInt32(tab.Rows[0][0]);
        }

        public DateTime GetEmployeeLastEnterShiftDate(int emp_id)//מחפש את התאריך האחרון שהעובד עבד
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = emp_id
            };
            DataTable tab = db.GetData("spr_get_employee_last_entershift_date", parameters);
            db.CloseConnection();

            if (tab.Rows.Count == 0)
                return DateTime.Parse("1999-10-05 11:09:59.733");
            return DateTime.Parse(tab.Rows[0][0].ToString()); 
        }

        public DataTable GetEmployeeShiftsFromDateToDate
            (int employee_id, string fromdate, string todate)//מחפש את המשמרות של העובד מתאריך לתאריך
        {
            DB db = new DB();
            SqlParameter[] parameters =
            {
                new SqlParameter("@employee_id", SqlDbType.Int),
                new SqlParameter("@fromdate", SqlDbType.VarChar,50),
                new SqlParameter("@todate", SqlDbType.VarChar,50)
            };
            parameters[0].Value = employee_id;
            parameters[1].Value = fromdate;
            parameters[2].Value = todate;

            DataTable tab = db.GetData("spr_get_employe_shifts_from_date_to_date", parameters);
            db.CloseConnection();
            return tab;
        }

        public DataTable GetLastEnterEmployee()//מחפש את העובד שנכנס אחרון
        {
            DB db = new DB();
            DataTable tab = db.GetData("spr_get_last_enter_employee", null);
            db.CloseConnection();
            return tab;
        }

        public string GetEmployeeSellsCount(int emp_id)//מושך את הכמות מכירות של העובד הכללית
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = emp_id
            };
            DataTable tab = db.GetData("spr_get_employee_sells_count", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין מכירות";
            return tab.Rows[0][1].ToString();
        }
        //מושך את הכמות מכירות של העובד החודשית
        public string GetEmployeeSellsMonthCount(int employee_id, string fromdate, string todate)
        {
            DB db = new DB();
            SqlParameter[] parameters =
            {
                new SqlParameter("@employee_id", SqlDbType.Int),
                new SqlParameter("@fromdate", SqlDbType.VarChar, 50),
                new SqlParameter("@todate", SqlDbType.VarChar, 50)
            };
            parameters[0].Value = employee_id;
            parameters[1].Value = fromdate;
            parameters[2].Value = todate;

            DataTable tab = db.GetData("spr_get_employee_sells_month_count", parameters);
            db.CloseConnection();

            if (tab.Rows.Count == 0)
                return "אין מכירות";
            return tab.Rows[0][1].ToString();

        }

        public string GetEmployeeLastSellDate(int emp_id)//בודק את התאריך מכירה אחרון של העובד
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = emp_id
            };
            DataTable tab = db.GetData("spr_get_employee_last_sell_date", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין מכירות";
            return tab.Rows[0][0].ToString();
        }

        public void ChangeIdWhenDelEmp(int Id)//משנה את התז בפרטי הזמנה מהעובד שמחקנו למנהל
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = Id
            };
            db.SetData("spr_change_id_when_del_emp", parameters);
            db.CloseConnection();
        }

        public void BackupDeletedEmployee(int Id)//מגבה את העובד שמחקנו
        {
            DB db = new DB();
            db.OpenConnection();
            SqlParameter[] parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@id", SqlDbType.Int)
            {
                Value = Id
            };
            db.SetData("spr_backup_del_emp", parameters);
            db.CloseConnection();
        }



    }
}
