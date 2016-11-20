VERSION 5.00
Object = "{831FDD16-0C5C-11D2-A9FC-0000F8754DA1}#2.0#0"; "MSCOMCTL.OCX"
Begin VB.Form Form1 
   Caption         =   "Form1"
   ClientHeight    =   2925
   ClientLeft      =   165
   ClientTop       =   555
   ClientWidth     =   10170
   LinkTopic       =   "Form1"
   ScaleHeight     =   2925
   ScaleWidth      =   10170
   StartUpPosition =   3  'Windows Default
   Begin MSComctlLib.ImageList ImageList1 
      Left            =   9240
      Top             =   1680
      _ExtentX        =   1005
      _ExtentY        =   1005
      BackColor       =   -2147483643
      MaskColor       =   12632256
      _Version        =   393216
   End
   Begin MSComctlLib.Toolbar Toolbar1 
      Align           =   1  'Align Top
      Height          =   570
      Left            =   0
      TabIndex        =   0
      Top             =   0
      Width           =   10170
      _ExtentX        =   17939
      _ExtentY        =   1005
      ButtonWidth     =   609
      ButtonHeight    =   953
      Appearance      =   1
      Style           =   1
      ImageList       =   "ImageList1"
      _Version        =   393216
      BorderStyle     =   1
   End
   Begin VB.Image Image1 
      Height          =   480
      Index           =   0
      Left            =   0
      Top             =   0
      Width           =   480
   End
End
Attribute VB_Name = "Form1"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit



Private Sub Form_Load()

Dim indice As Integer
Dim icono As String

Me.MousePointer = vbHourglass
Me.WindowState = 2


icono = Dir(App.Path & "\iconos\*.ico")

Do
    ImageList1.ImageHeight = 32
    ImageList1.ImageWidth = 32
    ImageList1.ListImages.Add , , LoadPicture(App.Path & "\iconos\" & icono)
    
    Toolbar1.Buttons.Add , , , , ImageList1.ListImages.Count
    
    icono = Dir
    
Loop Until icono = ""
Me.MousePointer = vbNormal
End Sub
