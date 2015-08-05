Module mMain
    Public frmMain As New CfrmMain
    Public Declare Function OpenRdr Lib "C:\RFID\VetcIBRI.dll" () As Boolean
    Public Declare Function GetRdrStatus Lib "C:\RFID\VetcIBRI.dll" () As Boolean
    Public Declare Function SetRdrPort Lib "C:\RFID\VetcIBRI.dll" (ByVal PortName As String) As Boolean
    Public Declare Function CloseRdr Lib "C:\RFID\VetcIBRI.dll" () As Boolean
    Public Declare Function ReadTagID Lib "C:\RFID\VetcIBRI.dll" () As Int32
    Public Declare Function ReadTagContent Lib "C:\RFID\VetcIBRI.dll" () As Int32
    Public Declare Sub GetIDByIndex Lib "C:\RFID\VetcIBRI.dll" (ByVal Index As Int32, ByVal CurID() As Byte)
    Public Declare Sub GetAntByIndex Lib "C:\RFID\VetcIBRI.dll" (ByVal Index As Int32, ByVal CurAnt() As Byte)
    Public Declare Sub GetContentByIndex Lib "C:\RFID\VetcIBRI.dll" (ByVal Index As Int32, ByVal CurContent() As Byte)
    Public Declare Function WriteTag Lib "C:\RFID\VetcIBRI.dll" (ByVal WriteData As String) As Int32
    Public Declare Function SetReadMaxTags Lib "C:\RFID\VetcIBRI.dll" (ByVal MaxNum As Int32) As Boolean
    Public Declare Function SetReadLen Lib "C:\RFID\VetcIBRI.dll" (ByVal MaxNum As Int32) As Boolean

    Sub Main()
        Application.Run(frmMain)
        End
    End Sub
End Module
