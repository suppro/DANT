using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DANT
{
    public partial class ManageForm : Form
    {
        string loginName;
        Client client = new Client();
        Appointment appointment = new Appointment();
        Employee employee = new Employee();
        public ManageForm (string loginName)
        {
            InitializeComponent();
            this.loginName = loginName;
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

        private void ManageForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "employeeListData.DataTable1". При необходимости она может быть перемещена или удалена.
            this.dataTable1TableAdapter.Fill(this.employeeListData.DataTable1);
            loadUserInfo();
        }
    }
}
