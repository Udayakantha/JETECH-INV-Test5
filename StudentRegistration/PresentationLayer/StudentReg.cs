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
    
    public partial class StudentReg : Form
    {
        BusinessLaye.StudentDetails objStudentDetails = new BusinessLaye.StudentDetails();
        
        public StudentReg()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') ||(e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1))
            {
                    e.Handled = true;
                
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }


        private void ClearForm()
        {
            textBoxStudentID.Text = "";
            textBoxName.Text = "";
            textBoxGPA.Text = "";
            dateTimePickerDOB.Value = DateTime.Today.Date;
            checkBoxActive.Checked = true;           
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                if (!InputValidate())
                {
                    return;
                }
                else
                {
                    DataAdd();
                }
               
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            finally
            {
                //this.Close();
            }
        }

        private void DataAdd()
        {
            try
            {
                DataRow dr = objStudentDetails.StuentGridData.NewRow();
              
                dr[0] = int.Parse(textBoxStudentID.Text.Trim());
                dr[1] = textBoxName.Text.Trim();
                dr[2] = DateTime.Parse(dateTimePickerDOB.Value.ToString());
                dr[3] = decimal.Parse(textBoxGPA.Text.Trim().ToString());
                dr[4] = checkBoxActive.Checked;

                objStudentDetails.StuentGridData.Rows.Add(dr);
            
            }
                 catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            finally
            {
                ClearForm();
                this.Close();
            } 
        }

        public Boolean InputValidate()
        { 
            if(textBoxName.Text.Trim() == string.Empty )
            {
                MessageBox.Show("Please Enter Name");
                return false;
            }
            else if (textBoxGPA.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Please Enter GPA");
                return false;
            }
            else
            {
                return true;
            }
            
        }

        private void StudentReg_Load(object sender, EventArgs e)
        {
            objStudentDetails.MaxId++;
            textBoxStudentID.Text = objStudentDetails.MaxId.ToString();
        }

    }
}
