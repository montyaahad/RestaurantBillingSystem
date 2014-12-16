using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using ComponentFactory.Krypton.Toolkit;
using System.Collections.Generic;
using Service.DTO;

namespace Windows.UserControls.BaseUserControls
{
    [Designer(typeof (ControlDesigner))]
    public partial class OpenGridView : KryptonDataGridView
    {
        public OpenGridView()
        {
            InitializeComponent();
        }

        public OpenGridView(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int rowHeight = RowTemplate.Height;

            int h = ColumnHeadersHeight + rowHeight*RowCount;
            int imgWidth = Width - 2;
            var rFrame = new Rectangle(0, 0, imgWidth, rowHeight);
            var rFill = new Rectangle(1, 1, imgWidth - 2, rowHeight);
            var rowHeader = new Rectangle(2, 2, RowHeadersWidth - 3, rowHeight);

            var pen = new Pen(GridColor, 1);

            var rowImg = new Bitmap(imgWidth, rowHeight);
            Graphics g = Graphics.FromImage(rowImg);
            g.DrawRectangle(pen, rFrame);
            g.FillRectangle(new SolidBrush(DefaultCellStyle.BackColor), rFill);
            g.FillRectangle(new SolidBrush(RowHeadersDefaultCellStyle.BackColor), rowHeader);

            var rowImgAAlternative = rowImg.Clone() as Bitmap;
            Graphics g2 = Graphics.FromImage(rowImgAAlternative);
            rFill.X += RowHeadersWidth - 1;
            g2.FillRectangle(new SolidBrush(AlternatingRowsDefaultCellStyle.BackColor), rFill);

            int w = RowHeadersWidth - 1;
            for (int j = 0; j < ColumnCount; j++)
            {
                g.DrawLine(pen, new Point(w, 0), new Point(w, rowHeight));
                g2.DrawLine(pen, new Point(w, 0), new Point(w, rowHeight));
                w += Columns[j].Width;
            }

            int loop = (Height - h)/rowHeight;
            for (int j = 0; j < loop + 1; j++)
            {
                int index = RowCount + j;
                if (index%2 == 0)
                {
                    e.Graphics.DrawImage(rowImg, 1, h + j*rowHeight);
                }
                else
                {
                    e.Graphics.DrawImage(rowImgAAlternative, 1, h + j*rowHeight);
                }
            }
        }
    }
}