using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StudentRegistration
{
    public partial class StudentDetails : Form
    {
        public StudentDetails()
        {
            InitializeComponent();
        }

        BusinessLaye.StudentDetails objStudentDetails = new BusinessLaye.StudentDetails();

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            StudentReg subForm = new StudentReg();
            subForm.Show();
        }

     

      

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            LoadFormData();                     
        }

        private void LoadFormData()
        {
            try
            {
                objStudentDetails.MaxId = objStudentDetails.BGetMaxSTDNo();
                objStudentDetails.StuentGridData = new DataTable();

                objStudentDetails.StuentGridData = objStudentDetails.BLoadGridData();
                dataGridViewStudentDetails.DataSource = objStudentDetails.StuentGridData;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int dbMaxSTDNo = objStudentDetails.BGetMaxSTDNo();
                DataView dv = new DataView(objStudentDetails.StuentGridData);
                dv.RowFilter = "STD_NO >  " + dbMaxSTDNo;
                DataTable dt = new DataTable();
                dt = dv.ToTable();

                int i = objStudentDetails.BBulkInsert(dt);

                if (i == 0)
                {
                    MessageBox.Show("Not Saved Successfully");
                }
                else
                {
                    FormClean();
                    LoadFormData();
                    MessageBox.Show("Saved Successfully");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void FormClean()
        {
            objStudentDetails.StuentGridData.Rows.Clear();
            objStudentDetails.MaxId = objStudentDetails.BGetMaxSTDNo();
        }

      
    }
}
