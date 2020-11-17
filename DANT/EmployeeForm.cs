using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;

namespace DANT
{
    public partial class EmployeeForm : Form
    {
        string loginName;
        Appointment appointment = new Appointment();
        Check check = new Check();
        public EmployeeForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            updateTable();
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            lbDate.Text = Convert.ToString(DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
            using (DANTDBEntities db = new DANTDBEntities())
            {

                Employee model = (from u in db.Employee
                                  join q in db.Position on u.position_id equals q.id
                                  where u.login == loginName
                                  select u).FirstOrDefault();
                lbEmployeeName.Text = model.name + " " + model.surname;
                lbPosition.Text = model.Position.position1;
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                    return;
                }
            }
        }

        private void addCheck(object sender, EventArgs e)
        {
            check.appointment_id = Convert.ToInt32(cbClient.SelectedValue.ToString());
            check.check_status_id = 1;
            check.service_cost = Convert.ToInt32(txtServiceCost.Text.Trim());


            if (String.IsNullOrEmpty(check.appointment_id.ToString()) || String.IsNullOrEmpty(check.service_cost.ToString()))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                Check model = (from u in db.Check
                                orderby u.number_check descending
                                select u).FirstOrDefault();
                check.number_check = model.number_check + 1;
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                    return;
                }
            }

            if (MessageBox.Show("Создать чек? Детали чека изменить нельзя", "Создать чек", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    db.Check.Add(check);
                    db.SaveChanges();
                }
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                appointment = db.Appointment.Where(x => x.id == check.appointment_id).FirstOrDefault();
                appointment.status_id = 4;
                db.Entry(appointment).State = EntityState.Modified;
                db.SaveChanges();
            }

            txtServiceCost.Text = "";
            appointment.id = 0;
            updateTable();
            MessageBox.Show("Данные успешно добавлены");
        }

        private void updateTable() 
        {
            this.dataTable1TableAdapter2.Fill(this.checkList2.DataTable1);
            this.dataTable1TableAdapter1.Fill(this.numberAppointment.DataTable1);
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
        }
    }
}
