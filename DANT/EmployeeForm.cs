using System;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace DANT
{
    public partial class EmployeeForm : Form
    {
        string loginName;
        Appointment appointment = new Appointment();
        Check check = new Check();
        int doctorID;
        public EmployeeForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            updateTable();
            loadUserInfo();
            TableFilterCheck();
            TableFilterAppointment();
            MessageBox.Show(cbAppointment.Items.Count.ToString());
            if (cbAppointment.Items.Count == 0)
                btnCreateCheck.Enabled = false;
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
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных", "Ошибка");
                    return;
                }
                lbEmployeeName.Text = model.name + " " + model.surname;
                lbPosition.Text = model.Position.position1;
                doctorID = model.id;
            }
        }

        private void addCheck(object sender, EventArgs e)
        {
            check.appointment_id = Convert.ToInt32(cbAppointment.SelectedValue.ToString());
            check.check_status_id = 1;
            check.service_cost = Convert.ToInt32(txtServiceCost.Text.Trim());

            if (String.IsNullOrEmpty(cbAppointment.SelectedItem.ToString()) || String.IsNullOrEmpty(check.service_cost.ToString()))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            var regexNumberID = @"^[1-9]\d{0,7}$";

            if (!Regex.IsMatch(txtServiceCost.Text, regexNumberID))
            {
                MessageBox.Show("Стоимсоть должна состоять из цифр и иметь длинну не более 7 символов", "Ошибка"); return;
            }


            using (DANTDBEntities db = new DANTDBEntities())
            {
                Check model = (from u in db.Check
                                orderby u.number_check descending
                                select u).FirstOrDefault();
                check.number_check = model.number_check + 1;
                if (model == null)
                {
                    MessageBox.Show("Ошибка закрузки данных", "Ошибка");
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
            else
                return;
        }


        private void updateTable() 
        {
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
            this.dataTable1TableAdapter1.Fill(this.numberAppointment.DataTable1);
        }

        private void TableFilterClickAppointment(object sender, EventArgs e)
        {
            TableFilterAppointment();
        }
        //Функция вызывается при изменении даты или врача на странице обслужанных клиентов
        private void TableFilterClickCheck(object sender, EventArgs e)
        {
            TableFilterCheck();
        }

        private void TableFilterCheck()
        {
            var dateCheckSelected = new DateTime(dtCheck.Value.Year, dtCheck.Value.Month, dtCheck.Value.Day);
            checkListBindingSource.Filter = $"employee_id = '{doctorID}' and date = '{dateCheckSelected}' and check_status_id <> 6";
            this.dataTable1TableAdapter2.Fill(this.checkList.DataTable1);
        }
        //Функция заполняет таблицу записей и фильтрует загруженные данные по выбранной дате и доктору
        private void TableFilterAppointment()
        {
            var dateAppointmentSelected = new DateTime(dtAppointment.Value.Year, dtAppointment.Value.Month, dtAppointment.Value.Day);
            appointmentDataBindingSource.Filter = $"employee_id = '{doctorID}' and date = '{dateAppointmentSelected}' and status_id <> 6";
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
        }
        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
