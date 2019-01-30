Namespace DXSample
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
            Me.imageList1 = New System.Windows.Forms.ImageList(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.repositoryItemComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemComboBox()
            Me.recordBindingSource = New System.Windows.Forms.BindingSource(Me.components)
            Me.colID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colParentID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colText = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colInfo = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colValue = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDt = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colState = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colImage = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colDetail = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.repositoryItemButtonEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit()
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
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
            Me.gridControl1.DataSource = Me.recordBindingSource
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(2)
            Me.gridControl1.Location = New System.Drawing.Point(0, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Margin = New System.Windows.Forms.Padding(2)
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemComboBox1, Me.repositoryItemButtonEdit1})
            Me.gridControl1.Size = New System.Drawing.Size(727, 494)
            Me.gridControl1.TabIndex = 0
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colID, Me.colParentID, Me.colText, Me.colInfo, Me.colValue, Me.colDt, Me.colState, Me.colImage, Me.colDetail})
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' repositoryItemComboBox1
            ' 
            Me.repositoryItemComboBox1.AutoHeight = False
            Me.repositoryItemComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.repositoryItemComboBox1.Items.AddRange(New Object() { "0", "1", "2", "3", "4", "5"})
            Me.repositoryItemComboBox1.Name = "repositoryItemComboBox1"
            ' 
            ' recordBindingSource
            ' 
            Me.recordBindingSource.DataSource = GetType(DXSample.Record)
            ' 
            ' colID
            ' 
            Me.colID.FieldName = "ID"
            Me.colID.Name = "colID"
            Me.colID.Visible = True
            Me.colID.VisibleIndex = 0
            ' 
            ' colParentID
            ' 
            Me.colParentID.FieldName = "ParentID"
            Me.colParentID.Name = "colParentID"
            Me.colParentID.Visible = True
            Me.colParentID.VisibleIndex = 1
            ' 
            ' colText
            ' 
            Me.colText.ColumnEdit = Me.repositoryItemButtonEdit1
            Me.colText.FieldName = "Text"
            Me.colText.Name = "colText"
            Me.colText.Visible = True
            Me.colText.VisibleIndex = 2
            ' 
            ' colInfo
            ' 
            Me.colInfo.FieldName = "Info"
            Me.colInfo.Name = "colInfo"
            Me.colInfo.Visible = True
            Me.colInfo.VisibleIndex = 3
            ' 
            ' colValue
            ' 
            Me.colValue.FieldName = "Value"
            Me.colValue.Name = "colValue"
            Me.colValue.Visible = True
            Me.colValue.VisibleIndex = 4
            ' 
            ' colDt
            ' 
            Me.colDt.FieldName = "Dt"
            Me.colDt.Name = "colDt"
            Me.colDt.Visible = True
            Me.colDt.VisibleIndex = 5
            ' 
            ' colState
            ' 
            Me.colState.FieldName = "State"
            Me.colState.Name = "colState"
            Me.colState.Visible = True
            Me.colState.VisibleIndex = 6
            ' 
            ' colImage
            ' 
            Me.colImage.FieldName = "Image"
            Me.colImage.Name = "colImage"
            Me.colImage.Visible = True
            Me.colImage.VisibleIndex = 7
            ' 
            ' colDetail
            ' 
            Me.colDetail.FieldName = "Detail"
            Me.colDetail.Name = "colDetail"
            Me.colDetail.Visible = True
            Me.colDetail.VisibleIndex = 8
            ' 
            ' repositoryItemButtonEdit1
            ' 
            Me.repositoryItemButtonEdit1.AutoHeight = False
            Me.repositoryItemButtonEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
            Me.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(727, 494)
            Me.Controls.Add(Me.gridControl1)
            Me.Margin = New System.Windows.Forms.Padding(2)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.recordBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.repositoryItemButtonEdit1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private imageList1 As System.Windows.Forms.ImageList
        Private gridControl1 As DevExpress.XtraGrid.GridControl
        Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Private repositoryItemComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemComboBox
        Private recordBindingSource As System.Windows.Forms.BindingSource
        Private colID As DevExpress.XtraGrid.Columns.GridColumn
        Private colParentID As DevExpress.XtraGrid.Columns.GridColumn
        Private colText As DevExpress.XtraGrid.Columns.GridColumn
        Private repositoryItemButtonEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit
        Private colInfo As DevExpress.XtraGrid.Columns.GridColumn
        Private colValue As DevExpress.XtraGrid.Columns.GridColumn
        Private colDt As DevExpress.XtraGrid.Columns.GridColumn
        Private colState As DevExpress.XtraGrid.Columns.GridColumn
        Private colImage As DevExpress.XtraGrid.Columns.GridColumn
        Private colDetail As DevExpress.XtraGrid.Columns.GridColumn
    End Class
End Namespace

