Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Form1
	Inherits System.Windows.Forms.Form
	Private Declare Function sndPlaySound Lib "winmm.dll"  Alias "sndPlaySoundA"(ByVal lpszSoundName As String, ByVal uFlags As Integer) As Integer
	Private Const sndAsync As Integer = &H1
	Private Const sndLoop As Integer = &H8
	Private Const sndNoStop As Integer = &H10
	
	Private Declare Function GetWindow Lib "user32" (ByVal hWnd As Integer, ByVal wCmd As Integer) As Integer
	Private Declare Function GetParent Lib "user32" (ByVal hWnd As Integer) As Integer
	Private Declare Function GetWindowTextLength Lib "user32"  Alias "GetWindowTextLengthA"(ByVal hWnd As Integer) As Integer
	Private Declare Function GetWindowText Lib "user32"  Alias "GetWindowTextA"(ByVal hWnd As Integer, ByVal lpString As String, ByVal cch As Integer) As Integer
	Const GW_HWNDFIRST As Short = 0
	Const GW_HWNDNEXT As Short = 2
	
	Sub LoadTaskList()
		Dim CurrWnd As Integer
		Dim Length As Integer
		Dim TaskName As String
		'UPGRADE_NOTE: Parent was upgraded to Parent_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim Parent_Renamed As Integer
		List1.Items.Clear()
		CurrWnd = GetWindow(Me.Handle.ToInt32, GW_HWNDFIRST)
		While CurrWnd <> 0
			Parent_Renamed = GetParent(CurrWnd)
			Length = GetWindowTextLength(CurrWnd)
			TaskName = Space(Length + 1)
			Length = GetWindowText(CurrWnd, TaskName, Length + 1)
			TaskName = VB.Left(TaskName, Len(TaskName) - 1)
			
			If Length > 0 Then
				If TaskName <> Me.Text Then
					List1.Items.Add(TaskName)
				End If
			End If
			CurrWnd = GetWindow(CurrWnd, GW_HWNDNEXT)
			System.Windows.Forms.Application.DoEvents()
		End While
	End Sub
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim objProcess As Object
		Dim objProcesses As Object
		Dim WMI As Object
		On Error Resume Next
		WMI = GetObject("winmgmts:")
		'UPGRADE_WARNING: Couldn't resolve default property of object WMI.execquery. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		objProcesses = WMI.execquery("SELECT * FROM win32_process WHERE Name = " & "'" & Text1.Text & "'" & ".exe")
		For	Each objProcess In objProcesses
			'UPGRADE_WARNING: Couldn't resolve default property of object objProcess.Terminate. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			objProcess.Terminate()
		Next objProcess
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		If Timer1.Enabled = True Then
			Timer1.Enabled = False
			Command2.Text = "Unfreeze"
		Else
			Timer1.Enabled = True
			Command2.Text = "Freeze"
		End If
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		If Label3.Visible = False Then
			Label1.Visible = True
			Label2.Visible = True
			Label3.Visible = True
			Label4.Visible = True
			Command3.Text = "Hide mouse coordinates"
		Else
			Label1.Visible = False
			Label2.Visible = False
			Label3.Visible = False
			Label4.Visible = False
			Command3.Text = "Show mouse coordinates"
		End If
	End Sub
	Private Sub Form1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Me.Hide()
        Form3.Visible = False
		Form6.Visible = True
        Form2.Left = VB6.TwipsToPixelsX(Frame1.Left * 15 + 1600)
		Form2.Top = VB6.TwipsToPixelsY(Frame1.Top * 15 + 1000)
	End Sub
	
	Private Sub Form1_MouseDown(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		If CDbl(Label3.Text) > Shape1.Left Then
			If CDbl(Label4.Text) > Shape1.Top Then
				If CDbl(Label3.Text) < Shape2.Left Then
					If CDbl(Label4.Text) < Shape2.Top Then
						Timer2.Enabled = True
					End If
				End If
			End If
		End If
	End Sub
	
	Private Sub Form1_MouseMove(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Label3.Text = CStr(X)
		Label4.Text = CStr(Y)
		If Timer2.Enabled = True Then
			Frame1.Left = X - 120
			Frame1.Top = Y + 30
			Shape1.Left = Frame1.Left
			Shape1.Top = Frame1.Top - 48
			Shape2.Left = Shape1.Left + 296
			Shape2.Top = Shape1.Top + 48
			Form2.Left = VB6.TwipsToPixelsX(Frame1.Left * 15 + 1600)
			Form2.Top = VB6.TwipsToPixelsY(Frame1.Top * 15 + 1000)
			Label5.Text = "form x " & VB6.PixelsToTwipsX(Form2.Left)
			Label6.Text = "form y " & VB6.PixelsToTwipsY(Form2.Top)
		End If
	End Sub
	Private Sub Form1_MouseUp(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
		Dim Button As Short = eventArgs.Button \ &H100000
		Dim Shift As Short = System.Windows.Forms.Control.ModifierKeys \ &H10000
		Dim X As Single = eventArgs.X
		Dim Y As Single = eventArgs.Y
		Timer2.Enabled = False
	End Sub
	
	'UPGRADE_WARNING: Event List1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		Text1.Text = List1.Text
	End Sub
	
	Private Sub start_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles start.Click
		If Form2.Visible = False Then
			Form2.Visible = False
			Form2.Visible = True
			sndPlaySound("c:\windows\media\Windows Information Bar.wav", sndAsync)
		Else
			Form2.Visible = False
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		LoadTaskList()
	End Sub
End Class