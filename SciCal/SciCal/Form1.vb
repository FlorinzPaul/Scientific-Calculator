'Imports System.Runtime.Hosting
'Imports System.Security.Cryptography
'Imports System.Windows.Forms.VisualStyles.VisualStyleElement
'Imports Microsoft.VisualBasic.Logging

Public Class Form1
    Dim firstValueIn, secondValueIn As Double
    Dim op As String
    Dim q As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "0"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "1"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "2"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "3"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "4"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "5"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "6"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "7"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "8"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (txtBoxResults.Text = "0") Then
            txtBoxResults.Text = "9"
        Else
            txtBoxResults.Text = txtBoxResults.Text + "9"
        End If
    End Sub

    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        If (txtBoxResults.Text.Length > 0) Then
            txtBoxResults.Text = txtBoxResults.Text.Remove(txtBoxResults.Text.Length - 1, 1)
        End If

        If (txtBoxResults.Text = "") Then
            txtBoxResults.Text = "0"
        End If
    End Sub

    Private Sub btnCE_Click(sender As Object, e As EventArgs) Handles btnCE.Click
        txtBoxResults.Text = "0"

        Dim f, s As String

        f = Convert.ToString(firstValueIn)
        s = Convert.ToString(secondValueIn)
        f = ""
        s = ""
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtBoxResults.Text = "0"
    End Sub

    Private Sub btnPM_Click(sender As Object, e As EventArgs) Handles btnPM.Click
        Dim q As Double
        q = Convert.ToDouble(txtBoxResults.Text)
        txtBoxResults.Text = Convert.ToString(-1 * q)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        firstValueIn = Double.Parse(txtBoxResults.Text)
        op = "+"
        txtBoxResults.Text = ""
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        firstValueIn = Double.Parse(txtBoxResults.Text)
        op = "-"
        txtBoxResults.Text = ""
    End Sub

    Private Sub btnMuti_Click(sender As Object, e As EventArgs) Handles btnMuti.Click
        firstValueIn = Double.Parse(txtBoxResults.Text)
        op = "*"
        txtBoxResults.Text = ""
    End Sub

    Private Sub btnDiv_Click(sender As Object, e As EventArgs) Handles btnDiv.Click
        firstValueIn = Double.Parse(txtBoxResults.Text)
        op = "/"
        txtBoxResults.Text = ""
    End Sub

    Private Sub btnExp_Click(sender As Object, e As EventArgs) Handles btnExp.Click
        firstValueIn = Double.Parse(txtBoxResults.Text)
        op = "Exp"
        txtBoxResults.Text = ""
    End Sub

    Private Sub btnMod_Click(sender As Object, e As EventArgs) Handles btnMod.Click
        firstValueIn = Double.Parse(txtBoxResults.Text)
        op = "Mod"
        txtBoxResults.Text = ""
    End Sub

    Private Sub btnPoint_Click(sender As Object, e As EventArgs) Handles btnPoint.Click
        If (btnPoint.Text = ".") Then
            If (Not txtBoxResults.Text.Contains(".")) Then
                txtBoxResults.Text = txtBoxResults.Text + btnPoint.Text
            End If
        End If
    End Sub

    Private Sub btnEquals_Click(sender As Object, e As EventArgs) Handles btnEquals.Click
        secondValueIn = Double.Parse(txtBoxResults.Text)

        Select Case op
            Case "+"
                txtBoxResults.Text = (firstValueIn + secondValueIn).ToString()

            Case "-"
                txtBoxResults.Text = (firstValueIn - secondValueIn).ToString()

            Case "*"
                txtBoxResults.Text = (firstValueIn * secondValueIn).ToString()

            Case "/"
                txtBoxResults.Text = (firstValueIn / secondValueIn).ToString()

            Case "Exp"
                Dim a As Double = Convert.ToDouble(txtBoxResults.Text)
                Dim b As Double = secondValueIn
                txtBoxResults.Text = Math.Exp(a * Math.Log(b * 4)).ToString()

            Case "Mod"
                txtBoxResults.Text = (firstValueIn Mod secondValueIn).ToString()

            Case Else
                txtBoxResults.Text = "Invalid Operator"

        End Select
    End Sub

    Private Sub btnPi_Click(sender As Object, e As EventArgs) Handles btnPi.Click
        txtBoxResults.Text = "3.14159265358979323"
    End Sub

    Private Sub btnLog_Click(sender As Object, e As EventArgs) Handles btnLog.Click
        Dim log As Double

        log = Convert.ToDouble(txtBoxResults.Text)
        log = Math.Log10(log)
        txtBoxResults.Text = Convert.ToString(log)
    End Sub

    Private Sub bntSqrt_Click(sender As Object, e As EventArgs) Handles bntSqrt.Click
        Dim sqrt As Double

        sqrt = Convert.ToDouble(txtBoxResults.Text)
        sqrt = Math.Sqrt(sqrt)
        txtBoxResults.Text = Convert.ToString(sqrt)
    End Sub

    Private Sub btnX2_Click(sender As Object, e As EventArgs) Handles btnX2.Click
        Dim x As Double
        x = Convert.ToDouble(txtBoxResults.Text)
        txtBoxResults.Text = Convert.ToString(x * x)

    End Sub

    Private Sub bntX3_Click(sender As Object, e As EventArgs) Handles bntX3.Click
        Dim x As Double
        x = Convert.ToDouble(txtBoxResults.Text)
        txtBoxResults.Text = Convert.ToString(x * x * x)
    End Sub

    Private Sub btnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        Dim dec As Double = Convert.ToDouble(txtBoxResults.Text)
        Dim num1, num2 As Integer

        num1 = Convert.ToInt32(dec)
        num2 = CInt(dec)
        txtBoxResults.Text = num2.ToString()
    End Sub

    Private Sub btnSin_Click(sender As Object, e As EventArgs) Handles btnSin.Click
        Dim sin As Double = Convert.ToDouble(txtBoxResults.Text)
        sin = Math.Sin(sin)
        txtBoxResults.Text = sin.ToString()
    End Sub

    Private Sub btnSinh_Click(sender As Object, e As EventArgs) Handles btnSinh.Click
        Dim sinh As Double = Convert.ToDouble(txtBoxResults.Text)
        sinh = Math.Sinh(sinh)
        txtBoxResults.Text = sinh.ToString()
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        Dim cos As Double = Convert.ToDouble(txtBoxResults.Text)
        cos = Math.Cos(cos)
        txtBoxResults.Text = cos.ToString()
    End Sub

    Private Sub btnCosh_Click(sender As Object, e As EventArgs) Handles btnCosh.Click
        Dim cosh As Double = Convert.ToDouble(txtBoxResults.Text)
        cosh = Math.Cosh(cosh)
        txtBoxResults.Text = cosh.ToString()
    End Sub

    Private Sub btnTan_Click(sender As Object, e As EventArgs) Handles btnTan.Click
        Dim tan As Double = Convert.ToDouble(txtBoxResults.Text)
        tan = Math.Tan(tan)
        txtBoxResults.Text = tan.ToString()
    End Sub

    Private Sub btnTanh_Click(sender As Object, e As EventArgs) Handles btnTanh.Click
        Dim tanh As Double = Convert.ToDouble(txtBoxResults.Text)
        tanh = Math.Tanh(tanh)
        txtBoxResults.Text = tanh.ToString()
    End Sub

    Private Sub btnBin_Click(sender As Object, e As EventArgs) Handles btnBin.Click
        Dim a As Integer = Integer.Parse(txtBoxResults.Text)
        txtBoxResults.Text = Convert.ToString(a, 2)
    End Sub

    Private Sub btnHex_Click(sender As Object, e As EventArgs) Handles btnHex.Click
        Dim a As Integer = Integer.Parse(txtBoxResults.Text)
        txtBoxResults.Text = Convert.ToString(a, 16)
    End Sub

    Private Sub btnFrac_Click(sender As Object, e As EventArgs) Handles btnFrac.Click
        Dim input As Double

        If Double.TryParse(txtBoxResults.Text, input) Then
            Dim result As Double = 1 / input
            txtBoxResults.Text = result.ToString
        Else
            txtBoxResults.Text = "Please enter a valid num  ber"
        End If
    End Sub

    Private Sub btnInx_Click(sender As Object, e As EventArgs) Handles btnInx.Click
        Dim inx As Double = Convert.ToDouble(txtBoxResults.Text)
        inx = Math.Log(inx)
        txtBoxResults.Text = inx.ToString()
    End Sub

    Private Sub btnPerc_Click(sender As Object, e As EventArgs) Handles btnPerc.Click
        Dim perc As Double
        perc = Convert.ToDouble(txtBoxResults.Text) / Convert.ToDouble(100)
        txtBoxResults.Text = Convert.ToString(perc)
    End Sub

    Private Sub btnOct_Click(sender As Object, e As EventArgs) Handles btnOct.Click
        Dim oct As Integer = Integer.Parse(txtBoxResults.Text)
        txtBoxResults.Text = Convert.ToString(oct, 8)
    End Sub

End Class