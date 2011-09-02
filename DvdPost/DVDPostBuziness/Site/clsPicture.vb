Public Class clsPicture
    Const MappingDiskPicture As String = "x:\"
    Const MappingDiskPictureTest As String = "d:\temp\"

    Enum TypePicture
        logo
        wallpaper
        banner_page
        banner_menu
        title_page
        landings
        thumbs
        surveys
        survey_detail
        home_page
    End Enum

    Public Shared Function GetExtension(ByVal tp As TypePicture) As String


        Select Case tp
            Case TypePicture.logo, TypePicture.banner_menu, TypePicture.thumbs, TypePicture.surveys
                Return ".gif"

            Case Else
                Return ".jpg"

        End Select

    End Function
    Public Shared Function getPathServerMapping() As String
        If DvdPostData.clsSession.isEnvTest Then
            Return MappingDiskPictureTest
        Else
            Return MappingDiskPicture
        End If


    End Function

    Public Shared Function getPathServer(Optional ByVal type_dvd As DvdPostData.clsProductDvd.Type_DVD = DvdPostData.clsProductDvd.Type_DVD.DVD_NORM) As String
        Dim sql As String
        Dim path As String

        sql = DvdPostData.clsPicture.getPathServer()
        path = DvdPostData.clsConnection.ExecuteScalar(sql)

        If DvdPostData.clsSession.isEnvTest Then
            Return MappingDiskPictureTest
        Else
       
            If type_dvd = DvdPostData.clsProductDvd.Type_DVD.DVD_NORM Then
                Return "\\" & path & "\images\"
            Else
                Return "\\" & path & "\imagesx\"
            End If

        End If

    End Function

    Public Shared Function ConvertStringToEnum(ByVal str As String) As TypePicture
        Dim tp_picture As TypePicture
        If [Enum].IsDefined(GetType(TypePicture), str) Then
            tp_picture = (CType([Enum].Parse(GetType(TypePicture), str, True), TypePicture))
            Return tp_picture
        End If
        Return Nothing
    End Function


End Class
