using System;
using System.Data;
using System.Data.SqlClient;

namespace PC_STORE
{
    class CheckClass
    {
        public int CheckId(string str_Id)//בדיקה אם התז תקין
        {
            int sum = 0, num;
            for (int i = 0; i < str_Id.Length - 1; i++)
            {
                if (i % 2 == 0)
                    sum += int.Parse(str_Id[i].ToString());

                else
                {
                    num = int.Parse(str_Id[i].ToString()) * 2;
                    sum += Sum_Dig(num);
                }
            }
            sum += int.Parse(str_Id[str_Id.Length - 1].ToString());
            if (sum % 10 != 0)
                return 0;
            return 1;
        }
        public int Sum_Dig(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n % 10;
                n /= 10;
            }
            return sum;
        }

        public bool IsValidEmail(string email)//בדיקה אם האימייל תקין
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        public string DailyIncome()//הכנסה יומית של החנות
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            DateTime today = DateTime.Today;
            parameters[0] = new SqlParameter("@date", SqlDbType.Date)
            {
                Value = today
            };

            DataTable tab = db.GetData("spr_get_daily_income", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין מכירות";
            return tab.Rows[0]["TOTAL_AMOUNT"].ToString();
        }

        public DataTable DailyChart()//עשר המוצרים הכי נמכרים היום
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            DateTime today = DateTime.Today;
            parameters[0] = new SqlParameter("@date", SqlDbType.DateTime)
            {
                Value = today.ToString("yyyy/MM/dd")
            };
            DataTable tab = db.GetData("spr_daily_chart", parameters);
            db.CloseConnection();
            return tab;
        }

        public string MonthlyIncome()//הכנסה חודשית של החנות
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];

            if (DateTime.Now.Day > 1 && DateTime.Now.Day < 10)
            {
                DateTime monthstart = new DateTime();
                //check if the month of the year is january, if yes we can't do -1.
                if (DateTime.Now.Month == 1)
                    monthstart = new DateTime(DateTime.Now.Year, 12, 10);
                else
                    monthstart = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 10);

                parameters[0] = new SqlParameter("@date", SqlDbType.Date)
                {
                    Value = monthstart
                };
            }
            else
            {
                DateTime monthstart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
                parameters[0] = new SqlParameter("@date", SqlDbType.Date)
                {
                    Value = monthstart
                };
            }
            DataTable tab = db.GetData("spr_get_monthly_income", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין מכירות";
            return tab.Rows[0]["TOTAL_AMOUNT"].ToString();
        }

        public DataTable MonthlyChart()//עשר המוצרים הכי נמכרים החודש
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];

            if (DateTime.Now.Day > 1 && DateTime.Now.Day < 10)
            {
                DateTime monthstart = new DateTime();
                //check if the month of the year is january, if yes we can't do -1.
                if (DateTime.Now.Month == 1)
                    monthstart = new DateTime(DateTime.Now.Year, 12, 10);
                else
                    monthstart = new DateTime(DateTime.Now.Year, DateTime.Now.Month - 1, 10);

                parameters[0] = new SqlParameter("@date", SqlDbType.Date)
                {
                    Value = monthstart
                };
            }
            else
            {
                DateTime monthstart = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 10);
                parameters[0] = new SqlParameter("@date", SqlDbType.Date)
                {
                    Value = monthstart
                };
            }
            DataTable tab = db.GetData("spr_monthly_chart", parameters);
            db.CloseConnection();
            return tab;
        }

        public string YearlyIncome()//הכנסה שנתית של החנות
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            DateTime year = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            parameters[0] = new SqlParameter("@date", SqlDbType.Date)
            {
                Value = year
            };

            DataTable tab = db.GetData("spr_get_yearly_income", parameters);
            db.CloseConnection();
            if (tab.Rows.Count == 0)
                return "אין מכירות";
            return tab.Rows[0]["TOTAL_AMOUNT"].ToString();
        }

        public DataTable YearlyChart()//עשר המוצרים הכי נמכרים השנה
        {
            DB db = new DB();
            SqlParameter[] parameters = new SqlParameter[1];
            DateTime year = new DateTime(DateTime.Now.Year - 1, DateTime.Now.Month, DateTime.Now.Day);
            parameters[0] = new SqlParameter("@date", SqlDbType.Date)
            {
                Value = year
            };

            DataTable tab = db.GetData("spr_yearly_chart", parameters);
            db.CloseConnection();
            return tab;
        }


    }
}
