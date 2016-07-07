using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace JobBoard
{
    public partial class formJobs : Form
    {
        public formJobs()
        {
            InitializeComponent();
        }
        private void formJobs_Load(object sender, EventArgs e)
        {
            
            if (!File.Exists(ConfigurationManager.AppSettings.Get("database_path")))
            {
                MessageBox.Show("Database not found! Please update application settings.", "Job Board", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                Application.Exit();
            }
            dataJobs_UpdateRefresh();
            // Floormatting
            dataJobs.Columns["ArtifactID"].Visible = false;
            dataJobs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void dataJobs_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            string database_path = ConfigurationManager.AppSettings.Get("database_path");
            var conn = new SQLiteConnection("Data Source=" + database_path + ";Version=3;");
            try
            {
                conn.Open();
                using (SQLiteCommand command = new SQLiteCommand(conn))
                {
                    command.CommandText =
                        "update Jobs set " + dataJobs.Columns[e.ColumnIndex].Name + " = @status where ArtifactID = @artifactid";
                    
                    command.Parameters.Add(new SQLiteParameter("@status", dataJobs.Rows[e.RowIndex].Cells[dataJobs.Columns[e.ColumnIndex].Name].Value.ToString()));
                    command.Parameters.Add(new SQLiteParameter("@artifactid", e.RowIndex + 1));
                    command.ExecuteNonQuery();
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("{0} Exception caught.", ex);
            }



        }
        public void dataJobs_UpdateRefresh()
        {
            string database_path = ConfigurationManager.AppSettings.Get("database_path");
            if (File.Exists(database_path))
            {
                const string sql = "select * from Jobs;";
                var conn = new SQLiteConnection("Data Source=" + database_path + ";Version=3;");
                try
                {
                    conn.Open();
                    DataSet ds = new DataSet();
                    var da = new SQLiteDataAdapter(sql, conn);
                    da.Fill(ds);
                    dataJobs.DataSource = ds.Tables[0].DefaultView;
                    stripStatus_Label01.Text = "Last Updated: " + DateTime.Now;
                    conn.Close();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {
            if (toolStripSplitButton1.Text == "Refresh")
            {
                dataJobs_UpdateRefresh();
            }
        }

        private void secondsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Text = "30 seconds";
            timerRefresh.Interval = 30000;
            timerRefresh.Enabled = true;
            dataJobs_UpdateRefresh();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Text = "Refresh";
            timerRefresh.Enabled = false;
        }

        private void timerRefresh_Tick(object sender, EventArgs e)
        {
            dataJobs_UpdateRefresh();
        }

        private void secondsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Text = "5 seconds";
            timerRefresh.Interval = 5000;
            timerRefresh.Enabled = true;
            dataJobs_UpdateRefresh();
        }

        private void minuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Text = "1 minute";
            timerRefresh.Interval = 60000;
            timerRefresh.Enabled = true;
            dataJobs_UpdateRefresh();
        }

        private void minutesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripSplitButton1.Text = "5 minutes";
            timerRefresh.Interval = 300000;
            timerRefresh.Enabled = true;
            dataJobs_UpdateRefresh();
        }

        private void dataJobs_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
