using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace RTURelayControl
{
    public partial class PortSettings : Form
    {
        public PortSettings()
        {
            InitializeComponent();

            InitializeFormElements();
            //comboBox1.SelectedIndex = 1;
        }

        /// <summary>
        /// Возвращение текстового представления параметра порта "Четность"
        /// </summary>
        /// <param name="parity">Передача четности типа Parity</param>
        /// <returns>Текстовое представление параметра</returns>
        private string GetParityText(Parity parity)
        {
            switch(parity){
                case Parity.None: return Resources.UiText.PortSettingsCBoxParityNone;
                case Parity.Even: return Resources.UiText.PortSettingsCBoxParityEven;
                case Parity.Odd: return Resources.UiText.PortSettingsCBoxParityOdd;
                case Parity.Mark: return Resources.UiText.PortSettingsCBoxParityMark;
                case Parity.Space: return Resources.UiText.PortSettingsCBoxParitySpace;
                default: return parity.ToString();
            }
        }

        /// <summary>
        /// Возвращение текстового представления параметра порта "Стоповый бит"
        /// </summary>
        /// <param name="stopBits">Передача стопового бита типа StopBits</param>
        /// <returns>Текстовое представление параметра</returns>
        private string GetStopBitsText(StopBits stopBits)
        {
            switch (stopBits)
            {
                case StopBits.None: return Resources.UiText.PortSettingsCBoxParityNone;
                case StopBits.One: return "1";
                case StopBits.OnePointFive: return "1.5";
                case StopBits.Two: return "2";
                default: return stopBits.ToString();
            }
        }

        /// <summary>
        /// Задание параметров элементов формы
        /// </summary>
        private void InitializeFormElements()
        {
            //Занесение локализованных подписей элементов
            this.Text = Resources.UiText.PortSettingsCaption;
            buttonAccept.Text = Resources.UiText.ButtonAccept;
            buttonCancel.Text = Resources.UiText.ButtonCancel;
            labelComPort.Text = Resources.UiText.PortSettingsLabelCOMPort;
            labelBaudRate.Text = Resources.UiText.PortSettingsLabelBaudRate;
            labelDataBit.Text = Resources.UiText.PortSettingsLabelDataBit;
            labelParity.Text = Resources.UiText.PortSettingsLabelParity;
            labelStopBit.Text = Resources.UiText.PortSettingsLabelStopBit;

            //Подключение DataSource к ComboBox объектам
            comboBoxComPort.DataSource = SerialPort.GetPortNames()
                .OrderBy(port => port)
                .ToList();
            comboBoxParity.DataSource = Enum.GetValues(typeof(Parity))
                .Cast<Parity>()
               // .OrderByDescending(p => p)
                .Select(p => new {Text = GetParityText(p), Value = p})
                .ToList();
            comboBoxStopBit.DataSource = Enum.GetValues(typeof(StopBits))
                .Cast<StopBits>()
              //  .OrderBy(s => s)
                .Select(s => new {Text = GetStopBitsText(s), Value = s})
                .ToList();

            //Указываем какие параметры отвечают за текст какие за значение
            comboBoxParity.DisplayMember = "Text";
            comboBoxParity.ValueMember = "Value";
            comboBoxStopBit.DisplayMember = "Text";
            comboBoxStopBit.ValueMember = "Value";

            //SerialPort port = new SerialPort("COM1", 300 , Parity.None, 8, StopBits.One);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}
