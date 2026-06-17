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

namespace RTURelayControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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