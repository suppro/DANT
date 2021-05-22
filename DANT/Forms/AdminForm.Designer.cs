using DANT.DataSets;
using DANT.DataSets.AdminForm;
using DANT.DataSets.DoctorForm;
using DANT.Model;

namespace DANT
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearClient = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumberCard = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnClient = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtClientSurname = new System.Windows.Forms.TextBox();
            this.txtClientName = new System.Windows.Forms.TextBox();
            this.txtClientPhone = new System.Windows.Forms.TextBox();
            this.txtClientPatronymic = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientDataBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.clientData = new DANT.DataSets.AdminForm.ClientData();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtAppointment = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClearAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.cbAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.appointmentStatusDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentStatusData = new DANT.DataSets.AdminForm.AppointmentStatusData();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.dtDateAppointment = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.timeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeData = new DANT.DataSets.AdminForm.TimeData();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.employeeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeData = new DANT.DataSets.AdminForm.EmployeeData();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAppointmentDoctor = new System.Windows.Forms.ComboBox();
            this.appointmentDoctorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDoctorData = new DANT.DataSets.AdminForm.AppointmentDoctorData();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.appointmentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dtCheck = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbCheckDoctor = new System.Windows.Forms.ComboBox();
            this.checkDoctorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkDoctorData = new DANT.DataSets.DoctorForm.CheckDoctorData();
            this.btnChangeCheck = new System.Windows.Forms.Button();
            this.dgvCheckList = new System.Windows.Forms.DataGridView();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbercheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicecostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkstatusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkList = new DANT.DataSets.DoctorForm.CheckList();
            this.timetableTableAdapter = new DANT.DataSets.AdminForm.TimeDataTableAdapters.TimetableTableAdapter();
            this.clientTableAdapter = new DANT.DataSets.AdminForm.ClientDataTableAdapters.ClientTableAdapter();
            this.dataTable1TableAdapter1 = new DANT.DataSets.AdminForm.AppointmentDoctorDataTableAdapters.DataTable1TableAdapter();
            this.appointmentStatusTableAdapter = new DANT.DataSets.AdminForm.AppointmentStatusDataTableAdapters.AppointmentStatusTableAdapter();
            this.employeeTableAdapter1 = new DANT.DataSets.DoctorForm.CheckDoctorDataTableAdapters.EmployeeTableAdapter();
            this.dataTable1TableAdapter2 = new DANT.DataSets.DoctorForm.CheckListTableAdapters.DataTable1TableAdapter();
            this.employeeTableAdapter = new DANT.DataSets.AdminForm.EmployeeDataTableAdapters.EmployeeTableAdapter();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 554);
            this.panel1.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(9, 162);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(203, 25);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "дата";
            this.lbDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(4, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сегодняшняя дата";
            // 
            // lbPosition
            // 
            this.lbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPosition.AutoSize = true;
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPosition.Location = new System.Drawing.Point(8, 105);
            this.lbPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(118, 25);
            this.lbPosition.TabIndex = 3;
            this.lbPosition.Text = "должность";
            this.lbPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(40, 80);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность:";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployeeName.Location = new System.Drawing.Point(990, 24);
            this.lbEmployeeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(51, 25);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "имя";
            this.lbEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сотрудника:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tabControl1.Location = new System.Drawing.Point(229, 96);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 443);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(241)))), ((int)(((byte)(108)))));
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dgvClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1068, 414);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить пациента";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(241)))), ((int)(((byte)(108)))));
            this.panel3.Controls.Add(this.btnClearClient);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtNumberCard);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.btnClient);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtClientSurname);
            this.panel3.Controls.Add(this.txtClientName);
            this.panel3.Controls.Add(this.txtClientPhone);
            this.panel3.Controls.Add(this.txtClientPatronymic);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 492);
            this.panel3.TabIndex = 24;
            // 
            // btnClearClient
            // 
            this.btnClearClient.Location = new System.Drawing.Point(4, 330);
            this.btnClearClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearClient.Name = "btnClearClient";
            this.btnClearClient.Size = new System.Drawing.Size(245, 28);
            this.btnClearClient.TabIndex = 44;
            this.btnClearClient.Text = "Отменить выбор";
            this.btnClearClient.UseVisualStyleBackColor = true;
            this.btnClearClient.Click += new System.EventHandler(this.ClearClientClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 239);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "Номер карты";
            // 
            // txtNumberCard
            // 
            this.txtNumberCard.Enabled = false;
            this.txtNumberCard.Location = new System.Drawing.Point(4, 258);
            this.txtNumberCard.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumberCard.Name = "txtNumberCard";
            this.txtNumberCard.Size = new System.Drawing.Size(244, 22);
            this.txtNumberCard.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(8, 4);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(241, 29);
            this.label7.TabIndex = 12;
            this.label7.Text = "Добавить пациента";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(4, 290);
            this.btnClient.Margin = new System.Windows.Forms.Padding(4);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(245, 32);
            this.btnClient.TabIndex = 11;
            this.btnClient.Text = "Добавить клиента";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.AddClient);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 47);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Фамилия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 191);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Телефон";
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(4, 66);
            this.txtClientSurname.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientSurname.MaxLength = 27;
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(244, 22);
            this.txtClientSurname.TabIndex = 14;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(4, 114);
            this.txtClientName.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientName.MaxLength = 27;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(244, 22);
            this.txtClientName.TabIndex = 15;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(4, 210);
            this.txtClientPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientPhone.MaxLength = 27;
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(244, 22);
            this.txtClientPhone.TabIndex = 19;
            // 
            // txtClientPatronymic
            // 
            this.txtClientPatronymic.Location = new System.Drawing.Point(4, 162);
            this.txtClientPatronymic.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientPatronymic.MaxLength = 27;
            this.txtClientPatronymic.Name = "txtClientPatronymic";
            this.txtClientPatronymic.Size = new System.Drawing.Size(244, 22);
            this.txtClientPatronymic.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Имя";
            // 
            // dgvClient
            // 
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.cardnumberDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn1,
            this.phoneDataGridViewTextBoxColumn1});
            this.dgvClient.DataSource = this.clientDataBindingSource1;
            this.dgvClient.Location = new System.Drawing.Point(275, 7);
            this.dgvClient.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.Size = new System.Drawing.Size(787, 478);
            this.dgvClient.TabIndex = 23;
            this.dgvClient.DoubleClick += new System.EventHandler(this.selectClient);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // cardnumberDataGridViewTextBoxColumn
            // 
            this.cardnumberDataGridViewTextBoxColumn.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardnumberDataGridViewTextBoxColumn.Name = "cardnumberDataGridViewTextBoxColumn";
            this.cardnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn1
            // 
            this.fioDataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn1.HeaderText = "ФИО пациента";
            this.fioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn1.Name = "fioDataGridViewTextBoxColumn1";
            this.fioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn1.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
            this.phoneDataGridViewTextBoxColumn1.Width = 125;
            // 
            // clientDataBindingSource1
            // 
            this.clientDataBindingSource1.DataMember = "Client";
            this.clientDataBindingSource1.DataSource = this.clientData;
            // 
            // clientData
            // 
            this.clientData.DataSetName = "ClientData";
            this.clientData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage3.Controls.Add(this.dtAppointment);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.cmbAppointmentDoctor);
            this.tabPage3.Controls.Add(this.dgvAppointment);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage3.Size = new System.Drawing.Size(1068, 414);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запись пациента";
            // 
            // dtAppointment
            // 
            this.dtAppointment.Location = new System.Drawing.Point(783, 17);
            this.dtAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Size = new System.Drawing.Size(244, 22);
            this.dtAppointment.TabIndex = 40;
            this.dtAppointment.ValueChanged += new System.EventHandler(this.TableFilterClickAppointment);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(696, 11);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 29);
            this.label16.TabIndex = 43;
            this.label16.Text = "Дата:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.OldLace;
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.btnClearAppointment);
            this.panel2.Controls.Add(this.btnDeleteAppointment);
            this.panel2.Controls.Add(this.cbAppointmentStatus);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.btnAppointment);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.txtClientID);
            this.panel2.Controls.Add(this.dtDateAppointment);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.cbTime);
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.cmbDoctorName);
            this.panel2.Controls.Add(this.label11);
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(-5, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 489);
            this.panel2.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 242);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 17);
            this.label17.TabIndex = 44;
            this.label17.Text = "Статус записи";
            // 
            // btnClearAppointment
            // 
            this.btnClearAppointment.Location = new System.Drawing.Point(11, 372);
            this.btnClearAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnClearAppointment.Name = "btnClearAppointment";
            this.btnClearAppointment.Size = new System.Drawing.Size(245, 28);
            this.btnClearAppointment.TabIndex = 43;
            this.btnClearAppointment.Text = "Отменить выбор";
            this.btnClearAppointment.UseVisualStyleBackColor = true;
            this.btnClearAppointment.Click += new System.EventHandler(this.ClearAppontmentClick);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Enabled = false;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(11, 335);
            this.btnDeleteAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(245, 28);
            this.btnDeleteAppointment.TabIndex = 42;
            this.btnDeleteAppointment.Text = "Удалить запись";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.DeleteAppointment);
            // 
            // cbAppointmentStatus
            // 
            this.cbAppointmentStatus.DataSource = this.appointmentStatusDataBindingSource;
            this.cbAppointmentStatus.DisplayMember = "status_appointment";
            this.cbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppointmentStatus.Enabled = false;
            this.cbAppointmentStatus.FormattingEnabled = true;
            this.cbAppointmentStatus.Location = new System.Drawing.Point(11, 262);
            this.cbAppointmentStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbAppointmentStatus.Name = "cbAppointmentStatus";
            this.cbAppointmentStatus.Size = new System.Drawing.Size(244, 24);
            this.cbAppointmentStatus.TabIndex = 40;
            this.cbAppointmentStatus.ValueMember = "id";
            // 
            // appointmentStatusDataBindingSource
            // 
            this.appointmentStatusDataBindingSource.DataMember = "AppointmentStatus";
            this.appointmentStatusDataBindingSource.DataSource = this.appointmentStatusData;
            // 
            // appointmentStatusData
            // 
            this.appointmentStatusData.DataSetName = "AppointmentStatusData";
            this.appointmentStatusData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(29, 11);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(243, 30);
            this.label15.TabIndex = 24;
            this.label15.Text = "Запись пациента";
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(11, 295);
            this.btnAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(245, 32);
            this.btnAppointment.TabIndex = 23;
            this.btnAppointment.Text = "Записать клиента";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.AddAppointment);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 48);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 17);
            this.label14.TabIndex = 25;
            this.label14.Text = "ID Пациента";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(11, 68);
            this.txtClientID.Margin = new System.Windows.Forms.Padding(4);
            this.txtClientID.MaxLength = 7;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(244, 22);
            this.txtClientID.TabIndex = 26;
            // 
            // dtDateAppointment
            // 
            this.dtDateAppointment.Location = new System.Drawing.Point(11, 164);
            this.dtDateAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dtDateAppointment.Name = "dtDateAppointment";
            this.dtDateAppointment.Size = new System.Drawing.Size(244, 22);
            this.dtDateAppointment.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(7, 96);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 17);
            this.label13.TabIndex = 29;
            this.label13.Text = "Имя врача";
            // 
            // cbTime
            // 
            this.cbTime.DataSource = this.timeDataBindingSource;
            this.cbTime.DisplayMember = "time";
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(11, 212);
            this.cbTime.Margin = new System.Windows.Forms.Padding(4);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(244, 24);
            this.cbTime.TabIndex = 37;
            this.cbTime.ValueMember = "id";
            // 
            // timeDataBindingSource
            // 
            this.timeDataBindingSource.DataMember = "Timetable";
            this.timeDataBindingSource.DataSource = this.timeData;
            // 
            // timeData
            // 
            this.timeData.DataSetName = "TimeData";
            this.timeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 17);
            this.label12.TabIndex = 30;
            this.label12.Text = "Дата";
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.DataSource = this.employeeDataBindingSource;
            this.cmbDoctorName.DisplayMember = "fio";
            this.cmbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(11, 116);
            this.cmbDoctorName.Margin = new System.Windows.Forms.Padding(4);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(244, 24);
            this.cmbDoctorName.TabIndex = 36;
            this.cmbDoctorName.ValueMember = "id";
            // 
            // employeeDataBindingSource
            // 
            this.employeeDataBindingSource.DataMember = "Employee";
            this.employeeDataBindingSource.DataSource = this.employeeData;
            // 
            // employeeData
            // 
            this.employeeData.DataSetName = "EmployeeData";
            this.employeeData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 192);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Время";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(275, 11);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(207, 29);
            this.label10.TabIndex = 41;
            this.label10.Text = "Записи ко врачу:";
            // 
            // cmbAppointmentDoctor
            // 
            this.cmbAppointmentDoctor.DataSource = this.appointmentDoctorDataBindingSource;
            this.cmbAppointmentDoctor.DisplayMember = "fio";
            this.cmbAppointmentDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentDoctor.FormattingEnabled = true;
            this.cmbAppointmentDoctor.Location = new System.Drawing.Point(499, 17);
            this.cmbAppointmentDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbAppointmentDoctor.Name = "cmbAppointmentDoctor";
            this.cmbAppointmentDoctor.Size = new System.Drawing.Size(188, 24);
            this.cmbAppointmentDoctor.TabIndex = 40;
            this.cmbAppointmentDoctor.ValueMember = "id";
            this.cmbAppointmentDoctor.SelectedIndexChanged += new System.EventHandler(this.TableFilterClickAppointment);
            // 
            // appointmentDoctorDataBindingSource
            // 
            this.appointmentDoctorDataBindingSource.DataMember = "DataTable1";
            this.appointmentDoctorDataBindingSource.DataSource = this.appointmentDoctorData;
            // 
            // appointmentDoctorData
            // 
            this.appointmentDoctorData.DataSetName = "AppointmentDoctorData";
            this.appointmentDoctorData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAppointment
            // 
            this.dgvAppointment.AutoGenerateColumns = false;
            this.dgvAppointment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppointment.DataSource = this.appointmentDataBindingSource;
            this.dgvAppointment.Location = new System.Drawing.Point(280, 50);
            this.dgvAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.RowHeadersWidth = 51;
            this.dgvAppointment.Size = new System.Drawing.Size(777, 438);
            this.dgvAppointment.TabIndex = 35;
            this.dgvAppointment.DoubleClick += new System.EventHandler(this.SelectAppointment);
            // 
            // appointmentDataBindingSource
            // 
            this.appointmentDataBindingSource.DataMember = "DataTable1";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.dtCheck);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.cmbCheckDoctor);
            this.tabPage2.Controls.Add(this.btnChangeCheck);
            this.tabPage2.Controls.Add(this.dgvCheckList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1068, 414);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Список обслуж. пациентов";
            // 
            // dtCheck
            // 
            this.dtCheck.Location = new System.Drawing.Point(605, 10);
            this.dtCheck.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheck.Name = "dtCheck";
            this.dtCheck.Size = new System.Drawing.Size(244, 22);
            this.dtCheck.TabIndex = 44;
            this.dtCheck.ValueChanged += new System.EventHandler(this.TableFilterClickCheck);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(519, 4);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(73, 29);
            this.label18.TabIndex = 47;
            this.label18.Text = "Дата:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(236, 4);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(76, 29);
            this.label19.TabIndex = 46;
            this.label19.Text = "Врач:";
            // 
            // cmbCheckDoctor
            // 
            this.cmbCheckDoctor.DataSource = this.checkDoctorDataBindingSource;
            this.cmbCheckDoctor.DisplayMember = "fio";
            this.cmbCheckDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckDoctor.FormattingEnabled = true;
            this.cmbCheckDoctor.Location = new System.Drawing.Point(321, 10);
            this.cmbCheckDoctor.Margin = new System.Windows.Forms.Padding(4);
            this.cmbCheckDoctor.Name = "cmbCheckDoctor";
            this.cmbCheckDoctor.Size = new System.Drawing.Size(188, 24);
            this.cmbCheckDoctor.TabIndex = 45;
            this.cmbCheckDoctor.ValueMember = "id";
            this.cmbCheckDoctor.SelectionChangeCommitted += new System.EventHandler(this.TableFilterClickCheck);
            // 
            // checkDoctorDataBindingSource
            // 
            this.checkDoctorDataBindingSource.DataMember = "Employee";
            this.checkDoctorDataBindingSource.DataSource = this.checkDoctorData;
            // 
            // checkDoctorData
            // 
            this.checkDoctorData.DataSetName = "CheckDoctorData";
            this.checkDoctorData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnChangeCheck
            // 
            this.btnChangeCheck.Enabled = false;
            this.btnChangeCheck.Location = new System.Drawing.Point(359, 457);
            this.btnChangeCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnChangeCheck.Name = "btnChangeCheck";
            this.btnChangeCheck.Size = new System.Drawing.Size(316, 28);
            this.btnChangeCheck.TabIndex = 1;
            this.btnChangeCheck.Text = "Подтвердить оплату чека";
            this.btnChangeCheck.UseVisualStyleBackColor = true;
            this.btnChangeCheck.Click += new System.EventHandler(this.ChangeCheck);
            // 
            // dgvCheckList
            // 
            this.dgvCheckList.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn1,
            this.numbercheckDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn3,
            this.cardnumberDataGridViewTextBoxColumn3,
            this.servicecostDataGridViewTextBoxColumn,
            this.checkstatusDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1,
            this.checkstatusidDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn3});
            this.dgvCheckList.DataSource = this.checkListBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCheckList.Location = new System.Drawing.Point(8, 43);
            this.dgvCheckList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheckList.Name = "dgvCheckList";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCheckList.RowHeadersVisible = false;
            this.dgvCheckList.RowHeadersWidth = 51;
            this.dgvCheckList.Size = new System.Drawing.Size(1049, 406);
            this.dgvCheckList.TabIndex = 0;
            this.dgvCheckList.DoubleClick += new System.EventHandler(this.SelectCheck);
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Время";
            this.timeDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            this.timeDataGridViewTextBoxColumn1.Width = 125;
            // 
            // numbercheckDataGridViewTextBoxColumn
            // 
            this.numbercheckDataGridViewTextBoxColumn.DataPropertyName = "number_check";
            this.numbercheckDataGridViewTextBoxColumn.HeaderText = "Номер чека";
            this.numbercheckDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numbercheckDataGridViewTextBoxColumn.Name = "numbercheckDataGridViewTextBoxColumn";
            this.numbercheckDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn3
            // 
            this.fioDataGridViewTextBoxColumn3.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn3.HeaderText = "ФИО Пациента";
            this.fioDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn3.Name = "fioDataGridViewTextBoxColumn3";
            this.fioDataGridViewTextBoxColumn3.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn3.Width = 200;
            // 
            // cardnumberDataGridViewTextBoxColumn3
            // 
            this.cardnumberDataGridViewTextBoxColumn3.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn3.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.cardnumberDataGridViewTextBoxColumn3.Name = "cardnumberDataGridViewTextBoxColumn3";
            this.cardnumberDataGridViewTextBoxColumn3.Width = 125;
            // 
            // servicecostDataGridViewTextBoxColumn
            // 
            this.servicecostDataGridViewTextBoxColumn.DataPropertyName = "service_cost";
            this.servicecostDataGridViewTextBoxColumn.HeaderText = "Стоимость услуг";
            this.servicecostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicecostDataGridViewTextBoxColumn.Name = "servicecostDataGridViewTextBoxColumn";
            this.servicecostDataGridViewTextBoxColumn.Width = 125;
            // 
            // checkstatusDataGridViewTextBoxColumn
            // 
            this.checkstatusDataGridViewTextBoxColumn.DataPropertyName = "check_status";
            this.checkstatusDataGridViewTextBoxColumn.HeaderText = "Статус чека";
            this.checkstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkstatusDataGridViewTextBoxColumn.Name = "checkstatusDataGridViewTextBoxColumn";
            this.checkstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn1
            // 
            this.employeeidDataGridViewTextBoxColumn1.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn1.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn1.Name = "employeeidDataGridViewTextBoxColumn1";
            this.employeeidDataGridViewTextBoxColumn1.Visible = false;
            this.employeeidDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Visible = false;
            this.dateDataGridViewTextBoxColumn1.Width = 125;
            // 
            // checkstatusidDataGridViewTextBoxColumn
            // 
            this.checkstatusidDataGridViewTextBoxColumn.DataPropertyName = "check_status_id";
            this.checkstatusidDataGridViewTextBoxColumn.HeaderText = "check_status_id";
            this.checkstatusidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkstatusidDataGridViewTextBoxColumn.Name = "checkstatusidDataGridViewTextBoxColumn";
            this.checkstatusidDataGridViewTextBoxColumn.Visible = false;
            this.checkstatusidDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn3
            // 
            this.idDataGridViewTextBoxColumn3.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn3.HeaderText = "id";
            this.idDataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn3.Name = "idDataGridViewTextBoxColumn3";
            this.idDataGridViewTextBoxColumn3.ReadOnly = true;
            this.idDataGridViewTextBoxColumn3.Visible = false;
            this.idDataGridViewTextBoxColumn3.Width = 125;
            // 
            // checkListBindingSource
            // 
            this.checkListBindingSource.DataMember = "DataTable1";
            this.checkListBindingSource.DataSource = this.checkList;
            // 
            // checkList
            // 
            this.checkList.DataSetName = "CheckList";
            this.checkList.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // timetableTableAdapter
            // 
            this.timetableTableAdapter.ClearBeforeFill = true;
            // 
            // clientTableAdapter
            // 
            this.clientTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentStatusTableAdapter
            // 
            this.appointmentStatusTableAdapter.ClearBeforeFill = true;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter2
            // 
            this.dataTable1TableAdapter2.ClearBeforeFill = true;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.lbEmployeeName);
            this.panel4.Location = new System.Drawing.Point(220, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1092, 75);
            this.panel4.TabIndex = 6;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1312, 554);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApp);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtClientPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtClientPatronymic;
        private System.Windows.Forms.TextBox txtClientName;
        private System.Windows.Forms.TextBox txtClientSurname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnClient;
        private System.Windows.Forms.ComboBox cbTime;
        private System.Windows.Forms.ComboBox cmbDoctorName;
        private System.Windows.Forms.DataGridView dgvAppointment;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnAppointment;
        private System.Windows.Forms.DateTimePicker dtDateAppointment;
        private System.Windows.Forms.BindingSource timeDataBindingSource;
        private TimeData timeData;
        private DataSets.AdminForm.TimeDataTableAdapters.TimetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAppointmentDoctor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChangeCheck;
        private System.Windows.Forms.DataGridView dgvCheckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private ClientData clientData;
        private DataSets.AdminForm.ClientDataTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientDataBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtAppointment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbAppointmentStatus;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnClearAppointment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtCheck;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbCheckDoctor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNumberCard;
        private System.Windows.Forms.BindingSource appointmentDataBindingSource;
        private AppointmentData appointmentData;
        private DataSets.AdminForm.AppointmentDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn2;
        private EmployeeData employeeData;
        private System.Windows.Forms.BindingSource appointmentDoctorDataBindingSource;
        private AppointmentDoctorData appointmentDoctorData;
        private DataSets.AdminForm.AppointmentDoctorDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource appointmentStatusDataBindingSource;
        private AppointmentStatusData appointmentStatusData;
        private DataSets.AdminForm.AppointmentStatusDataTableAdapters.AppointmentStatusTableAdapter appointmentStatusTableAdapter;
        private System.Windows.Forms.BindingSource checkDoctorDataBindingSource;
        private CheckDoctorData checkDoctorData;
        private DataSets.DoctorForm.CheckDoctorDataTableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.BindingSource checkListBindingSource;
        private CheckList checkList;
        private DataSets.DoctorForm.CheckListTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbercheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkstatusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnClearClient;
        private System.Windows.Forms.BindingSource employeeDataBindingSource;
        private DataSets.AdminForm.EmployeeDataTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.Panel panel4;
    }
}