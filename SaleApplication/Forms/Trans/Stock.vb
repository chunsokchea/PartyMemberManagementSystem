Public Module Stock

    Public Sub Update(ByVal StoreId As Int16, ByVal ProductId As Int16, ByVal Qty As Decimal)

        Dim sql = <sql>
IF NOT EXISTS(SELECT * FROM Stock WHERE ProductId=@ProductId AND StoreId=@StoreId AND Active=1) 
    INSERT INTO Stock VALUES(@ProductId,@StoreId,@Qty,1);
ELSE 
    UPDATE Stock SET Qty=Qty+@Qty WHERE ProductId=@ProductId AND StoreId=@StoreId;
                  </sql>.Value

        Cmd.Parameters("@StoreId") = StoreId
        Cmd.Parameters("@ProductId") = ProductId
        Cmd.Parameters("@Qty") = Qty
        Cmd.ExecuteNonQuery(sql)
    End Sub
End Module
