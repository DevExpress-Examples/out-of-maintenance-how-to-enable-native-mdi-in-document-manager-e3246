Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraBars.Docking2010.Views.NativeMdi
Imports DevExpress.XtraEditors

Namespace DocumentManager_NativeMDI
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Private childCount As Integer = 0
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			CreateDocumentManager()
			For i As Integer = 0 To 2
				AddChild()
			Next i
		End Sub
		Private Sub CreateDocumentManager()
			Dim dm As New DocumentManager(components)
			dm.MdiParent = Me
			dm.View = New NativeMdiView()
		End Sub
		Private Sub AddChild()
			Dim childForm As Form = Nothing
			childForm = New Form()
			childCount += 1
'INSTANT VB WARNING: An assignment within expression was extracted from the following statement:
'ORIGINAL LINE: childForm.Text = "Child Form " + (++childCount);
			childForm.Text = "Child Form " & (childCount)

			Dim btn As New SimpleButton()
			btn.Text = "Button " & childCount
			btn.Parent = childForm

			childForm.MdiParent = Me
			childForm.Show()
		End Sub
	End Class
End Namespace