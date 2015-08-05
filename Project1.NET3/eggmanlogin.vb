Option Strict Off
Option Explicit On
Friend Class Form4
	Inherits System.Windows.Forms.Form
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		If Text1.Text = "" Then
			MsgBox("You did not put in a user name os I will log you in as " & Label3.Text & ". Ma hahahahahahahahahaha", MsgBoxStyle.Critical, "No username")
			Form2.Label1.Text = Label3.Text
			Form1.Visible = True
			Me.Visible = False
		Else
			Form2.Label1.Text = Text1.Text
			Form1.Visible = True
			Me.Visible = False
		End If
	End Sub
	
	Private Sub Text1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text1.Click
		Text1.Text = ""
	End Sub
	
	Private Sub Text2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text2.Click
		Text2.Text = ""
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim Randomstring As Object
		Dim cb As Object
		Dim rgch As String
		Dim use As String
		Dim use2 As String
		Dim use3 As String
		Dim use4 As String
		Dim use5 As String
		Dim use6 As String
		Dim use7 As String
		Dim use8 As String
		Dim use9 As String
		Dim use10 As String
		
		rgch = "abcdefghijklmnopqrstuvwxyz"
		
		rgch = rgch & UCase(rgch) & "0123456789"
		
		Dim i As Integer
		
		'UPGRADE_WARNING: Couldn't resolve default property of object cb. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 1 To cb
			
		Next 
		
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Randomstring = Randomstring & Mid(rgch, Int(Rnd() * Len(rgch) + 1), 1)
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use2 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use3 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use4 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use5 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use6 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use7 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use8 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use9 = Randomstring
		'UPGRADE_WARNING: Couldn't resolve default property of object Randomstring. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		use10 = Randomstring
		Label3.Text = use & use2 & use3 & use4 & use5 & use6 & use7 & use8 & use9 & use10
	End Sub
End Class