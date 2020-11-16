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
        public AdminForm(string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appointmentData2.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.appointmentData2.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appointmentStatusData.AppointmentStatus". При необходимости она может быть перемещена или удалена.
            this.appointmentStatusTableAdapter.Fill(this.appointmentStatusData.AppointmentStatus);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appointmentData1.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.appointmentData1.DataTable1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "appointmentDoctorData.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter1.Fill(this.appointmentDoctorData.DataTable1);
            this.clientTableAdapter.Fill(this.clientData.Client);
            this.dataTable1TableAdapter.Fill(this.appointmentData.DataTable1);
            this.timetableTableAdapter.Fill(this.timeData.Timetable);
            this.employeeTableAdapter.Fill(this.employeeData.Employee);
            loadUserInfo();
        }

        private void loadUserInfo()
        {
            lbDate.Text = Convert.ToString(DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year);
            using (DANTDBEntities db = new DANTDBEntities())
            {

                Employee model = (from u in db.Employee
                                  join q in db.EmployeeStatus on u.position_id equals q.id
                                  where u.login == loginName
                                  select u).FirstOrDefault();
                lbEmployeeName.Text = model.name + " " + model.surname;
                lbPosition.Text = model.EmployeeStatus.position;
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
            client.email = txtClientEmail.Text.Trim();
            if (client.id == 1)
                client.card_number = 100000;
            else
                client.card_number = Convert.ToInt32(dgvClient[1, dgvClient.Rows.Count - 1].Value) + 1;
            if (String.IsNullOrEmpty(client.surname) || String.IsNullOrEmpty(client.name) || String.IsNullOrEmpty(client.patronymic) || String.IsNullOrEmpty(client.phone) || String.IsNullOrEmpty(client.email))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }

            using (DANTDBEntities db = new DANTDBEntities())
            {
                if (client.id == 0)
                    db.Client.Add(client);
                else
                    db.Entry(client).State = EntityState.Modified;
                db.SaveChanges();
            }
            txtClientName.Text = txtClientSurname.Text = txtClientPatronymic.Text = txtClientPhone.Text = txtClientEmail.Text = "";
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
                    txtClientName.Text = client.name;
                    txtClientSurname.Text = client.surname;
                    txtClientPatronymic.Text = client.patronymic;
                    txtClientPhone.Text = client.phone;
                    txtClientEmail.Text = client.email;
                }
                btnClient.Text = "Обновить запись";
            }
        }

        private void AddAppointment(object sender, EventArgs e)
        {
            appointment.client_id = Convert.ToInt32(txtClientID.Text.Trim());
            appointment.employee_id = Convert.ToInt32(cmbDoctorName.SelectedValue.ToString());
            appointment.date = dtDateAppointment.Value.Date;
            appointment.time_id = Convert.ToInt32(cbTime.SelectedValue);
            appointment.comment = "хэр";


            if (String.IsNullOrEmpty(appointment.client_id.ToString()) || String.IsNullOrEmpty(appointment.employee_id.ToString()) || String.IsNullOrEmpty(appointment.date.ToString()) || String.IsNullOrEmpty(appointment.time_id.ToString()))
            {
                MessageBox.Show("Все поля должны быть заполненны"); return;
            }
           
            using (DANTDBEntities db = new DANTDBEntities())
            {
                if (appointment.id == 0)
                {
                    appointment.status_id = 1;
                    db.Appointment.Add(appointment);
                }
                else
                    appointment.status_id = Convert.ToInt32(cbAppointmentStatus.SelectedValue);
                    db.Entry(appointment).State = EntityState.Modified;
                db.SaveChanges();
            }
            
            txtClientID.Text = cmbDoctorName.Text = dtDateAppointment.Text = cbTime.Text = "";
            appointment.id = 0;
            this.dataTable1TableAdapter.Fill(this.appointmentData2.DataTable1);
            MessageBox.Show("Данные успешно добавлены");  
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
                using (DANTDBEntities db = new DANTDBEntities())
                {
                    appointment = db.Appointment.Where(x => x.id == appointment.id).FirstOrDefault();
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
                    this.dataTable1TableAdapter.Fill(this.appointmentData2.DataTable1);
                    ClearAppointment();
                    MessageBox.Show("Удаление прошло успешно");
                }
            }
        }
        private void ClearAppontmentClick(object sender, EventArgs e)
        {
            ClearAppointment();
        }
        private void ClearAppointment()
        {
            txtClientID.Text = cmbDoctorName.Text = dtDateAppointment.Text = cbTime.Text = "";
            btnClearAppointment.Enabled = false;
            btnAppointment.Text = "Обновить запись";
            appointment.id = 0;
        }
    }   
}
