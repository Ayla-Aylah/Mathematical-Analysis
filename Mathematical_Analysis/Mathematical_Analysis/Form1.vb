Public Class frmdisplay
    Dim strFile As String
    Dim strvalue As String
    Dim outcome As String
    Dim dcmp As Integer
    Dim ccoutcome As Double
    Dim cc As Boolean = False

    Function Mean_Answer(facts As Integer()) As Double
        Dim summation As Integer = 0
        Dim xbar As Double
        For itg As Integer = 0 To facts.Length - 1
            summation += facts(itg)
        Next
        xbar = Convert.ToDouble(summation / (facts.Length - 1))
        Return xbar
    End Function

    Function Median_Answer(facts As Integer()) As Double
        If facts.Length > 0 Then
            ' Sort the array
            Array.Sort(facts)

            ' Check if the array length is even or odd
            If facts.Length Mod 2 = 0 Then
                ' If it is even, average the two central facts
                Dim centre1 As Integer = facts.Length \ 2
                Dim centre2 As Integer = centre1 - 1
                Return (facts(centre1) + facts(centre2)) / 2.0
            Else
                ' If odd, return the central fact
                Dim centre As Integer = facts.Length \ 2
                Return facts(centre)
            End If
        Else
            Return 0
        End If

    End Function

    Function Mode_Answer(facts As Integer()) As Integer
        If facts.Length > 0 Then
            ' Generate a dictionary to save each number's frequency
            Dim FMap As New Dictionary(Of Integer, Integer)

            ' Go over the array again to count frequencies
            For Each no As Integer In facts
                If FMap.ContainsKey(no) Then
                    FMap(no) += 1
                Else
                    FMap(no) = 1
                End If
            Next

            ' Check the maximum frequency to find the mode or modes
            Dim maxF As Integer = FMap.Values.Max()
            Dim modelist As New List(Of Integer)

            For Each pair In FMap
                If pair.Value = maxF Then
                    modelist.Add(pair.Key)
                End If
            Next

            ' Return the mode or modes
            If modelist.Count = 1 Then
                Return modelist(0)
            Else
                ' If there are several modes, you may want to manage it properly
                ' This example returns the first mode discovered to keep it simple 
                Return modelist(0)
            End If
        Else
            Return 0
        End If
    End Function

    Function Correlation_Coefficient_Answer(a() As Integer, b() As Integer) As Double
        ' Check if the arrays's length are the same
        If a.Length = b.Length AndAlso a.Length > 0 Then
            ' Rank the set of data
            Dim arank() As Integer = Order_Arr(a)
            Dim brank() As Integer = Order_Arr(b)

            ' Compute the gaps between orders
            Dim rankgaps() As Integer = Minus_Arr(arank, brank)

            ' Square the rank gaps 
            Dim rankgapssquared() As Integer = CubicArr(rankgaps)

            ' total of the squared order gaps
            Dim totalofsquaredgaps As Double = rankgapssquared.Sum()

            ' Compute Spearman's rank correlation coefficient
            Dim n As Integer = a.Length
            Dim spearmancc As Double = 1 - ((6 * totalofsquaredgaps) / (n * (n * n - 1)))

            Return spearmancc
        Else
            ' If arrays are empty or not the equivalent length, return a value of 0
            Return 0
        End If
    End Function

    Function Order_Arr(arr() As Integer) As Integer()
        ' To store ranks of data,make an array
        Dim orders(arr.Length - 1) As Integer

        ' To keep the index-value pairs,generate a list
        Dim idxvaluepairs As New List(Of KeyValuePair(Of Integer, Integer))

        'Add index-value pairs to the list
        For itg As Integer = 0 To arr.Length - 1
            idxvaluepairs.Add(New KeyValuePair(Of Integer, Integer)(itg, arr(itg)))
        Next

        ' Sort the list according to the values
        idxvaluepairs.Sort(Function(x, y) x.Value.CompareTo(y.Value))

        ' Assign the ranks to the values sorted
        For itg As Integer = 0 To idxvaluepairs.Count - 1
            orders(idxvaluepairs(itg).Key) = itg + 1
        Next

        Return orders
    End Function

    Function Minus_Arr(arr1() As Integer, arr2() As Integer) As Integer()
        ' Check if the arrays's length are the same
        If arr1.Length = arr2.Length Then
            ' Generate an array to keep gaps
            Dim gaps(arr1.Length - 1) As Integer

            ' Determine the gaps between related numbers
            For itg As Integer = 0 To arr1.Length - 1
                gaps(itg) = arr1(itg) - arr2(itg)
            Next

            Return gaps
        Else
            ' if arrays are differ in length, return the blank array 
            Return {}
        End If
    End Function

    Function CubicArr(arr() As Integer) As Integer()
        ' Generate an array for storing squared values
        Dim squaredvlus(arr.Length - 1) As Integer

        ' Find the square of every number
        For itg As Integer = 0 To arr.Length - 1
            squaredvlus(itg) = arr(itg) * arr(itg)
        Next

        Return squaredvlus
    End Function

    Sub correlationDescription(cc As Double)
        ' Describe the direction and strength of the correlation
        Dim direction As String = ""
        Dim strength As String = ""

        ' Show off the interpretation of the correlation
        outcome = "Correlation coefficient of " + Convert.ToString(Math.Round(ccoutcome, dcmp)) + vbNewLine
        If cc > 0 Then
            direction = " positive"
        ElseIf cc < 0 Then
            direction = " negative"
        Else
            direction = ""
        End If
        If Math.Abs(cc) >= 0.8 Then
            strength = "strong"
        ElseIf Math.Abs(cc) >= 0.5 Then
            strength = "medium"
        ElseIf Math.Abs(cc) >= 0.3 Then
            strength = "low"
        Else
            strength = "very low"
        End If

        ' Interpretation of the correlation according to the standard rules
        If Math.Abs(cc) >= 0.8 Then
            outcome += "This is a " + strength + direction + ",very strong correlation."
        ElseIf Math.Abs(cc) >= 0.5 Then
            outcome += "This is a medium correlation."
        ElseIf Math.Abs(cc) >= 0.3 Then
            outcome += "This is a low correlation."
        Else
            outcome += "This is a very low or no correlation."
        End If

        If cc > 0 Then
            outcome += " As the value of X rises so does the value of Y."
        ElseIf cc < 0 Then
            outcome += " As the value of X rises but declines the value of Y."
        End If
        txtsolution.Text = outcome
    End Sub

    Private Sub chkimport_CheckedChanged(sender As Object, e As EventArgs) Handles chkimport.CheckedChanged
        If chkimport.Checked Then
            txtimport.Enabled = True
            btnaccess.Enabled = True
        Else
            txtimport.Enabled = False
            btnaccess.Enabled = False
        End If
    End Sub

    Private Sub btnupload_Click(sender As Object, e As EventArgs) Handles btnupload.Click
        Dim ofd As OpenFileDialog = New OpenFileDialog()

        ofd.Title = "Please Choose a File for Analysis"
        ofd.InitialDirectory = "D:\"
        ofd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*"
        ofd.FilterIndex = 2
        ofd.RestoreDirectory = True

        If ofd.ShowDialog() = DialogResult.OK Then
            strFile = ofd.FileName
            txtupload.Text = strFile
            btncarry.Enabled = True
        End If
    End Sub

    Private Sub btncarry_Click(sender As Object, e As EventArgs) Handles btncarry.Click

        If txtupload.Text = "" Then
            MsgBox("Please Choose a Text File!")
            Exit Sub
        End If

        Dim objectReader As New System.IO.StreamReader(strFile)

        strvalue = objectReader.ReadToEnd
        txtimport.Text = strvalue
        'MsgBox("Select Mean, Median, Mode or Correlation Coefficient to evaluate the data.")
        btncarry.Enabled = False
        btndetermine.Enabled = True
        objectReader.Close()
        txtsolution.Text = "Carried data successfully for determining ... "
    End Sub

    Private Sub btnaccess_Click(sender As Object, e As EventArgs) Handles btnaccess.Click
        If txtimport.Text = "" Then
            MsgBox("Please import Data in Text Box!")
            Exit Sub
        End If
        strvalue = txtimport.Text
        'MsgBox("Select Mean, Median, Mode or Correlation Coefficient to evaluate the data.")
        btnaccess.Enabled = False
        chkimport.Checked = False
        txtimport.Enabled = False
        btndetermine.Enabled = True
        txtsolution.Text = "Carried data successfully for determining ... "
    End Sub

    Private Sub btndetermine_Click(sender As Object, e As EventArgs) Handles btndetermine.Click
        If chkMean.Checked = False And chkMedian.Checked = False And chkMode.Checked = False And chkCC.Checked = False Then
            MsgBox("Please select Mean, Median, Mode, or Correlation Coefficient!")
            Exit Sub
        End If
        outcome = ""
        'Collection of data for determining mean, median and mode
        Dim dataarr As String() = strvalue.Split(" "c)

        Dim DataInt(dataarr.Length) As Integer

        For itg As Integer = 0 To dataarr.Length - 1
            If Not (IsNumeric(dataarr(itg))) Then
                MsgBox("Please input only Integer values, separated by space: e.g.,.8 1 3 2 7")
                Exit Sub
            Else
                DataInt(itg) = Convert.ToInt32(dataarr(itg))
            End If
        Next

        dcmp = Convert.ToInt32(cboDecimalPlace.Text)

        If chkMean.Checked Then
            'Call Mean_Answer Function
            outcome += "**************************" + vbNewLine + "Mean: " + Convert.ToString(Math.Round(Mean_Answer(DataInt), dcmp)) + vbNewLine
        End If

        If chkMedian.Checked Then
            'Call Median_Answer Function
            outcome += "**************************" + vbNewLine + "Median: " + Convert.ToString(Math.Round(Median_Answer(DataInt), dcmp)) + vbNewLine
        End If

        If chkMode.Checked Then
            'Call Mode_Answer Function
            outcome += "**************************" + vbNewLine + "Mode: " + Convert.ToString(Math.Round(Mode_Answer(DataInt), dcmp)) + vbNewLine
        End If

        If chkCC.Checked Then
            'Data set for determining correlation coefficient
            Dim dataarr2 As String() = txtreport.Text.Split(" "c)

            Dim DataInt2(dataarr.Length) As Integer

            For itg As Integer = 0 To dataarr2.Length - 1
                If Not (IsNumeric(dataarr2(itg))) Then
                    MsgBox("Please input integer values, separating by space: e.g.,. 3 7 9 2 8 in required text box ")
                    Exit Sub
                Else
                    DataInt2(itg) = Convert.ToInt32(dataarr2(itg))
                End If
            Next

            'Call Correlation_Coefficient_Answer Function
            cc = True
            ccoutcome = Correlation_Coefficient_Answer(DataInt, DataInt2)
            outcome += "**************************" + vbNewLine + "Correlation Coefficient: " + Convert.ToString(Math.Round(ccoutcome, dcmp)) + vbNewLine
        End If

        'Display final outcome
        txtsolution.Text = outcome


    End Sub

    Private Sub chkCC_CheckedChanged(sender As Object, e As EventArgs) Handles chkCC.CheckedChanged
        If chkCC.Checked = True Then
            btnreport.Enabled = True
            txtreport.Enabled = True
        Else
            btnreport.Enabled = False
            txtreport.Enabled = False
        End If
    End Sub

    Private Sub btnreport_Click(sender As Object, e As EventArgs) Handles btnreport.Click
        If cc Then 'Identify if correlation coefficient is calculated or not
            correlationDescription(ccoutcome)
        Else
            MsgBox("Please calculate correlation coefficient first to see the report of answer")
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
