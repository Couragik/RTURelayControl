using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Net.Configuration;

namespace RTURelayControl
{
    
    //Создаем список enum для открытия нужной секции в окне настроек
    public enum SettingsSectionEnum
    {
        Program,
        Interface,
        Timer,
        Automat
    
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMenuTags();

            AppSettings.Load();

            dataGridView1.ColumnCount = 3;


            dataGridView1.Columns[0].Name = "№";
            dataGridView1.Columns[1].Name = "Название";
            dataGridView1.Columns[2].Name = "Состояние";



            for (int i = 1; i <= 15; i++)
            {

                int row =
                dataGridView1.Rows.Add(
                    i,
                    "Реле " + i,
                    "ВЫКЛ");


                var cell = new SplitButtonCell();


                cell.Value = "ВЫКЛ";

                ContextMenuStrip menu =
                new ContextMenuStrip();


                menu.Items.Add("Авто");
                menu.Items.Add("Ручной");
                menu.Items.Add("Блокировка");


                cell.Menu = menu;


                dataGridView1.Rows[row]
                    .Cells[2] = cell;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            MessageBox.Show(
               Properties.Settings.Default.test,
               "Сообщение",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1,
               MessageBoxOptions.DefaultDesktopOnly);
            Properties.Settings.Default.test = "777";
            //Properties.Settings.Default.test3 = "678";
            Properties.Settings.Default.Save();
            */

        }

        public void InitializeMenuTags()
        {   
            programsetToolStripMenuItem.Tag = SettingsSectionEnum.Program;
            interfacesetToolStripMenuItem.Tag = SettingsSectionEnum.Interface;
            timersetToolStripMenuItem.Tag = SettingsSectionEnum.Timer;
            automatsetToolStripMenuItem.Tag = SettingsSectionEnum.Automat;
        }

        private void SettingsMenuItem_Click(object sender, EventArgs e)
        {
            var menuItem = (ToolStripMenuItem)sender;
            var section = (SettingsSectionEnum)menuItem.Tag;

            using (var settingsForm = new FormSettings(section))
            {
                settingsForm.ShowDialog();
            }
        }

    }

    public class RelayInfo
    {
        public string Name { get; set; }

        public bool State { get; set; }

        public string Mode { get; set; }
    }


    public class SplitButtonCell : DataGridViewButtonCell
    {
        public ContextMenuStrip Menu { get; set; }

        public int SplitWidth { get; set; } = 25;


        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {

            base.Paint(
                graphics,
                clipBounds,
                cellBounds,
                rowIndex,
                cellState,
                value,
                formattedValue,
                errorText,
                cellStyle,
                advancedBorderStyle,
                paintParts);


            // линия разделителя
            int x = cellBounds.Right - SplitWidth;
            graphics.DrawLine(
                        Pens.Gray,
                        x,
                        cellBounds.Top + 3,
                        x,
                        cellBounds.Bottom - 5);


            // стрелка
            int centerY = cellBounds.Y + cellBounds.Height / 2;
            Point[] arrow =
            {
            new Point(x + 7, centerY - 3),
            new Point(x + 16, centerY - 3),
            new Point(x + 11, centerY + 3)
            };


            graphics.FillPolygon(
                Brushes.Black,
                arrow);
        }

        protected override void OnMouseDown(
        DataGridViewCellMouseEventArgs e)
        {

            base.OnMouseDown(e);


            Rectangle arrowArea =
                new Rectangle(
                    this.ContentBounds.Right - SplitWidth,
                    this.ContentBounds.Top,
                    SplitWidth,
                    this.ContentBounds.Height);

            if (arrowArea.Contains(e.Location))
            {
                Menu?.Show(
                    DataGridView,
                    DataGridView.PointToClient(
                        Cursor.Position));
            }
            else
            {
                // основная кнопка

                if (Value?.ToString() == "ВКЛ")
                    Value = "ВЫКЛ";
                else
                    Value = "ВКЛ";


                DataGridView.Refresh();
            }
        }
    }
}