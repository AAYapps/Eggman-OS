Option Strict Off
Option Explicit On
Friend Class Form5
	Inherits System.Windows.Forms.Form
	Private Sub Form5_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim FileNum As Short
		Dim DataArray() As Byte
		
		DataArray = My.Resources.start_101
		
		FileNum = FreeFile
		FileOpen(FileNum, "C:\TEMP.mpg", OpenMode.Binary)
		'UPGRADE_WARNING: Put was upgraded to FilePut and has a new behavior. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		FilePut(FileNum, DataArray, 1)
		FileClose(FileNum)
	End Sub
End Class