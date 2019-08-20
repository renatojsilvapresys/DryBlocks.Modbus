namespace DryBlocks.DemoApp
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelComPort = new System.Windows.Forms.Label();
            this.comboBoxComPort = new System.Windows.Forms.ComboBox();
            this.labelModbusAddress = new System.Windows.Forms.Label();
            this.buttonInitiateComm = new System.Windows.Forms.Button();
            this.buttonStopComm = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.buttonSetPointUpdate = new System.Windows.Forms.Button();
            this.buttonInputUpdate = new System.Windows.Forms.Button();
            this.textBoxSetpointValue = new System.Windows.Forms.TextBox();
            this.labelSetPointValue = new System.Windows.Forms.Label();
            this.textBoxInputValue = new System.Windows.Forms.TextBox();
            this.labelInputValue = new System.Windows.Forms.Label();
            this.labelInputType = new System.Windows.Forms.Label();
            this.comboBoxInputType = new System.Windows.Forms.ComboBox();
            this.numericUpDownModbusAddress = new System.Windows.Forms.NumericUpDown();
            this.buttonProbeUpdate = new System.Windows.Forms.Button();
            this.textBoxProbeValue = new System.Windows.Forms.TextBox();
            this.labelProbeValue = new System.Windows.Forms.Label();
            this.buttonOutputUpdate = new System.Windows.Forms.Button();
            this.textBoxOutputControl = new System.Windows.Forms.TextBox();
            this.labelOutputValue = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModbusAddress)).BeginInit();
            this.SuspendLayout();
            // 
            // labelComPort
            // 
            this.labelComPort.AutoSize = true;
            this.labelComPort.Location = new System.Drawing.Point(22, 18);
            this.labelComPort.Name = "labelComPort";
            this.labelComPort.Size = new System.Drawing.Size(57, 13);
            this.labelComPort.TabIndex = 11;
            this.labelComPort.Text = "COM Port";
            // 
            // comboBoxComPort
            // 
            this.comboBoxComPort.FormattingEnabled = true;
            this.comboBoxComPort.Location = new System.Drawing.Point(25, 34);
            this.comboBoxComPort.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxComPort.Name = "comboBoxComPort";
            this.comboBoxComPort.Size = new System.Drawing.Size(121, 21);
            this.comboBoxComPort.TabIndex = 0;
            // 
            // labelModbusAddress
            // 
            this.labelModbusAddress.AutoSize = true;
            this.labelModbusAddress.Location = new System.Drawing.Point(153, 18);
            this.labelModbusAddress.Name = "labelModbusAddress";
            this.labelModbusAddress.Size = new System.Drawing.Size(94, 13);
            this.labelModbusAddress.TabIndex = 12;
            this.labelModbusAddress.Text = "Modbus Address";
            // 
            // buttonInitiateComm
            // 
            this.buttonInitiateComm.Location = new System.Drawing.Point(288, 32);
            this.buttonInitiateComm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInitiateComm.Name = "buttonInitiateComm";
            this.buttonInitiateComm.Size = new System.Drawing.Size(100, 23);
            this.buttonInitiateComm.TabIndex = 14;
            this.buttonInitiateComm.Text = "Initiate COM";
            this.buttonInitiateComm.UseVisualStyleBackColor = true;
            this.buttonInitiateComm.Click += new System.EventHandler(this.buttonInitiateComm_Click);
            // 
            // buttonStopComm
            // 
            this.buttonStopComm.Enabled = false;
            this.buttonStopComm.Location = new System.Drawing.Point(390, 32);
            this.buttonStopComm.Margin = new System.Windows.Forms.Padding(0);
            this.buttonStopComm.Name = "buttonStopComm";
            this.buttonStopComm.Size = new System.Drawing.Size(100, 23);
            this.buttonStopComm.TabIndex = 15;
            this.buttonStopComm.Text = "Stop COM";
            this.buttonStopComm.UseVisualStyleBackColor = true;
            this.buttonStopComm.Click += new System.EventHandler(this.buttonFinishComm_Click);
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.buttonOutputUpdate);
            this.panelMain.Controls.Add(this.textBoxOutputControl);
            this.panelMain.Controls.Add(this.labelOutputValue);
            this.panelMain.Controls.Add(this.buttonProbeUpdate);
            this.panelMain.Controls.Add(this.textBoxProbeValue);
            this.panelMain.Controls.Add(this.labelProbeValue);
            this.panelMain.Controls.Add(this.buttonSetPointUpdate);
            this.panelMain.Controls.Add(this.buttonInputUpdate);
            this.panelMain.Controls.Add(this.textBoxSetpointValue);
            this.panelMain.Controls.Add(this.labelSetPointValue);
            this.panelMain.Controls.Add(this.textBoxInputValue);
            this.panelMain.Controls.Add(this.labelInputValue);
            this.panelMain.Controls.Add(this.labelInputType);
            this.panelMain.Controls.Add(this.comboBoxInputType);
            this.panelMain.Location = new System.Drawing.Point(25, 77);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(465, 201);
            this.panelMain.TabIndex = 16;
            // 
            // buttonSetPointUpdate
            // 
            this.buttonSetPointUpdate.Location = new System.Drawing.Point(382, 85);
            this.buttonSetPointUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSetPointUpdate.Name = "buttonSetPointUpdate";
            this.buttonSetPointUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPointUpdate.TabIndex = 15;
            this.buttonSetPointUpdate.Text = "Update";
            this.buttonSetPointUpdate.UseVisualStyleBackColor = true;
            this.buttonSetPointUpdate.Click += new System.EventHandler(this.buttonOutputUpdate_Click);
            // 
            // buttonInputUpdate
            // 
            this.buttonInputUpdate.Location = new System.Drawing.Point(141, 86);
            this.buttonInputUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonInputUpdate.Name = "buttonInputUpdate";
            this.buttonInputUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonInputUpdate.TabIndex = 12;
            this.buttonInputUpdate.Text = "Update";
            this.buttonInputUpdate.UseVisualStyleBackColor = true;
            this.buttonInputUpdate.Click += new System.EventHandler(this.buttonInputUpdate_Click);
            // 
            // textBoxSetpointValue
            // 
            this.textBoxSetpointValue.Location = new System.Drawing.Point(255, 86);
            this.textBoxSetpointValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxSetpointValue.Name = "textBoxSetpointValue";
            this.textBoxSetpointValue.Size = new System.Drawing.Size(121, 22);
            this.textBoxSetpointValue.TabIndex = 14;
            // 
            // labelSetPointValue
            // 
            this.labelSetPointValue.AutoSize = true;
            this.labelSetPointValue.Location = new System.Drawing.Point(252, 70);
            this.labelSetPointValue.Name = "labelSetPointValue";
            this.labelSetPointValue.Size = new System.Drawing.Size(81, 13);
            this.labelSetPointValue.TabIndex = 16;
            this.labelSetPointValue.Text = "SetPoint Value";
            // 
            // textBoxInputValue
            // 
            this.textBoxInputValue.Enabled = false;
            this.textBoxInputValue.Location = new System.Drawing.Point(10, 86);
            this.textBoxInputValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxInputValue.Name = "textBoxInputValue";
            this.textBoxInputValue.Size = new System.Drawing.Size(121, 22);
            this.textBoxInputValue.TabIndex = 10;
            // 
            // labelInputValue
            // 
            this.labelInputValue.AutoSize = true;
            this.labelInputValue.Location = new System.Drawing.Point(7, 70);
            this.labelInputValue.Name = "labelInputValue";
            this.labelInputValue.Size = new System.Drawing.Size(66, 13);
            this.labelInputValue.TabIndex = 13;
            this.labelInputValue.Text = "Input Value";
            // 
            // labelInputType
            // 
            this.labelInputType.AutoSize = true;
            this.labelInputType.Location = new System.Drawing.Point(7, 12);
            this.labelInputType.Name = "labelInputType";
            this.labelInputType.Size = new System.Drawing.Size(60, 13);
            this.labelInputType.TabIndex = 8;
            this.labelInputType.Text = "Input Type";
            // 
            // comboBoxInputType
            // 
            this.comboBoxInputType.FormattingEnabled = true;
            this.comboBoxInputType.Location = new System.Drawing.Point(10, 28);
            this.comboBoxInputType.Margin = new System.Windows.Forms.Padding(0);
            this.comboBoxInputType.Name = "comboBoxInputType";
            this.comboBoxInputType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxInputType.TabIndex = 7;
            // 
            // numericUpDownModbusAddress
            // 
            this.numericUpDownModbusAddress.Location = new System.Drawing.Point(156, 34);
            this.numericUpDownModbusAddress.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDownModbusAddress.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownModbusAddress.Name = "numericUpDownModbusAddress";
            this.numericUpDownModbusAddress.Size = new System.Drawing.Size(120, 22);
            this.numericUpDownModbusAddress.TabIndex = 17;
            this.numericUpDownModbusAddress.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonProbeUpdate
            // 
            this.buttonProbeUpdate.Location = new System.Drawing.Point(382, 26);
            this.buttonProbeUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProbeUpdate.Name = "buttonProbeUpdate";
            this.buttonProbeUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonProbeUpdate.TabIndex = 18;
            this.buttonProbeUpdate.Text = "Update";
            this.buttonProbeUpdate.UseVisualStyleBackColor = true;
            this.buttonProbeUpdate.Click += new System.EventHandler(this.buttonProbeUpdate_Click);
            // 
            // textBoxProbeValue
            // 
            this.textBoxProbeValue.Location = new System.Drawing.Point(255, 27);
            this.textBoxProbeValue.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxProbeValue.Name = "textBoxProbeValue";
            this.textBoxProbeValue.Size = new System.Drawing.Size(121, 22);
            this.textBoxProbeValue.TabIndex = 17;
            // 
            // labelProbeValue
            // 
            this.labelProbeValue.AutoSize = true;
            this.labelProbeValue.Location = new System.Drawing.Point(252, 11);
            this.labelProbeValue.Name = "labelProbeValue";
            this.labelProbeValue.Size = new System.Drawing.Size(68, 13);
            this.labelProbeValue.TabIndex = 19;
            this.labelProbeValue.Text = "Probe Value";
            // 
            // buttonOutputUpdate
            // 
            this.buttonOutputUpdate.Location = new System.Drawing.Point(382, 140);
            this.buttonOutputUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.buttonOutputUpdate.Name = "buttonOutputUpdate";
            this.buttonOutputUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonOutputUpdate.TabIndex = 21;
            this.buttonOutputUpdate.Text = "Update";
            this.buttonOutputUpdate.UseVisualStyleBackColor = true;
            this.buttonOutputUpdate.Click += new System.EventHandler(this.buttonOutputUpdate_Click_1);
            // 
            // textBoxOutputControl
            // 
            this.textBoxOutputControl.Location = new System.Drawing.Point(255, 141);
            this.textBoxOutputControl.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxOutputControl.Name = "textBoxOutputControl";
            this.textBoxOutputControl.Size = new System.Drawing.Size(121, 22);
            this.textBoxOutputControl.TabIndex = 20;
            // 
            // labelOutputValue
            // 
            this.labelOutputValue.AutoSize = true;
            this.labelOutputValue.Location = new System.Drawing.Point(252, 125);
            this.labelOutputValue.Name = "labelOutputValue";
            this.labelOutputValue.Size = new System.Drawing.Size(76, 13);
            this.labelOutputValue.TabIndex = 22;
            this.labelOutputValue.Text = "Output Value";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 302);
            this.Controls.Add(this.numericUpDownModbusAddress);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonStopComm);
            this.Controls.Add(this.buttonInitiateComm);
            this.Controls.Add(this.labelModbusAddress);
            this.Controls.Add(this.labelComPort);
            this.Controls.Add(this.comboBoxComPort);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LC-505";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownModbusAddress)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelComPort;
        private System.Windows.Forms.ComboBox comboBoxComPort;
        private System.Windows.Forms.Label labelModbusAddress;
        private System.Windows.Forms.Button buttonInitiateComm;
        private System.Windows.Forms.Button buttonStopComm;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonSetPointUpdate;
        private System.Windows.Forms.Button buttonInputUpdate;
        private System.Windows.Forms.TextBox textBoxSetpointValue;
        private System.Windows.Forms.Label labelSetPointValue;
        private System.Windows.Forms.TextBox textBoxInputValue;
        private System.Windows.Forms.Label labelInputValue;
        private System.Windows.Forms.Label labelInputType;
        private System.Windows.Forms.ComboBox comboBoxInputType;
        private System.Windows.Forms.NumericUpDown numericUpDownModbusAddress;
        private System.Windows.Forms.Button buttonProbeUpdate;
        private System.Windows.Forms.TextBox textBoxProbeValue;
        private System.Windows.Forms.Label labelProbeValue;
        private System.Windows.Forms.Button buttonOutputUpdate;
        private System.Windows.Forms.TextBox textBoxOutputControl;
        private System.Windows.Forms.Label labelOutputValue;
    }
}

