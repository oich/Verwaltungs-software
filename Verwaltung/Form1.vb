﻿Public Class Form1
    Private pfad_main As String
    Private pfad_master As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles But_anlg.Click
        Dim pfad As String
        Dim kn_nr As String
        Dim kunde As String
        Dim af_nr As String
        Dim beab As String
        Dim af_bez As String
        Dim kont As String
        Dim date1 As String
        Dim pfad_kunde As String
        Dim pfad_auftrag As String


        date1 = Date_heute.Value.ToString("ddMMyyyy")
        kn_nr = TE_KundenNR.Text
        kunde = TE_kunde.Text
        af_nr = TE_AuftragNR.Text
        beab = CoB_beab.Text
        af_bez = TE_bennenung.Text
        kont = TE_kontakt.Text
        pfad = (pfad_main & lb_abteilung.SelectedItem & "\")
        pfad_kunde = (pfad & kn_nr & "_" & kunde)
        pfad_auftrag = (pfad & kn_nr & "_" & kunde & "\" & kn_nr & "." & af_nr & "_" & beab & "_" & af_bez & "_" & date1 & "_" & kont)
        pfad_master = pfad_master
        If System.IO.Directory.Exists(pfad_kunde) = False Then
            System.IO.Directory.CreateDirectory(pfad_kunde)
        End If

        If System.IO.Directory.Exists(pfad_auftrag) = False Then
            System.IO.Directory.CreateDirectory(pfad_auftrag)
            My.Computer.FileSystem.CopyDirectory(pfad_master, pfad_auftrag)

        End If


    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        brow_kunde.Navigate("d:\verwaltung\")
        If Txt_url_main.Text = "" Then
            pfad_main = ("D:\verwaltung\")
        Else
            pfad_main = Txt_url_main.Text
        End If

        If Txt_url_master.Text = "" Then
            pfad_master = ("D:\verwaltung\master")
        Else
            pfad_master = Txt_url_master.Text
        End If

    End Sub
    Dim ready As Boolean = False
    Private Sub brow_kunde_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles brow_kunde.DocumentCompleted
        ready = True

    End Sub
    Private Sub brow_kunde_navigating(sender As Object, e As WebBrowserNavigatingEventArgs) Handles brow_kunde.Navigating

        If ready Then
            Dim URL_kunde = e.Url
            brow_auftrag.Navigate(URL_kunde)

            e.Cancel = True
        End If
        ready = False

    End Sub



    Private Sub lb_abteilung_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lb_abteilung.SelectedIndexChanged
        If lb_abteilung.SelectedItem = ("Lohnfertigung") Then
            ready = True
            brow_kunde.Navigate(pfad_main & "Lohnfertigung")
            'd:\verwaltung

        End If

        If lb_abteilung.SelectedItem = ("Vorrichtungsbau") Then
            ready = True
            brow_kunde.Navigate(pfad_main & "Vorrichtungsbau")

        End If
        ready = False
    End Sub

    Private Sub btn_addurl_main_Click(sender As Object, e As EventArgs) Handles btn_addurl_main.Click
        FolderBrowser_main.ShowDialog()
        Txt_url_main.Text = FolderBrowser_main.SelectedPath

    End Sub

    Private Sub btn_addurl_master_Click(sender As Object, e As EventArgs) Handles btn_addurl_master.Click
        FolderBrowser_master.ShowDialog()
        Txt_url_master.Text = FolderBrowser_master.SelectedPath

    End Sub
End Class
