Public Module App
    Public UserName As String
    Public UserFullName As String
    Public AuthorizedPermissions As New DataTable

    Public Function IsAuthorized(ByVal permission As Permissions) As Boolean
        For Each row In AuthorizedPermissions.Rows
            If row(0) = permission Then
                Return True
            End If
        Next
        Return False
    End Function

End Module

'WITH TMP(LEVEL,PermissionId,PermissionName)
'As
'(
'  SELECT 1 AS LEVEL,
'         PermissionId,
'         CAST(PermissionName AS NVARCHAR(MAX)) AS PermissionName
'    FROM system.Permission e
'    WHERE  ParentId=0  
'  UNION ALL 
'  SELECT t.LEVEL+1,e.PermissionId,t.PermissionName+'_'+e.PermissionName
'  FROM system.Permission e
'    INNER JOIN TMP t ON e.ParentId=t.PermissionId
'  WHERE t.LEVEL<100 -- avoid infinite.
')
'SELECT PermissionName+'='+CONVERT(NVARCHAR,PermissionId)+','
'FROM TMP
'ORDER BY PermissionName;

Public Enum Permissions
    Manage = 2
    Manage_Village = 21
    Manage_Village_Add = 23
    Manage_Village_View = 22
    Manage_village_Edit = 24
    Manage_Village_Delete = 25

    'Manage_Category = 21
    'Manage_Category_Add = 23
    'Manage_Category_Delete = 25
    'Manage_Category_Edit = 24
    'Manage_Category_View = 22

    Manage_Group = 5
    Manage_Group_Add = 7
    Manage_Group_View = 6
    Manage_Group_Edit = 8
    Manage_Group_Delete = 10

    'Manage_Customer = 5
    'Manage_Customer_Add = 7
    'Manage_Customer_Delete = 10
    'Manage_Customer_Edit = 8
    'Manage_Customer_View = 6

    Manage_Role = 16
    Manage_Role_add = 18
    Manage_Role_View = 17
    Manage_Role_Edit = 19
    Manage_Role_Delete = 20

    'Manage_Product = 16
    'Manage_Product_Add = 18
    'Manage_Product_Delete = 20
    'Manage_Product_Edit = 19
    'Manage_Product_View = 17    

    'Manage_Store = 31
    'Manage_Store_Add = 33
    'Manage_Store_Delete = 35
    'Manage_Store_Edit = 34
    'Manage_Store_View = 32

    'Manage_Type = 26
    'Manage_Type_Add = 28
    'Manage_Type_Delete = 30
    'Manage_Type_Edit = 29
    'Manage_Type_View = 27
    'Manage_Vendor = 11
    'Manage_Vendor_Add = 13
    'Manage_Vendor_Delete = 15
    'Manage_Vendor_Edit = 14
    'Manage_Vendor_View = 12
    Report = 4
    Security = 3
    Security_Role = 58
    Security_Role_Add = 60
    Security_Role_Delete = 62
    Security_Role_Edit = 61
    Security_Role_View = 59
    Security_User = 53
    Security_User_Add = 55
    Security_User_Delete = 57
    Security_User_Edit = 56
    Security_User_View = 54

    List = 37
    List_Member = 38
    List_Member_add = 40
    List_Member_view = 39
    List_Member_Edit = 41
    List_Member_Delete = 42

    'Trans = 37
    'Trans_Invoice = 38
    'Trans_Invoice_Add = 40
    'Trans_Invoice_Delete = 42
    'Trans_Invoice_Edit = 41
    'Trans_Invoice_View = 39
    'Trans_Purchase = 43
    'Trans_Purchase_Add = 45
    'Trans_Purchase_Delete = 47
    'Trans_Purchase_Edit = 46
    'Trans_Purchase_View = 44
    'Trans_Transfer = 48
    'Trans_Transfer_Add = 50
    'Trans_Transfer_Delete = 52
    'Trans_Transfer_Edit = 51
    'Trans_Transfer_View = 49
End Enum
