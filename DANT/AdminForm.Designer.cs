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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.clientData = new DANT.ClientData();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtAppointment = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClearAppointment = new System.Windows.Forms.Button();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.cbAppointmentStatus = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.dtDateAppointment = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTime = new System.Windows.Forms.ComboBox();
            this.timeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timeData = new DANT.TimeData();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbDoctorName = new System.Windows.Forms.ComboBox();
            this.employeeDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeData = new DANT.EmployeeData();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cmbAppointmentDoctor = new System.Windows.Forms.ComboBox();
            this.appointmentDoctorDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentDoctorData = new DANT.AppointmentDoctorData();
            this.dgvAppointment = new System.Windows.Forms.DataGridView();
            this.appointmentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentData = new DANT.AppointmentData();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.cmbCheckDoctor = new System.Windows.Forms.ComboBox();
            this.btnChangeCheck = new System.Windows.Forms.Button();
            this.dgvCheckList = new System.Windows.Forms.DataGridView();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbercheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicecostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkList = new DANT.CheckList();
            this.appointmentStatusDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentStatusData = new DANT.AppointmentStatusData();
            this.employeeTableAdapter = new DANT.EmployeeDataTableAdapters.EmployeeTableAdapter();
            this.timetableTableAdapter = new DANT.TimeDataTableAdapters.TimetableTableAdapter();
            this.clientTableAdapter = new DANT.ClientDataTableAdapters.ClientTableAdapter();
            this.dataTable1TableAdapter1 = new DANT.AppointmentDoctorDataTableAdapters.DataTable1TableAdapter();
            this.appointmentStatusTableAdapter = new DANT.AppointmentStatusDataTableAdapters.AppointmentStatusTableAdapter();
            this.dataTable1TableAdapter = new DANT.AppointmentDataTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter2 = new DANT.CheckListTableAdapters.DataTable1TableAdapter();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusappointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientDataBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientData)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusData)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OldLace;
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbEmployeeName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(166, 450);
            this.panel1.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(9, 151);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(152, 20);
            this.lbDate.TabIndex = 5;
            this.lbDate.Text = "дата";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Сегодняшняя дата";
            // 
            // lbPosition
            // 
            this.lbPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbPosition.Location = new System.Drawing.Point(5, 84);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(160, 20);
            this.lbPosition.TabIndex = 3;
            this.lbPosition.Text = "должность";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(29, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Должность:";
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployeeName.Location = new System.Drawing.Point(3, 34);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(160, 20);
            this.lbEmployeeName.TabIndex = 1;
            this.lbEmployeeName.Text = "имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сотрудника:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(172, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 426);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dgvClient);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Добавить пациента";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.OldLace;
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
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 400);
            this.panel3.TabIndex = 24;
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
            this.txtClientSurname.Name = "txtClientSurname";
            this.txtClientSurname.Size = new System.Drawing.Size(184, 20);
            this.txtClientSurname.TabIndex = 14;
            // 
            // txtClientName
            // 
            this.txtClientName.Location = new System.Drawing.Point(3, 93);
            this.txtClientName.Name = "txtClientName";
            this.txtClientName.Size = new System.Drawing.Size(184, 20);
            this.txtClientName.TabIndex = 15;
            // 
            // txtClientPhone
            // 
            this.txtClientPhone.Location = new System.Drawing.Point(3, 171);
            this.txtClientPhone.Name = "txtClientPhone";
            this.txtClientPhone.Size = new System.Drawing.Size(184, 20);
            this.txtClientPhone.TabIndex = 19;
            // 
            // txtClientPatronymic
            // 
            this.txtClientPatronymic.Location = new System.Drawing.Point(3, 132);
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
            this.dgvClient.Location = new System.Drawing.Point(206, 6);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.Size = new System.Drawing.Size(590, 388);
            this.dgvClient.TabIndex = 23;
            this.dgvClient.DoubleClick += new System.EventHandler(this.selectClient);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "ID Клиента";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cardnumberDataGridViewTextBoxColumn
            // 
            this.cardnumberDataGridViewTextBoxColumn.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn.Name = "cardnumberDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn1
            // 
            this.fioDataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn1.HeaderText = "ФИО пациента";
            this.fioDataGridViewTextBoxColumn1.Name = "fioDataGridViewTextBoxColumn1";
            this.fioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn1.Width = 200;
            // 
            // phoneDataGridViewTextBoxColumn1
            // 
            this.phoneDataGridViewTextBoxColumn1.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn1.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn1.Name = "phoneDataGridViewTextBoxColumn1";
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
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(799, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Запись пациента";
            // 
            // dtAppointment
            // 
            this.dtAppointment.Location = new System.Drawing.Point(587, 14);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Size = new System.Drawing.Size(184, 20);
            this.dtAppointment.TabIndex = 40;
            this.dtAppointment.ValueChanged += new System.EventHandler(this.TableFilterClick);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(522, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 24);
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
            this.panel2.Location = new System.Drawing.Point(-4, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 397);
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
            this.cbAppointmentStatus.DisplayMember = "id";
            this.cbAppointmentStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppointmentStatus.Enabled = false;
            this.cbAppointmentStatus.FormattingEnabled = true;
            this.cbAppointmentStatus.Location = new System.Drawing.Point(8, 213);
            this.cbAppointmentStatus.Name = "cbAppointmentStatus";
            this.cbAppointmentStatus.Size = new System.Drawing.Size(184, 21);
            this.cbAppointmentStatus.TabIndex = 40;
            this.cbAppointmentStatus.ValueMember = "id";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label15.Location = new System.Drawing.Point(22, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(182, 24);
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
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(206, 9);
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
            this.cmbAppointmentDoctor.Location = new System.Drawing.Point(374, 14);
            this.cmbAppointmentDoctor.Name = "cmbAppointmentDoctor";
            this.cmbAppointmentDoctor.Size = new System.Drawing.Size(142, 21);
            this.cmbAppointmentDoctor.TabIndex = 40;
            this.cmbAppointmentDoctor.ValueMember = "id";
            this.cmbAppointmentDoctor.SelectedIndexChanged += new System.EventHandler(this.TableFilterClick);
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
            this.timeDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.statusappointmentDataGridViewTextBoxColumn,
            this.cardnumberDataGridViewTextBoxColumn1,
            this.employeeidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn1,
            this.expr1DataGridViewTextBoxColumn});
            this.dgvAppointment.DataSource = this.appointmentDataBindingSource;
            this.dgvAppointment.Location = new System.Drawing.Point(210, 41);
            this.dgvAppointment.Name = "dgvAppointment";
            this.dgvAppointment.RowHeadersVisible = false;
            this.dgvAppointment.Size = new System.Drawing.Size(583, 356);
            this.dgvAppointment.TabIndex = 35;
            this.dgvAppointment.DoubleClick += new System.EventHandler(this.SelectAppointment);
            // 
            // appointmentDataBindingSource
            // 
            this.appointmentDataBindingSource.DataMember = "DataTable1";
            this.appointmentDataBindingSource.DataSource = this.appointmentData;
            // 
            // appointmentData
            // 
            this.appointmentData.DataSetName = "AppointmentData";
            this.appointmentData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.cmbCheckDoctor);
            this.tabPage2.Controls.Add(this.btnChangeCheck);
            this.tabPage2.Controls.Add(this.dgvCheckList);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 400);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Список обслуж. клиентов";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(454, 8);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(184, 20);
            this.dateTimePicker1.TabIndex = 44;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.TableFilterClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label18.Location = new System.Drawing.Point(389, 3);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 24);
            this.label18.TabIndex = 47;
            this.label18.Text = "Дата:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label19.Location = new System.Drawing.Point(177, 3);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(58, 24);
            this.label19.TabIndex = 46;
            this.label19.Text = "Врач:";
            // 
            // cmbCheckDoctor
            // 
            this.cmbCheckDoctor.DataSource = this.appointmentDoctorDataBindingSource;
            this.cmbCheckDoctor.DisplayMember = "fio";
            this.cmbCheckDoctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCheckDoctor.FormattingEnabled = true;
            this.cmbCheckDoctor.Location = new System.Drawing.Point(241, 8);
            this.cmbCheckDoctor.Name = "cmbCheckDoctor";
            this.cmbCheckDoctor.Size = new System.Drawing.Size(142, 21);
            this.cmbCheckDoctor.TabIndex = 45;
            this.cmbCheckDoctor.ValueMember = "id";
            this.cmbCheckDoctor.SelectedIndexChanged += new System.EventHandler(this.TableFilterClick);
            // 
            // btnChangeCheck
            // 
            this.btnChangeCheck.Enabled = false;
            this.btnChangeCheck.Location = new System.Drawing.Point(269, 371);
            this.btnChangeCheck.Name = "btnChangeCheck";
            this.btnChangeCheck.Size = new System.Drawing.Size(237, 23);
            this.btnChangeCheck.TabIndex = 1;
            this.btnChangeCheck.Text = "Подтвердить оплату чека";
            this.btnChangeCheck.UseVisualStyleBackColor = true;
            this.btnChangeCheck.Click += new System.EventHandler(this.ChangeCheck);
            // 
            // dgvCheckList
            // 
            this.dgvCheckList.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn1,
            this.numbercheckDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn3,
            this.cardnumberDataGridViewTextBoxColumn3,
            this.checkstatusDataGridViewTextBoxColumn,
            this.servicecostDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn1,
            this.dateDataGridViewTextBoxColumn1});
            this.dgvCheckList.DataSource = this.checkListBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCheckList.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCheckList.Location = new System.Drawing.Point(6, 35);
            this.dgvCheckList.Name = "dgvCheckList";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCheckList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCheckList.RowHeadersVisible = false;
            this.dgvCheckList.Size = new System.Drawing.Size(787, 330);
            this.dgvCheckList.TabIndex = 0;
            this.dgvCheckList.DoubleClick += new System.EventHandler(this.SelectCheck);
            // 
            // timeDataGridViewTextBoxColumn1
            // 
            this.timeDataGridViewTextBoxColumn1.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn1.HeaderText = "Время";
            this.timeDataGridViewTextBoxColumn1.Name = "timeDataGridViewTextBoxColumn1";
            // 
            // numbercheckDataGridViewTextBoxColumn
            // 
            this.numbercheckDataGridViewTextBoxColumn.DataPropertyName = "number_check";
            this.numbercheckDataGridViewTextBoxColumn.HeaderText = "Номер чека";
            this.numbercheckDataGridViewTextBoxColumn.Name = "numbercheckDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn3
            // 
            this.fioDataGridViewTextBoxColumn3.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn3.HeaderText = "ФИО Пациента";
            this.fioDataGridViewTextBoxColumn3.Name = "fioDataGridViewTextBoxColumn3";
            this.fioDataGridViewTextBoxColumn3.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn3.Width = 200;
            // 
            // cardnumberDataGridViewTextBoxColumn3
            // 
            this.cardnumberDataGridViewTextBoxColumn3.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn3.HeaderText = "Номер карта";
            this.cardnumberDataGridViewTextBoxColumn3.Name = "cardnumberDataGridViewTextBoxColumn3";
            // 
            // checkstatusDataGridViewTextBoxColumn
            // 
            this.checkstatusDataGridViewTextBoxColumn.DataPropertyName = "check_status";
            this.checkstatusDataGridViewTextBoxColumn.HeaderText = "Статус чека";
            this.checkstatusDataGridViewTextBoxColumn.Name = "checkstatusDataGridViewTextBoxColumn";
            // 
            // servicecostDataGridViewTextBoxColumn
            // 
            this.servicecostDataGridViewTextBoxColumn.DataPropertyName = "service_cost";
            this.servicecostDataGridViewTextBoxColumn.HeaderText = "Стоимость услуг";
            this.servicecostDataGridViewTextBoxColumn.Name = "servicecostDataGridViewTextBoxColumn";
            // 
            // employeeidDataGridViewTextBoxColumn1
            // 
            this.employeeidDataGridViewTextBoxColumn1.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn1.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn1.Name = "employeeidDataGridViewTextBoxColumn1";
            this.employeeidDataGridViewTextBoxColumn1.Visible = false;
            // 
            // dateDataGridViewTextBoxColumn1
            // 
            this.dateDataGridViewTextBoxColumn1.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn1.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn1.Name = "dateDataGridViewTextBoxColumn1";
            this.dateDataGridViewTextBoxColumn1.Visible = false;
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
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
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
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter2
            // 
            this.dataTable1TableAdapter2.ClearBeforeFill = true;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время";
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО Пациента";
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // statusappointmentDataGridViewTextBoxColumn
            // 
            this.statusappointmentDataGridViewTextBoxColumn.DataPropertyName = "status_appointment";
            this.statusappointmentDataGridViewTextBoxColumn.HeaderText = "Статус записи";
            this.statusappointmentDataGridViewTextBoxColumn.Name = "statusappointmentDataGridViewTextBoxColumn";
            // 
            // cardnumberDataGridViewTextBoxColumn1
            // 
            this.cardnumberDataGridViewTextBoxColumn1.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn1.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn1.Name = "cardnumberDataGridViewTextBoxColumn1";
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
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
            ((System.ComponentModel.ISupportInitialize)(this.timeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDoctorData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentStatusData)).EndInit();
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
        private System.Windows.Forms.BindingSource employeeDataBindingSource;
        private EmployeeData employeeData;
        private EmployeeDataTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DateTimePicker dtDateAppointment;
        private System.Windows.Forms.BindingSource timeDataBindingSource;
        private TimeData timeData;
        private TimeDataTableAdapters.TimetableTableAdapter timetableTableAdapter;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbAppointmentDoctor;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnChangeCheck;
        private System.Windows.Forms.DataGridView dgvCheckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private ClientData clientData;
        private ClientDataTableAdapters.ClientTableAdapter clientTableAdapter;
        private System.Windows.Forms.BindingSource clientDataBindingSource1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtAppointment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbAppointmentStatus;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.BindingSource appointmentDoctorDataBindingSource;
        private AppointmentDoctorData appointmentDoctorData;
        private AppointmentDoctorDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource appointmentStatusDataBindingSource;
        private AppointmentStatusData appointmentStatusData;
        private AppointmentStatusDataTableAdapters.AppointmentStatusTableAdapter appointmentStatusTableAdapter;
        private System.Windows.Forms.Button btnClearAppointment;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
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
        private AppointmentDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn2;
        private System.Windows.Forms.BindingSource checkListBindingSource;
        private CheckList checkList;
        private CheckListTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbercheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
    }
}