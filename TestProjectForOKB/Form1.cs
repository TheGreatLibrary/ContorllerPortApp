using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO.Ports;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestProjectForOKB
{
    public partial class Form1 : Form
    {
        private SerialPort serialPort;

        private bool disconnecting = false; // отвечает за разрешенность работы метода по получению данных
        public Form1()
        {
            InitializeComponent();

            // инициализация настроек значениями по умолчанию из списка
            comboBoxBaudRate.SelectedIndex = 2;
            comboBoxDataBits.SelectedIndex = 3;
            comboBoxStopBits.SelectedIndex = 0;

            serialPort = new SerialPort(); // инициализация порта

            // добавление в выпадающее меню вариантов, исходя из описаний настроек порта
            LoadAvailablePorts();
            LoadParityOptions();
            LoadHandshakeOptions();
        } 

        private void LoadAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
        } // получение всех доступных портов
        private void LoadParityOptions()
        {
            comboBoxParity.Items.AddRange(Enum.GetNames(typeof(Parity)));
            comboBoxParity.SelectedItem = Parity.None.ToString();
        } // получение всех доступных вариантов битов четности
        private void LoadHandshakeOptions()
        {
            comboBoxHandshake.Items.AddRange(Enum.GetNames(typeof(Handshake)));
            comboBoxHandshake.SelectedItem = Handshake.None.ToString();
        } // получение всех доступных вариантов протоколов управления

        private void ConnectOff_Click(object sender, EventArgs e)
        {
            try
            {
                disconnecting = true; // идет отключение, нельзя получать данные

                if (serialPort.IsOpen)
                {
                    serialPort.DataReceived -= DataReceivedHandler; // Unsubscribe the event handler first
                    serialPort.Close();
                    textBoxStatus.AppendText("Отключено от " + serialPort.PortName + Environment.NewLine);
                }
            }
            catch (Exception ex)
            {
                textBoxStatus.AppendText("Ошибка при отключении: " + ex.Message + Environment.NewLine);
            }
            finally
            {
                disconnecting = false; // отключение завершено, после подключения можно будет запрашивать данные
            }
        } // отключает текущее подключение порта
        private void ConnectOn_Click(object sender, EventArgs e)
        {
            if (comboBoxPorts.SelectedItem != null && !disconnecting)
            {
                try
                {
                    serialPort.PortName = comboBoxPorts.SelectedItem.ToString();
                    serialPort.BaudRate = int.Parse(comboBoxBaudRate.SelectedItem.ToString());
                    serialPort.DataBits = int.Parse(comboBoxDataBits.SelectedItem.ToString());
                    serialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), comboBoxStopBits.SelectedItem.ToString());

                    // Обработка значения четности
                    string selectedParity = comboBoxParity.SelectedItem.ToString();
                    if (Enum.TryParse<Parity>(selectedParity, out var parity))
                    {
                        serialPort.Parity = parity;
                    }
                    else
                    {
                        serialPort.Parity = Parity.None;
                    }
                    // Обработка значения четности
                    string selectedHandshake = comboBoxHandshake.SelectedItem.ToString();
                    if (Enum.TryParse<Handshake>(selectedHandshake, out var handshake))
                    {
                        serialPort.Handshake = handshake;
                    }
                    else
                    {
                        serialPort.Handshake = Handshake.None;
                    }

                    serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
                    serialPort.Open();
                    textBoxStatus.AppendText("Подключено к " + serialPort.PortName + Environment.NewLine);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка подключения: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Выберите COM-порт.");
            }
        } // подключает порт и производит настройку по выбранным настройкам

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                try
                {
                    string date = serialPort.ReadLine();
                    var splitedDate = date.Split(' ');

                    this.Invoke(new Action(() =>
                    {
                        if (splitedDate[0] == "ch3_res")
                            textBoxPressure.AppendText(date + Environment.NewLine);
                        if (splitedDate[0] == "ch2_res")
                            textBoxTemperature.AppendText(date + Environment.NewLine);
                    }));
                }
                catch (Exception ex)
                {
                    this.Invoke(new Action(() =>
                    {
                        textBoxStatus.AppendText("Ошибка при получении данных: " + ex.Message + Environment.NewLine);
                    }));
                }
            }
        } // Отвечает за запрос данных и выведение
    }
}
