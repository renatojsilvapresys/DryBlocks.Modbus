using System;
using System.IO.Ports;
using System.Windows.Forms;

namespace DryBlocks.DemoApp
{
    public partial class FormMain : Form
    {
        private Presys.Calibrators.Comm.DryBlocks.Modbus.DryBlocks device;

        public FormMain()
        {
            InitializeComponent();
            device = new Presys.Calibrators.Comm.DryBlocks.Modbus.DryBlocks();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            comboBoxComPort.DataSource = SerialPort.GetPortNames();

            comboBoxInputType.DataSource = Presys.Calibrators.Comm.DryBlocks.Modbus.DryBlocks.GetInputTypes();
            //comboBoxOutputType.DataSource = Presys.Calibrators.Comm.DryBlocks.Modbus.DryBlocks.GetOuputTypes();           

            ClearForm();

            comboBoxInputType.SelectedIndexChanged += comboBoxInputType_SelectedIndexChanged;
            //comboBoxOutputType.SelectedIndexChanged += comboBoxOutputType_SelectedIndexChanged;
        }

        private void buttonInitiateComm_Click(object sender, EventArgs e)
        {
            device.InitiateComm(String.Format("{0}|{1}|{2}|{3}|{4}|{5}|{6}|{7}",
                comboBoxComPort.Text, numericUpDownModbusAddress.Text, 
                "5", "0", "1", "0", "500", "50"));
            StartForm();
        }

        private void buttonFinishComm_Click(object sender, EventArgs e)
        {
            device.FinishComm();
            ClearForm();
        }

        private void comboBoxInputType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                device.ChangeInputType(comboBoxInputType.Text);
            }
            catch (Exception ex)
            {
                ClearForm();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                       
        }              

        private void buttonInputUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxInputValue.Text = device.ReadInputValue();
            }
            catch (Exception ex)
            {
                ClearForm();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void buttonOutputUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxSetpointValue.Text = device.SetSetPointValue(textBoxSetpointValue.Text);
            }
            catch (FormatException ex)
            {             
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }            
        }       

        private void StartForm()
        {
            panelMain.Enabled = buttonStopComm.Enabled = true;
            comboBoxComPort.Enabled = numericUpDownModbusAddress.Enabled = buttonInitiateComm.Enabled = !panelMain.Enabled;

            try
            {
                comboBoxInputType.SelectedItem = device.GetCurrentInputType();
                //comboBoxOutputType.SelectedItem = device.GetCurrentOutputType();
            }
            catch (Exception ex)
            {
                ClearForm();
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }           
        }

        private void ClearForm()
        {
            panelMain.Enabled = buttonStopComm.Enabled = false;
            buttonInitiateComm.Enabled = !panelMain.Enabled;
            comboBoxComPort.Enabled = numericUpDownModbusAddress.Enabled = buttonInitiateComm.Enabled = !panelMain.Enabled;

            comboBoxInputType.SelectedItem = "None";
            //comboBoxOutputType.SelectedItem = "None";

            textBoxInputValue.Text = String.Empty;
            textBoxSetpointValue.Text = String.Empty;
        }

        private void buttonProbeUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxProbeValue.Text = device.ReadProbeValue();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutputUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                textBoxOutputControl.Text = device.ReadOutputControlValue();
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
