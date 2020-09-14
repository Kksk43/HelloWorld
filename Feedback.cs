using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManage
{
    public partial class Feedback : Form
    {
        Dictionary<int, int> dicT = new Dictionary<int, int>();
        Dictionary<int, int> dicF = new Dictionary<int, int>();
        public Feedback()
        {
            InitializeComponent();
        }

        private void Feedback_Load(object sender, EventArgs e)
        {
            //设置窗体大小不能改变
            MaximizeBox = false;
            MinimizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;

            this.dvgFeedback.AutoGenerateColumns = false;
            this.dvgFeedback.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dvgFeedback.DefaultCellStyle.WrapMode = DataGridViewTriState.True;//自动换行
            this.dvgFeedback.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;//自动调整每行的高度

            DataSet ds = DataAccess.GetDataSetBySql("select *from feedback");
            dvgFeedback.DataSource = ds.Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex > dvgFeedback.Rows.Count - 2) return;
            if (e.ColumnIndex < 2) return;

            int t = Convert.ToInt32(dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
            int floor = Convert.ToInt32(dvgFeedback.Rows[e.RowIndex].Cells[0].Value);

            if (dicT.ContainsKey(floor)&&e.ColumnIndex == 2)
            {
                t--;
                dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = t;
                dicT.Remove(floor);
                DataAccess.UADDataTable($"update feedback set Fabulous={t} where Floor={floor}");
                return;
            }
            else if (dicF.ContainsKey(floor)&&e.ColumnIndex == 3)
            {
                t--;
                dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Black;
                dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = t;
                dicF.Remove(floor);
                DataAccess.UADDataTable($"update feedback set Stamp={t} where Floor={floor}");
                return;
            }
            else if (dicT.Count + dicT.Count == 20)
            {
                MessageBox.Show("可操作次数达上限！");
                return;
            }

            t++;
            dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.ForeColor = Color.Red;
            dvgFeedback.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = t;
            if (e.ColumnIndex == 2)
            {
                dicT.Add(floor, t);
                DataAccess.UADDataTable($"update feedback set Fabulous={t} where Floor={floor}");
            }
            else if (e.ColumnIndex == 3)
            {
                dicF.Add(floor, t);
                DataAccess.UADDataTable($"update feedback set Stamp={t} where Floor={floor}");
            }
        }
    }
}
