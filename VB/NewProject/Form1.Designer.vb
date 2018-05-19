Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.DashboardCommon
Namespace NewProject
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
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			Me.simpleButton1 = New DevExpress.XtraEditors.SimpleButton()
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.DashboardSource = GetType(NewProject.Dashboard1)
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.PrintingOptions.FontInfo.GdiCharSet = (CByte(0))
			Me.dashboardViewer1.PrintingOptions.FontInfo.Name = Nothing
			Me.dashboardViewer1.Size = New System.Drawing.Size(662, 490)
			Me.dashboardViewer1.TabIndex = 0
'			Me.dashboardViewer1.DataLoading += New DataLoadingEventHandler(Me.dashboardViewer1_DataLoading);
			' 
			' simpleButton1
			' 
			Me.simpleButton1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.simpleButton1.Location = New System.Drawing.Point(575, 455)
			Me.simpleButton1.Name = "simpleButton1"
			Me.simpleButton1.Size = New System.Drawing.Size(75, 23)
			Me.simpleButton1.TabIndex = 1
			Me.simpleButton1.Text = "Test"
'			Me.simpleButton1.Click += New System.EventHandler(Me.simpleButton1_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(662, 490)
			Me.Controls.Add(Me.simpleButton1)
			Me.Controls.Add(Me.dashboardViewer1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
		Private WithEvents simpleButton1 As DevExpress.XtraEditors.SimpleButton






	End Class
End Namespace

