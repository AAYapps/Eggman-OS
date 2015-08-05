Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class Form6
	Inherits System.Windows.Forms.Form
	Private Declare Function sndPlaySound Lib "winmm.dll"  Alias "sndPlaySoundA"(ByVal lpszSoundName As String, ByVal uFlags As Integer) As Integer
	Private Const sndAsync As Integer = &H1
	Private Const sndLoop As Integer = &H8
	Private Const sndNoStop As Integer = &H10
	Sub pause(ByRef interval As Object)
		Dim current As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		current = VB.Timer()
		'UPGRADE_WARNING: Couldn't resolve default property of object interval. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object current. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Do While VB.Timer() - current < Val(interval)
			System.Windows.Forms.Application.DoEvents()
		Loop 
	End Sub
	
	Private Sub Picture1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture1.Click
		If Form1.Visible = True Then
			If MsgBox("Are you sure you what to force shutdown computer", MsgBoxStyle.YesNo, "Force Shutdown") = MsgBoxResult.Yes Then
				sndPlaySound("C:\windows\media\ding.wav", sndAsync)
				Form1.Visible = False
			End If
		End If
		Form2.Visible = False
		Form4.Visible = False
		Form5.Visible = False
		Form3.Visible = False
		Form3.Timer1.Enabled = False
		Form3.Timer2.Enabled = False
		Form3.Label1.Text = "0"
		Picture2.Visible = True
		sndPlaySound("C:\windows\media\ding.wav", sndAsync)
	End Sub
	
	Private Sub Picture2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Picture2.Click
		Picture2.Visible = False
		sndPlaySound("C:\eggman.wav", sndAsync)
		pause((5))
		Form3.Visible = True
		Form3.Timer1.Enabled = True
	End Sub
End Class