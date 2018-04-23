Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Reflection
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraReports.UI

Namespace WindowsFormsApplication1
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			If checkedListBoxControl1.CheckedItems.Count = 0 Then
				MessageBox.Show("Select at least one report from the list")
				Return
			End If

			If folderBrowserDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
				For Each item As CheckedListBoxItem In checkedListBoxControl1.CheckedItems
					Dim reportType As Type = System.Reflection.Assembly.GetExecutingAssembly().GetType(item.Value.ToString())
					Dim report As XtraReport = TryCast(Activator.CreateInstance(reportType), XtraReport)
					report.ExportToPdf(folderBrowserDialog1.SelectedPath & "\" & reportType.Name & ".pdf")
				Next item
			End If
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim allTypes() As Type = System.Reflection.Assembly.GetExecutingAssembly().GetTypes()

			For Each curType As Type In allTypes
				If curType.BaseType Is GetType(XtraReport) Then
					checkedListBoxControl1.Items.Add(curType.ToString())
				End If
			Next curType

		End Sub
	End Class
End Namespace
