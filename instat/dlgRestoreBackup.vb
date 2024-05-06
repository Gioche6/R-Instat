﻿' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Imports System.IO
Imports RDotNet

Public Class dlgRestoreBackup
    Private strAutoSavedLogScript As String
    Private strAutoSavedDataFilePaths() As String
    Private strAutoSavedLogFilePaths() As String
    Private strAutoSavedInternalLogFilePaths() As String
    Private strScript As String
    Private strLoadDateFilePath As String
    Private bUserClose As Boolean = True
    Private clsDummyFunction As New RFunction
    Private strAutoSaveDataFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_data_auto_save")
    Private strAutoSaveLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_log_auto_save")
    Private strAutoSaveInternalLogFolderPath As String = Path.Combine(Path.GetTempPath, "R-Instat_debug_log_auto_save")
    Private bReset As Boolean = True
    Private bFirstload As Boolean = True

    Private Sub dlgRestoreBackup_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 411

        ucrChkShowDataFile.Checked = False
        ucrChkShowInternalLogFile.Checked = False
        ucrChkShowLogFile.Checked = False

        'temporary - not yet implemented
        ucrChkSendInternalLog.Visible = False
        ucrInputSavedPathData.Visible = False
        ucrInputSavedPathLog.Visible = False
        ucrInputSavedPathInternalLog.Visible = False

        If (Directory.Exists(strAutoSaveLogFolderPath)) Then
            strAutoSavedLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveLogFolderPath).ToArray
        End If
        If Directory.Exists(strAutoSaveDataFolderPath) Then
            strAutoSavedDataFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveDataFolderPath).ToArray
        End If
        If (Directory.Exists(strAutoSaveInternalLogFolderPath)) Then
            strAutoSavedInternalLogFilePaths = My.Computer.FileSystem.GetFiles(strAutoSaveInternalLogFolderPath).ToArray
        End If

        ucrBase.contextMenuStripToScript.Enabled = False

        ucrChkSendInternalLog.SetText("Send Debugging Log to R-Instat Team")

        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 Then
            ucrChkShowDataFile.SetText("Backup Data File Detected")
            rdoLoadBackupData.Enabled = True
            ucrInputSavedPathData.Enabled = True
            ucrChkShowDataFile.Enabled = True
        Else
            ucrChkShowDataFile.SetText("No Backup Data File Detected")
            rdoLoadBackupData.Enabled = False
            ucrInputSavedPathData.Enabled = False
            ucrChkShowDataFile.Enabled = False
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 Then
            ucrChkShowLogFile.SetText("Backup Log File Detected")
            rdoRunBackupLog.Enabled = True
            ucrInputSavedPathLog.Enabled = True
            ucrChkShowLogFile.Enabled = True
        Else
            ucrChkShowLogFile.SetText("No Backup Log File Detected")
            rdoRunBackupLog.Enabled = False
            ucrInputSavedPathLog.Enabled = False
            ucrChkShowLogFile.Enabled = False
        End If
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 Then
            ucrChkShowInternalLogFile.SetText("Backup Debugging Log File Detected")
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        Else
            ucrChkShowInternalLogFile.SetText("No Backup Debugging Log File Detected")
            ucrChkSendInternalLog.Visible = False
            ucrChkSendInternalLog.Checked = False
        End If
        ucrPnlRecoveryOption.AddRadioButton(rdoLoadBackupData)
        ucrPnlRecoveryOption.AddRadioButton(rdoRunBackupLog)
        ucrPnlRecoveryOption.AddRadioButton(rdoNeither)

        ucrPnlRecoveryOption.AddParameterValuesCondition(rdoLoadBackupData, "backup", "data")
        ucrPnlRecoveryOption.AddParameterValuesCondition(rdoRunBackupLog, "backup", "log")
        ucrPnlRecoveryOption.AddParameterValuesCondition(rdoNeither, "backup", "neither")
    End Sub

    Private Sub SetDefaults()
        ucrInputSavedPathData.Clear()
        ucrInputSavedPathLog.Clear()
        ucrInputSavedPathInternalLog.Clear()
        ucrChkShowDataFile.Checked = False
        ucrChkShowLogFile.Checked = False
        ucrChkSendInternalLog.Checked = False
        clsDummyFunction.AddParameter("backup", "neither")
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputSavedPathData.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputSavedPathLog.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlRecoveryOption.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub SaveFiles()
        If strAutoSavedDataFilePaths IsNot Nothing AndAlso strAutoSavedDataFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedDataFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathData.IsEmpty() AndAlso ucrChkShowDataFile.Checked Then
                    File.Copy(strAutoSavedDataFilePaths(0), ucrInputSavedPathData.FilePath(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete data file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
        If strAutoSavedLogFilePaths IsNot Nothing AndAlso strAutoSavedLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedLogFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathLog.IsEmpty() AndAlso ucrChkShowLogFile.Checked Then
                    File.Copy(strAutoSavedLogFilePaths(0), ucrInputSavedPathLog.FilePath(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete log file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
        If strAutoSavedInternalLogFilePaths IsNot Nothing AndAlso strAutoSavedInternalLogFilePaths.Count > 0 AndAlso File.Exists(strAutoSavedInternalLogFilePaths(0)) Then
            Try
                If Not ucrInputSavedPathInternalLog.IsEmpty() AndAlso ucrChkSendInternalLog.Checked Then
                    File.Copy(strAutoSavedInternalLogFilePaths(0), ucrInputSavedPathInternalLog.FilePath(), True)
                End If
            Catch ex As Exception
                MsgBox("Could not copy and/or delete internal log file." & Environment.NewLine & ex.Message, "Error copying/deleting file")
            End Try
        End If
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(rdoRunBackupLog.Checked OrElse rdoLoadBackupData.Checked OrElse rdoNeither.Checked)
    End Sub

    Private Sub ucrChkShowDataFile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowLogFile.ControlValueChanged, ucrChkShowInternalLogFile.ControlValueChanged, ucrChkShowDataFile.ControlValueChanged
        ucrInputSavedPathData.Visible = ucrChkShowDataFile.Checked
        ucrInputSavedPathLog.Visible = ucrChkShowLogFile.Checked
        ucrInputSavedPathInternalLog.Visible = ucrChkShowInternalLogFile.Checked
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlRecoveryOption.ControlContentsChanged
        strScript = ""
        strLoadDateFilePath = ""
        If rdoRunBackupLog.Checked Then
            'Retrieve the latest autosaved file based on the stored timestamp
            Dim autoSaveDirectory As New DirectoryInfo(strAutoSaveLogFolderPath)
            Dim strLatestLogFile As FileInfo = autoSaveDirectory.GetFiles("log*.R").OrderByDescending(Function(f) f.LastWriteTime).FirstOrDefault()
            strScript = strLatestLogFile.FullName
            clsDummyFunction.AddParameter("backup", "log")
        ElseIf rdoLoadBackupData.Checked Then
            'Retrieve the latest autosaved file based on the stored timestamp
            Dim autoSaveDirectory As New DirectoryInfo(strAutoSaveDataFolderPath)
            Dim strLatestDataFile As FileInfo = autoSaveDirectory.GetFiles("data_*.rds").OrderByDescending(Function(f) f.LastWriteTime).FirstOrDefault()

            strLoadDateFilePath = strLatestDataFile.FullName
            clsDummyFunction.AddParameter("backup", "data")
        Else
            clsDummyFunction.AddParameter("backup", "neither")
        End If

        TestOKEnabled()
    End Sub

    Private Sub ucrInputSavedPathData_Leave(sender As Object, e As EventArgs) Handles ucrInputSavedPathData.Leave
        If Not String.IsNullOrEmpty(ucrInputSavedPathData.IsEmpty) Then
            frmMain.clsRecentItems.addToMenu(Replace(ucrInputSavedPathData.FilePath, "\", "/"))
        End If
    End Sub

    Private Sub ucrInputSavedPathLog_Leave(sender As Object, e As EventArgs) Handles ucrInputSavedPathLog.Leave
        If Not String.IsNullOrEmpty(ucrInputSavedPathLog.IsEmpty) Then
            frmMain.clsRecentItems.addToMenu(Replace(ucrInputSavedPathLog.FilePath, "\", "/"))
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub GetRecoveryFiles(strRScripts As String, strDataFilePath As String)
        'if data file recovered then add it as part of the initial R set up script
        If Not String.IsNullOrEmpty(strDataFilePath) Then
            strRScripts = strRScripts & Environment.NewLine &
                        "# Importing auto recovered data" & Environment.NewLine &
                        frmMain.clsRLink.GetImportRDSRScript(strDataFilePath, False)
        End If

        'execute the R-Instat set up R scripts
        If Not String.IsNullOrEmpty(strRScripts) Then
            For Each strLine As String In strRScripts.Split({Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries)
                frmMain.clsRLink.RunScript(strScript:=strLine.Trim(), bSeparateThread:=True, bSilent:=True)
            Next
        End If

        'grids are only updated when clsRLink.bInstatObjectExists = True
        If frmMain.clsRLink.RunInternalScriptGetValue(strScript:="exists('" & frmMain.clsRLink.strInstatDataObject & "')",
                                              bSeparateThread:=True, bSilent:=True).AsCharacter(0) = "TRUE" Then
            'set R-Instat R object as exists if it has been set up in R level and refresh the grids
            'refreshing grids internally updates the .Net databook object as well.
            frmMain.clsRLink.bInstatObjectExists = True
            frmMain.UpdateAllGrids()
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        GetRecoveryFiles(strScript, strLoadDateFilePath)
        SaveFiles()
    End Sub
End Class