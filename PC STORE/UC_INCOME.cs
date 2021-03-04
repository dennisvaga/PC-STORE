
using System.Data;
using System.Windows.Forms;

namespace PC_STORE
{
    public partial class UC_INCOME : UserControl
    {
        public UC_INCOME()
        {
            InitializeComponent();
        }

        public void UC_INCOME_Load(object sender, System.EventArgs e)
        {
            ChartLoad();
        }
        //טעינת הגרפים והתוויות של ההכנסות
        private void ChartLoad()
        {
            CheckClass check = new CheckClass();
            LBL_DAILY_IN.Text = "₪ " + check.DailyIncome();//הכנסה יומית של החנות
            LBL_MONTHLY_IN.Text = "₪ " + check.MonthlyIncome();//הכנסה חודשית של החנות
            LBL_YEARLY_IN.Text = "₪ " + check.YearlyIncome();//הכנסה שנתית של החנות


            //-----------------------גרף של כמות מוצרים יומית----------------------------------------
            DataTable tab_daily_chart = check.DailyChart();

            foreach (var series in DailyChart.Series)//מאפס את הגרף
                series.Points.Clear();

            DailyChart.DataSource = tab_daily_chart;

            for (int i = 0; i < tab_daily_chart.Rows.Count; i++)
                DailyChart.Series["כמות"].Points.AddXY(tab_daily_chart.Rows[i][0].ToString(), tab_daily_chart.Rows[i][1].ToString());

            //-----------------------גרף של כמות מוצרים חודשית----------------------------------------
            DataTable tab_month_chart = check.MonthlyChart();

            foreach (var series in MontlyChart.Series)//מאפס את הגרף
                series.Points.Clear();

            MontlyChart.DataSource = tab_month_chart;

            for (int i = 0; i < tab_month_chart.Rows.Count; i++)
                MontlyChart.Series["כמות"].Points.AddXY(tab_month_chart.Rows[i][0].ToString(), tab_month_chart.Rows[i][1].ToString());

            //-----------------------גרף של כמות מוצרים שנתית----------------------------------------
            DataTable tab_yearly_chart = check.YearlyChart();

            foreach (var series in YearlyChart.Series)//מאפס את הגרף
                series.Points.Clear();

            YearlyChart.DataSource = tab_yearly_chart;

            for (int i = 0; i < tab_yearly_chart.Rows.Count; i++)
                YearlyChart.Series["כמות"].Points.AddXY(tab_yearly_chart.Rows[i][0].ToString(), tab_yearly_chart.Rows[i][1].ToString());

        }
        //כפתור לעידכון הנתונים
        private void BTN_UPDATE_Click(object sender, System.EventArgs e)
        {
            ChartLoad();
        }
    }
}
