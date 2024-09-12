<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tReceive = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblDuration = New System.Windows.Forms.Label()
        Me.lblCallEnded = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.Call_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_CurrentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_LookupBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblIO = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.Event_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Event_HistoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WatchdogDataSet1 = New WDCallerID.WatchdogDataSet()
        Me.Event_HistoryTableAdapter = New WDCallerID.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter()
        Me.TableAdapterManager1 = New WDCallerID.WatchdogDataSetTableAdapters.TableAdapterManager()
        Me.Call_HistoryBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_HistoryTableAdapter1 = New WDCallerID.WatchdogDataSetTableAdapters.Call_HistoryTableAdapter()
        Me.Call_HistoryDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Call_CurrentBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_CurrentTableAdapter1 = New WDCallerID.WatchdogDataSetTableAdapters.Call_CurrentTableAdapter()
        Me.Call_CurrentDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Call_LookupBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Call_LookupTableAdapter1 = New WDCallerID.WatchdogDataSetTableAdapters.Call_LookupTableAdapter()
        Me.Call_LookupDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tSerialCheck = New System.Windows.Forms.Timer(Me.components)
        Me.lblCOMStatus = New System.Windows.Forms.Label()
        Me.lblCOMCheck = New System.Windows.Forms.Label()
        CType(Me.Call_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_CurrentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_LookupBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Event_HistoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WatchdogDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_HistoryBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_HistoryDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_CurrentBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_CurrentDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_LookupBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Call_LookupDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(119, 149)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(98, 22)
        Me.btnStop.TabIndex = 24
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Enabled = False
        Me.btnStart.Location = New System.Drawing.Point(12, 149)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(98, 22)
        Me.btnStart.TabIndex = 23
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Port:"
        '
        'tReceive
        '
        Me.tReceive.Interval = 700
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Phone Number:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Call Duration:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Call Time:"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNumber.Location = New System.Drawing.Point(98, 58)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblPhoneNumber.TabIndex = 29
        Me.lblPhoneNumber.Text = "111-222-3333"
        '
        'lblDuration
        '
        Me.lblDuration.AutoSize = True
        Me.lblDuration.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDuration.Location = New System.Drawing.Point(98, 101)
        Me.lblDuration.Name = "lblDuration"
        Me.lblDuration.Size = New System.Drawing.Size(31, 13)
        Me.lblDuration.TabIndex = 30
        Me.lblDuration.Text = "0000"
        '
        'lblCallEnded
        '
        Me.lblCallEnded.AutoSize = True
        Me.lblCallEnded.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCallEnded.Location = New System.Drawing.Point(98, 123)
        Me.lblCallEnded.Name = "lblCallEnded"
        Me.lblCallEnded.Size = New System.Drawing.Size(106, 13)
        Me.lblCallEnded.TabIndex = 31
        Me.lblCallEnded.Text = "12/31/0000 12:00:00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Name:"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(98, 80)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(37, 13)
        Me.lblName.TabIndex = 33
        Me.lblName.Text = "_____"
        '
        'Call_HistoryBindingSource
        '
        Me.Call_HistoryBindingSource.DataMember = "Call_History"
        '
        'Call_CurrentBindingSource
        '
        Me.Call_CurrentBindingSource.DataMember = "Call_Current"
        '
        'Call_LookupBindingSource
        '
        Me.Call_LookupBindingSource.DataMember = "Call_Lookup"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 38)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 13)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "In/Out-bound:"
        '
        'lblIO
        '
        Me.lblIO.AutoSize = True
        Me.lblIO.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIO.Location = New System.Drawing.Point(98, 38)
        Me.lblIO.Name = "lblIO"
        Me.lblIO.Size = New System.Drawing.Size(13, 13)
        Me.lblIO.TabIndex = 36
        Me.lblIO.Text = "_"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(44, 9)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(37, 13)
        Me.lblPort.TabIndex = 37
        Me.lblPort.Text = "COM3"
        '
        'Event_HistoryDataGridView
        '
        Me.Event_HistoryDataGridView.AutoGenerateColumns = False
        Me.Event_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Event_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.Event_HistoryDataGridView.DataSource = Me.Event_HistoryBindingSource
        Me.Event_HistoryDataGridView.Location = New System.Drawing.Point(194, 38)
        Me.Event_HistoryDataGridView.Name = "Event_HistoryDataGridView"
        Me.Event_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Event_HistoryDataGridView.TabIndex = 37
        Me.Event_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Event_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Event_ID"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Event_Timestamp"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'Event_HistoryBindingSource
        '
        Me.Event_HistoryBindingSource.DataMember = "Event_History"
        Me.Event_HistoryBindingSource.DataSource = Me.WatchdogDataSet1
        '
        'WatchdogDataSet1
        '
        Me.WatchdogDataSet1.DataSetName = "WatchdogDataSet"
        Me.WatchdogDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Event_HistoryTableAdapter
        '
        Me.Event_HistoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager1
        '
        Me.TableAdapterManager1.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager1.Call_CurrentTableAdapter = Nothing
        Me.TableAdapterManager1.Call_HistoryTableAdapter = Nothing
        Me.TableAdapterManager1.Call_LookupTableAdapter = Nothing
        Me.TableAdapterManager1.Event_HistoryTableAdapter = Me.Event_HistoryTableAdapter
        Me.TableAdapterManager1.UpdateOrder = WDCallerID.WatchdogDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Call_HistoryBindingSource1
        '
        Me.Call_HistoryBindingSource1.DataMember = "Call_History"
        Me.Call_HistoryBindingSource1.DataSource = Me.WatchdogDataSet1
        '
        'Call_HistoryTableAdapter1
        '
        Me.Call_HistoryTableAdapter1.ClearBeforeFill = True
        '
        'Call_HistoryDataGridView
        '
        Me.Call_HistoryDataGridView.AutoGenerateColumns = False
        Me.Call_HistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Call_HistoryDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.Call_HistoryDataGridView.DataSource = Me.Call_HistoryBindingSource1
        Me.Call_HistoryDataGridView.Location = New System.Drawing.Point(210, 38)
        Me.Call_HistoryDataGridView.Name = "Call_HistoryDataGridView"
        Me.Call_HistoryDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Call_HistoryDataGridView.TabIndex = 37
        Me.Call_HistoryDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Call_Timestamp"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Call_Timestamp"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Call_Number"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Call_Number"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Call_Name"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Call_Name"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Call_Duration"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Call_Duration"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'Call_CurrentBindingSource1
        '
        Me.Call_CurrentBindingSource1.DataMember = "Call_Current"
        Me.Call_CurrentBindingSource1.DataSource = Me.WatchdogDataSet1
        '
        'Call_CurrentTableAdapter1
        '
        Me.Call_CurrentTableAdapter1.ClearBeforeFill = True
        '
        'Call_CurrentDataGridView
        '
        Me.Call_CurrentDataGridView.AutoGenerateColumns = False
        Me.Call_CurrentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Call_CurrentDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.Call_CurrentDataGridView.DataSource = Me.Call_CurrentBindingSource1
        Me.Call_CurrentDataGridView.Location = New System.Drawing.Point(210, 54)
        Me.Call_CurrentDataGridView.Name = "Call_CurrentDataGridView"
        Me.Call_CurrentDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Call_CurrentDataGridView.TabIndex = 37
        Me.Call_CurrentDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Call_Timestamp"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Call_Timestamp"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Call_Name"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Call_Name"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'Call_LookupBindingSource1
        '
        Me.Call_LookupBindingSource1.DataMember = "Call_Lookup"
        Me.Call_LookupBindingSource1.DataSource = Me.WatchdogDataSet1
        '
        'Call_LookupTableAdapter1
        '
        Me.Call_LookupTableAdapter1.ClearBeforeFill = True
        '
        'Call_LookupDataGridView
        '
        Me.Call_LookupDataGridView.AutoGenerateColumns = False
        Me.Call_LookupDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Call_LookupDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.Call_LookupDataGridView.DataSource = Me.Call_LookupBindingSource1
        Me.Call_LookupDataGridView.Location = New System.Drawing.Point(194, 54)
        Me.Call_LookupDataGridView.Name = "Call_LookupDataGridView"
        Me.Call_LookupDataGridView.Size = New System.Drawing.Size(10, 10)
        Me.Call_LookupDataGridView.TabIndex = 37
        Me.Call_LookupDataGridView.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Call_Number"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Call_Number"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Call_Name"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Call_Name"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'tSerialCheck
        '
        Me.tSerialCheck.Interval = 3600000
        '
        'lblCOMStatus
        '
        Me.lblCOMStatus.AutoSize = True
        Me.lblCOMStatus.Location = New System.Drawing.Point(98, 9)
        Me.lblCOMStatus.Name = "lblCOMStatus"
        Me.lblCOMStatus.Size = New System.Drawing.Size(13, 13)
        Me.lblCOMStatus.TabIndex = 38
        Me.lblCOMStatus.Text = "_"
        '
        'lblCOMCheck
        '
        Me.lblCOMCheck.AutoSize = True
        Me.lblCOMCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCOMCheck.Location = New System.Drawing.Point(117, 13)
        Me.lblCOMCheck.Name = "lblCOMCheck"
        Me.lblCOMCheck.Size = New System.Drawing.Size(71, 9)
        Me.lblCOMCheck.TabIndex = 39
        Me.lblCOMCheck.Text = "12/31/0000 12:00:00"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 178)
        Me.Controls.Add(Me.lblCOMCheck)
        Me.Controls.Add(Me.lblCOMStatus)
        Me.Controls.Add(Me.Call_LookupDataGridView)
        Me.Controls.Add(Me.Call_CurrentDataGridView)
        Me.Controls.Add(Me.Call_HistoryDataGridView)
        Me.Controls.Add(Me.Event_HistoryDataGridView)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblIO)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCallEnded)
        Me.Controls.Add(Me.lblDuration)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.Label4)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "WD Caller ID"
        CType(Me.Call_HistoryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_CurrentBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_LookupBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Event_HistoryDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Event_HistoryBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.WatchdogDataSet1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_HistoryBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_HistoryDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_CurrentBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_CurrentDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_LookupBindingSource1,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.Call_LookupDataGridView,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents btnStop As System.Windows.Forms.Button
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tReceive As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblPhoneNumber As System.Windows.Forms.Label
    Friend WithEvents lblDuration As System.Windows.Forms.Label
    Friend WithEvents lblCallEnded As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents Call_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_CurrentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_LookupBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblIO As System.Windows.Forms.Label
    Friend WithEvents WatchdogDataSet As WDCallerID.WatchdogDataSet
    Friend WithEvents TableAdapterManager As WDCallerID.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Call_HistoryTableAdapter As WDCallerID.WatchdogDataSetTableAdapters.Call_HistoryTableAdapter
    Friend WithEvents Call_CurrentTableAdapter As WDCallerID.WatchdogDataSetTableAdapters.Call_CurrentTableAdapter
    Friend WithEvents Call_LookupTableAdapter As WDCallerID.WatchdogDataSetTableAdapters.Call_LookupTableAdapter
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents WatchdogDataSet1 As WDCallerID.WatchdogDataSet
    Friend WithEvents Event_HistoryBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Event_HistoryTableAdapter As WDCallerID.WatchdogDataSetTableAdapters.Event_HistoryTableAdapter
    Friend WithEvents TableAdapterManager1 As WDCallerID.WatchdogDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Event_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_HistoryBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Call_HistoryTableAdapter1 As WDCallerID.WatchdogDataSetTableAdapters.Call_HistoryTableAdapter
    Friend WithEvents Call_HistoryDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_CurrentBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Call_CurrentTableAdapter1 As WDCallerID.WatchdogDataSetTableAdapters.Call_CurrentTableAdapter
    Friend WithEvents Call_CurrentDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Call_LookupBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents Call_LookupTableAdapter1 As WDCallerID.WatchdogDataSetTableAdapters.Call_LookupTableAdapter
    Friend WithEvents Call_LookupDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tSerialCheck As System.Windows.Forms.Timer
    Friend WithEvents lblCOMStatus As System.Windows.Forms.Label
    Friend WithEvents lblCOMCheck As System.Windows.Forms.Label

End Class
