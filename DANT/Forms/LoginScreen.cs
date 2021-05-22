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
using System.Security.Cryptography;
using DANT.Model;

namespace DANT
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        private String getHash(String text)
        {
            byte[] hashenc, bytes = Encoding.ASCII.GetBytes(text);
            String result = "";

            using (MD5 md5 = new MD5CryptoServiceProvider())
            {
                hashenc = md5.ComputeHash(bytes);
                foreach (var b in hashenc)
                    result += b.ToString("x2");
            }

            return result;
        }
        private void loginUser(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string password = txtPassword.Text;

            if (String.IsNullOrEmpty(login) || login.Equals("Логин"))
            {
                MessageBox.Show("Не введен логин", "Информация"); return;
            }
            else if (String.IsNullOrEmpty(password) || password.Equals("Пароль"))
            {
                MessageBox.Show("Не введен пароль", "Информация"); return;
            }

            password = getHash(getHash(password));

            Employee employee;
            bool userAuth = false;
            using (DANTDBEntities db = new DANTDBEntities())
            {
                employee = db.Employee.FirstOrDefault(u => u.login == login && u.password == password);
                if (employee != null)
                {
                    userAuth = true;
                }
            }
            if (!userAuth)
            {
                MessageBox.Show("Неправильный логин или пароль"); return;
            }
            else
            {
                if (employee.position_id == 1) 
                {
                    this.Visible = false;
                    AdminForm userForm = new AdminForm(login);
                    userForm.Show();
                }
                else
                {
                    this.Visible = false;
                    EmployeeForm employeeForm = new EmployeeForm(login);
                    employeeForm.Show();
                }
            }
        }

        private void closeApp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
