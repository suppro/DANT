using DANT.DataSets;
using DANT.DataSets.AdminForm;
using DANT.DataSets.DoctorForm;

namespace DANT
{
    partial class EmployeeForm
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
            this.dtAppointment = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNameService = new System.Windows.Forms.ComboBox();
            this.servicesDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesData = new DANT.DataSets.DoctorForm.ServicesData();
            this.listService = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreateCheck = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAppointment = new System.Windows.Forms.ComboBox();
            this.numberAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberAppointment = new DANT.DataSets.AdminForm.NumberAppointment();
            this.dgvAppo = new System.Windows.Forms.DataGridView();
            this.numberappointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusappointmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expr1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appointmentDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentData = new DANT.DataSets.AdminForm.AppointmentData();
            this.checkListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkList = new DANT.DataSets.DoctorForm.CheckList();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient = new DANT.DataSets.AdminForm.Patient();
            this.servicesDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentStatusTableAdapter = new DANT.DataSets.AdminForm.PatientTableAdapters.AppointmentStatusTableAdapter();
            this.dataTable1TableAdapter2 = new DANT.DataSets.DoctorForm.CheckListTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter1 = new DANT.DataSets.AdminForm.NumberAppointmentTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter = new DANT.DataSets.AdminForm.AppointmentDataTableAdapters.DataTable1TableAdapter();
            this.serviceTableAdapter = new DANT.DataSets.DoctorForm.ServicesDataTableAdapters.ServiceTableAdapter();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.dtCheck = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvCheckList = new System.Windows.Forms.DataGridView();
            this.timeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbercheckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cardnumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkstatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDateBindingSource)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtAppointment
            // 
            this.dtAppointment.Location = new System.Drawing.Point(503, 13);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Size = new System.Drawing.Size(184, 20);
            this.dtAppointment.TabIndex = 44;
            this.dtAppointment.ValueChanged += new System.EventHandler(this.TableFilterClickAppointment);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(438, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 24);
            this.label16.TabIndex = 45;
            this.label16.Text = "Дата:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnDeleteService);
            this.panel2.Controls.Add(this.btnAddService);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.cbNameService);
            this.panel2.Controls.Add(this.listService);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtServiceCost);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.btnCreateCheck);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.cbAppointment);
            this.panel2.Location = new System.Drawing.Point(3, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 341);
            this.panel2.TabIndex = 43;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(104, 122);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(88, 23);
            this.btnDeleteService.TabIndex = 50;
            this.btnDeleteService.Text = "Удалить";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.deleteService);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(8, 122);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(84, 23);
            this.btnAddService.TabIndex = 49;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.addService);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Название услуги";
            // 
            // cbNameService
            // 
            this.cbNameService.DataSource = this.servicesDataBindingSource;
            this.cbNameService.DisplayMember = "name";
            this.cbNameService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameService.FormattingEnabled = true;
            this.cbNameService.Location = new System.Drawing.Point(9, 96);
            this.cbNameService.Name = "cbNameService";
            this.cbNameService.Size = new System.Drawing.Size(184, 21);
            this.cbNameService.TabIndex = 48;
            this.cbNameService.ValueMember = "id";
            // 
            // servicesDataBindingSource
            // 
            this.servicesDataBindingSource.DataMember = "Service";
            this.servicesDataBindingSource.DataSource = this.servicesData;
            // 
            // servicesData
            // 
            this.servicesData.DataSetName = "ServicesData";
            this.servicesData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // listService
            // 
            this.listService.FormattingEnabled = true;
            this.listService.Location = new System.Drawing.Point(8, 150);
            this.listService.Margin = new System.Windows.Forms.Padding(2);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(184, 95);
            this.listService.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 45;
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(8, 264);
            this.txtServiceCost.MaxLength = 7;
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.ReadOnly = true;
            this.txtServiceCost.Size = new System.Drawing.Size(184, 20);
            this.txtServiceCost.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Стоимость услуг";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(0, 5);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(204, 24);
            this.label11.TabIndex = 25;
            this.label11.Text = "Создать чек";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCreateCheck
            // 
            this.btnCreateCheck.Location = new System.Drawing.Point(8, 288);
            this.btnCreateCheck.Name = "btnCreateCheck";
            this.btnCreateCheck.Size = new System.Drawing.Size(184, 23);
            this.btnCreateCheck.TabIndex = 42;
            this.btnCreateCheck.Text = "Создать чек";
            this.btnCreateCheck.UseVisualStyleBackColor = true;
            this.btnCreateCheck.Click += new System.EventHandler(this.addCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(58, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "ID Записи";
            // 
            // cbAppointment
            // 
            this.cbAppointment.DataSource = this.numberAppointmentBindingSource;
            this.cbAppointment.DisplayMember = "number_appointment";
            this.cbAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppointment.FormattingEnabled = true;
            this.cbAppointment.Location = new System.Drawing.Point(9, 56);
            this.cbAppointment.Name = "cbAppointment";
            this.cbAppointment.Size = new System.Drawing.Size(184, 21);
            this.cbAppointment.TabIndex = 37;
            this.cbAppointment.ValueMember = "id";
            // 
            // numberAppointmentBindingSource
            // 
            this.numberAppointmentBindingSource.DataMember = "DataTable1";
            this.numberAppointmentBindingSource.DataSource = this.numberAppointment;
            // 
            // numberAppointment
            // 
            this.numberAppointment.DataSetName = "NumberAppointment";
            this.numberAppointment.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvAppo
            // 
            this.dgvAppo.AutoGenerateColumns = false;
            this.dgvAppo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAppo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numberappointmentDataGridViewTextBoxColumn,
            this.timeDataGridViewTextBoxColumn,
            this.statusappointmentDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn,
            this.cardnumberDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn1,
            this.expr1DataGridViewTextBoxColumn,
            this.statusidDataGridViewTextBoxColumn});
            this.dgvAppo.DataSource = this.appointmentDataBindingSource;
            this.dgvAppo.Location = new System.Drawing.Point(213, 42);
            this.dgvAppo.Name = "dgvAppo";
            this.dgvAppo.RowHeadersVisible = false;
            this.dgvAppo.RowHeadersWidth = 51;
            this.dgvAppo.Size = new System.Drawing.Size(744, 307);
            this.dgvAppo.TabIndex = 36;
            // 
            // numberappointmentDataGridViewTextBoxColumn
            // 
            this.numberappointmentDataGridViewTextBoxColumn.DataPropertyName = "number_appointment";
            this.numberappointmentDataGridViewTextBoxColumn.HeaderText = "Номер записи";
            this.numberappointmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.numberappointmentDataGridViewTextBoxColumn.Name = "numberappointmentDataGridViewTextBoxColumn";
            this.numberappointmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            this.timeDataGridViewTextBoxColumn.DataPropertyName = "time";
            this.timeDataGridViewTextBoxColumn.HeaderText = "Время записи";
            this.timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            this.timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statusappointmentDataGridViewTextBoxColumn
            // 
            this.statusappointmentDataGridViewTextBoxColumn.DataPropertyName = "status_appointment";
            this.statusappointmentDataGridViewTextBoxColumn.HeaderText = "Статус записи";
            this.statusappointmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusappointmentDataGridViewTextBoxColumn.Name = "statusappointmentDataGridViewTextBoxColumn";
            this.statusappointmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // fioDataGridViewTextBoxColumn
            // 
            this.fioDataGridViewTextBoxColumn.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn.HeaderText = "ФИО Пациента";
            this.fioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn.Name = "fioDataGridViewTextBoxColumn";
            this.fioDataGridViewTextBoxColumn.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn.Width = 125;
            // 
            // cardnumberDataGridViewTextBoxColumn
            // 
            this.cardnumberDataGridViewTextBoxColumn.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.cardnumberDataGridViewTextBoxColumn.Name = "cardnumberDataGridViewTextBoxColumn";
            this.cardnumberDataGridViewTextBoxColumn.Width = 125;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Телефон пациента";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
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
            // expr1DataGridViewTextBoxColumn
            // 
            this.expr1DataGridViewTextBoxColumn.DataPropertyName = "Expr1";
            this.expr1DataGridViewTextBoxColumn.HeaderText = "Expr1";
            this.expr1DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.expr1DataGridViewTextBoxColumn.Name = "expr1DataGridViewTextBoxColumn";
            this.expr1DataGridViewTextBoxColumn.ReadOnly = true;
            this.expr1DataGridViewTextBoxColumn.Visible = false;
            this.expr1DataGridViewTextBoxColumn.Width = 125;
            // 
            // statusidDataGridViewTextBoxColumn
            // 
            this.statusidDataGridViewTextBoxColumn.DataPropertyName = "status_id";
            this.statusidDataGridViewTextBoxColumn.HeaderText = "status_id";
            this.statusidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusidDataGridViewTextBoxColumn.Name = "statusidDataGridViewTextBoxColumn";
            this.statusidDataGridViewTextBoxColumn.Visible = false;
            this.statusidDataGridViewTextBoxColumn.Width = 125;
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
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "AppointmentStatus";
            this.patientBindingSource.DataSource = this.patient;
            // 
            // patient
            // 
            this.patient.DataSetName = "Patient";
            this.patient.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // appointmentStatusTableAdapter
            // 
            this.appointmentStatusTableAdapter.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter2
            // 
            this.dataTable1TableAdapter2.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter1
            // 
            this.dataTable1TableAdapter1.ClearBeforeFill = true;
            // 
            // dataTable1TableAdapter
            // 
            this.dataTable1TableAdapter.ClearBeforeFill = true;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(11, 48);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(961, 390);
            this.metroTabControl1.TabIndex = 4;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.dtAppointment);
            this.metroTabPage2.Controls.Add(this.label16);
            this.metroTabPage2.Controls.Add(this.dgvAppo);
            this.metroTabPage2.Controls.Add(this.panel2);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(953, 348);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Создние квитанций";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.dtCheck);
            this.metroTabPage3.Controls.Add(this.label6);
            this.metroTabPage3.Controls.Add(this.dgvCheckList);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(953, 348);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Журнал пациентов";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // dtCheck
            // 
            this.dtCheck.Location = new System.Drawing.Point(424, -3);
            this.dtCheck.Name = "dtCheck";
            this.dtCheck.Size = new System.Drawing.Size(184, 20);
            this.dtCheck.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(358, -8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 50;
            this.label6.Text = "Дата:";
            // 
            // dgvCheckList
            // 
            this.dgvCheckList.AutoGenerateColumns = false;
            this.dgvCheckList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.timeDataGridViewTextBoxColumn1,
            this.numbercheckDataGridViewTextBoxColumn,
            this.fioDataGridViewTextBoxColumn1,
            this.cardnumberDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn1,
            this.checkstatusDataGridViewTextBoxColumn,
            this.employeeidDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn1});
            this.dgvCheckList.DataSource = this.checkListBindingSource;
            this.dgvCheckList.Location = new System.Drawing.Point(139, 23);
            this.dgvCheckList.Name = "dgvCheckList";
            this.dgvCheckList.RowHeadersVisible = false;
            this.dgvCheckList.RowHeadersWidth = 51;
            this.dgvCheckList.Size = new System.Drawing.Size(629, 290);
            this.dgvCheckList.TabIndex = 48;
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
            // fioDataGridViewTextBoxColumn1
            // 
            this.fioDataGridViewTextBoxColumn1.DataPropertyName = "fio";
            this.fioDataGridViewTextBoxColumn1.HeaderText = "ФИО Пациента";
            this.fioDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.fioDataGridViewTextBoxColumn1.Name = "fioDataGridViewTextBoxColumn1";
            this.fioDataGridViewTextBoxColumn1.ReadOnly = true;
            this.fioDataGridViewTextBoxColumn1.Width = 200;
            // 
            // cardnumberDataGridViewTextBoxColumn1
            // 
            this.cardnumberDataGridViewTextBoxColumn1.DataPropertyName = "card_number";
            this.cardnumberDataGridViewTextBoxColumn1.HeaderText = "Номер карты";
            this.cardnumberDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.cardnumberDataGridViewTextBoxColumn1.Name = "cardnumberDataGridViewTextBoxColumn1";
            this.cardnumberDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "service_cost";
            this.dataGridViewTextBoxColumn1.HeaderText = "Стоимость услуг";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // checkstatusDataGridViewTextBoxColumn
            // 
            this.checkstatusDataGridViewTextBoxColumn.DataPropertyName = "check_status";
            this.checkstatusDataGridViewTextBoxColumn.HeaderText = "Статус чека";
            this.checkstatusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.checkstatusDataGridViewTextBoxColumn.Name = "checkstatusDataGridViewTextBoxColumn";
            this.checkstatusDataGridViewTextBoxColumn.Width = 125;
            // 
            // employeeidDataGridViewTextBoxColumn
            // 
            this.employeeidDataGridViewTextBoxColumn.DataPropertyName = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.HeaderText = "employee_id";
            this.employeeidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.employeeidDataGridViewTextBoxColumn.Name = "employeeidDataGridViewTextBoxColumn";
            this.employeeidDataGridViewTextBoxColumn.Visible = false;
            this.employeeidDataGridViewTextBoxColumn.Width = 125;
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel4.Controls.Add(this.lbEmployeeName);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.iconButton2);
            this.panel4.Controls.Add(this.iconButton1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(984, 42);
            this.panel4.TabIndex = 7;
            // 
            // lbEmployeeName
            // 
            this.lbEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbEmployeeName.Location = new System.Drawing.Point(664, 6);
            this.lbEmployeeName.Name = "lbEmployeeName";
            this.lbEmployeeName.Size = new System.Drawing.Size(281, 24);
            this.lbEmployeeName.TabIndex = 27;
            this.lbEmployeeName.Text = "Имя сотрудника";
            this.lbEmployeeName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Выход";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.UserCircle;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 40;
            this.iconButton2.Location = new System.Drawing.Point(940, 0);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(44, 41);
            this.iconButton2.TabIndex = 3;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(46, 42);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(984, 450);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.metroTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EmployeeForm";
            this.Text = "Стоматология";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApp);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDateBindingSource)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAppo;
        private AppointmentData appointmentData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreateCheck;
        private System.Windows.Forms.ComboBox cbAppointment;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtAppointment;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private Patient patient;
        private DataSets.AdminForm.PatientTableAdapters.AppointmentStatusTableAdapter appointmentStatusTableAdapter;
        private System.Windows.Forms.BindingSource servicesDateBindingSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServiceCost;
        private System.Windows.Forms.Label label2;
        private NumberAppointment numberAppointment;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource checkListBindingSource;
        private CheckList checkList;
        private DataSets.DoctorForm.CheckListTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
        private System.Windows.Forms.BindingSource numberAppointmentBindingSource;
        private DataSets.AdminForm.NumberAppointmentTableAdapters.DataTable1TableAdapter dataTable1TableAdapter1;
        private System.Windows.Forms.BindingSource appointmentDataBindingSource;
        private DataSets.AdminForm.AppointmentDataTableAdapters.DataTable1TableAdapter dataTable1TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusappointmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn expr1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusidDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbNameService;
        private System.Windows.Forms.BindingSource servicesDataBindingSource;
        private ServicesData servicesData;
        private DataSets.DoctorForm.ServicesDataTableAdapters.ServiceTableAdapter serviceTableAdapter;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private System.Windows.Forms.DateTimePicker dtCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvCheckList;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbercheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Panel panel4;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label lbEmployeeName;
    }
}