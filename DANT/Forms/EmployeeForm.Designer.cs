﻿using DANT.DataSets;
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dtAppointment = new System.Windows.Forms.DateTimePicker();
            this.label16 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnAddService = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbNameService = new System.Windows.Forms.ComboBox();
            this.numberAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.numberAppointment = new DANT.DataSets.AdminForm.NumberAppointment();
            this.listService = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServiceCost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCreateCheck = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbAppointment = new System.Windows.Forms.ComboBox();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.checkListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkList = new DANT.DataSets.DoctorForm.CheckList();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient = new DANT.DataSets.AdminForm.Patient();
            this.servicesDateBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbEmployeeName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.appointmentStatusTableAdapter = new DANT.DataSets.AdminForm.PatientTableAdapters.AppointmentStatusTableAdapter();
            this.dataTable1TableAdapter2 = new DANT.DataSets.DoctorForm.CheckListTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter1 = new DANT.DataSets.AdminForm.NumberAppointmentTableAdapters.DataTable1TableAdapter();
            this.dataTable1TableAdapter = new DANT.DataSets.AdminForm.AppointmentDataTableAdapters.DataTable1TableAdapter();
            this.servicesData = new DANT.DataSets.DoctorForm.ServicesData();
            this.servicesDataBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceTableAdapter = new DANT.DataSets.DoctorForm.ServicesDataTableAdapters.ServiceTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDateBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(258, 13);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1047, 528);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Ivory;
            this.tabPage1.Controls.Add(this.dtAppointment);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.dgvAppo);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1039, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Просмотр записей";
            // 
            // dtAppointment
            // 
            this.dtAppointment.Location = new System.Drawing.Point(577, 16);
            this.dtAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.dtAppointment.Name = "dtAppointment";
            this.dtAppointment.Size = new System.Drawing.Size(244, 22);
            this.dtAppointment.TabIndex = 44;
            this.dtAppointment.ValueChanged += new System.EventHandler(this.TableFilterClickAppointment);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(491, 10);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 29);
            this.label16.TabIndex = 45;
            this.label16.Text = "Дата:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
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
            this.panel2.Location = new System.Drawing.Point(0, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(272, 487);
            this.panel2.TabIndex = 43;
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Location = new System.Drawing.Point(139, 150);
            this.btnDeleteService.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(118, 28);
            this.btnDeleteService.TabIndex = 50;
            this.btnDeleteService.Text = "Удалить";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.deleteService);
            // 
            // btnAddService
            // 
            this.btnAddService.Location = new System.Drawing.Point(11, 150);
            this.btnAddService.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(112, 28);
            this.btnAddService.TabIndex = 49;
            this.btnAddService.Text = "Добавить";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.addService);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 97);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 17);
            this.label7.TabIndex = 47;
            this.label7.Text = "Название услуги";
            // 
            // cbNameService
            // 
            this.cbNameService.DataSource = this.servicesDataBindingSource;
            this.cbNameService.DisplayMember = "name";
            this.cbNameService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNameService.FormattingEnabled = true;
            this.cbNameService.Location = new System.Drawing.Point(12, 118);
            this.cbNameService.Margin = new System.Windows.Forms.Padding(4);
            this.cbNameService.Name = "cbNameService";
            this.cbNameService.Size = new System.Drawing.Size(244, 24);
            this.cbNameService.TabIndex = 48;
            this.cbNameService.ValueMember = "id";
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
            // listService
            // 
            this.listService.FormattingEnabled = true;
            this.listService.ItemHeight = 16;
            this.listService.Location = new System.Drawing.Point(11, 185);
            this.listService.Name = "listService";
            this.listService.Size = new System.Drawing.Size(244, 116);
            this.listService.TabIndex = 46;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 45;
            // 
            // txtServiceCost
            // 
            this.txtServiceCost.Location = new System.Drawing.Point(11, 325);
            this.txtServiceCost.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceCost.MaxLength = 7;
            this.txtServiceCost.Name = "txtServiceCost";
            this.txtServiceCost.ReadOnly = true;
            this.txtServiceCost.Size = new System.Drawing.Size(244, 22);
            this.txtServiceCost.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 43;
            this.label2.Text = "Стоимость услуг";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(48, 6);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 29);
            this.label11.TabIndex = 25;
            this.label11.Text = "Создать чек";
            // 
            // btnCreateCheck
            // 
            this.btnCreateCheck.Location = new System.Drawing.Point(11, 355);
            this.btnCreateCheck.Margin = new System.Windows.Forms.Padding(4);
            this.btnCreateCheck.Name = "btnCreateCheck";
            this.btnCreateCheck.Size = new System.Drawing.Size(245, 28);
            this.btnCreateCheck.TabIndex = 42;
            this.btnCreateCheck.Text = "Создать чек";
            this.btnCreateCheck.UseVisualStyleBackColor = true;
            this.btnCreateCheck.Click += new System.EventHandler(this.addCheck);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 48);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 26;
            this.label10.Text = "ID Записи";
            // 
            // cbAppointment
            // 
            this.cbAppointment.DataSource = this.numberAppointmentBindingSource;
            this.cbAppointment.DisplayMember = "number_appointment";
            this.cbAppointment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAppointment.FormattingEnabled = true;
            this.cbAppointment.Location = new System.Drawing.Point(12, 69);
            this.cbAppointment.Margin = new System.Windows.Forms.Padding(4);
            this.cbAppointment.Name = "cbAppointment";
            this.cbAppointment.Size = new System.Drawing.Size(244, 24);
            this.cbAppointment.TabIndex = 37;
            this.cbAppointment.ValueMember = "id";
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
            this.dgvAppo.Location = new System.Drawing.Point(280, 52);
            this.dgvAppo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAppo.Name = "dgvAppo";
            this.dgvAppo.RowHeadersVisible = false;
            this.dgvAppo.RowHeadersWidth = 51;
            this.dgvAppo.Size = new System.Drawing.Size(777, 439);
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.SeaShell;
            this.tabPage2.Controls.Add(this.dtCheck);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.dgvCheckList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1039, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Список обслж. пациентов";
            // 
            // dtCheck
            // 
            this.dtCheck.Location = new System.Drawing.Point(466, 45);
            this.dtCheck.Margin = new System.Windows.Forms.Padding(4);
            this.dtCheck.Name = "dtCheck";
            this.dtCheck.Size = new System.Drawing.Size(244, 22);
            this.dtCheck.TabIndex = 46;
            this.dtCheck.ValueChanged += new System.EventHandler(this.TableFilterClickCheck);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(379, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 29);
            this.label6.TabIndex = 47;
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
            this.dgvCheckList.Location = new System.Drawing.Point(87, 77);
            this.dgvCheckList.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCheckList.Name = "dgvCheckList";
            this.dgvCheckList.RowHeadersVisible = false;
            this.dgvCheckList.RowHeadersWidth = 51;
            this.dgvCheckList.Size = new System.Drawing.Size(839, 357);
            this.dgvCheckList.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Ivory;
            this.panel1.Controls.Add(this.lbDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lbPosition);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lbEmployeeName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 554);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbDate
            // 
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDate.Location = new System.Drawing.Point(4, 224);
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
            this.label5.Location = new System.Drawing.Point(30, 164);
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
            this.lbPosition.Location = new System.Drawing.Point(60, 115);
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
            this.label3.Location = new System.Drawing.Point(49, 90);
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
            this.lbEmployeeName.Location = new System.Drawing.Point(91, 61);
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
            this.label1.Location = new System.Drawing.Point(35, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя сотрудника:";
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
            // servicesData
            // 
            this.servicesData.DataSetName = "ServicesData";
            this.servicesData.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicesDataBindingSource
            // 
            this.servicesDataBindingSource.DataMember = "Service";
            this.servicesDataBindingSource.DataSource = this.servicesData;
            // 
            // serviceTableAdapter
            // 
            this.serviceTableAdapter.ClearBeforeFill = true;
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(1312, 554);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeApp);
            this.Load += new System.EventHandler(this.EmployeeForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAppo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentDataBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentData)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDateBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesDataBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dgvAppo;
        private AppointmentData appointmentData;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCreateCheck;
        private System.Windows.Forms.ComboBox cbAppointment;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbEmployeeName;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvCheckList;
        private System.Windows.Forms.DateTimePicker dtCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicecostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn surnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patronymicDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource checkListBindingSource;
        private CheckList checkList;
        private DataSets.DoctorForm.CheckListTableAdapters.DataTable1TableAdapter dataTable1TableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbercheckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cardnumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkstatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn1;
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
    }
}