Public Class ToDoFuKenPicker
    Private TDFKBox As System.Windows.Forms.ComboBox
    Private TDFKList As System.Windows.Forms.ListBox
    Private WithEvents AddButton As System.Windows.Forms.Button
    Private WithEvents DeleteButton As System.Windows.Forms.Button

    Dim TDFK() As String = {
        "北海道", "青森", "岩手", "宮城", "秋田", "山形", "福島",
        "茨城", "栃木", "群馬", "埼玉", "千葉", "東京", "神奈川",
        "新潟", "富山", "石川", "福井", "山梨", "長野", "岐阜", "静岡", "愛知",
        "三重", "滋賀", "京都", "大阪", "兵庫", "奈良", "和歌山",
        "鳥取", "島根", "岡山", "広島", "山口",
        "徳島", "香川", "愛媛", "高知",
        "福岡", "佐賀", "長崎", "熊本", "大分", "宮崎", "鹿児島", "沖縄"
    }


    'フォームのLoadイベントハンドラ
    Private Sub ToDoFuKenPicker_Load(ByVal sender As Object, _
            ByVal e As EventArgs) Handles MyBase.Load

        'フォーム
        With Me
            .Name = "ToDoFuKenPicker"
            .Width = 500
            .Height = 300
        End With

        'インスタンス生成
        TDFKBox = New System.Windows.Forms.ComboBox()
        TDFKList = New System.Windows.Forms.ListBox()
        AddButton = New System.Windows.Forms.Button()
        DeleteButton = New System.Windows.Forms.Button()


        'プロパティ設定
        TDFKBox.Name = "TDFKBox"
        TDFKList.Name = "TDFKList"
        TDFKList.SelectionMode = SelectionMode.MultiSimple
        AddButton.Name = "AddButton"
        DeleteButton.Name = "DeleteButton"

        'サイズ・位置設定
        TDFKBox.Location = New Point(10, 10)
        TDFKBox.Size = New System.Drawing.Size(200, 50)
        TDFKList.Location = New Point(10, 110)
        TDFKList.Size = New System.Drawing.Size(200, 50)
        AddButton.Location = New Point(10, 50)
        AddButton.Size = New System.Drawing.Size(200, 50)
        DeleteButton.Location = New Point(220, 110)
        DeleteButton.Size = New System.Drawing.Size(100, 50)

        'プルダウン　データ設定
        For i As Integer = 0 To TDFK.Length - 1
            If i = 0 Then
                TDFKBox.Items.Add("（指定しない）")
                TDFKBox.Items.Add("■北海道・東北地方")
            ElseIf i = 7 Then
                TDFKBox.Items.Add("■関東地方")
            ElseIf i = 14 Then
                TDFKBox.Items.Add("■中部地方")
            ElseIf i = 23 Then
                TDFKBox.Items.Add("■近畿地方")
            ElseIf i = 30 Then
                TDFKBox.Items.Add("■中国地方")
            ElseIf i = 35 Then
                TDFKBox.Items.Add("■四国地方")
            ElseIf i = 39 Then
                TDFKBox.Items.Add("■九州・沖縄地方")
            End If
            TDFKBox.Items.Add("　－" & TDFK(i))
        Next

        'ボタン名設定
        AddButton.Text = "↓追加"
        DeleteButton.Text = "削除"

        'フォームに追加
        Controls.Add(TDFKBox)
        Controls.Add(TDFKList)
        Controls.Add(AddButton)
        Controls.Add(DeleteButton)

    End Sub

    Private Sub AddButton_Click(ByVal sender As Object, _
            ByVal e As EventArgs) Handles AddButton.Click
        Dim key As Integer = TDFKBox.SelectedIndex

        'MessageBox.Show(key, "Selected Index")

        If 1 <= key And key <= 8 Then
            If key = 1 Then
                For i As Integer = 0 To 6
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 2))
            End If
        ElseIf 9 <= key And key <= 16 Then
            If key = 9 Then
                For i As Integer = 7 To 13
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 3))
            End If
        ElseIf 17 <= key And key <= 26 Then
            If key = 17 Then
                For i As Integer = 14 To 22
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 4))
            End If
        ElseIf 27 <= key And key <= 34 Then
            If key = 27 Then
                For i As Integer = 23 To 29
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 5))
            End If
        ElseIf 35 <= key And key <= 40 Then
            If key = 35 Then
                For i As Integer = 30 To 34
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 6))
            End If
        ElseIf 41 <= key And key <= 45 Then
            If key = 41 Then
                For i As Integer = 35 To 38
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 7))
            End If
        ElseIf 46 <= key And key <= 54 Then
            If key = 46 Then
                For i As Integer = 39 To 46
                    TDFKList.Items.Add(TDFK(i))
                Next
            Else
                TDFKList.Items.Add(TDFK(key - 8))
            End If
        End If
    End Sub

    Private Sub DeleteButton_Click(ByVal sender As Object, _
        ByVal e As EventArgs) Handles DeleteButton.Click
        For i As Integer = TDFKList.SelectedIndices.Count - 1 To 0 Step -1
            TDFKList.Items.RemoveAt(TDFKList.SelectedIndices(i))
        Next
    End Sub
End Class
