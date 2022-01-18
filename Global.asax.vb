Imports System.Web
Imports System.Web.SessionState
Imports CollegeBoardDLL

Public Class [Global]
    Inherits System.Web.HttpApplication

#Region " Component Designer Generated Code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Component Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Required by the Component Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Component Designer
    'It can be modified using the Component Designer.
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        components = New System.ComponentModel.Container()
    End Sub

#End Region

#Region "Class Variables"
    Private objWSCombo As ClsComboBoxFilling

#End Region

    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application is started
        Try
            'added by prakash on nov 16'07
            'Application("ConOpen") = 0
            'Application("ConClose") = 0
            'Application("RptConOpen") = 0
            'Application("RptConClose") = 0

        Catch ex As Exception

        End Try
        

    End Sub

    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        Try
            objWSCombo = New ClsComboBoxFilling
            Session("ServerDate") = objWSCombo.ServerDate_Fetch()
        Catch ex As Exception

        End Try
    End Sub

    Sub Application_BeginRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires at the beginning of each request
    End Sub

    Sub Application_AuthenticateRequest(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires upon attempting to authenticate the use
    End Sub

    Sub Application_Error(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when an error occurs
    End Sub

    Sub Session_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the session ends
        Try
            Session.Clear()
            Session.RemoveAll()
            Session.Abandon()
            '''Session("ServerDate") = Nothing
            '''Response.Write("<script language=Javascript>Javascript:window.open(http://localhost/prototypefinal/Login.aspx);</script>")
            '''Response.Write("<script language=Javascript>Javascript:window.open('Home.aspx','_top');</script>")
            Response.Write("<script language=Javascript>Javascript:window.open('Home.aspx','_top');</script>")
        Catch ex As Exception

        End Try
    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs)
        ' Fires when the application ends
        Try
            Application.Clear()
            Application.RemoveAll()
        Catch ex As Exception

        End Try
    End Sub

End Class
