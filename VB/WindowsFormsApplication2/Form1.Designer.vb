Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication2
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
			Me.dockManager1 = New DevExpress.XtraBars.Docking.DockManager(Me.components)
			Me.dockPanel1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel1_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.dockPanel2 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.dockPanel2_Container = New DevExpress.XtraBars.Docking.ControlContainer()
			Me.panelContainer1 = New DevExpress.XtraBars.Docking.DockPanel()
			Me.textEdit1 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit2 = New DevExpress.XtraEditors.TextEdit()
			Me.textEdit3 = New DevExpress.XtraEditors.TextEdit()
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.dockPanel1.SuspendLayout()
			Me.dockPanel1_Container.SuspendLayout()
			Me.dockPanel2.SuspendLayout()
			Me.dockPanel2_Container.SuspendLayout()
			Me.panelContainer1.SuspendLayout()
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dockManager1
			' 
			Me.dockManager1.Form = Me
			Me.dockManager1.RootPanels.AddRange(New DevExpress.XtraBars.Docking.DockPanel() { Me.panelContainer1})
			Me.dockManager1.TopZIndexControls.AddRange(New String() { "DevExpress.XtraBars.BarDockControl", "DevExpress.XtraBars.StandaloneBarDockControl", "System.Windows.Forms.StatusBar", "System.Windows.Forms.MenuStrip", "System.Windows.Forms.StatusStrip", "DevExpress.XtraBars.Ribbon.RibbonStatusBar", "DevExpress.XtraBars.Ribbon.RibbonControl"})

			' 
			' dockPanel1
			' 
			Me.dockPanel1.Controls.Add(Me.dockPanel1_Container)
			Me.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel1.ID = New System.Guid("6a043048-7826-44c9-8989-c15ffd3f2489")
			Me.dockPanel1.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel1.Name = "dockPanel1"
			Me.dockPanel1.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel1.Size = New System.Drawing.Size(238, 333)
			Me.dockPanel1.Text = "dockPanel1"
			' 
			' dockPanel1_Container
			' 
			Me.dockPanel1_Container.Controls.Add(Me.textEdit2)
			Me.dockPanel1_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel1_Container.Name = "dockPanel1_Container"
			Me.dockPanel1_Container.Size = New System.Drawing.Size(238, 333)
			Me.dockPanel1_Container.TabIndex = 0
			' 
			' dockPanel2
			' 
			Me.dockPanel2.Controls.Add(Me.dockPanel2_Container)
			Me.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill
			Me.dockPanel2.FloatVertical = True
			Me.dockPanel2.ID = New System.Guid("3b61d53c-65f3-49f8-a156-225b4b7e754b")
			Me.dockPanel2.Location = New System.Drawing.Point(4, 23)
			Me.dockPanel2.Name = "dockPanel2"
			Me.dockPanel2.OriginalSize = New System.Drawing.Size(200, 200)
			Me.dockPanel2.Size = New System.Drawing.Size(238, 333)
			Me.dockPanel2.Text = "dockPanel2"
			' 
			' dockPanel2_Container
			' 
			Me.dockPanel2_Container.Controls.Add(Me.textEdit3)
			Me.dockPanel2_Container.Location = New System.Drawing.Point(0, 0)
			Me.dockPanel2_Container.Name = "dockPanel2_Container"
			Me.dockPanel2_Container.Size = New System.Drawing.Size(238, 333)
			Me.dockPanel2_Container.TabIndex = 0
			' 
			' panelContainer1
			' 
			Me.panelContainer1.ActiveChild = Me.dockPanel2
			Me.panelContainer1.Controls.Add(Me.dockPanel1)
			Me.panelContainer1.Controls.Add(Me.dockPanel2)
			Me.panelContainer1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right
			Me.panelContainer1.ID = New System.Guid("286cf1e6-f11e-4d7f-89dd-78b56f6c8fee")
			Me.panelContainer1.Location = New System.Drawing.Point(213, 0)
			Me.panelContainer1.Name = "panelContainer1"
			Me.panelContainer1.OriginalSize = New System.Drawing.Size(246, 200)
			Me.panelContainer1.Size = New System.Drawing.Size(246, 387)
			Me.panelContainer1.Tabbed = True
			Me.panelContainer1.Text = "panelContainer1"
			' 
			' textEdit1
			' 
			Me.textEdit1.Location = New System.Drawing.Point(26, 119)
			Me.textEdit1.Name = "textEdit1"
			Me.textEdit1.Size = New System.Drawing.Size(100, 20)
			Me.textEdit1.TabIndex = 3

'			Me.textEdit1.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnTextEditMouseDown);
'			Me.textEdit1.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnTextEditMouseMove);
			' 
			' textEdit2
			' 
			Me.textEdit2.Location = New System.Drawing.Point(29, 57)
			Me.textEdit2.Name = "textEdit2"
			Me.textEdit2.Size = New System.Drawing.Size(100, 20)
			Me.textEdit2.TabIndex = 0
			' 
			' textEdit3
			' 
			Me.textEdit3.Location = New System.Drawing.Point(78, 167)
			Me.textEdit3.Name = "textEdit3"
			Me.textEdit3.Size = New System.Drawing.Size(100, 20)
			Me.textEdit3.TabIndex = 0
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(459, 387)
			Me.Controls.Add(Me.textEdit1)
			Me.Controls.Add(Me.panelContainer1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dockManager1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.dockPanel1.ResumeLayout(False)
			Me.dockPanel1_Container.ResumeLayout(False)
			Me.dockPanel2.ResumeLayout(False)
			Me.dockPanel2_Container.ResumeLayout(False)
			Me.panelContainer1.ResumeLayout(False)
			CType(Me.textEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.textEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private dockManager1 As DevExpress.XtraBars.Docking.DockManager
		Private WithEvents textEdit1 As DevExpress.XtraEditors.TextEdit
		Private panelContainer1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel1_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private dockPanel2 As DevExpress.XtraBars.Docking.DockPanel
		Private dockPanel2_Container As DevExpress.XtraBars.Docking.ControlContainer
		Private textEdit3 As DevExpress.XtraEditors.TextEdit
		Private textEdit2 As DevExpress.XtraEditors.TextEdit
	End Class
End Namespace

