﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class dlgScript
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbFeatures = New System.Windows.Forms.TabControl()
        Me.tbPageSaveData = New System.Windows.Forms.TabPage()
        Me.lblSaveObjectFormat = New System.Windows.Forms.Label()
        Me.ucrCboSaveOutputObjectFormat = New instat.ucrInputComboBox()
        Me.lblSaveObjectType = New System.Windows.Forms.Label()
        Me.ucrCboSaveOutputObjectType = New instat.ucrInputComboBox()
        Me.rdoSaveOutputObject = New System.Windows.Forms.RadioButton()
        Me.rdoSaveDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoSaveColumn = New System.Windows.Forms.RadioButton()
        Me.ucrSaveData = New instat.ucrSave()
        Me.ucrDataFrameSaveOutputSelect = New instat.ucrDataFrame()
        Me.ucrPnlSaveData = New instat.UcrPanel()
        Me.tbPageGetData = New System.Windows.Forms.TabPage()
        Me.ucrReceiverGetOutputObject = New instat.ucrReceiverSingle()
        Me.ucrReceiverGetColumns = New instat.ucrReceiverMultiple()
        Me.lblGetColumn = New System.Windows.Forms.Label()
        Me.ucrDataFrameGetDF = New instat.ucrDataFrame()
        Me.lblGetObjectType = New System.Windows.Forms.Label()
        Me.ucrCboGetOutputObjectType = New instat.ucrInputComboBox()
        Me.rdoGetOutputObject = New System.Windows.Forms.RadioButton()
        Me.lblGetOutputObject = New System.Windows.Forms.Label()
        Me.rdoGetDataFrame = New System.Windows.Forms.RadioButton()
        Me.rdoGetColumn = New System.Windows.Forms.RadioButton()
        Me.ucrPnlGetData = New instat.UcrPanel()
        Me.ucrSelectorGetObject = New instat.ucrSelectorByDataFrameAddRemove()
        Me.tbPageCommon = New System.Windows.Forms.TabPage()
        Me.ucrCboLibPackage = New instat.ucrInputComboBox()
        Me.lblGetPackage = New System.Windows.Forms.Label()
        Me.lblRemoveObject = New System.Windows.Forms.Label()
        Me.ucrInputRemoveObjects = New instat.ucrInputTextBox()
        Me.tbPageLibrary = New System.Windows.Forms.TabPage()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.txtScript = New System.Windows.Forms.TextBox()
        Me.ucrBase = New instat.ucrButtons()
        Me.tbFeatures.SuspendLayout()
        Me.tbPageSaveData.SuspendLayout()
        Me.tbPageGetData.SuspendLayout()
        Me.tbPageCommon.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbFeatures
        '
        Me.tbFeatures.Controls.Add(Me.tbPageSaveData)
        Me.tbFeatures.Controls.Add(Me.tbPageGetData)
        Me.tbFeatures.Controls.Add(Me.tbPageCommon)
        Me.tbFeatures.Controls.Add(Me.tbPageLibrary)
        Me.tbFeatures.Location = New System.Drawing.Point(8, 7)
        Me.tbFeatures.Name = "tbFeatures"
        Me.tbFeatures.SelectedIndex = 0
        Me.tbFeatures.Size = New System.Drawing.Size(446, 271)
        Me.tbFeatures.TabIndex = 31
        '
        'tbPageSaveData
        '
        Me.tbPageSaveData.Controls.Add(Me.lblSaveObjectFormat)
        Me.tbPageSaveData.Controls.Add(Me.ucrCboSaveOutputObjectFormat)
        Me.tbPageSaveData.Controls.Add(Me.lblSaveObjectType)
        Me.tbPageSaveData.Controls.Add(Me.ucrCboSaveOutputObjectType)
        Me.tbPageSaveData.Controls.Add(Me.rdoSaveOutputObject)
        Me.tbPageSaveData.Controls.Add(Me.rdoSaveDataFrame)
        Me.tbPageSaveData.Controls.Add(Me.rdoSaveColumn)
        Me.tbPageSaveData.Controls.Add(Me.ucrSaveData)
        Me.tbPageSaveData.Controls.Add(Me.ucrDataFrameSaveOutputSelect)
        Me.tbPageSaveData.Controls.Add(Me.ucrPnlSaveData)
        Me.tbPageSaveData.Location = New System.Drawing.Point(4, 22)
        Me.tbPageSaveData.Name = "tbPageSaveData"
        Me.tbPageSaveData.Size = New System.Drawing.Size(438, 245)
        Me.tbPageSaveData.TabIndex = 2
        Me.tbPageSaveData.Text = "Save Data"
        Me.tbPageSaveData.UseVisualStyleBackColor = True
        '
        'lblSaveObjectFormat
        '
        Me.lblSaveObjectFormat.AutoSize = True
        Me.lblSaveObjectFormat.Location = New System.Drawing.Point(87, 145)
        Me.lblSaveObjectFormat.Name = "lblSaveObjectFormat"
        Me.lblSaveObjectFormat.Size = New System.Drawing.Size(42, 13)
        Me.lblSaveObjectFormat.TabIndex = 56
        Me.lblSaveObjectFormat.Text = "Format:"
        '
        'ucrCboSaveOutputObjectFormat
        '
        Me.ucrCboSaveOutputObjectFormat.AddQuotesIfUnrecognised = True
        Me.ucrCboSaveOutputObjectFormat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSaveOutputObjectFormat.GetSetSelectedIndex = -1
        Me.ucrCboSaveOutputObjectFormat.IsReadOnly = False
        Me.ucrCboSaveOutputObjectFormat.Location = New System.Drawing.Point(88, 160)
        Me.ucrCboSaveOutputObjectFormat.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboSaveOutputObjectFormat.Name = "ucrCboSaveOutputObjectFormat"
        Me.ucrCboSaveOutputObjectFormat.Size = New System.Drawing.Size(141, 21)
        Me.ucrCboSaveOutputObjectFormat.TabIndex = 55
        '
        'lblSaveObjectType
        '
        Me.lblSaveObjectType.AutoSize = True
        Me.lblSaveObjectType.Location = New System.Drawing.Point(85, 101)
        Me.lblSaveObjectType.Name = "lblSaveObjectType"
        Me.lblSaveObjectType.Size = New System.Drawing.Size(34, 13)
        Me.lblSaveObjectType.TabIndex = 54
        Me.lblSaveObjectType.Text = "Type:"
        '
        'ucrCboSaveOutputObjectType
        '
        Me.ucrCboSaveOutputObjectType.AddQuotesIfUnrecognised = True
        Me.ucrCboSaveOutputObjectType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSaveOutputObjectType.GetSetSelectedIndex = -1
        Me.ucrCboSaveOutputObjectType.IsReadOnly = False
        Me.ucrCboSaveOutputObjectType.Location = New System.Drawing.Point(87, 116)
        Me.ucrCboSaveOutputObjectType.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboSaveOutputObjectType.Name = "ucrCboSaveOutputObjectType"
        Me.ucrCboSaveOutputObjectType.Size = New System.Drawing.Size(144, 21)
        Me.ucrCboSaveOutputObjectType.TabIndex = 53
        '
        'rdoSaveOutputObject
        '
        Me.rdoSaveOutputObject.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveOutputObject.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveOutputObject.FlatAppearance.BorderSize = 2
        Me.rdoSaveOutputObject.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveOutputObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveOutputObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveOutputObject.Location = New System.Drawing.Point(235, 14)
        Me.rdoSaveOutputObject.Name = "rdoSaveOutputObject"
        Me.rdoSaveOutputObject.Size = New System.Drawing.Size(86, 30)
        Me.rdoSaveOutputObject.TabIndex = 51
        Me.rdoSaveOutputObject.TabStop = True
        Me.rdoSaveOutputObject.Text = "Output Object"
        Me.rdoSaveOutputObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveOutputObject.UseVisualStyleBackColor = True
        '
        'rdoSaveDataFrame
        '
        Me.rdoSaveDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoSaveDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveDataFrame.Location = New System.Drawing.Point(79, 14)
        Me.rdoSaveDataFrame.Name = "rdoSaveDataFrame"
        Me.rdoSaveDataFrame.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveDataFrame.TabIndex = 49
        Me.rdoSaveDataFrame.TabStop = True
        Me.rdoSaveDataFrame.Text = "Data Frame"
        Me.rdoSaveDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveDataFrame.UseVisualStyleBackColor = True
        '
        'rdoSaveColumn
        '
        Me.rdoSaveColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSaveColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveColumn.FlatAppearance.BorderSize = 2
        Me.rdoSaveColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSaveColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSaveColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSaveColumn.Location = New System.Drawing.Point(157, 14)
        Me.rdoSaveColumn.Name = "rdoSaveColumn"
        Me.rdoSaveColumn.Size = New System.Drawing.Size(80, 30)
        Me.rdoSaveColumn.TabIndex = 50
        Me.rdoSaveColumn.TabStop = True
        Me.rdoSaveColumn.Text = "Column"
        Me.rdoSaveColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSaveColumn.UseVisualStyleBackColor = True
        '
        'ucrSaveData
        '
        Me.ucrSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrSaveData.Location = New System.Drawing.Point(88, 193)
        Me.ucrSaveData.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSaveData.Name = "ucrSaveData"
        Me.ucrSaveData.Size = New System.Drawing.Size(258, 22)
        Me.ucrSaveData.TabIndex = 35
        '
        'ucrDataFrameSaveOutputSelect
        '
        Me.ucrDataFrameSaveOutputSelect.AutoSize = True
        Me.ucrDataFrameSaveOutputSelect.bDropUnusedFilterLevels = False
        Me.ucrDataFrameSaveOutputSelect.bUseCurrentFilter = True
        Me.ucrDataFrameSaveOutputSelect.Location = New System.Drawing.Point(86, 54)
        Me.ucrDataFrameSaveOutputSelect.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameSaveOutputSelect.Name = "ucrDataFrameSaveOutputSelect"
        Me.ucrDataFrameSaveOutputSelect.Size = New System.Drawing.Size(158, 47)
        Me.ucrDataFrameSaveOutputSelect.TabIndex = 29
        '
        'ucrPnlSaveData
        '
        Me.ucrPnlSaveData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlSaveData.Location = New System.Drawing.Point(13, 12)
        Me.ucrPnlSaveData.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlSaveData.Name = "ucrPnlSaveData"
        Me.ucrPnlSaveData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlSaveData.TabIndex = 47
        '
        'tbPageGetData
        '
        Me.tbPageGetData.Controls.Add(Me.ucrReceiverGetOutputObject)
        Me.tbPageGetData.Controls.Add(Me.ucrReceiverGetColumns)
        Me.tbPageGetData.Controls.Add(Me.lblGetColumn)
        Me.tbPageGetData.Controls.Add(Me.ucrDataFrameGetDF)
        Me.tbPageGetData.Controls.Add(Me.lblGetObjectType)
        Me.tbPageGetData.Controls.Add(Me.ucrCboGetOutputObjectType)
        Me.tbPageGetData.Controls.Add(Me.rdoGetOutputObject)
        Me.tbPageGetData.Controls.Add(Me.lblGetOutputObject)
        Me.tbPageGetData.Controls.Add(Me.rdoGetDataFrame)
        Me.tbPageGetData.Controls.Add(Me.rdoGetColumn)
        Me.tbPageGetData.Controls.Add(Me.ucrPnlGetData)
        Me.tbPageGetData.Controls.Add(Me.ucrSelectorGetObject)
        Me.tbPageGetData.Location = New System.Drawing.Point(4, 22)
        Me.tbPageGetData.Name = "tbPageGetData"
        Me.tbPageGetData.Padding = New System.Windows.Forms.Padding(3)
        Me.tbPageGetData.Size = New System.Drawing.Size(438, 245)
        Me.tbPageGetData.TabIndex = 1
        Me.tbPageGetData.Text = "Get Data"
        Me.tbPageGetData.UseVisualStyleBackColor = True
        '
        'ucrReceiverGetOutputObject
        '
        Me.ucrReceiverGetOutputObject.AutoSize = True
        Me.ucrReceiverGetOutputObject.frmParent = Nothing
        Me.ucrReceiverGetOutputObject.Location = New System.Drawing.Point(240, 117)
        Me.ucrReceiverGetOutputObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGetOutputObject.Name = "ucrReceiverGetOutputObject"
        Me.ucrReceiverGetOutputObject.Selector = Nothing
        Me.ucrReceiverGetOutputObject.Size = New System.Drawing.Size(138, 20)
        Me.ucrReceiverGetOutputObject.strNcFilePath = ""
        Me.ucrReceiverGetOutputObject.TabIndex = 27
        Me.ucrReceiverGetOutputObject.ucrSelector = Nothing
        '
        'ucrReceiverGetColumns
        '
        Me.ucrReceiverGetColumns.AutoSize = True
        Me.ucrReceiverGetColumns.frmParent = Nothing
        Me.ucrReceiverGetColumns.Location = New System.Drawing.Point(243, 104)
        Me.ucrReceiverGetColumns.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrReceiverGetColumns.Name = "ucrReceiverGetColumns"
        Me.ucrReceiverGetColumns.Selector = Nothing
        Me.ucrReceiverGetColumns.Size = New System.Drawing.Size(137, 105)
        Me.ucrReceiverGetColumns.strNcFilePath = ""
        Me.ucrReceiverGetColumns.TabIndex = 49
        Me.ucrReceiverGetColumns.ucrSelector = Nothing
        '
        'lblGetColumn
        '
        Me.lblGetColumn.AutoSize = True
        Me.lblGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGetColumn.Location = New System.Drawing.Point(252, 88)
        Me.lblGetColumn.Name = "lblGetColumn"
        Me.lblGetColumn.Size = New System.Drawing.Size(45, 13)
        Me.lblGetColumn.TabIndex = 50
        Me.lblGetColumn.Text = "Column:"
        '
        'ucrDataFrameGetDF
        '
        Me.ucrDataFrameGetDF.AutoSize = True
        Me.ucrDataFrameGetDF.bDropUnusedFilterLevels = False
        Me.ucrDataFrameGetDF.bUseCurrentFilter = True
        Me.ucrDataFrameGetDF.Location = New System.Drawing.Point(81, 55)
        Me.ucrDataFrameGetDF.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrDataFrameGetDF.Name = "ucrDataFrameGetDF"
        Me.ucrDataFrameGetDF.Size = New System.Drawing.Size(224, 59)
        Me.ucrDataFrameGetDF.TabIndex = 31
        '
        'lblGetObjectType
        '
        Me.lblGetObjectType.AutoSize = True
        Me.lblGetObjectType.Location = New System.Drawing.Point(239, 57)
        Me.lblGetObjectType.Name = "lblGetObjectType"
        Me.lblGetObjectType.Size = New System.Drawing.Size(34, 13)
        Me.lblGetObjectType.TabIndex = 48
        Me.lblGetObjectType.Text = "Type:"
        '
        'ucrCboGetOutputObjectType
        '
        Me.ucrCboGetOutputObjectType.AddQuotesIfUnrecognised = True
        Me.ucrCboGetOutputObjectType.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboGetOutputObjectType.GetSetSelectedIndex = -1
        Me.ucrCboGetOutputObjectType.IsReadOnly = False
        Me.ucrCboGetOutputObjectType.Location = New System.Drawing.Point(241, 72)
        Me.ucrCboGetOutputObjectType.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboGetOutputObjectType.Name = "ucrCboGetOutputObjectType"
        Me.ucrCboGetOutputObjectType.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboGetOutputObjectType.TabIndex = 47
        '
        'rdoGetOutputObject
        '
        Me.rdoGetOutputObject.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetOutputObject.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetOutputObject.FlatAppearance.BorderSize = 2
        Me.rdoGetOutputObject.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetOutputObject.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetOutputObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetOutputObject.Location = New System.Drawing.Point(235, 12)
        Me.rdoGetOutputObject.Name = "rdoGetOutputObject"
        Me.rdoGetOutputObject.Size = New System.Drawing.Size(85, 30)
        Me.rdoGetOutputObject.TabIndex = 46
        Me.rdoGetOutputObject.TabStop = True
        Me.rdoGetOutputObject.Text = "Output Object"
        Me.rdoGetOutputObject.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetOutputObject.UseVisualStyleBackColor = True
        '
        'lblGetOutputObject
        '
        Me.lblGetOutputObject.AutoSize = True
        Me.lblGetOutputObject.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblGetOutputObject.Location = New System.Drawing.Point(242, 101)
        Me.lblGetOutputObject.Name = "lblGetOutputObject"
        Me.lblGetOutputObject.Size = New System.Drawing.Size(41, 13)
        Me.lblGetOutputObject.TabIndex = 26
        Me.lblGetOutputObject.Text = "Object:"
        '
        'rdoGetDataFrame
        '
        Me.rdoGetDataFrame.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetDataFrame.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatAppearance.BorderSize = 2
        Me.rdoGetDataFrame.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetDataFrame.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetDataFrame.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetDataFrame.Location = New System.Drawing.Point(79, 12)
        Me.rdoGetDataFrame.Name = "rdoGetDataFrame"
        Me.rdoGetDataFrame.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetDataFrame.TabIndex = 44
        Me.rdoGetDataFrame.TabStop = True
        Me.rdoGetDataFrame.Text = "Data Frame"
        Me.rdoGetDataFrame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetDataFrame.UseVisualStyleBackColor = True
        '
        'rdoGetColumn
        '
        Me.rdoGetColumn.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGetColumn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetColumn.FlatAppearance.BorderSize = 2
        Me.rdoGetColumn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGetColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGetColumn.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGetColumn.Location = New System.Drawing.Point(157, 12)
        Me.rdoGetColumn.Name = "rdoGetColumn"
        Me.rdoGetColumn.Size = New System.Drawing.Size(80, 30)
        Me.rdoGetColumn.TabIndex = 45
        Me.rdoGetColumn.TabStop = True
        Me.rdoGetColumn.Text = "Column"
        Me.rdoGetColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGetColumn.UseVisualStyleBackColor = True
        '
        'ucrPnlGetData
        '
        Me.ucrPnlGetData.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlGetData.Location = New System.Drawing.Point(5, 10)
        Me.ucrPnlGetData.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlGetData.Name = "ucrPnlGetData"
        Me.ucrPnlGetData.Size = New System.Drawing.Size(402, 36)
        Me.ucrPnlGetData.TabIndex = 42
        '
        'ucrSelectorGetObject
        '
        Me.ucrSelectorGetObject.AutoSize = True
        Me.ucrSelectorGetObject.bDropUnusedFilterLevels = False
        Me.ucrSelectorGetObject.bShowHiddenColumns = False
        Me.ucrSelectorGetObject.bUseCurrentFilter = True
        Me.ucrSelectorGetObject.Location = New System.Drawing.Point(9, 52)
        Me.ucrSelectorGetObject.Margin = New System.Windows.Forms.Padding(0)
        Me.ucrSelectorGetObject.Name = "ucrSelectorGetObject"
        Me.ucrSelectorGetObject.Size = New System.Drawing.Size(222, 188)
        Me.ucrSelectorGetObject.TabIndex = 34
        '
        'tbPageCommon
        '
        Me.tbPageCommon.Controls.Add(Me.ucrCboLibPackage)
        Me.tbPageCommon.Controls.Add(Me.lblGetPackage)
        Me.tbPageCommon.Controls.Add(Me.lblRemoveObject)
        Me.tbPageCommon.Controls.Add(Me.ucrInputRemoveObjects)
        Me.tbPageCommon.Location = New System.Drawing.Point(4, 22)
        Me.tbPageCommon.Name = "tbPageCommon"
        Me.tbPageCommon.Size = New System.Drawing.Size(438, 245)
        Me.tbPageCommon.TabIndex = 3
        Me.tbPageCommon.Text = "Common"
        Me.tbPageCommon.UseVisualStyleBackColor = True
        '
        'ucrCboLibPackage
        '
        Me.ucrCboLibPackage.AddQuotesIfUnrecognised = True
        Me.ucrCboLibPackage.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboLibPackage.GetSetSelectedIndex = -1
        Me.ucrCboLibPackage.IsReadOnly = False
        Me.ucrCboLibPackage.Location = New System.Drawing.Point(14, 28)
        Me.ucrCboLibPackage.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrCboLibPackage.Name = "ucrCboLibPackage"
        Me.ucrCboLibPackage.Size = New System.Drawing.Size(137, 21)
        Me.ucrCboLibPackage.TabIndex = 44
        '
        'lblGetPackage
        '
        Me.lblGetPackage.AutoSize = True
        Me.lblGetPackage.Location = New System.Drawing.Point(11, 11)
        Me.lblGetPackage.Name = "lblGetPackage"
        Me.lblGetPackage.Size = New System.Drawing.Size(73, 13)
        Me.lblGetPackage.TabIndex = 43
        Me.lblGetPackage.Text = "Get Package:"
        '
        'lblRemoveObject
        '
        Me.lblRemoveObject.AutoSize = True
        Me.lblRemoveObject.Location = New System.Drawing.Point(12, 68)
        Me.lblRemoveObject.Name = "lblRemoveObject"
        Me.lblRemoveObject.Size = New System.Drawing.Size(95, 13)
        Me.lblRemoveObject.TabIndex = 3
        Me.lblRemoveObject.Text = "Remove Object(s):"
        '
        'ucrInputRemoveObjects
        '
        Me.ucrInputRemoveObjects.AddQuotesIfUnrecognised = True
        Me.ucrInputRemoveObjects.AutoSize = True
        Me.ucrInputRemoveObjects.IsMultiline = False
        Me.ucrInputRemoveObjects.IsReadOnly = False
        Me.ucrInputRemoveObjects.Location = New System.Drawing.Point(11, 86)
        Me.ucrInputRemoveObjects.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputRemoveObjects.Name = "ucrInputRemoveObjects"
        Me.ucrInputRemoveObjects.Size = New System.Drawing.Size(145, 21)
        Me.ucrInputRemoveObjects.TabIndex = 2
        '
        'tbPageLibrary
        '
        Me.tbPageLibrary.Location = New System.Drawing.Point(4, 22)
        Me.tbPageLibrary.Name = "tbPageLibrary"
        Me.tbPageLibrary.Size = New System.Drawing.Size(438, 245)
        Me.tbPageLibrary.TabIndex = 4
        Me.tbPageLibrary.Text = "Examples"
        Me.tbPageLibrary.UseVisualStyleBackColor = True
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblPreview.Location = New System.Drawing.Point(9, 281)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(48, 13)
        Me.lblPreview.TabIndex = 30
        Me.lblPreview.Text = "Preview:"
        '
        'txtScript
        '
        Me.txtScript.Location = New System.Drawing.Point(5, 299)
        Me.txtScript.Multiline = True
        Me.txtScript.Name = "txtScript"
        Me.txtScript.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtScript.Size = New System.Drawing.Size(445, 96)
        Me.txtScript.TabIndex = 32
        '
        'ucrBase
        '
        Me.ucrBase.AutoSize = True
        Me.ucrBase.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrBase.Location = New System.Drawing.Point(6, 399)
        Me.ucrBase.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrBase.Name = "ucrBase"
        Me.ucrBase.Size = New System.Drawing.Size(408, 52)
        Me.ucrBase.TabIndex = 16
        '
        'dlgScript
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(458, 458)
        Me.Controls.Add(Me.txtScript)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.tbFeatures)
        Me.Controls.Add(Me.ucrBase)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "dlgScript"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Script"
        Me.tbFeatures.ResumeLayout(False)
        Me.tbPageSaveData.ResumeLayout(False)
        Me.tbPageSaveData.PerformLayout()
        Me.tbPageGetData.ResumeLayout(False)
        Me.tbPageGetData.PerformLayout()
        Me.tbPageCommon.ResumeLayout(False)
        Me.tbPageCommon.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ucrBase As ucrButtons
    Friend WithEvents ucrDataFrameGetDF As ucrDataFrame
    Friend WithEvents tbFeatures As TabControl
    Friend WithEvents tbPageGetData As TabPage
    Friend WithEvents tbPageSaveData As TabPage
    Friend WithEvents lblPreview As Label
    Friend WithEvents ucrSaveData As ucrSave
    Friend WithEvents tbPageCommon As TabPage
    Friend WithEvents ucrDataFrameSaveOutputSelect As ucrDataFrame
    Friend WithEvents ucrSelectorGetObject As ucrSelectorByDataFrameAddRemove
    Friend WithEvents lblGetOutputObject As Label
    Friend WithEvents ucrReceiverGetOutputObject As ucrReceiverSingle
    Friend WithEvents ucrPnlGetData As UcrPanel
    Friend WithEvents rdoGetDataFrame As RadioButton
    Friend WithEvents rdoGetColumn As RadioButton
    Friend WithEvents rdoGetOutputObject As RadioButton
    Friend WithEvents rdoSaveOutputObject As RadioButton
    Friend WithEvents rdoSaveDataFrame As RadioButton
    Friend WithEvents rdoSaveColumn As RadioButton
    Friend WithEvents ucrPnlSaveData As UcrPanel
    Friend WithEvents txtScript As TextBox
    Friend WithEvents lblGetObjectType As Label
    Friend WithEvents ucrCboGetOutputObjectType As ucrInputComboBox
    Friend WithEvents tbPageLibrary As TabPage
    Friend WithEvents lblSaveObjectType As Label
    Friend WithEvents ucrCboSaveOutputObjectType As ucrInputComboBox
    Friend WithEvents lblSaveObjectFormat As Label
    Friend WithEvents ucrCboSaveOutputObjectFormat As ucrInputComboBox
    Friend WithEvents lblRemoveObject As Label
    Friend WithEvents ucrInputRemoveObjects As ucrInputTextBox
    Friend WithEvents ucrCboLibPackage As ucrInputComboBox
    Friend WithEvents lblGetPackage As Label
    Friend WithEvents ucrReceiverGetColumns As ucrReceiverMultiple
    Friend WithEvents lblGetColumn As Label
End Class
