Imports Microsoft.VisualBasic
Imports System
Namespace WindowsFormsApplication1
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
			Me.button1 = New System.Windows.Forms.Button()
			Me.checkedListBoxControl1 = New DevExpress.XtraEditors.CheckedListBoxControl()
			Me.folderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' button1
			' 
			Me.button1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.button1.Location = New System.Drawing.Point(13, 13)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(259, 23)
			Me.button1.TabIndex = 0
			Me.button1.Text = "Export Selected Reports"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click);
			' 
			' checkedListBoxControl1
			' 
			Me.checkedListBoxControl1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.checkedListBoxControl1.Location = New System.Drawing.Point(13, 43)
			Me.checkedListBoxControl1.Name = "checkedListBoxControl1"
			Me.checkedListBoxControl1.Size = New System.Drawing.Size(259, 206)
			Me.checkedListBoxControl1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(284, 261)
			Me.Controls.Add(Me.checkedListBoxControl1)
			Me.Controls.Add(Me.button1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.checkedListBoxControl1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents button1 As System.Windows.Forms.Button
		Private checkedListBoxControl1 As DevExpress.XtraEditors.CheckedListBoxControl
		Private folderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
	End Class
End Namespace

