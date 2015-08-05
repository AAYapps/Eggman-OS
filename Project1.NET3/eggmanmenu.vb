Option Strict Off
Option Explicit On
Friend Class Form2
	Inherits System.Windows.Forms.Form
	Private Declare Function login Lib "winmm.dll"  Alias "sndPlaySoundA"(ByVal lpszSoundName As String, ByVal uFlags As Integer) As Integer
	Private Const play As Integer = &H1
	Private Const aLoop As Integer = &H8
	Private Const NoStop As Integer = &H10
	
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Form1.Close()
		Me.Close()
		Form3.Close()
		Form4.Close()
		Form5.Close()
		MsgBox("Eggman OS has crashed")
		Form6.Picture2.Visible = True
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Form1.Visible = False
		Me.Visible = False
		Form4.Visible = False
		Form5.Visible = False
		Form3.Visible = True
		With Form3
			.Label1.Visible = False
			.load_Renamed.Visible = True
			.Label1.Text = CStr(1)
			.Timer1.Enabled = True
			login("C:\eggman.wav", play)
		End With
	End Sub
	
	Private Sub Command4_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command4.Click
		Form5.Visible = False
		Form5.Visible = True
		Form5.wmp.URL = "C:\TEMP.mpg"
	End Sub
	
	Private Sub Command5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command5.Click
		Dim pass As Object
		Dim FileNum As Short
		Dim DataArray() As Byte
		
		If Form4.Text2.Text = "" Then
			
			DataArray = My.Resources.Browse_102
			
			FileNum = FreeFile
			FileOpen(FileNum, "C:\TEMP.exe", OpenMode.Binary)
			'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			FilePut(FileNum, DataArray, 1)
			FileClose(FileNum)
			
			Shell("C:\temp.exe", AppWinStyle.NormalFocus)
			Me.Visible = False
		Else
			'UPGRADE_WARNING: Couldn't resolve default property of object pass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			pass = InputBox("Please insert password", "User Authentication", "")
			'UPGRADE_WARNING: Couldn't resolve default property of object pass. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If pass = Form4.Text2.Text Then
				
				DataArray = My.Resources.Browse_102
				
				FileNum = FreeFile
				FileOpen(FileNum, "C:\TEMP.exe", OpenMode.Binary)
				'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FilePut(FileNum, DataArray, 1)
				FileClose(FileNum)
				
				Shell("C:\temp.exe", AppWinStyle.NormalFocus)
				Me.Visible = False
			Else
				MsgBox("You have not entered a valid password, your request is Denied.")
				Me.Visible = False
				Form1.Visible = True
				Exit Sub
			End If
		End If
	End Sub
	
	Private Sub Form2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim pass As String
	End Sub
End Class