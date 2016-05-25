using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SummonManager
{
    public partial class fTimeInDeptPieChartStat : Form
    {
        public fTimeInDeptPieChartStat()
        {
            InitializeComponent();
            
        }
        Color[] myPieColors = { Color.Red, Color.Black, Color.Blue, Color.Green, 
                                Color.DarkOrchid, Color.Pink, Color.Aqua,Color.Lime ,
                                Color.Yellow, Color.Orange, Color.Teal, Color.Magenta};


        public void DrawPieChartOnForm()
        {
            DBSummon dbs = new DBSummon();
            DataTable t = dbs.GetPieChart(dateTimePicker1.Value, dateTimePicker2.Value);



            //Take Total 11 Values & Draw Chart Of These Values.
            double[] myPiePercent = new double[t.Rows.Count];
            string[] text = new string[t.Rows.Count];
            double ts_sum = 0;
            foreach (DataRow r in t.Rows)
            {
                ts_sum += (int)r["ts"];
            }
            int i = 0;
            foreach (DataRow r in t.Rows)
            {
                text[i] = r["sts"].ToString();
                myPiePercent[i++] = double.Parse(r["ts"].ToString()) * 100 / ts_sum;
            }
            label4.Text = text[0] + " - "+myPiePercent[0].ToString("0.00") + "%";
            label5.Text = text[1] + " - " + myPiePercent[1].ToString("0.00") + "%";
            label6.Text = text[2] + " - " + myPiePercent[2].ToString("0.00") + "%";
            label7.Text = text[3] + " - " + myPiePercent[3].ToString("0.00") + "%";
            label8.Text = text[4] + " - " + myPiePercent[4].ToString("0.00") + "%";
            label9.Text = text[5] + " - " + myPiePercent[5].ToString("0.00") + "%";
            label10.Text = text[6] + " - " + myPiePercent[6].ToString("0.00") + "%";
            label11.Text = text[7] + " - " + myPiePercent[7].ToString("0.00") + "%";
            label12.Text = text[8] + " - " + myPiePercent[8].ToString("0.00") + "%";
            label13.Text = text[9] + " - " + myPiePercent[9].ToString("0.00") + "%";
            label14.Text = text[10] + " - " + myPiePercent[10].ToString("0.00") + "%";
            label15.Text = text[11] + " - " + myPiePercent[11].ToString("0.00") + "%";
            //Новое
            //Подготовка (к производству)
            //ПДБ. В работе
            //Скомпановано (производство)
            //Изготовление (цех)
            //Возвращено из цеха
            //ОТК
            //Рекламация
            //Коммерческий отдел
            //Готово к отгрузке
            //Отгружается
            //Монтажники



            //Take Colors To Display Pie In That Colors Of Taken Five Values.

            using (Graphics myPieGraphic = this.CreateGraphics())
            {
                //Give Location Which Will Display Chart At That Location.
                Point myPieLocation = new Point(10, 150);

                //Set Here Size Of The ChartÃ¢â‚¬Â¦
                Size myPieSize = new Size(500, 500);

                //Call Function Which Will Draw Pie of Values.
                DrawPieChart(myPiePercent, myPieColors, myPieGraphic, myPieLocation, myPieSize);
            }
        }


        // Draws a pie chart.
        public void DrawPieChart(double[] myPiePerecents, Color[] myPieColors, Graphics myPieGraphic, Point
      myPieLocation, Size myPieSize)
        {
            //Check if sections add up to 100.
            double sum = 0;
            foreach (double percent_loopVariable in myPiePerecents)
            {
                sum += percent_loopVariable;
            }

            if (sum != 100)
            {
               // MessageBox.Show("Sum Do Not Add Up To 100.");
            }

            //Check Here Number Of Values & Colors Are Same Or Not.They Must Be Same.
            if (myPiePerecents.Length != myPieColors.Length)
            {
                MessageBox.Show("There Must Be The Same Number Of Percents And Colors.");
            }

            double PiePercentTotal = 0;
            for (int PiePercents = 0; PiePercents < myPiePerecents.Length; PiePercents++)
            {
                using (SolidBrush brush = new SolidBrush(myPieColors[PiePercents]))
                {

                    //Here it Will Convert Each Value Into 360, So Total Into 360 & Then It Will Draw A Full Pie Chart.
                    myPieGraphic.FillPie(brush, new Rectangle(myPieLocation, myPieSize), Convert.ToSingle(PiePercentTotal * 360 / 100), Convert.ToSingle(myPiePerecents[PiePercents] * 360 / 100));
                }

                PiePercentTotal += myPiePerecents[PiePercents];
            }
            return;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            DrawPieChartOnForm();
        }

        private void fTimeInDeptPieChartStat_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today;
        }
    }
}
