using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DANT
{
    public partial class AdminForm : Form
    {
        string loginName;
        Client client = new Client();
        Appointment appointment = new Appointment();
        Check check = new Check();
        public AdminForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            UpdateTable();
            loadUserInfo();
            TableFilterAppointment();
            TableFilterCheck();
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

        private void AddClient(object sender, EventArgs e)
        {
            client.surname = txtClientSurname.Text.Trim();
            client.name = txtClientName.Text.Trim();
            client.patronymic = txtClientPatronymic.Text.Trim();
            client.phone = txtClientPhone.Text.Trim();
            if (String.IsNullOrEmpty(client.surname) || String.IsNullOrEmpty(client.name) || String.IsNullOrEmpty(client.patronymic) || String.IsNullOrEmpty(client.phone))
            {
                MessageBox.Show("Все поля должны быть заполненны"); 
                return;
            }
            if (client.id == 0)
            {
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    if (client.id != 0) 
                    {
                        Client model = (from u in db.Client
                                        orderby u.card_number descending
                                        select u).FirstOrDefault();
                        client.card_number = model.card_number + 1;
                        if (model == null)
                        {
                            MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                            return;
                        }
                    }
                    else
                        client.card_number = 100000;
                }
            }
            else
                client.card_number = Convert.ToInt32(txtNumberCard.Text.Trim());

            using (DANTDBEntities db = new DANTDBEntities())
            {
                if (client.id == 0)
                    db.Client.Add(client);
                else
                    db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
            txtClientName.Text = txtClientSurname.Text = txtClientPatronymic.Text = txtClientPhone.Text = "";
            client.id = 0;
            this.clientTableAdapter.Fill(this.clientData.Client);
            MessageBox.Show("Данные успешно добавлены");
        }

        private void selectClient(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                client.id = Convert.ToInt32(dgvClient.CurrentRow.Cells["idDataGridViewTextBoxColumn"].Value);
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    client = db.Client.Where(x => x.id == client.id).FirstOrDefault();
                    if (client == null)
                    {
                        MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                        return;
                    }
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                    txtClientPhone.Text = client.phone;
                    txtNumberCard.Text = client.card_number.ToString();
                }
                btnClient.Text = "Обновить запись";
            }
        }

        private void AddAppointment(object sender, EventArgs e)
        {
            DateTime dateAppointment = new DateTime(dtDateAppointment.Value.Year, dtDateAppointment.Value.Month, dtDateAppointment.Value.Day);
            appointment.client_id = Convert.ToInt32(txtClientID.Text.Trim());
            appointment.employee_id = Convert.ToInt32(cmbDoctorName.SelectedValue.ToString());
            appointment.date = dtDateAppointment.Value.Date;
            appointment.time_id = Convert.ToInt32(cbTime.SelectedValue);

            if (String.IsNullOrEmpty(appointment.client_id.ToString()) || String.IsNullOrEmpty(appointment.employee_id.ToString()) || String.IsNullOrEmpty(appointment.date.ToString()) || String.IsNullOrEmpty(appointment.time_id.ToString()))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                Appointment model = (from u in db.Appointment
                               orderby u.number_appointment descending
                               select u).FirstOrDefault();
                if (model == null)
                {
                    appointment.number_appointment = 510000;
                }
                else
                    appointment.number_appointment = model.number_appointment + 1;
            }

            if (appointment.id == 0)
                if (!VerificationForm(dateAppointment))
                    return;


            using (DANTDBEntities db = new DANTDBEntities())
            {
                if (appointment.id == 0)
                {
                    appointment.status_id = 1;
                    db.Appointment.Add(appointment);
                }
                else
                {
                    appointment.status_id = Convert.ToInt32(cbAppointmentStatus.SelectedValue);
                    /*
                    if (appointment.status_id == 1)
                    {
                        MessageBox.Show("Нельзя поменять статус записи на 'Записан'","Ошибка"); return;
                    }
                    if (DateTime.Today < dateAppointment && appointment.status_id == 2)
                    {
                        MessageBox.Show("Нельзя поменять статус записи на 'Явился на прием' до такого как наступит дата приема ", "Ошибка"); return;
                    }
                    if (DateTime.Today < dateAppointment && appointment.status_id == 3)
                    {
                        MessageBox.Show("Нельзя поменять статус записи на 'Не явился на прием' до такого как наступит дата приема ", "Ошибка"); return;
                    }
                    */
                    db.Entry(appointment).State = EntityState.Modified;
                }
                db.SaveChanges();
            }
            
            txtClientID.Text = cmbDoctorName.Text = dtDateAppointment.Text = cbTime.Text = "";
            appointment.id = 0;
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
            MessageBox.Show("Данные успешно добавлены");
            ClearAppointment();
        }

        private void SelectAppointment(object sender, EventArgs e)
        {
            if (dgvClient.CurrentRow.Index != -1)
            {
                appointment.id = Convert.ToInt32(dgvAppointment.CurrentRow.Cells["idDataGridViewTextBoxColumn1"].Value);
                txtClientID.Enabled = false;
                cmbDoctorName.Enabled = false;
                dtDateAppointment.Enabled = false;
                cbTime.Enabled = false;
                cbAppointmentStatus.Enabled = true;
                btnDeleteAppointment.Enabled = true;
                btnClearAppointment.Enabled = true;
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    appointment = db.Appointment.Where(x => x.id == appointment.id).FirstOrDefault();
                    if (appointment == null)
                    {
                        MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                        return;
                    }
                    cbAppointmentStatus.SelectedValue = appointment.status_id;
                    txtClientID.Text = appointment.client_id.ToString();
                    cmbDoctorName.SelectedValue = appointment.employee_id;
                    dtDateAppointment.Value = appointment.date;
                    cbTime.SelectedValue = appointment.time_id;
                }
                btnAppointment.Text = "Обновить запись";
            }
        }
        private void DeleteAppointment(object sender, EventArgs e)
        {
            if (MessageBox.Show("Удалить эту запись?", "Удаление", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    var entry = db.Entry(appointment);
                    if (entry.State == EntityState.Detached)
                        db.Appointment.Attach(appointment);
                    db.Appointment.Remove(appointment);
                    db.SaveChanges();
                    this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
                    ClearAppointment();
                    MessageBox.Show("Удаление прошло успешно");
                }
            }
            btnDeleteAppointment.Enabled = false;
        }
        private void ChangeCheck(object sender, EventArgs e)
        {
            check.check_status_id = 2;
            using (DANTDBEntities db = new DANTDBEntities())
            {
                db.Entry(check).State = EntityState.Modified;
                db.SaveChanges();
            }
            btnChangeCheck.Enabled = false;
            UpdateTable();
        }
        private void SelectCheck(object sender, EventArgs e)
        {
            if (dgvCheckList.CurrentRow.Index != -1)
            {
                check.id = Convert.ToInt32(dgvCheckList.CurrentRow.Cells["idDataGridViewTextBoxColumn3"].Value);
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    check = db.Check.Where(x => x.id == check.id).FirstOrDefault();
                    if (check == null)
                    {
                        MessageBox.Show("Ошибка закрузки данных пользователя", "Ошибка");
                        return;
                    }
                }
                btnChangeCheck.Enabled = true;
            }
        }

        private void ClearAppontmentClick(object sender, EventArgs e)
        {
            ClearAppointment();
        }
        private void ClearAppointment()
        {
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
            txtClientID.Text = cmbDoctorName.Text = dtDateAppointment.Text = cbTime.Text = "";
            txtClientID.Enabled = true;
            cmbDoctorName.Enabled = true;
            dtDateAppointment.Enabled = true;
            cbTime.Enabled = true;
            cbAppointmentStatus.Enabled = false;
            btnClearAppointment.Enabled = false;
            btnDeleteAppointment.Enabled = false;
            btnAppointment.Text = "Добавить запись";
            appointment.id = 0;
        }

        private void TableFilterClickAppointment(object sender, EventArgs e)
        {
            TableFilterAppointment();
        }
        private void TableFilterClickCheck(object sender, EventArgs e)
        {
            TableFilterCheck();
        }
        private void TableFilterCheck()
        {
            var doctorCheckSelected = Convert.ToInt32(cmbAppointmentDoctor.SelectedValue);
            var dateCheckSelected = new DateTime(dtAppointment.Value.Year, dtAppointment.Value.Month, dtAppointment.Value.Day);
            checkListBindingSource.Filter = $"employee_id = '{doctorCheckSelected}' and date = '{dateCheckSelected}'";
            this.dataTable1TableAdapter2.Fill(this.checkList.DataTable1);
        }
        private void TableFilterAppointment()
        {
            var doctorAppointmentSelected = Convert.ToInt32(cmbAppointmentDoctor.SelectedValue);
            var dateAppointmentSelected = new DateTime(dtAppointment.Value.Year, dtAppointment.Value.Month, dtAppointment.Value.Day);
            appointmentDataBindingSource.Filter = $"employee_id = '{doctorAppointmentSelected}' and date = '{dateAppointmentSelected}'";
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
        }
        private void UpdateTable()
        {
            this.employeeTableAdapter.Fill(this.employeeData.Employee);
            this.dataTable1TableAdapter1.Fill(this.appointmentDoctorData.DataTable1);
            this.appointmentStatusTableAdapter.Fill(this.appointmentStatusData.AppointmentStatus);
            this.employeeTableAdapter1.Fill(this.checkDoctorData.Employee);
            this.dataTable1TableAdapter2.Fill(this.checkList.DataTable1);
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
            this.clientTableAdapter.Fill(this.clientData.Client);
            this.timetableTableAdapter.Fill(this.timeData.Timetable);
        }
        private bool VerificationForm(DateTime dateAppointment)
        {
            
            DateTime dt = DateTime.Today;
            DateTime datePosibleAppointment = new DateTime(dt.Year, dt.Month + 1, dt.Day);

            if (dateAppointment <= DateTime.Today)
            {
                MessageBox.Show("Записать пациента возможно только на следующие дни от текущей даты", "Ошибка"); return false;
            }
            if (dateAppointment > datePosibleAppointment)
            {
                MessageBox.Show("Записать пациента возможно только не более чем на месяц вперед", "Ошибка"); return false;
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                Appointment model = (from u in db.Appointment
                                     where u.date == appointment.date && u.time_id == appointment.time_id && u.employee_id == appointment.employee_id
                                     select u).FirstOrDefault();
                if (model != null)
                {
                    MessageBox.Show("Нельзя записать пациента на одну дату, время и врача более одно раза", "Ошибка");
                    return false;
                }
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                Appointment model = (from u in db.Appointment
                                     where u.date == appointment.date && u.time_id == appointment.time_id
                                     select u).FirstOrDefault();
                if (model != null)
                {
                    MessageBox.Show("Нельзя записать пациента на одну дату и время более одно раза", "Ошибка");
                    return false;
                }
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                Appointment model = (from u in db.Appointment
                                     where u.date == appointment.date && u.time_id == appointment.time_id
                                     select u).FirstOrDefault();
                if (model != null)
                {
                    MessageBox.Show("Нельзя записать пациента на одну дату и время более одно раза", "Ошибка");
                    return false;
                }
            }
            return true;
        }
    }   
}
