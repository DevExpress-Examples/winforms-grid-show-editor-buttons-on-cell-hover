Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors.Controls
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository


Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			For i As Integer = 0 To 99
				dataSet11.Tables(0).Rows.Add(New Object() { i, i, i})
			Next i
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Me.InitData()
			gridControl1.ForceInitialize()
		End Sub

		Private rowHandle As Integer = -1

		Private Sub gridView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles gridView1.MouseMove
			Dim view As GridView = TryCast(sender, GridView)
			Dim hi As GridHitInfo = view.CalcHitInfo(e.Location)

			If hi.InRowCell AndAlso hi.Column.FieldName = "FirstName" Then
				rowHandle = hi.RowHandle
			Else
				rowHandle = -1
			End If
		   view.Invalidate()
		End Sub

		Private Sub gridView1_CustomDrawCell(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventArgs) Handles gridView1.CustomDrawCell
			If e.Column.FieldName = "FirstName" AndAlso e.RowHandle = rowHandle Then
				Dim info As ComboBoxViewInfo = TryCast((TryCast(e.Cell, GridCellInfo)).ViewInfo, ComboBoxViewInfo)
				Dim args As New EditorButtonObjectInfoArgs(e.Cache, New EditorButton(ButtonPredefines.Combo), e.Appearance)
				args.Bounds = New Rectangle(e.Bounds.Right - 17, e.Bounds.Y, 17, e.Bounds.Height)
				info.EditorButtonPainter.DrawObject(args)
				Dim rect As Rectangle = e.Bounds
				rect.Offset(2, 0)
				e.Appearance.DrawString(e.Cache, e.DisplayText, rect)
				e.Handled = True
			End If
		End Sub

	End Class
End Namespace
