Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Linq
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking
Imports DevExpress.XtraEditors

Namespace WindowsFormsApplication2
	Public Class PanelHelper
		Private manager As DockManager

		Public Sub New(ByVal manager As DockManager)
			Me.manager = manager
			AddHandler manager.RegisterDockPanel, AddressOf OnRegisterDockPanel
		End Sub

		Private Sub OnRegisterDockPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs)
			e.Panel.AllowDrop = True
			AddHandler e.Panel.DragOver, AddressOf OnPanelDragOver
		End Sub

		Private Sub OnPanelDragOver(ByVal sender As Object, ByVal e As DragEventArgs)
			Dim pnl As DockPanel = TryCast(sender, DockPanel)
			Dim pt As Point = pnl.PointToClient(New Point(e.X, e.Y))
			Dim info As HitInfo = pnl.GetHitInfo(pt)
			If info.HitTest = HitTest.Tab Then
				e.Effect = DragDropEffects.All
				info.Tab.Show()
			End If
		End Sub

		Private Sub OnUnregisterDockPanel(ByVal sender As Object, ByVal e As DevExpress.XtraBars.Docking.DockPanelEventArgs)
			RemoveHandler e.Panel.DragOver, AddressOf OnPanelDragOver
		End Sub
	End Class
End Namespace
