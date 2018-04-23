Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication3
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.customerInfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.dataSet11 = New WindowsApplication3.DataSet1()
			Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colFirstName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
			Me.colLastName = New DevExpress.XtraGrid.Columns.GridColumn()
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' customerInfoBindingSource
			' 
			Me.customerInfoBindingSource.DataMember = "CustomerInfo"
			Me.customerInfoBindingSource.DataSource = Me.dataSet11
			' 
			' dataSet11
			' 
			Me.dataSet11.DataSetName = "DataSet1"
			Me.dataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' imageList1
			' 
			Me.imageList1.ImageStream = (CType(resources.GetObject("imageList1.ImageStream"), System.Windows.Forms.ImageListStreamer))
			Me.imageList1.TransparentColor = System.Drawing.Color.Transparent
			Me.imageList1.Images.SetKeyName(0, "1.jpg")
			Me.imageList1.Images.SetKeyName(1, "2.jpg")
			Me.imageList1.Images.SetKeyName(2, "3.jpg")
			Me.imageList1.Images.SetKeyName(3, "4.jpg")
			Me.imageList1.Images.SetKeyName(4, "5.jpg")
			Me.imageList1.Images.SetKeyName(5, "6.jpg")
			Me.imageList1.Images.SetKeyName(6, "7.jpg")
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.customerInfoBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1})
			Me.gridControl1.Size = New System.Drawing.Size(969, 608)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colFirstName, Me.colLastName})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomDrawCell += New DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(Me.gridView1_CustomDrawCell);
'			Me.gridView1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.gridView1_MouseMove);
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' colFirstName
			' 
			Me.colFirstName.Caption = "FirstName"
			Me.colFirstName.ColumnEdit = Me.repositoryItemComboBox1
			Me.colFirstName.FieldName = "FirstName"
			Me.colFirstName.Name = "colFirstName"
			Me.colFirstName.Visible = True
			Me.colFirstName.VisibleIndex = 1
			' 
			' repositoryItemComboBox1
			' 
			Me.repositoryItemComboBox1.AutoHeight = False
			Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemComboBox1.Items.AddRange(New Object() { "0", "1", "2", "3", "4", "5"})
			Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
			' 
			' colLastName
			' 
			Me.colLastName.Caption = "LastName"
			Me.colLastName.FieldName = "LastName"
			Me.colLastName.Name = "colLastName"
			Me.colLastName.Visible = True
			Me.colLastName.VisibleIndex = 2
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(969, 608)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.customerInfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet11, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private customerInfoBindingSource As System.Windows.Forms.BindingSource
		Private dataSet11 As DataSet1
		Private imageList1 As System.Windows.Forms.ImageList
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colFirstName As DevExpress.XtraGrid.Columns.GridColumn
		Private colLastName As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
	End Class
End Namespace

