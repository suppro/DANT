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
            this.lbEmployeeName = new System.Windows.Forms.Label();
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
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberappointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentData1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentData1 = new DANT.DataSets.AdminForm.AppointmentData();
            this.appointmentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtCheck = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbCheckDoctor = new System.Windows.Forms.ComboBox();
            this.checkDoctorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkDoctorData = new DANT.DataSets.DoctorForm.CheckDoctorData();
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
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.btnChangeCheck = new MetroFramework.Controls.MetroButton();
            this.dataTable1TableAdapter3 = new DANT.DataSets.AdminForm.AppointmentDataTableAdapters.DataTable1TableAdapter();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            this.panel4.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeeName.AutoSize = true;
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployeeName.Location = new System.Drawing.Point(845, 9);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(89, 20);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "Имя врача";
            this.lbEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
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
            this.panel3.Location = new System.Drawing.Point(11, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 341);
            this.panel3.TabIndex = 24;
            // 
            // btnClearClient
            // 
            this.btnClearClient.Location = new System.Drawing.Point(3, 268);
            this.btnClearClient.Name = "btnClearClient";
            this.btnClearClient.Size = new System.Drawing.Size(184, 23);
            this.btnClearClient.TabIndex = 44;
            this.btnClearClient.Text = "Отменить выбор";
            this.btnClearClient.UseVisualStyleBackColor = true;
            this.btnClearClient.Click += new System.EventHandler(this.ClearClientClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(0, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Номер карты";
            // 
            // txtNumberCard
            // 
            this.txtNumberCard.Enabled = false;
            this.txtNumberCard.Location = new System.Drawing.Point(3, 210);
            this.txtNumberCard.Name = "txtNumberCard";
            this.txtNumberCard.Size = new System.Drawing.Size(184, 20);
            this.txtNumberCard.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 24);
            this.label7.TabIndex = 12;
            this.label7.Text = "Добавить пациента";
            // 
            // btnClient
            // 
            this.btnClient.Location = new System.Drawing.Point(3, 236);
            this.btnClient.Name = "btnClient";
            this.btnClient.Size = new System.Drawing.Size(184, 26);
            this.btnClient.TabIndex = 11;
            this.btnClient.Text = "Добавить клиента";
            this.btnClient.UseVisualStyleBackColor = true;
            this.btnClient.Click += new System.EventHandler(this.AddClient);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(0, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Фамилия";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Телефон";
            // 
            // txtClientSurname
            // 
            this.txtClientSurname.Location = new System.Drawing.Point(3, 54);
            this.txtClientSurname.MaxLength = 27;
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(184, 20);
            this.txtClientSurname.TabIndex = 14;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(3, 93);
            this.txtClientName.MaxLength = 27;
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(184, 20);
            this.txtClientName.TabIndex = 15;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(3, 171);
            this.txtClientPhone.MaxLength = 27;
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(184, 20);
            this.txtClientPhone.TabIndex = 19;
            // 
            // txtClientPatronymic
            // 
            this.txtClientPatronymic.Location = new System.Drawing.Point(3, 132);
            this.txtClientPatronymic.MaxLength = 27;
            this.txtClientPatronymic.Name = "txtClientPatronymic";
            this.txtClientPatronymic.Size = new System.Drawing.Size(184, 20);
            this.txtClientPatronymic.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
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
            this.dgvClient.Location = new System.Drawing.Point(217, 7);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidth = 51;
            this.dgvClient.Size = new System.Drawing.Size(722, 341);
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
            // dtAppointment
            // 
            this.dtAppointment.Location = new System.Drawing.Point(668, 24);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Size = new System.Drawing.Size(218, 20);
            this.dtAppointment.TabIndex = 40;
            this.dtAppointment.ValueChanged += new System.EventHandler(this.TableFilterClickAppointment);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(603, 19);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 24);
            this.label16.TabIndex = 43;
            this.label16.Text = "Дата:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
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
            this.panel2.Location = new System.Drawing.Point(3, 10);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 338);
            this.panel2.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 197);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Статус записи";
            // 
            // btnClearAppointment
            // 
            this.btnClearAppointment.Location = new System.Drawing.Point(8, 302);
            this.btnClearAppointment.Name = "btnClearAppointment";
            this.btnClearAppointment.Size = new System.Drawing.Size(184, 23);
            this.btnClearAppointment.TabIndex = 43;
            this.btnClearAppointment.Text = "Отменить выбор";
            this.btnClearAppointment.UseVisualStyleBackColor = true;
            this.btnClearAppointment.Click += new System.EventHandler(this.ClearAppontmentClick);
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Enabled = false;
            this.btnDeleteAppointment.Location = new System.Drawing.Point(8, 272);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(184, 23);
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
            this.cbAppointmentStatus.Location = new System.Drawing.Point(8, 213);
            this.cbAppointmentStatus.Name = "cbAppointmentStatus";
            this.cbAppointmentStatus.Size = new System.Drawing.Size(184, 21);
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
            this.label15.Location = new System.Drawing.Point(22, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(170, 24);
            this.label15.TabIndex = 24;
            this.label15.Text = "Запись пациента";
            // 
            // btnAppointment
            // 
            this.btnAppointment.Location = new System.Drawing.Point(8, 240);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(184, 26);
            this.btnAppointment.TabIndex = 23;
            this.btnAppointment.Text = "Записать клиента";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.AddAppointment);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(5, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 13);
            this.label14.TabIndex = 25;
            this.label14.Text = "ID Пациента";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(8, 55);
            this.txtClientID.MaxLength = 7;
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(184, 20);
            this.txtClientID.TabIndex = 26;
            // 
            // dtDateAppointment
            // 
            this.dtDateAppointment.Location = new System.Drawing.Point(8, 133);
            this.dtDateAppointment.Name = "dtDateAppointment";
            this.dtDateAppointment.Size = new System.Drawing.Size(184, 20);
            this.dtDateAppointment.TabIndex = 38;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(61, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "Имя врача";
            // 
            // cbTime
            // 
            this.cbTime.DataSource = this.timeDataBindingSource;
            this.cbTime.DisplayMember = "time";
            this.cbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTime.FormattingEnabled = true;
            this.cbTime.Location = new System.Drawing.Point(8, 172);
            this.cbTime.Name = "cbTime";
            this.cbTime.Size = new System.Drawing.Size(184, 21);
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
            this.label12.Location = new System.Drawing.Point(7, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Дата";
            // 
            // cmbDoctorName
            // 
            this.cmbDoctorName.DataSource = this.employeeDataBindingSource;
            this.cmbDoctorName.DisplayMember = "fio";
            this.cmbDoctorName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDoctorName.FormattingEnabled = true;
            this.cmbDoctorName.Location = new System.Drawing.Point(8, 94);
            this.cmbDoctorName.Name = "cmbDoctorName";
            this.cmbDoctorName.Size = new System.Drawing.Size(184, 21);
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
            this.label11.Location = new System.Drawing.Point(7, 156);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "Время";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(218, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 24);
            this.label10.TabIndex = 41;
            this.label10.Text = "Записи ко врачу:";
            // 
            // cmbAppointmentDoctor
            // 
            this.cmbAppointmentDoctor.DataSource = this.appointmentDoctorDataBindingSource;
            this.cmbAppointmentDoctor.DisplayMember = "fio";
            this.cmbAppointmentDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAppointmentDoctor.FormattingEnabled = true;
            this.cmbAppointmentDoctor.Location = new System.Drawing.Point(386, 24);
            this.cmbAppointmentDoctor.Name = "cmbAppointmentDoctor";
            this.cmbAppointmentDoctor.Size = new System.Drawing.Size(176, 21);
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
            this.dgvAppointment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.cardnumberDataGridViewTextBoxColumn4,
            this.numberappointmentDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.statusidDataGridViewTextBoxColumn});
            this.dgvAppointment.DataSource = this.appointmentData1BindingSource;
            this.dgvAppointment.Location = new System.Drawing.Point(222, 56);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.RowHeadersWidth = 51;
            this.dgvAppointment.Size = new System.Drawing.Size(730, 292);
            this.dgvAppointment.TabIndex = 35;
            this.dgvAppointment.DoubleClick += new System.EventHandler(this.SelectAppointment);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn1.HeaderText = "Время";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "fio";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn3.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "status_appointment";
            this.dataGridViewTextBoxColumn4.HeaderText = "Статус записи";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "date";
            this.dataGridViewTextBoxColumn5.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // cardnumberDataGridViewTextBoxColumn4
            // 
            this.cardnumberDataGridViewTextBoxColumn4.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn4.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn4.Name = "cardnumberDataGridViewTextBoxColumn4";
            // 
            // numberappointmentDataGridViewTextBoxColumn
            // 
            this.numberappointmentDataGridViewTextBoxColumn.DataPropertyName = "number_appointment";
            this.numberappointmentDataGridViewTextBoxColumn.HeaderText = "Номер записи";
            this.numberappointmentDataGridViewTextBoxColumn.Name = "numberappointmentDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn4
            // 
            this.idDataGridViewTextBoxColumn4.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn4.HeaderText = "id";
            this.idDataGridViewTextBoxColumn4.Name = "idDataGridViewTextBoxColumn4";
            this.idDataGridViewTextBoxColumn4.ReadOnly = true;
            this.idDataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "employee_id";
            this.dataGridViewTextBoxColumn6.HeaderText = "employee_id";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Expr1";
            this.dataGridViewTextBoxColumn7.HeaderText = "Expr1";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            this.statusidDataGridViewTextBoxColumn.Visible = false;
            // 
            // appointmentData1BindingSource
            // 
            this.appointmentData1BindingSource.DataMember = "DataTable1";
            this.appointmentData1BindingSource.DataSource = this.appointmentData1;
            // 
            // appointmentData1
            // 
            this.appointmentData1.DataSetName = "AppointmentData";
            this.appointmentData1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentDataBindingSource
            // 
            this.appointmentDataBindingSource.DataMember = "DataTable1";
            // 
            // dtCheck
            // 
            this.dtCheck.Location = new System.Drawing.Point(481, 17);
            this.dtCheck.Name = "dtCheck";
            this.dtCheck.Size = new System.Drawing.Size(184, 20);
            this.dtCheck.TabIndex = 44;
            this.dtCheck.ValueChanged += new System.EventHandler(this.TableFilterClickCheck);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.White;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(416, 12);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 24);
            this.label18.TabIndex = 47;
            this.label18.Text = "Дата:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(204, 12);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 24);
            this.label19.TabIndex = 46;
            this.label19.Text = "Врач:";
            // 
            // cmbCheckDoctor
            // 
            this.cmbCheckDoctor.DataSource = this.checkDoctorDataBindingSource;
            this.cmbCheckDoctor.DisplayMember = "fio";
            this.cmbCheckDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckDoctor.FormattingEnabled = true;
            this.cmbCheckDoctor.Location = new System.Drawing.Point(268, 17);
            this.cmbCheckDoctor.Name = "cmbCheckDoctor";
            this.cmbCheckDoctor.Size = new System.Drawing.Size(142, 21);
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
            // dgvCheckList
            // 
            this.dgvCheckList.AutoGenerateColumns = false;
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
            this.dgvCheckList.Location = new System.Drawing.Point(3, 51);
            this.dgvCheckList.Name = "dgvCheckList";
            this.dgvCheckList.RowHeadersVisible = false;
            this.dgvCheckList.RowHeadersWidth = 51;
            this.dgvCheckList.Size = new System.Drawing.Size(937, 272);
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
            this.numbercheckDataGridViewTextBoxColumn.HeaderText = "Номер квитанции";
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
            this.checkstatusDataGridViewTextBoxColumn.HeaderText = "Статус квитанции";
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
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Controls.Add(this.lbEmployeeName);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 42);
            this.panel4.TabIndex = 6;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(12, 48);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(960, 398);
            this.metroTabControl1.TabIndex = 7;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.panel3);
            this.metroTabPage1.Controls.Add(this.dgvClient);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(952, 356);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Пациенты";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dtAppointment);
            this.metroTabPage2.Controls.Add(this.label16);
            this.metroTabPage2.Controls.Add(this.label10);
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.Controls.Add(this.cmbAppointmentDoctor);
            this.metroTabPage2.Controls.Add(this.dgvAppointment);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(952, 356);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Записи";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.btnChangeCheck);
            this.metroTabPage3.Controls.Add(this.dtCheck);
            this.metroTabPage3.Controls.Add(this.label18);
            this.metroTabPage3.Controls.Add(this.label19);
            this.metroTabPage3.Controls.Add(this.cmbCheckDoctor);
            this.metroTabPage3.Controls.Add(this.dgvCheckList);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(952, 356);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Квитанции";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // btnChangeCheck
            // 
            this.btnChangeCheck.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnChangeCheck.Highlight = true;
            this.btnChangeCheck.Location = new System.Drawing.Point(346, 329);
            this.btnChangeCheck.Name = "btnChangeCheck";
            this.btnChangeCheck.Size = new System.Drawing.Size(230, 23);
            this.btnChangeCheck.Style = MetroFramework.MetroColorStyle.Blue;
            this.btnChangeCheck.TabIndex = 48;
            this.btnChangeCheck.Text = "Подтверждение оплаты квитанции";
            this.btnChangeCheck.UseSelectable = true;
            this.btnChangeCheck.Click += new System.EventHandler(this.ChangeCheck);
            // 
            // dataTable1TableAdapter3
            // 
            this.dataTable1TableAdapter3.ClearBeforeFill = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Стоматология";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApp);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkDoctorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbEmployeeName;
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
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.BindingSource appointmentData1BindingSource;
        private AppointmentData appointmentData1;
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
        private MetroFramework.Controls.MetroButton btnChangeCheck;
        private DataSets.AdminForm.AppointmentDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
    }
}