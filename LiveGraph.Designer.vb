<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiveGraph
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea13 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend13 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series37 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series38 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series39 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title13 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea14 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend14 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series40 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series41 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series42 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title14 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiveGraph))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LiveFeed = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.rtbReceived = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxCO = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rtxtBoxSmoke = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rtxtBoxLPG = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.ShowGraph = New System.Windows.Forms.Button()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbPort = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbBaud = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnConnect = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        CType(Me.LiveFeed, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'LiveFeed
        '
        Me.LiveFeed.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea13.Name = "LFChartArea"
        Me.LiveFeed.ChartAreas.Add(ChartArea13)
        Legend13.Name = "Legend1"
        Me.LiveFeed.Legends.Add(Legend13)
        Me.LiveFeed.Location = New System.Drawing.Point(3, 1)
        Me.LiveFeed.Name = "LiveFeed"
        Me.LiveFeed.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series37.BorderColor = System.Drawing.Color.Lime
        Series37.BorderWidth = 2
        Series37.ChartArea = "LFChartArea"
        Series37.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series37.Color = System.Drawing.Color.Red
        Series37.LabelBorderWidth = 0
        Series37.Legend = "Legend1"
        Series37.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series37.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Square
        Series37.Name = "LPG"
        Series38.BorderColor = System.Drawing.Color.Transparent
        Series38.BorderWidth = 2
        Series38.ChartArea = "LFChartArea"
        Series38.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series38.Color = System.Drawing.Color.Lime
        Series38.LabelBorderColor = System.Drawing.Color.White
        Series38.Legend = "Legend1"
        Series38.MarkerBorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Series38.MarkerColor = System.Drawing.Color.Indigo
        Series38.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Triangle
        Series38.Name = "Smoke"
        Series39.BorderWidth = 2
        Series39.ChartArea = "LFChartArea"
        Series39.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series39.Color = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series39.Legend = "Legend1"
        Series39.MarkerBorderColor = System.Drawing.Color.Maroon
        Series39.MarkerColor = System.Drawing.Color.Red
        Series39.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle
        Series39.Name = "CO"
        Me.LiveFeed.Series.Add(Series37)
        Me.LiveFeed.Series.Add(Series38)
        Me.LiveFeed.Series.Add(Series39)
        Me.LiveFeed.Size = New System.Drawing.Size(906, 469)
        Me.LiveFeed.TabIndex = 0
        Me.LiveFeed.Text = "Chart1"
        Title13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Title13.Name = "Title1"
        Title13.Text = "Air Pollution Trend Chart"
        Me.LiveFeed.Titles.Add(Title13)
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.ItemSize = New System.Drawing.Size(90, 30)
        Me.TabControl1.Location = New System.Drawing.Point(0, 45)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(920, 510)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label10)
        Me.TabPage1.Controls.Add(Me.rtbReceived)
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(Me.Label7)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.LiveFeed)
        Me.TabPage1.Location = New System.Drawing.Point(4, 34)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(912, 472)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Live Feeds"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.BackColor = System.Drawing.Color.Gainsboro
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(780, 322)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(126, 19)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Recieved Data"
        '
        'rtbReceived
        '
        Me.rtbReceived.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbReceived.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbReceived.Location = New System.Drawing.Point(780, 341)
        Me.rtbReceived.Name = "rtbReceived"
        Me.rtbReceived.Size = New System.Drawing.Size(126, 22)
        Me.rtbReceived.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.BackColor = System.Drawing.Color.Gainsboro
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(780, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(126, 18)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "LEGEND"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(741, 450)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(109, 19)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Time( s )"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(11, 47)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(36, 61)
        Me.TextBox1.TabIndex = 5
        Me.TextBox1.Text = "Y ( LPG Smoke CO )"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(780, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(126, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "SCALE"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(780, 153)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 19)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Time 1:1"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(780, 133)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(127, 23)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Y Axis - 1:1000"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtBoxCO)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rtxtBoxSmoke)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.rtxtBoxLPG)
        Me.GroupBox1.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(780, 185)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(126, 125)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Streams"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "CO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtBoxCO
        '
        Me.txtBoxCO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBoxCO.Location = New System.Drawing.Point(51, 89)
        Me.txtBoxCO.Name = "txtBoxCO"
        Me.txtBoxCO.Size = New System.Drawing.Size(67, 24)
        Me.txtBoxCO.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Smoke"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtxtBoxSmoke
        '
        Me.rtxtBoxSmoke.ForeColor = System.Drawing.Color.Green
        Me.rtxtBoxSmoke.Location = New System.Drawing.Point(51, 59)
        Me.rtxtBoxSmoke.Name = "rtxtBoxSmoke"
        Me.rtxtBoxSmoke.Size = New System.Drawing.Size(67, 24)
        Me.rtxtBoxSmoke.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Sans Unicode", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "LPG"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rtxtBoxLPG
        '
        Me.rtxtBoxLPG.ForeColor = System.Drawing.Color.Red
        Me.rtxtBoxLPG.Location = New System.Drawing.Point(51, 29)
        Me.rtxtBoxLPG.Name = "rtxtBoxLPG"
        Me.rtxtBoxLPG.Size = New System.Drawing.Size(67, 24)
        Me.rtxtBoxLPG.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.TextBox2)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.Chart2)
        Me.TabPage2.Controls.Add(Me.ShowGraph)
        Me.TabPage2.Controls.Add(Me.dtDate)
        Me.TabPage2.Location = New System.Drawing.Point(4, 34)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(912, 472)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Previous Data"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(660, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Select Date"
        '
        'Chart2
        '
        Me.Chart2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        ChartArea14.AxisX.Interval = 1.0R
        ChartArea14.AxisX.IsLabelAutoFit = False
        ChartArea14.AxisX.LabelStyle.Angle = 90
        ChartArea14.AxisX.Minimum = 0.0R
        ChartArea14.AxisX.ScaleView.Size = 25.0R
        ChartArea14.AxisY.Interval = 10.0R
        ChartArea14.AxisY.IsLabelAutoFit = False
        ChartArea14.AxisY.Maximum = 100.0R
        ChartArea14.AxisY.Minimum = 0.0R
        ChartArea14.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea14)
        Legend14.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend14)
        Me.Chart2.Location = New System.Drawing.Point(3, 44)
        Me.Chart2.Name = "Chart2"
        Series40.BorderWidth = 2
        Series40.ChartArea = "ChartArea1"
        Series40.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series40.Color = System.Drawing.Color.Red
        Series40.Legend = "Legend1"
        Series40.Name = "LPG"
        Series41.BorderWidth = 2
        Series41.ChartArea = "ChartArea1"
        Series41.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series41.Color = System.Drawing.Color.Lime
        Series41.Legend = "Legend1"
        Series41.Name = "Smoke"
        Series42.BorderWidth = 2
        Series42.ChartArea = "ChartArea1"
        Series42.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline
        Series42.Legend = "Legend1"
        Series42.MarkerColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Series42.Name = "CO"
        Me.Chart2.Series.Add(Series40)
        Me.Chart2.Series.Add(Series41)
        Me.Chart2.Series.Add(Series42)
        Me.Chart2.Size = New System.Drawing.Size(903, 398)
        Me.Chart2.TabIndex = 6
        Me.Chart2.Text = "Chart2"
        Title14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Title14.Name = "Title1"
        Title14.Text = "Air Pollution Trend For Specific Date"
        Me.Chart2.Titles.Add(Title14)
        '
        'ShowGraph
        '
        Me.ShowGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ShowGraph.Location = New System.Drawing.Point(831, 6)
        Me.ShowGraph.Name = "ShowGraph"
        Me.ShowGraph.Size = New System.Drawing.Size(75, 21)
        Me.ShowGraph.TabIndex = 5
        Me.ShowGraph.Text = "Show Graph"
        Me.ShowGraph.UseVisualStyleBackColor = True
        '
        'dtDate
        '
        Me.dtDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtDate.Location = New System.Drawing.Point(729, 7)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(96, 20)
        Me.dtDate.TabIndex = 4
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.Color.Beige
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSplitButton1, Me.cmbPort, Me.ToolStripLabel1, Me.cmbBaud, Me.ToolStripSeparator1, Me.btnConnect, Me.ToolStripSeparator2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(922, 42)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripSplitButton1.Image = CType(resources.GetObject("ToolStripSplitButton1.Image"), System.Drawing.Image)
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(60, 39)
        Me.ToolStripSplitButton1.Text = "COM Port"
        '
        'cmbPort
        '
        Me.cmbPort.Name = "cmbPort"
        Me.cmbPort.Size = New System.Drawing.Size(121, 42)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(60, 39)
        Me.ToolStripLabel1.Text = "Baud Rate"
        '
        'cmbBaud
        '
        Me.cmbBaud.Name = "cmbBaud"
        Me.cmbBaud.Size = New System.Drawing.Size(121, 42)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 42)
        '
        'btnConnect
        '
        Me.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.btnConnect.Image = CType(resources.GetObject("btnConnect.Image"), System.Drawing.Image)
        Me.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(56, 39)
        Me.btnConnect.Text = "Connect"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 42)
        '
        'SerialPort1
        '
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.BackColor = System.Drawing.Color.Gainsboro
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(780, 68)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(126, 18)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "LEGEND"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label12.BackColor = System.Drawing.Color.Gainsboro
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(780, 144)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(126, 18)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "SCALE"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(780, 190)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(126, 19)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "Time 1:1"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(780, 170)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(127, 23)
        Me.Label14.TabIndex = 12
        Me.Label14.Text = "Y Axis - 1:1000"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Location = New System.Drawing.Point(8, 89)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(36, 61)
        Me.TextBox2.TabIndex = 16
        Me.TextBox2.Text = "Y ( LPG Smoke CO )"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(694, 432)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(109, 19)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Time( s )"
        '
        'LiveGraph
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(922, 561)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(938, 600)
        Me.Name = "LiveGraph"
        Me.Text = "Air Pollution Monitoring"
        CType(Me.LiveFeed, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LiveFeed As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Chart2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents ShowGraph As System.Windows.Forms.Button
    Friend WithEvents dtDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbPort As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbBaud As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents btnConnect As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBoxCO As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rtxtBoxSmoke As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents rtxtBoxLPG As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents rtbReceived As System.Windows.Forms.TextBox
    Friend WithEvents SerialPort1 As System.IO.Ports.SerialPort
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label

End Class
