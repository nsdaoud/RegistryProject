Imports System.IO
Imports Telerik.WinControls.UI
Imports System.Xml
Imports System.Configuration

Public Class Frmfilepath

    Private Sub Frmfilepath_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdfilepath.AutoSizeColumnsMode = GridViewAutoSizeColumnsMode.Fill

        LoadFileFromConfig()
    End Sub

    Public Sub LoadFileFromConfig()
        'Dim ApplicationPath As String = Application.StartupPath
        'Dim YourPath As String = Path.GetDirectoryName(ApplicationPath)
        'Dim path__1 As String = Path.GetDirectoryName(YourPath) + "\app.config"
        Dim appSettings = ConfigurationManager.AppSettings
        Dim xmlDataSet As New DataSet()
        Dim workTable As New DataTable
        'appSettings = ConfigurationManager.AppSettings.AllKeys
        'xmlDataSet.ReadXml(path__1)
        'For Each key As String In appSettings.AllKeys
        '    Console.WriteLine("Key: {0} Value: {1}", key, appSettings(key))

        'Next

        'Me.grdfilepath.Columns.Add("Key", "Key")
        'Me.grdfilepath.Columns.Add("Value", "Value")

        'If grdfilepath.Rows.Count > 0 Then
        '    For i As Integer = 0 To grdfilepath.Rows.Count - 1
        '        grdfilepath.Rows.RemoveAti)
        '    Next
        'End If

        workTable.Columns.Add("Key", GetType(String))
        workTable.Columns.Add("Value", GetType(String))

        For Each key As String In ConfigurationManager.AppSettings
            Dim workRow As DataRow = workTable.NewRow()
            workRow("Key") = key
            workRow("Value") = ConfigurationManager.AppSettings(key)
            workTable.Rows.Add(workRow)
            'Me.grdfilepath.Rows.Add(key, ConfigurationManager.AppSettings(key))
        Next

        grdfilepath.DataSource = workTable

        getfirstselectedrow()
    End Sub

    Private Sub grdfilepath_CellClick(sender As Object, e As GridViewCellEventArgs) Handles grdfilepath.CellClick

        txtfiletype.Text = grdfilepath.SelectedRows(0).Cells(0).Value
        txtfilelocation.Text = grdfilepath.SelectedRows(0).Cells(1).Value
        'MessageBox.Show("ss")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnfilelocation.Click
        ' New FolderBrowserDialog instance
        Dim Fld As New FolderBrowserDialog()

        ' Set initial selected folder
        'Fld.SelectedPath = curfolder.Text

        '' Show the "Make new folder" button
        'Fld.ShowNewFolderButton = True

        If Fld.ShowDialog() = DialogResult.OK Then
            ' Select successful
            'MessageBox.Show("The folder you selected is : " + Fld.SelectedPath)
            txtfilelocation.Text = Fld.SelectedPath
        Else
            ' Selection canceled
            MessageBox.Show("Operation canceled.")
        End If

    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        AddUpdateAppSettings(txtfiletype.Text, txtfilelocation.Text)
        LoadFileFromConfig()
        getfirstselectedrow()
    End Sub
    Public Sub getfirstselectedrow()
        txtfiletype.Text = ""
        txtfilelocation.Text = ""
        If grdfilepath.Rows.Count > 0 Then
            txtfiletype.Text = grdfilepath.Rows(0).Cells(0).Value
            txtfilelocation.Text = grdfilepath.Rows(0).Cells(1).Value

        End If

    End Sub


    Sub AddUpdateAppSettings(key As String, value As String)
        Try
            Dim configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            Dim settings = configFile.AppSettings.Settings
            If IsNothing(settings(key)) Then
                settings.Add(key, value)
            Else
                settings(key).Value = value
            End If
            configFile.Save(ConfigurationSaveMode.Modified)
            ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name)
        Catch e As ConfigurationErrorsException
            Console.WriteLine("Error writing app settings")
        End Try
    End Sub

    Public Sub add(name As String)
        Dim ApplicationPath As String = Application.StartupPath
        Dim YourPath As String = Path.GetDirectoryName(ApplicationPath)
        Dim isNew As Boolean = False

        Dim path__1 As String = Path.GetDirectoryName(YourPath) + "\app.config"
        Dim doc As New XmlDocument()
        doc.Load(path__1)
        Dim list As XmlNodeList = doc.DocumentElement.SelectNodes(String.Format("appSettings/add[@key='{0}']", name))
        Dim node As XmlNode
        isNew = list.Count = 0
        If isNew Then
            node = doc.CreateNode(XmlNodeType.Element, "add", Nothing)
            Dim attribute As XmlAttribute = doc.CreateAttribute("name")
            attribute.Value = name
            node.Attributes.Append(attribute)

            attribute = doc.CreateAttribute("connectionString")
            attribute.Value = ""
            node.Attributes.Append(attribute)

            attribute = doc.CreateAttribute("providerName")
            attribute.Value = "System.Data.SqlClient"
            node.Attributes.Append(attribute)
        Else
            node = list(0)
        End If
        'Dim conString As String = node.Attributes("connectionString").Value
        'Dim conStringBuilder As New SqlConnectionStringBuilder(conString)
        'conStringBuilder.InitialCatalog = "Sample"
        'conStringBuilder.DataSource = "myserver"
        'conStringBuilder.IntegratedSecurity = False
        'conStringBuilder.UserID = "test"
        'conStringBuilder.Password = "12345"
        'node.Attributes("connectionString").Value = conStringBuilder.ConnectionString
        node.Attributes("value").Value = txtfilelocation.Text
        If isNew Then
            doc.DocumentElement.SelectNodes("connectionStrings")(0).AppendChild(node)
        End If
        doc.Save(path__1)
    End Sub
End Class