<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128631892/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1956)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Data Grid - Show editor button when hovering over a data cell

In this example:

The [GridView.OptionsView.ShowButtonMode](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Base.ColumnViewOptionsView.ShowButtonMode) property speifies when the View displays editor buttons. Available modes include:

* Display editor buttons for all cdata ells.
* Display editor buttons for the focused cell.
* Display editor buttons for data cells within the focused row.
* Display editor buttons for the active cell editor.

This example handles the [CustomDrawCell](https://docs.devexpress.com/WindowsForms/DevExpress.XtraGrid.Views.Grid.GridView.CustomDrawCell) event to display editor buttons when hovering over a grid cell:

```csharp
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
```


## Files to Review

* [Form1.cs](./CS/WindowsApplication3/Form1.cs) (VB: [Form1.vb](./VB/WindowsApplication3/Form1.vb))
