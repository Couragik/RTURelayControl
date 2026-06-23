
namespace RTURelayControl
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connoptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devicelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.devicesurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.context2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eventsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eventlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorlogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbuslogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.interfacesetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timersetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatsetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagnosisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusmonitorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modbusrequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usermanualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.connectionsToolStripMenuItem,
            this.devicesToolStripMenuItem,
            this.eventsToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.diagnosisToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // connectionsToolStripMenuItem
            // 
            this.connectionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem,
            this.reconnectToolStripMenuItem,
            this.toolStripSeparator1,
            this.connoptionsToolStripMenuItem});
            this.connectionsToolStripMenuItem.Name = "connectionsToolStripMenuItem";
            this.connectionsToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.connectionsToolStripMenuItem.Text = "Подключение";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.connectToolStripMenuItem.Text = "Подключиться";
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.disconnectToolStripMenuItem.Text = "Отключиться";
            // 
            // reconnectToolStripMenuItem
            // 
            this.reconnectToolStripMenuItem.Name = "reconnectToolStripMenuItem";
            this.reconnectToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.reconnectToolStripMenuItem.Text = "Переподключиться";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(179, 6);
            // 
            // connoptionsToolStripMenuItem
            // 
            this.connoptionsToolStripMenuItem.Name = "connoptionsToolStripMenuItem";
            this.connoptionsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.connoptionsToolStripMenuItem.Text = "Параметры порта...";
            // 
            // devicesToolStripMenuItem
            // 
            this.devicesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.devicesurveyToolStripMenuItem,
            this.toolStripSeparator2,
            this.devicelistToolStripMenuItem});
            this.devicesToolStripMenuItem.Name = "devicesToolStripMenuItem";
            this.devicesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.devicesToolStripMenuItem.Text = "Устройства";
            // 
            // devicelistToolStripMenuItem
            // 
            this.devicelistToolStripMenuItem.Name = "devicelistToolStripMenuItem";
            this.devicelistToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.devicelistToolStripMenuItem.Text = "Список устройств...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(179, 6);
            // 
            // devicesurveyToolStripMenuItem
            // 
            this.devicesurveyToolStripMenuItem.Name = "devicesurveyToolStripMenuItem";
            this.devicesurveyToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.devicesurveyToolStripMenuItem.Text = "Включить опрос";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 339);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(760, 163);
            this.dataGridView1.TabIndex = 3;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context1ToolStripMenuItem,
            this.context2ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(121, 48);
            // 
            // context1ToolStripMenuItem
            // 
            this.context1ToolStripMenuItem.Name = "context1ToolStripMenuItem";
            this.context1ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.context1ToolStripMenuItem.Text = "context1";
            // 
            // context2ToolStripMenuItem
            // 
            this.context2ToolStripMenuItem.Name = "context2ToolStripMenuItem";
            this.context2ToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.context2ToolStripMenuItem.Text = "context2";
            // 
            // button1
            // 
            this.button1.ContextMenuStrip = this.contextMenuStrip1;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Location = new System.Drawing.Point(112, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Column3";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewButtonColumn1.Text = "1";
            // 
            // eventsToolStripMenuItem
            // 
            this.eventsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eventlogToolStripMenuItem,
            this.modbuslogToolStripMenuItem,
            this.errorlogToolStripMenuItem});
            this.eventsToolStripMenuItem.Name = "eventsToolStripMenuItem";
            this.eventsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.eventsToolStripMenuItem.Text = "События";
            // 
            // eventlogToolStripMenuItem
            // 
            this.eventlogToolStripMenuItem.Name = "eventlogToolStripMenuItem";
            this.eventlogToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.eventlogToolStripMenuItem.Text = "Журнал событий...";
            // 
            // errorlogToolStripMenuItem
            // 
            this.errorlogToolStripMenuItem.Name = "errorlogToolStripMenuItem";
            this.errorlogToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.errorlogToolStripMenuItem.Text = "Журнал ошибок...";
            // 
            // modbuslogToolStripMenuItem
            // 
            this.modbuslogToolStripMenuItem.Name = "modbuslogToolStripMenuItem";
            this.modbuslogToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.modbuslogToolStripMenuItem.Text = "Журнал обмена Modbus...";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interfacesetToolStripMenuItem,
            this.programsetToolStripMenuItem,
            this.timersetToolStripMenuItem,
            this.automatsetToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.settingsToolStripMenuItem.Text = "Настройки";
            // 
            // interfacesetToolStripMenuItem
            // 
            this.interfacesetToolStripMenuItem.Name = "interfacesetToolStripMenuItem";
            this.interfacesetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.interfacesetToolStripMenuItem.Text = "Интерфейс...";
            // 
            // programsetToolStripMenuItem
            // 
            this.programsetToolStripMenuItem.Name = "programsetToolStripMenuItem";
            this.programsetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.programsetToolStripMenuItem.Text = "Программа...";
            // 
            // timersetToolStripMenuItem
            // 
            this.timersetToolStripMenuItem.Name = "timersetToolStripMenuItem";
            this.timersetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.timersetToolStripMenuItem.Text = "Опрос и таймауты...";
            // 
            // automatsetToolStripMenuItem
            // 
            this.automatsetToolStripMenuItem.Name = "automatsetToolStripMenuItem";
            this.automatsetToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.automatsetToolStripMenuItem.Text = "Автоматизация...";
            // 
            // diagnosisToolStripMenuItem
            // 
            this.diagnosisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modbusmonitorToolStripMenuItem,
            this.modbusrequestToolStripMenuItem});
            this.diagnosisToolStripMenuItem.Name = "diagnosisToolStripMenuItem";
            this.diagnosisToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.diagnosisToolStripMenuItem.Text = "Диагностика";
            // 
            // modbusmonitorToolStripMenuItem
            // 
            this.modbusmonitorToolStripMenuItem.Name = "modbusmonitorToolStripMenuItem";
            this.modbusmonitorToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.modbusmonitorToolStripMenuItem.Text = "Монитор Modbus";
            // 
            // modbusrequestToolStripMenuItem
            // 
            this.modbusrequestToolStripMenuItem.Name = "modbusrequestToolStripMenuItem";
            this.modbusrequestToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.modbusrequestToolStripMenuItem.Text = "Ручной запрос Modbus...";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usermanualToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.helpToolStripMenuItem.Text = "Справка";
            // 
            // usermanualToolStripMenuItem
            // 
            this.usermanualToolStripMenuItem.Name = "usermanualToolStripMenuItem";
            this.usermanualToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.usermanualToolStripMenuItem.Text = "Руководство пользователя";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.aboutToolStripMenuItem.Text = "О программе";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 400);
            this.Name = "Form1";
            this.Text = "RTURelayControl";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem context1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem context2ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewButtonColumn1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem connoptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devicelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem devicesurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eventlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorlogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbuslogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interfacesetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timersetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatsetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagnosisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusmonitorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modbusrequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usermanualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

