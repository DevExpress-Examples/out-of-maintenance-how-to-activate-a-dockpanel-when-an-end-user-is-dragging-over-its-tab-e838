Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication2
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			textEdit3.AllowDrop = True
			textEdit2.AllowDrop = textEdit3.AllowDrop
			AddHandler textEdit2.DragDrop, AddressOf OnTextEditDragDrop
			AddHandler textEdit3.DragDrop, AddressOf OnTextEditDragDrop

			AddHandler textEdit2.DragOver, AddressOf OnTextEditDragOver
			AddHandler textEdit3.DragOver, AddressOf OnTextEditDragOver

			Dim TempPanelHelper As PanelHelper = New PanelHelper(dockManager1)
		End Sub



		Private Sub OnTextEditMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles textEdit1.MouseMove
			If e.Button = MouseButtons.Left AndAlso ((Math.Abs(e.X - p.X) > SystemInformation.DragSize.Width) OrElse (Math.Abs(e.Y - p.Y) > SystemInformation.DragSize.Height)) Then
				Dim textEdit As TextEdit = TryCast(sender, TextEdit)
				textEdit.DoDragDrop(textEdit.Text, DragDropEffects.All)
			End If
		End Sub


		Private p As Point
		Private Sub OnTextEditMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles textEdit1.MouseDown
			p = New Point(e.X, e.Y)
		End Sub

		Private Sub OnTextEditDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			If e.Data.GetDataPresent(GetType(String)) Then
				e.Effect = DragDropEffects.Copy
			End If
		End Sub


		Private Sub OnTextEditDragDrop(ByVal sender As Object, ByVal e As DragEventArgs)
			If e.Data.GetDataPresent(GetType(String)) Then
				Dim text As String = e.Data.GetData(GetType(String)).ToString()
				Dim textEdit As TextEdit = TryCast(sender, TextEdit)
				textEdit.EditValue = text
			End If
		End Sub

		Protected Overrides Sub OnFormClosing(ByVal e As FormClosingEventArgs)
			MyBase.OnFormClosing(e)
			RemoveHandler textEdit2.DragDrop, AddressOf OnTextEditDragDrop
			RemoveHandler textEdit3.DragDrop, AddressOf OnTextEditDragDrop

			RemoveHandler textEdit2.DragOver, AddressOf OnTextEditDragOver
			RemoveHandler textEdit3.DragOver, AddressOf OnTextEditDragOver
		End Sub
	End Class
End Namespace