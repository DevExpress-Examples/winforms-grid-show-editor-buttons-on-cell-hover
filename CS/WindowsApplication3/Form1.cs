using System;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Controls;
using System.Drawing;
using DevExpress.XtraEditors.Repository;


namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0;i < 100;i++)
                dataSet11.Tables[0].Rows.Add(new object[] { i, i, i});
        }
       
        private void Form1_Load(object sender, EventArgs e) {
            this.InitData();
            gridControl1.ForceInitialize();
        }
       
        int rowHandle = -1;

        private void gridView1_MouseMove(object sender, MouseEventArgs e) {
            GridView view = sender as GridView;
            GridHitInfo hi = view.CalcHitInfo(e.Location);

            if(hi.InRowCell && hi.Column.FieldName == "FirstName") 
                rowHandle = hi.RowHandle;
            else
                rowHandle = -1;
           view.Invalidate(); 
        }

        private void gridView1_CustomDrawCell(object sender, DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs e) {
            if(e.Column.FieldName == "FirstName" && e.RowHandle == rowHandle) {
                ComboBoxViewInfo info = (e.Cell as GridCellInfo).ViewInfo as ComboBoxViewInfo;
                EditorButtonObjectInfoArgs args = new EditorButtonObjectInfoArgs(e.Cache, new EditorButton(ButtonPredefines.Combo), e.Appearance);
                args.Bounds = new Rectangle(e.Bounds.Right - 17, e.Bounds.Y, 17, e.Bounds.Height);
                info.EditorButtonPainter.DrawObject(args);
                Rectangle rect = e.Bounds;
                rect.Offset(2, 0);
                e.Appearance.DrawString(e.Cache, e.DisplayText, rect);
                e.Handled = true;
            }
        }

    }
}
