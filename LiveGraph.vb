'Option Strict On
#Region "Import What you can't Produce"
Imports System.Windows.Forms.DataVisualization.Charting
' These are imported to allow the use of serial port and in flow of steams of data
Imports System
Imports System.ComponentModel
Imports System.Threading
Imports System.IO.Ports
#End Region
Public Class LiveGraph
#Region "Declare your Assets"
    Dim connectionFlag As String = ""
    Dim Rand As New Random
    Dim myPort As Array                                              'COM Ports detected on the system will be stored here
    Delegate Sub SetTextCallback(ByVal [text] As String)             'Added to prevent threading errors during receiveing of data

    '//PlotGraph needs them
    Dim dhour As Double = 0  'dhour is a counter sync with the hour of the day
    Public cnn As New OleDb.OleDbConnection
    Dim lpg As Double
    Dim smoke As Double
    Dim co As Double

    '//ReceivedText() needs them
    Dim count As Integer = 0
    Dim x As Char 'parity letter - checks whether received data belong to stream L,S or C
    Dim a As String 'binds streams of L
    Dim b As String 'binds streams of S
    Dim c As String 'binds streams of C
#End Region
#Region "OnLoad Event - Setup"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'When our form loads, auto detect all serial ports in the system and populate the cmbPort Combo box.
        myPort = IO.Ports.SerialPort.GetPortNames() 'Get all com ports available

        cmbBaud.Items.Add(9600)     'Populate the cmbBaud Combo box to common baud rates used   
        cmbBaud.Items.Add(19200)
        cmbBaud.Items.Add(38400)
        cmbBaud.Items.Add(57600)
        cmbBaud.Items.Add(115200)

        For i = 0 To UBound(myPort)
            cmbPort.Items.Add(myPort(i))
        Next
        cmbPort.Text = cmbPort.Items.Item(0)    'Set cmbPort text to the first COM port detected
        cmbBaud.Text = cmbBaud.Items.Item(0)    'Set cmbBaud text to the first Baud rate on the list

        Me.Location = New Point(CInt((Screen.PrimaryScreen.WorkingArea.Width / 2) - (Me.Width / 2)), CInt((Screen.PrimaryScreen.WorkingArea.Height / 2) - (Me.Height / 2)))
        LiveFeed.ChartAreas("LFChartArea").AxisX.Interval = 1
        LiveFeed.ChartAreas("LFChartArea").AxisX.Minimum = 0
        LiveFeed.ChartAreas("LFChartArea").AxisX.LabelStyle.Angle = 90
        LiveFeed.ChartAreas("LFChartArea").AxisY.Interval = 10
        LiveFeed.ChartAreas("LFChartArea").AxisY.Minimum = 0
        LiveFeed.ChartAreas("LFChartArea").AxisX.ScaleView.Size = 25
        LiveFeed.ChartAreas("LFChartArea").AxisX.ScrollBar.Size = 10


        LiveFeed.ChartAreas("LFChartArea").AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll
        LiveFeed.ChartAreas("LFChartArea").AxisX.ScrollBar.IsPositionedInside = True
        LiveFeed.ChartAreas("LFChartArea").AxisX.ScrollBar.BackColor = Color.White
        LiveFeed.ChartAreas("LFChartArea").AxisX.ScrollBar.ButtonColor = Color.White

        Chart2.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.SmallScroll
        Chart2.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = True
        Chart2.ChartAreas(0).AxisX.ScrollBar.BackColor = Color.White
        Chart2.ChartAreas(0).AxisX.ScrollBar.ButtonColor = Color.White
        Chart2.ChartAreas(0).AxisY.Interval = 10

        Timer1.Interval = 1000 ' TODO: Change interval to 3600000(Every Hour) or 60000(Every Minute)
        Timer1.Enabled = True

    End Sub
#End Region
#Region "Timer Tick Event"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Dim sec As String = Now.ToString("HH:mm:ss")
        Dim dt As String = Today.ToString("MM/dd/yyyy")
        PlotGraph(sec)
        SaveToDatabase(sec, dt)

    End Sub

#End Region
#Region "Plot Graph/Chart"
    Private Sub PlotGraph(sec As String)

        LiveFeed.Series("LPG").Points.AddXY(dhour, CDbl(lpg) / 1000)
        LiveFeed.Series("Smoke").Points.AddXY(dhour, CDbl(smoke) / 1000)
        LiveFeed.Series("CO").Points.AddXY(dhour, CDbl(co) / 1000)
        LiveFeed.ChartAreas("LFChartArea").AxisX.CustomLabels.Add(dhour - 1, dhour + 1, sec)

        dhour += 1

        If LiveFeed.ChartAreas("LFChartArea").AxisX.Maximum > LiveFeed.ChartAreas("LFChartArea").AxisX.ScaleView.Size Then
            LiveFeed.ChartAreas("LFChartArea").AxisX.ScaleView.Scroll(LiveFeed.ChartAreas("LFChartArea").AxisX.Maximum)
        End If

    End Sub
#End Region
#Region "On Data Received Event"
    Private Sub SerialPort1_DataReceived(ByVal sender As Object, ByVal e As System.IO.Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        ReceivedText(SerialPort1.ReadExisting())    'Automatically called every time a data is received at the serialPort
    End Sub
#End Region
#Region "Determine Data Received"
    Private Sub ReceivedText(ByVal [text] As String)

        'compares the ID of the creating Thread to the ID of the calling Thread
        If Me.rtbReceived.InvokeRequired Then
            Dim x As New SetTextCallback(AddressOf ReceivedText)
            Me.Invoke(x, New Object() {(text)})
        Else

            Me.rtbReceived.Text = text                              ' assign text to received text box

            If rtbReceived.Text = "L" Or x = "L" Then               ' execute if received data or x is "A"
                If rtbReceived.Text = "L" Then                      ' execute if received data is "A"
                    x = "L"                                         ' assign "A" to x
                End If

                If rtbReceived.Text <> "L" Then                     ' execute if receive value is not "A"
                    a = a & rtbReceived.Text                        ' append received data to "a"
                    count += 1                                      ' increament by 1
                End If

                If count = 5 Then                                   ' once the 3 digits has been captured execute
                    rtxtBoxLPG.Text = a
                    lpg = a
                    count = 0                                       ' assign 0 to count
                    x = ""                                          ' store empty string on "x"
                    a = ""                                          ' store empty string on "a"
                End If


            ElseIf rtbReceived.Text = "S" Or x = "S" Then           ' execute if received data or x is "B"

                If rtbReceived.Text = "S" Then                      ' execute if received data is "B"
                    x = "S"                                         ' assign "B" to x
                End If

                If rtbReceived.Text <> "S" Then                     ' execute if receive value is not "B"
                    b = b & rtbReceived.Text                        ' append received data to "b"
                    count += 1                                      ' increament by 1
                End If

                If count = 5 Then                                   ' once the 3 digits has been captured execute
                    rtxtBoxSmoke.Text = b                         ' store value of "c" in Temperature Set Point text box
                    smoke = b
                    count = 0                                       ' assign 0 to count
                    x = ""                                          ' store empty string on "x"
                    b = ""                                          ' store empty string on "b"
                End If

            ElseIf rtbReceived.Text = "C" Or x = "C" Then           ' execute if received data or x is "C"

                If rtbReceived.Text = "C" Then                      ' execute if received data is "C"
                    x = "C"                                         ' assign "C" to x
                End If

                If rtbReceived.Text <> "C" Then                     ' execute if receive value is not "C"
                    c = c & rtbReceived.Text                        ' append received data to "c"
                    count += 1                                      ' increament by 1
                End If

                If count = 5 Then                                   ' once the 3 digits has been captured execute
                    txtBoxCO.Text = c              ' store value of "c" in Temperature Set Point text box
                    co = c
                    count = 0                                       ' assign 0 to count
                    x = ""                                          ' store empty string on "x"
                    c = ""                                          ' store empty string on "c"
                End If

            End If
        End If
    End Sub
#End Region
#Region "Database Connection"
    Public Sub getConnection()
        cnn = New OleDb.OleDbConnection
        cnn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" _
            & Application.StartupPath & "\dt.accdb"
        'if connection is not open
        If Not cnn.State = ConnectionState.Open Then
            'open connection
            cnn.Open()
        End If
    End Sub
#End Region
#Region "Plot Chart for Specific Date"
    Private Sub ShowGraph_Click(sender As Object, e As EventArgs) Handles ShowGraph.Click
        RedrawPoints(Chart2)
        getConnection()
        Dim reader As OleDb.OleDbDataReader
        Dim sql As String = "SELECT Lpg, Smoke, Co, Hr, currDate FROM Variable WHERE currDate BETWEEN '" & dtDate.Text & "' AND '" & dtDate.Text & "'"
        Dim command = New OleDb.OleDbCommand(sql, cnn)
        reader = command.ExecuteReader
        While reader.Read
            Chart2.Series(0).Points.AddXY(reader.GetString(3), CDbl(reader.GetString(0)) / 1000)
            Chart2.Series(1).Points.AddXY(reader.GetString(3), CDbl(reader.GetString(1)) / 1000)
            Chart2.Series(2).Points.AddXY(reader.GetString(3), CDbl(reader.GetString(2)) / 1000)
        End While
    End Sub
#End Region
#Region "Save To Database"
    Public Sub SaveToDatabase(sec As String, dt As String)
        getConnection()
        Dim cmd As New OleDb.OleDbCommand
        cmd.Connection = cnn
        cmd.CommandText = "INSERT INTO Variable(Lpg,Smoke,Co,Hr,currDate) " & _
            "VALUES('" & lpg & "','" & smoke & "','" & co & "','" & sec & "','" & dt & "')"
        cmd.ExecuteNonQuery()
        cnn.Close()
    End Sub
#End Region
#Region "Redraw Chart"
    Public Sub RedrawPoints(cht As Chart)
        cht.Series(0).Points.Clear()
        cht.Series(1).Points.Clear()
        cht.Series(2).Points.Clear()
    End Sub
#End Region
#Region "Device Connection"
    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        If (connectionFlag <> "Connected") Then
            SerialPort1.PortName = cmbPort.Text             'Set SerialPort1 to the selected COM port at startup
            SerialPort1.BaudRate = cmbBaud.Text             'Set Baud rate to the selected value on 

            'Other Serial Port Property

            SerialPort1.Parity = IO.Ports.Parity.None       ' no parity bit
            SerialPort1.StopBits = IO.Ports.StopBits.One    ' stop bit is 1
            SerialPort1.DataBits = 8                        ' Receive a bit 
            SerialPort1.Open()                              ' Open our serial port
            connectionFlag = "Connected"
            btnConnect.Text = "Disconnect"

        ElseIf (connectionFlag = "Connected") Then
            SerialPort1.Close()             'Close our Serial Port
            connectionFlag = "Disconnected"
            btnConnect.Text = "Connect"
        End If

    End Sub
#End Region
#Region "Port and Baud onChange Event"
    Private Sub cmbPort_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        If SerialPort1.IsOpen = False Then
            SerialPort1.PortName = cmbPort.Text         'pop a message box to user if he is changing ports
        Else                                            'without disconnecting first.
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub

    Private Sub cmbBaud_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If SerialPort1.IsOpen = False Then
            SerialPort1.BaudRate = cmbBaud.Text         'pop a message box to user if he is changing baud rate
        Else                                            'without disconnecting first.
            MsgBox("Valid only if port is Closed", vbCritical)
        End If
    End Sub
#End Region
End Class
