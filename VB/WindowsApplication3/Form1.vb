Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository


Namespace DXSample
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Sub InitData()
            recordBindingSource.DataSource = DataHelper.GetData(100)
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
            Me.InitData()
        End Sub

        Private rowHandle As Integer = -1

        Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
            Dim view As GridView = TryCast(sender, GridView)
            Dim hi As GridHitInfo = view.CalcHitInfo(e.Location)

            If hi.InRowCell AndAlso hi.Column.FieldName = "Text" Then
                rowHandle = hi.RowHandle
            Else
                rowHandle = -1
            End If
           view.Invalidate()
        End Sub

        Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
            If e.Column.FieldName = "Text" AndAlso e.RowHandle = rowHandle Then
                Dim cellInfo As GridCellInfo = TryCast(e.Cell, GridCellInfo)
                Dim info As ButtonEditViewInfo = TryCast(cellInfo.ViewInfo, ButtonEditViewInfo)
                Dim textRect As Rectangle = info.MaskBoxRect
                textRect.Offset(e.Bounds.X, e.Bounds.Y)
                Dim args As New EditorButtonObjectInfoArgs(e.Cache, info.Item.Buttons(0), e.Appearance)
                Dim minBounds As Rectangle = info.EditorButtonPainter.CalcObjectMinBounds(args)
                args.Bounds = New Rectangle(e.Bounds.Right - minBounds.Width, e.Bounds.Y + (e.Bounds.Height - minBounds.Height) \ 2, minBounds.Width, minBounds.Height)
                info.EditorButtonPainter.DrawObject(args)
                e.Cache.DrawString(e.DisplayText, e.Appearance.Font, e.Appearance.GetForeBrush(e.Cache), textRect, e.Appearance.GetStringFormat())
                e.Handled = True
            End If
        End Sub

    End Class
End Namespace
