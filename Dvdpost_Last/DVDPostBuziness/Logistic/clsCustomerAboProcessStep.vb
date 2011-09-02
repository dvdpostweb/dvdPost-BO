Public Class clsCustomerAboProcessStep
    Public customers_id As Integer
    Public Norm As clsProductTypeAboprocessStep
    Public Adult As clsProductTypeAboprocessStep
    Public stat As DvdPostData.Customer_stat

    Public Sub New(ByVal Pcustomers_id As Integer, ByVal sleep As Boolean)

        customers_id = Pcustomers_id
        Norm = New clsProductTypeAboprocessStep()
        Adult = New clsProductTypeAboprocessStep()
        stat = New DvdPostData.Customer_stat(Pcustomers_id, sleep)
    End Sub
End Class
