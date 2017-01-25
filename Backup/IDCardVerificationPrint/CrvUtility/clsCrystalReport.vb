Imports System.IO
Public Class clsCrystalReport
    Private myTempFolderName As String
    Private myAppPath As String
    Private myFileName As String
    Private myFileNumber As Integer
    Private myDataSourcePath As String
    Private myReportPath As String
    Private myCrxApp As CRAXDDRT.Application
    Private myCrxReport As CRAXDDRT.Report
    Private myCrxDataBase As CRAXDDRT.Database
    Private mFileNumber As Integer
    Public Function ParameterCount() As Integer
        Return myCrxReport.ParameterFields.Count
    End Function

    Public Function ParameterNames(ByVal pIndex As Integer) As String
        Dim myParaName As String = myCrxReport.ParameterFields.Item(pIndex).Name
        Return myParaName.Substring(2, myParaName.Length - 3)
    End Function

    Public Function ReportPath(ByVal pPath As String) As Boolean
        Try
            myCrxReport = myCrxApp.OpenReport(pPath)
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub New()
        myCrxApp = New CRAXDDRT.Application
        myCrxReport = New CRAXDDRT.Report
        myAppPath = Application.StartupPath
        myFileName = ""
        myFileNumber = 0
        myTempFolderName = "Temp"
        myDataSourcePath = ""
        myReportPath = ""

    End Sub

    Private Sub GetFullPath()
        mFileNumber += 1
        myFileNumber = mFileNumber
        If Directory.Exists(myAppPath & "\" & myTempFolderName) = False Then
            Directory.CreateDirectory(myAppPath & "\" & myTempFolderName)
        End If
        myDataSourcePath = myAppPath & "\" & myTempFolderName & "\" & myFileName & "_" & myFileNumber & ".xml"
    End Sub

    Public Sub SetParameterValue(ByVal pName As String, ByVal pValue As Object)
        myCrxReport.ParameterFields.GetItemByName(pName).AddCurrentValue(pValue)
    End Sub

    Public Sub DiscardSavedData()
        myCrxReport.DiscardSavedData()
    End Sub

    Private Sub DataSourcePath()
        myCrxReport.Database.Tables(1).Location = myDataSourcePath
    End Sub

    Public Sub DataSourcePath(ByVal pDataSourcePath As String)
        myCrxReport.Database.Tables(1).Location = pDataSourcePath
    End Sub

    Public Sub PrintToPrinter()
        myCrxReport.PrintOut(False, 1, , 1, 1)

    End Sub

    Public Sub PrintToPrinter(ByVal pCopy As Integer)
        myCrxReport.PrintOut(False, pCopy, , 1, 1)
    End Sub

    'Public Function SetDataSource(ByVal ParamArray pScripts() As String) As Boolean
    '    Dim myDataSet As New DataSet
    '    Dim myResult As String
    '    For i As Integer = 0 To UBound(pScripts) Step 2
    '        myResult = String.Empty
    '        myResult = mCls.FillDataSet(myDataSet, pScripts(i), pScripts(i + 1))
    '        If myResult <> "TRUE" Then
    '            MsgBox(myResult)
    '            Return False
    '        End If
    '    Next i
    '    Try
    '        myFileName = pScripts(1) & "_" & Now.Date.Year & Now.Date.Month & Now.Date.Day & "_" & Now.TimeOfDay.Milliseconds
    '        GetFullPath()
    '        myDataSet.WriteXml(myDataSourcePath, XmlWriteMode.WriteSchema)
    '        DataSourcePath()
    '        Return True
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '        Return False
    '    End Try
    'End Function

    Public Function SetDataSource(ByVal pDataSet As DataSet, ByVal pTableName As String) As Boolean
        Try
            myFileName = pTableName & "_" & Now.Date.Year & Now.Date.Month & Now.Date.Day & "_" & Now.TimeOfDay.Milliseconds
            GetFullPath()
            pDataSet.WriteXml(myDataSourcePath, XmlWriteMode.WriteSchema)
            DataSourcePath()
            Return True
        Catch ex As Exception
            ' MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function SetDataSource(ByVal pDataTale As DataTable, ByVal pTableName As String) As Boolean
        Dim myDataSet As New DataSet
        Dim myDataTable As New DataTable
        myDataTable = pDataTale.Copy
        myDataTable.TableName = pTableName
        myDataSet.Tables.Add(myDataTable)
        Try
            myFileName = pTableName & "_" & Now.Date.Year & Now.Date.Month & Now.Date.Day & "_" & Now.TimeOfDay.Milliseconds
            GetFullPath()
            myDataSet.WriteXml(myDataSourcePath, XmlWriteMode.WriteSchema)
            DataSourcePath()
            Return True
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return False
        End Try
    End Function
    Public Function Report() As CRAXDDRT.Report
        Return myCrxReport
    End Function

    Public Sub Close()
        'Dim myObj As New clsIO
        'Try
        '    If myDataSourcePath <> "" Then
        '        myObj.DeleteFile(myDataSourcePath)
        '    End If
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
        Try
            If myDataSourcePath <> "" Then
                If System.IO.File.Exists(myDataSourcePath) = True Then
                    System.IO.File.Delete(myDataSourcePath)
                End If
            End If
        Catch ex As Exception
            '  MsgBox(ex.Message)
        End Try
    End Sub
End Class