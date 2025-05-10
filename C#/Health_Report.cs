using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Farm_Management_System
{
    public partial class Health_Report : Form
    {
        public Health_Report()
        {
            InitializeComponent();
        }
        HealthReportClass hc = new HealthReportClass();

        private void ReportList_DGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                int row_index = e.RowIndex;

                txbx_reportID.Text = ReportList_DGV.Rows[row_index].Cells[0].Value.ToString();
                combx_cattle.Text = ReportList_DGV.Rows[row_index].Cells[1].Value.ToString();
                txbx_even.Text = ReportList_DGV.Rows[row_index].Cells[2].Value.ToString();
                txbx_diagnosis.Text = ReportList_DGV.Rows[row_index].Cells[3].Value.ToString();
                report_date.Text = ReportList_DGV.Rows[row_index].Cells[4].Value.ToString();
                txbx_treatment.Text = ReportList_DGV.Rows[row_index].Cells[5].Value.ToString();
                txbx_vat_name.Text = ReportList_DGV.Rows[row_index].Cells[6].Value.ToString();
                txbx_treat_cost.Text = ReportList_DGV.Rows[row_index].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            { 

            
            }
            finally
            {

            }

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            try
            {
                hc.Cattle_Type = combx_cattle.Text;
                hc.even = txbx_even.Text;
                hc.diagnosis = txbx_diagnosis.Text;
                hc.reportdate = report_date.Value.ToString();
                hc.treatment = txbx_treatment.Text;
                hc.vatname = txbx_vat_name.Text;
                hc.costtreatment = float.Parse(txbx_treat_cost.Text);

                bool success = hc.Insert(hc);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Inserted!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Insertion failed!");
                }


                DataTable dt = hc.Select();
                ReportList_DGV.DataSource = dt;

            }
            catch(Exception)
            {
                MessageBox.Show("Missing Information");
            }
            finally
            {

            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            try
            {
                hc.Cattle_Type = combx_cattle.Text;
                hc.even = txbx_even.Text;
                hc.diagnosis = txbx_diagnosis.Text;
                hc.reportdate = report_date.Value.ToString();
                hc.treatment = txbx_treatment.Text;
                hc.vatname = txbx_vat_name.Text;
                hc.costtreatment = float.Parse(txbx_treat_cost.Text);

                bool success = hc.Update(hc);

                if (success == true)
                {
                    MessageBox.Show("Successfully data Update!");
                    Clear();
                }
                else
                {
                    MessageBox.Show("Data Update failed!");
                }


                DataTable dt = hc.Select();
                ReportList_DGV.DataSource = dt;


            }
            catch(Exception)
            {

            }

        }
        public void Clear()
        {
            combx_cattle.Text = null;
            txbx_reportID.Text = null;
            txbx_even.Text = null;
            txbx_diagnosis.Text = null;
            txbx_treatment.Text = null;
            txbx_vat_name.Text = null;
            txbx_treat_cost.Text = null;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btn_show_Click(object sender, EventArgs e)
        {
            DataTable dt = hc.Select();
            ReportList_DGV.DataSource = dt;
        }

        private void txbx_search_TextChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("");

            string query = "Select * from ReportTBL where ID like '%" + txbx_search.Text + "%' ";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            ReportList_DGV.DataSource = dt;
        }
    }
}
