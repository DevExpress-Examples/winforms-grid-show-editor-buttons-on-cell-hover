using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using DevExpress.XtraEditors.Repository;


namespace DXSample {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        public void InitData() {
            recordBindingSource.DataSource = DataHelper.GetData(100);
        }
       
        private void Form1_Load(object sender, EventArgs e) {
            this.InitData();
        }
       
        int rowHandle = -1;

        private void gridView1_MouseMove(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            GridHitInfo hi = view.CalcHitInfo(e.Location);

            if(hi.InRowCell && hi.Column.FieldName == "Text") 
                rowHandle = hi.RowHandle;
            else
                rowHandle = -1;
           view.Invalidate(); 
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column.FieldName == "Text" && e.RowHandle == rowHandle) {
                GridCellInfo cellInfo = e.Cell as GridCellInfo;
                ButtonEditViewInfo info = cellInfo.ViewInfo as ButtonEditViewInfo;
                Rectangle textRect = info.MaskBoxRect;
                textRect.Offset(e.Bounds.X, e.Bounds.Y);
                EditorButtonObjectInfoArgs args = new EditorButtonObjectInfoArgs(e.Cache, info.Item.Buttons[0], e.Appearance);
                Rectangle minBounds = info.EditorButtonPainter.CalcObjectMinBounds(args);
                args.Bounds = new Rectangle(e.Bounds.Right - minBounds.Width, e.Bounds.Y + (e.Bounds.Height - minBounds.Height) / 2, minBounds.Width, minBounds.Height);
                info.EditorButtonPainter.DrawObject(args);
                e.Cache.DrawString(e.DisplayText, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), textRect, e.Appearance.GetStringFormat());
                e.Handled = true;
            }
        }

    }
}
