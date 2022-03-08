Public Class result

#Region "CMYK"
    Private Structure _CMYK
        Dim C As Byte
        Dim M As Byte
        Dim Y As Byte
        Dim K As Byte
    End Structure

    ' TODO: Cleanup (Won't happen, this shit works)
    Private Function colorToCMYK(clr As Color) As _CMYK
        Dim r = clr.R / 255.0F
        Dim g = clr.G / 255.0F
        Dim b = clr.B / 255.0F

        Dim res As New _CMYK
        res.K = Math.Min(1.0F - r, Math.Min(1.0F - b, 1.0F - g))

        If res.K = 1.0F Then
            res.C = 0
            res.M = 0
            res.Y = 0
        Else
            res.C = Math.Round((1.0F - r - res.K) / (1.0F - res.K) * 100)
            res.M = Math.Round((1.0F - g - res.K) / (1.0F - res.K) * 100)
            res.Y = Math.Round((1.0F - b - res.K) / (1.0F - res.K) * 100)
        End If

        res.K = Math.Round(res.K * 100)

        Return res
    End Function
#End Region

#Region "RGBA to float to string please kill me why god why please stop this misery"
    Private Structure RGBAf
        Dim R As Double
        Dim G As Double
        Dim B As Double
        Dim A As Double
    End Structure

    Private Function colorToRgbaFloat(clr As Color) As RGBAf
        Dim res As New RGBAf With {
            .R = Math.Round(clr.R / 255, 3),
            .G = Math.Round(clr.G / 255, 3),
            .B = Math.Round(clr.B / 255, 3),
            .A = Math.Round(clr.A / 255, 3)
        }
        Return res
    End Function

    Private Structure RGBAf_s
        Dim R As String
        Dim G As String
        Dim B As String
        Dim A As String
    End Structure

    Private Function rgbaFloatToString(rgbaf As RGBAf) As RGBAf_s
        Dim res As New RGBAf_s With {
            .R = rgbaf.R.ToString.Replace(",", "."),
            .G = rgbaf.G.ToString.Replace(",", "."),
            .B = rgbaf.B.ToString.Replace(",", "."),
            .A = rgbaf.A.ToString.Replace(",", ".")
            }
        Return res
    End Function

    Private Function formatArgbFloat(clr As Color) As RGBAf_s
        Dim floatClr = colorToRgbaFloat(clr)
        Dim strClr = rgbaFloatToString(floatClr)
        Return strClr
    End Function
#End Region

    Public Shared Function colorToHex(clr As Color) As String
        Return clr.ToArgb().ToString("X6").Substring(2, 6)
    End Function

    Sub New(clr As Color)
        InitializeComponent()

        Dim hex = colorToHex(clr)
        Dim cmyk = colorToCMYK(clr)
        Dim rgbaf = formatArgbFloat(clr)

        txtHEX.Text = String.Format("#{0}", hex)
        txtRGB.Text = String.Format("rgb({0}, {1}, {2})", clr.R, clr.G, clr.B)
        txtRGBf.Text = String.Format("rgb({0}, {1}, {2})", rgbaf.R, rgbaf.G, rgbaf.B)
        txtRGBA.Text = String.Format("rgba({0}, {1}, {2}, {3})", clr.R, clr.G, clr.B, clr.A)
        txtRGBAf.Text = String.Format("rgba({0}, {1}, {2}, {3})", rgbaf.R, rgbaf.G, rgbaf.B, rgbaf.A)
        txtCMYK.Text = String.Format("{0}%, {1}%, {2}%, {3}%", cmyk.C, cmyk.M, cmyk.Y, cmyk.K)

        colorPanel.BackColor = clr
    End Sub

    Private Sub txt_Click(sender As Object, e As EventArgs) Handles _
            txtHEX.Click,
            txtRGBA.Click,
            txtRGBAf.Click,
            txtCMYK.Click,
            txtRGB.Click,
            txtRGBf.Click

        Dim txtbx As TextBox = CType(sender, TextBox)
        txtbx.SelectAll()
    End Sub
End Class