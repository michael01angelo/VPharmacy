Friend Module layer

    Friend currentUser As New user
    Friend currentUserType As New usertype

    Friend dgvHeaderStyle As New DataGridViewCellStyle
    Friend dgvLeftStyle As New DataGridViewCellStyle
    Friend dgvRightStyle As New DataGridViewCellStyle

    Friend csbConnStr As New MySqlConnectionStringBuilder
    Private conn As New MySqlConnection()
    Private sqlTrans As MySqlTransaction
    Friend query As New trace

    Friend Structure company
        Friend name As String
        Friend address As String
        Friend numbers As String
    End Structure

    Friend Structure trace
        Friend err As Boolean
        Friend count As Integer
        Friend message As String
    End Structure

    Friend Structure adjustment
        Friend id As Integer
        Friend code As String
        Friend productID As Integer
        Friend type As String
        Friend variance As Integer
        Friend remarks As String
        Friend eventdate As Date
    End Structure
    Friend Structure category
        Friend id As Integer
        Friend name As String
    End Structure
    Friend Structure discount
        Friend id As Integer
        Friend value As Decimal
        Friend description As String
    End Structure
    Friend Structure expiry
        Friend id As Integer
        Friend productID As Integer
        Friend batch As String
        Friend expdate As Date
    End Structure
    Friend Structure product
        Friend id As Integer
        Friend code As String
        Friend name As String
        Friend subcategory As String
        Friend generic As String
        Friend unitID As Integer
        Friend discountable As Boolean
        Friend vatable As Boolean
        Friend price As Decimal
        Friend markup As Decimal
        Friend rop As Integer
        Friend stock As Integer
    End Structure
    Friend Structure purchasedproduct
        Friend id As Integer
        Friend code As String
        Friend eventdate As Date
        Friend supplierID As Integer
        Friend productID As Integer
        Friend quantity As String
    End Structure
    Friend Structure receipt
        Friend id As Integer
        Friend code As String
        Friend datetime As Date
        Friend cashierID As Integer
        Friend discountID As Integer
        Friend amountdue As Decimal
        Friend cash As Decimal
        Friend void As Boolean
    End Structure
    Friend Structure receiptnumber
        Friend startCode As String
        Friend endCode As String
    End Structure
    Friend Structure receivedproduct
        Friend id As Integer
        Friend code As String
        Friend eventdate As Date
        Friend supplierID As Integer
        Friend productID As Integer
        Friend quantity As Integer
        Friend price As Decimal
    End Structure
    Friend Structure returnedproduct
        Friend id As Integer
        Friend eventdate As Date
        Friend supplierID As Integer
        Friend productID As Integer
        Friend quantity As Integer
        Friend remarks As String
    End Structure
    Friend Structure subcategory
        Friend id As Integer
        Friend categoryID As Integer
        Friend name As String
        Friend markup As Decimal
    End Structure
    Friend Structure supplier
        Friend id As Integer
        Friend code As String
        Friend name As String
        Friend address As String
        Friend telephone As String
        Friend fax As String
        Friend person As String
        Friend number As String
    End Structure
    Friend Structure trail
        Friend id As Integer
        Friend session As String
        Friend userID As Integer
        Friend action As String
    End Structure
    Friend Structure transaction
        Friend id As Integer
        Friend receiptID As Integer
        Friend productID As Integer
        Friend price As Decimal
        Friend quantity As Integer
    End Structure
    Friend Structure unit
        Friend id As Integer
        Friend name As String
    End Structure
    Friend Structure user
        Friend id As Integer
        Friend name As String
        Friend typeID As Integer
        Friend hint As String
        Friend surname As String
        Friend givenname As String
        Friend address As String
    End Structure
    Friend Structure usertype
        Friend id As Integer
        Friend name As String
        Friend fm As String
        Friend tn As String
        Friend rp As String
        Friend sc As String
    End Structure

    Friend Sub getCompanyDetails()
        Dim company As New company
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [name], [address], [numbers] FROM [company]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With company
                    .name = reader("name").ToString
                    .address = reader("address").ToString
                    .numbers = reader("numbers").ToString
                End With
            End While
        End If
        reader.Close()
        With My.Settings
            .CompanyName = company.name
            .CompanyAddress = company.address
            .CompanyNumbers = company.numbers
            .Save()
        End With
    End Sub

    Friend Function getMaxCode(table As String) As Integer
        Dim maxValue As Integer = 0
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT MAX([code]) AS [max] FROM [" + table + "]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                If Not reader("max").ToString.Equals(String.Empty) Then
                    maxValue = CInt(reader("max").ToString)
                End If
            End While
        End If
        reader.Close()
        Return maxValue
    End Function

    Friend Function getAdjustments() As List(Of adjustment)
        Dim lstAdjustments As New List(Of adjustment)
        Dim adjustment As New adjustment
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [product], [type], [variance], [remarks], [date] FROM [adjustments]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With adjustment
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .productID = reader("product").ToString
                    .type = reader("type").ToString
                    .variance = reader("variance").ToString
                    .remarks = reader("remarks").ToString
                    .eventdate = reader("date").ToString
                End With
                lstAdjustments.Add(adjustment)
            End While
        End If
        reader.Close()
        Return lstAdjustments
    End Function

    Friend Function getCategories() As List(Of category)
        Dim lstCategories As New List(Of category)
        Dim category As New category
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [name] FROM [categories]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With category
                    .id = reader("id").ToString
                    .name = reader("name").ToString
                End With
                lstCategories.Add(category)
            End While
        End If
        reader.Close()
        Return lstCategories
    End Function

    Friend Function getDiscounts() As List(Of discount)
        Dim lstDiscounts As New List(Of discount)
        Dim discount As New discount
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [value], [description] FROM [discounts]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With discount
                    .id = reader("id").ToString
                    .value = reader("value").ToString
                    .description = reader("description").ToString
                End With
                lstDiscounts.Add(discount)
            End While
        End If
        reader.Close()
        Return lstDiscounts
    End Function

    Friend Function getExpiry(id As Integer) As expiry
        Dim expiry As New expiry
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [product], [batch], [date] FROM [expiry]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With expiry
                    .id = reader("id").ToString
                    .productID = reader("product").ToString
                    .batch = reader("batch").ToString
                    .expdate = reader("date").ToString
                End With
            End While
        End If
        reader.Close()
        Return expiry
    End Function

    Friend Function getExpiries() As List(Of expiry)
        Dim lstExpiries As New List(Of expiry)
        Dim expiry As New expiry
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [product], [batch], [date] FROM [expiry]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With expiry
                    .id = reader("id").ToString
                    .productID = reader("product").ToString
                    .batch = reader("batch").ToString
                    .expdate = reader("date").ToString
                End With
                lstExpiries.Add(expiry)
            End While
        End If
        reader.Close()
        Return lstExpiries
    End Function

    Friend Function getProduct(Optional id As Integer = 0, Optional code As String = "", Optional name As String = "") As product
        Dim product As New product
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            If id <> 0 Then
                .CommandText = "SELECT [id], [code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock] FROM [products] WHERE [id]=@id"
                .Parameters.AddWithValue("@id", id)
            End If
            If name <> String.Empty Then
                .CommandText = "SELECT [id], [code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock] FROM [products] WHERE [id]=@name"
                .Parameters.AddWithValue("@name", name)
            End If
            If code <> String.Empty Then
                .CommandText = "SELECT [id], [code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock] FROM [products] WHERE [code]=@code"
                .Parameters.AddWithValue("@code", code)
            End If
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With product
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .name = reader("name").ToString
                    .subcategory = reader("subcategory").ToString
                    .generic = reader("generic").ToString
                    .unitID = reader("unit").ToString
                    If reader("discountable").ToString = "yes" Then
                        .discountable = True
                    Else
                        .discountable = False
                    End If
                    If reader("vatable").ToString = "yes" Then
                        .vatable = True
                    Else
                        .vatable = False
                    End If
                    .price = reader("price").ToString
                    .markup = reader("markup").ToString
                    .rop = reader("rop").ToString
                    .stock = reader("stock").ToString
                End With
            End While
        End If
        reader.Close()
        Return product
    End Function

    Friend Function getProducts() As List(Of product)
        Dim lstProducts As New List(Of product)
        Dim product As New product
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock] FROM [products]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With product
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .name = reader("name").ToString
                    .subcategory = reader("subcategory").ToString
                    .generic = reader("generic").ToString
                    .unitID = reader("unit").ToString
                    If reader("discountable").ToString = "yes" Then
                        .discountable = True
                    Else
                        .discountable = False
                    End If
                    If reader("vatable").ToString = "yes" Then
                        .vatable = True
                    Else
                        .vatable = False
                    End If
                    .price = reader("price").ToString
                    .markup = reader("markup").ToString
                    .rop = reader("rop").ToString
                    .stock = reader("stock").ToString
                End With
                lstProducts.Add(product)
            End While
        End If
        reader.Close()
        Return lstProducts
    End Function

    Friend Function getProductsByCategory(category As category, subcategory As subcategory) As List(Of product)
        Dim lstProducts As New List(Of product)
        Dim product As New product
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            If category.id = 0 And subcategory.id = 0 Then
                .CommandText = "SELECT [id], [code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock] FROM [products]"
            Else
                If subcategory.id = 0 Then
                    .CommandText = "SELECT * FROM [products] JOIN [subcategories] ON [subcategories].[id]=[products].[subcategory] WHERE [subcategories].[category]=@category"
                    .Parameters.AddWithValue("@category", category.id)
                Else
                    .CommandText = "SELECT [id], [code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock] FROM [products] WHERE [subcategory]=@subcategory"
                    .Parameters.AddWithValue("@subcategory", subcategory.id)
                End If
            End If
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With product
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .name = reader("name").ToString
                    .subcategory = reader("subcategory").ToString
                    .generic = reader("generic").ToString
                    .unitID = reader("unit").ToString
                    If reader("discountable").ToString = "yes" Then
                        .discountable = True
                    Else
                        .discountable = False
                    End If
                    If reader("vatable").ToString = "yes" Then
                        .vatable = True
                    Else
                        .vatable = False
                    End If
                    .price = reader("price").ToString
                    .markup = reader("markup").ToString
                    .rop = reader("rop").ToString
                    .stock = reader("stock").ToString
                End With
                lstProducts.Add(product)
            End While
        End If
        reader.Close()
        Return lstProducts
    End Function

    Friend Function getPurchaseOrders() As List(Of purchasedproduct)
        Dim lstPurchasedProducts As New List(Of purchasedproduct)
        Dim purchasedproduct As New purchasedproduct
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [date], [supplier] FROM [purchasedproducts] GROUP BY [code]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With purchasedproduct
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .eventdate = reader("date").ToString
                    .supplierID = reader("supplier").ToString
                End With
                lstPurchasedProducts.Add(purchasedproduct)
            End While
        End If
        reader.Close()
        Return lstPurchasedProducts
    End Function

    Friend Function getPurchasedProducts(code As String) As List(Of purchasedproduct)
        Dim lstPurchasedProducts As New List(Of purchasedproduct)
        Dim purchasedproduct As New purchasedproduct
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [date], [supplier], [product], [quantity] FROM [purchasedproducts] WHERE [code]=@code"
            .Parameters.AddWithValue("@code", code)
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With purchasedproduct
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .eventdate = reader("date").ToString
                    .supplierID = reader("supplier").ToString
                    .productID = reader("product").ToString
                    .quantity = reader("quantity").ToString
                End With
                lstPurchasedProducts.Add(purchasedproduct)
            End While
        End If
        reader.Close()
        Return lstPurchasedProducts
    End Function

    Friend Function getReceipt(Optional id As Integer = 0, Optional code As String = "") As receipt
        Dim receipt As New receipt
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            If id <> 0 Then
                .CommandText = "SELECT [id], [code], [datetime], [cashier], [discount], [amountdue], [cash], [void] FROM [receipts] WHERE [id]=@id"
                .Parameters.AddWithValue("@id", id)
            End If
            If code <> String.Empty Then
                .CommandText = "SELECT [id], [code], [datetime], [cashier], [discount], [amountdue], [cash], [void] FROM [receipts] WHERE [code]=@code"
                .Parameters.AddWithValue("@code", code)
            End If
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With receipt
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .datetime = CDate(reader("datetime").ToString)
                    .cashierID = reader("cashier").ToString
                    .discountID = reader("discount").ToString
                    .amountdue = CDec(reader("amountdue").ToString)
                    .cash = CDec(reader("cash").ToString)
                    If reader("void").ToString.Equals("yes") Then
                        .void = True
                    Else
                        .void = False
                    End If
                End With
            End While
        End If
        reader.Close()
        Return receipt
    End Function

    Friend Function getReceipts(startDate As Date, endDate As Date) As List(Of receipt)
        Dim lstReceipts As New List(Of receipt)
        Dim receipt As New receipt
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [datetime], [cashier], [discount], [amountdue], [cash], [void] FROM [receipts] WHERE [datetime]>@startDate AND [datetime]<@endDate"
            With .Parameters
                .AddWithValue("@startDate", startDate)
                .AddWithValue("@endDate", endDate)
            End With
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With receipt
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .datetime = CDate(reader("datetime").ToString)
                    .cashierID = reader("cashier").ToString
                    .discountID = reader("discount").ToString
                    .amountdue = CDec(reader("amountdue").ToString)
                    .cash = CDec(reader("cash").ToString)
                    If reader("void").ToString.Equals("yes") Then
                        .void = True
                    Else
                        .void = False
                    End If
                End With
                lstReceipts.Add(receipt)
            End While
        End If
        reader.Close()
        Return lstReceipts
    End Function

    Friend Function getReceiptCode() As receiptnumber
        Dim receiptnumber As New receiptnumber
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [start], [end] FROM [receiptnumber]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With receiptnumber
                    .startCode = reader("start").ToString
                    .endCode = reader("end").ToString
                End With
            End While
        End If
        reader.Close()
        Return receiptnumber
    End Function

    Friend Function getReceivedProducts(code As String) As List(Of receivedproduct)
        Dim lstReceivedProducts As New List(Of receivedproduct)
        Dim receivedproduct As New receivedproduct
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [date], [supplier], [product], [quantity], [price] FROM [receivedproducts] WHERE [code]=@code"
            .Parameters.AddWithValue("@code", code)
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With receivedproduct
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .eventdate = reader("date").ToString
                    .supplierID = reader("supplier").ToString
                    .productID = reader("product").ToString
                    .quantity = reader("quantity").ToString
                    .price = reader("price").ToString
                End With
                lstReceivedProducts.Add(receivedproduct)
            End While
        End If
        reader.Close()
        Return lstReceivedProducts
    End Function

    Friend Function getReturnedProducts(supplier As supplier, eventdate As Date) As List(Of returnedproduct)
        Dim lstReturnedProducts As New List(Of returnedproduct)
        Dim returnedproduct As New returnedproduct
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [date], [supplier], [product], [quantity], [remarks] FROM [returnedproducts] WHERE [supplier]=@supplier AND [date]=@date"
            With .Parameters
                .AddWithValue("@supplier", supplier.id)
                .AddWithValue("@date", eventdate.ToString("yyyy-MM-dd"))
            End With
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With returnedproduct
                    .id = reader("id").ToString
                    .eventdate = reader("date").ToString
                    .supplierID = reader("supplier").ToString
                    .productID = reader("product").ToString
                    .quantity = reader("quantity").ToString
                    .remarks = reader("remarks").ToString
                End With
                lstReturnedProducts.Add(returnedproduct)
            End While
        End If
        reader.Close()
        Return lstReturnedProducts
    End Function

    Friend Function getSubCategories(category As category) As List(Of subcategory)
        Dim lstSubCategories As New List(Of subcategory)
        Dim subcategory As New subcategory
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [category], [name], [markup] FROM [subcategories] WHERE [category]=@categoryID"
            .Parameters.AddWithValue("@categoryID", category.id)
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With subcategory
                    .id = reader("id").ToString
                    .categoryID = reader("category").ToString
                    .name = reader("name").ToString
                    .markup = reader("markup").ToString
                End With
                lstSubCategories.Add(subcategory)
            End While
        End If
        reader.Close()
        Return lstSubCategories
    End Function

    Friend Function getSuppliers() As List(Of supplier)
        Dim lstSuppliers As New List(Of supplier)
        Dim supplier As New supplier
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [code], [name], [address], [telephone], [fax], [person], [number] FROM [suppliers]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With supplier
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .name = reader("name").ToString
                    .address = reader("address").ToString
                    .telephone = reader("telephone").ToString
                    .fax = reader("fax").ToString
                    .person = reader("person").ToString
                    .number = reader("number").ToString
                End With
                lstSuppliers.Add(supplier)
            End While
        End If
        reader.Close()
        Return lstSuppliers
    End Function

    Friend Function getSupplier(Optional id As Integer = 0, Optional name As String = "", Optional code As String = "") As supplier
        Dim supplier As New supplier
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            If id <> 0 Then
                .CommandText = "SELECT [id], [code], [name], [address], [telephone], [fax], [person], [number] FROM [suppliers] WHERE [id]=@id"
                .Parameters.AddWithValue("@id", id)
            End If
            If name <> String.Empty Then
                .CommandText = "SELECT [id], [code], [name], [address], [telephone], [fax], [person], [number] FROM [suppliers] WHERE [name]=@name"
                .Parameters.AddWithValue("@name", name)
            End If
            If code <> String.Empty Then
                .CommandText = "SELECT [id], [code], [name], [address], [telephone], [fax], [person], [number] FROM [suppliers] WHERE [code]=@code"
                .Parameters.AddWithValue("@code", code)
            End If
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With supplier
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .name = reader("name").ToString
                    .address = reader("address").ToString
                    .telephone = reader("telephone").ToString
                    .fax = reader("fax").ToString
                    .person = reader("person").ToString
                    .number = reader("number").ToString
                End With
            End While
        End If
        reader.Close()
        Return supplier
    End Function

    Friend Function getSuppliersProducts(supplier As supplier) As List(Of product)
        Dim lstProducts As New List(Of product)
        Dim product As New product
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT * FROM [products] JOIN [suppliersproducts] ON [suppliersproducts].[product]=[products].[id] WHERE [suppliersproducts].[supplier]=@supplier"
            .Parameters.AddWithValue("@supplier", supplier.id)
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With product
                    .id = reader("id").ToString
                    .code = reader("code").ToString
                    .name = reader("name").ToString
                    .subcategory = reader("subcategory").ToString
                    .generic = reader("generic").ToString
                    .unitID = reader("unit").ToString
                    If reader("discountable").ToString = "yes" Then
                        .discountable = True
                    Else
                        .discountable = False
                    End If
                    If reader("vatable").ToString = "yes" Then
                        .vatable = True
                    Else
                        .vatable = False
                    End If
                    .price = reader("price").ToString
                    .markup = reader("markup").ToString
                    .rop = reader("rop").ToString
                    .stock = reader("stock").ToString
                End With
                lstProducts.Add(product)
            End While
        End If
        reader.Close()
        Return lstProducts
    End Function

    Friend Function getUnits() As List(Of unit)
        Dim lstUnits As New List(Of unit)
        Dim unit As New unit
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [name] FROM [units]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With unit
                    .id = reader("id").ToString
                    .name = reader("name").ToString
                End With
                lstUnits.Add(unit)
            End While
        End If
        reader.Close()
        Return lstUnits
    End Function

    Friend Function getUsers() As List(Of user)
        Dim lstUsers As New List(Of user)
        Dim user As New user
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [name], [type], [hint], [surname], [givenname] FROM [users]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With user
                    .id = reader("id").ToString
                    .name = reader("name").ToString
                    .typeID = reader("type").ToString
                    .hint = reader("hint").ToString
                    .surname = reader("surname").ToString
                    .givenname = reader("givenname").ToString
                End With
                lstUsers.Add(user)
            End While
        End If
        reader.Close()
        Return lstUsers
    End Function

    Friend Function getUserTypes() As List(Of usertype)
        Dim lstUserTypes As New List(Of usertype)
        Dim usertype As New usertype
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [id], [name], [fm], [tn], [rp], [sc] FROM [usertypes]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With usertype
                    .id = reader("id").ToString
                    .name = reader("name").ToString
                    .fm = reader("fm").ToString
                    .tn = reader("tn").ToString
                    .rp = reader("rp").ToString
                    .sc = reader("sc").ToString
                End With
                lstUserTypes.Add(usertype)
            End While
        End If
        reader.Close()
        Return lstUserTypes
    End Function

    Friend Function getVAT() As Decimal
        Dim decVAT As New Decimal
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SELECT [value] FROM [vat]"
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                decVAT = reader("value").ToString
            End While
        End If
        reader.Close()
        Return decVAT
    End Function

    Friend Sub query_adjustment(adjustment As adjustment, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [adjustments] ([code], [product], [type], [variance], [remarks], [date]) VALUES (@code, @product, @type, @variance, @remarks, @date)"
                    With .Parameters
                        .AddWithValue("@code", adjustment.code)
                        .AddWithValue("@product", adjustment.productID)
                        .AddWithValue("@type", adjustment.type)
                        .AddWithValue("@variance", adjustment.variance)
                        .AddWithValue("@remarks", adjustment.remarks)
                        .AddWithValue("@date", adjustment.eventdate)
                    End With
                Case sqlType.update

                Case sqlType.delete
                    .CommandText = "DELETE FROM [adjustments] WHERE [id]=@id"
                    .Parameters.AddWithValue("@id", adjustment.id)
            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_category(category As category, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [categories] ([name]) VALUES (@name)"
                    .Parameters.AddWithValue("@name", category.name)
                Case sqlType.update
                    .CommandText = "UPDATE [categories] SET [name]=@name WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@name", category.name)
                        .AddWithValue("@id", category.id)
                    End With
                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_discount(discount As discount, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [discounts] ([value], [description]) VALUES (@value, @description)"
                    With .Parameters
                        .AddWithValue("@value", discount.value)
                        .AddWithValue("@description", discount.description)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [discounts] SET [value]=@value, [description]=@description WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@value", discount.value)
                        .AddWithValue("@description", discount.description)
                        .AddWithValue("@id", discount.id)
                    End With
                Case sqlType.delete
                    .CommandText = "DELETE FROM [discounts] WHERE [id]=@id"
                    .Parameters.AddWithValue("@id", discount.id)
            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_expiry(expiry As expiry, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [expiry] ([product], [batch], [date]) VALUES (@product, @batch, @date)"
                    With .Parameters
                        .AddWithValue("@product", expiry.productID)
                        .AddWithValue("@batch", expiry.batch)
                        .AddWithValue("@date", expiry.expdate)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [expiry] SET [product]=@product, [batch]=@batch, [date]=@date WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@product", expiry.productID)
                        .AddWithValue("@batch", expiry.batch)
                        .AddWithValue("@date", expiry.expdate)
                        .AddWithValue("@id", expiry.id)
                    End With
                Case sqlType.delete
                    .CommandText = "DELETE FROM [expiry] WHERE [id]=@id"
                    .Parameters.AddWithValue("@id", expiry.id)
            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_product(product As product, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [products] ([code], [name], [subcategory], [generic], [unit], [discountable], [vatable], [price], [markup], [rop], [stock]) VALUES (@code, @name, @subcategory, @generic, @unitID, @discountable, @vatable, @price, @markup, @rop, @stock)"
                    With .Parameters
                        .AddWithValue("@code", product.code)
                        .AddWithValue("@name", product.name)
                        .AddWithValue("@subcategory", product.subcategory)
                        .AddWithValue("@generic", product.generic)
                        .AddWithValue("@unitID", product.unitID)
                        If product.discountable Then
                            .AddWithValue("@discountable", "yes")
                        Else
                            .AddWithValue("@discountable", "no")
                        End If
                        If product.vatable Then
                            .AddWithValue("@vatable", "yes")
                        Else
                            .AddWithValue("@vatable", "no")
                        End If
                        .AddWithValue("@price", product.price)
                        .AddWithValue("@markup", product.markup)
                        .AddWithValue("@rop", product.rop)
                        .AddWithValue("@stock", product.stock)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [products] SET [code]=@code, [name]=@name, [subcategory]=@subcategory, [generic]=@generic, [unit]=@unitID, [discountable]=@discountable, [vatable]=@vatable, [price]=@price, [markup]=@markup, [rop]=@rop, [stock]=@stock WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@code", product.code)
                        .AddWithValue("@name", product.name)
                        .AddWithValue("@subcategory", product.subcategory)
                        .AddWithValue("@generic", product.generic)
                        .AddWithValue("@unitID", product.unitID)
                        If product.discountable Then
                            .AddWithValue("@discountable", "yes")
                        Else
                            .AddWithValue("@discountable", "no")
                        End If
                        If product.vatable Then
                            .AddWithValue("@vatable", "yes")
                        Else
                            .AddWithValue("@vatable", "no")
                        End If
                        .AddWithValue("@price", product.price)
                        .AddWithValue("@markup", product.markup)
                        .AddWithValue("@rop", product.rop)
                        .AddWithValue("@stock", product.stock)
                        .AddWithValue("@id", product.id)
                    End With
                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_purchase(purchasedproduct As purchasedproduct, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [purchasedproducts] ([code], [date], [supplier], [product], [quantity]) VALUES (@code, @date, @supplier, @product, @quantity)"
                    With .Parameters
                        .AddWithValue("@code", purchasedproduct.code)
                        .AddWithValue("@date", purchasedproduct.eventdate)
                        .AddWithValue("@supplier", purchasedproduct.supplierID)
                        .AddWithValue("@product", purchasedproduct.productID)
                        .AddWithValue("@quantity", purchasedproduct.quantity)
                    End With
                Case sqlType.update

                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_receipt(receipt As receipt, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [receipts] ([code], [datetime], [cashier], [discount], [amountdue], [cash], [void]) VALUES (@code, @datetime, @cashier, @discount, @amountdue, @cash, @void)"
                    With .Parameters
                        .AddWithValue("@code", receipt.code)
                        .AddWithValue("@datetime", receipt.datetime)
                        .AddWithValue("@cashier", receipt.cashierID)
                        .AddWithValue("@discount", receipt.discountID)
                        .AddWithValue("@amountdue", receipt.amountdue)
                        .AddWithValue("@cash", receipt.cash)
                        If receipt.void Then
                            .AddWithValue("@void", "yes")
                        Else
                            .AddWithValue("@void", "no")
                        End If
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [receipts] SET [name]=@name WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@code", receipt.code)
                        .AddWithValue("@datetime", receipt.datetime)
                        .AddWithValue("@cashier", receipt.cashierID)
                        .AddWithValue("@discount", receipt.discountID)
                        .AddWithValue("@amountdue", receipt.amountdue)
                        .AddWithValue("@cash", receipt.cash)
                        If receipt.void Then
                            .AddWithValue("@void", "yes")
                        Else
                            .AddWithValue("@void", "no")
                        End If
                        .AddWithValue("@id", receipt.id)
                    End With
                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_receiptSave(receipt As receipt)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "UPDATE [receipts] SET [void]=@void WHERE [id]=@id"
            With .Parameters
                .AddWithValue("@void", "no")
                .AddWithValue("@id", receipt.id)
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_receiptcode(receiptnumber As receiptnumber)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "UPDATE [receiptnumber] SET [start]=@start, [end]=@end"
            With .Parameters
                .AddWithValue("@start", receiptnumber.startCode)
                .AddWithValue("@end", receiptnumber.endCode)
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_receivedproduct(receivedproduct As receivedproduct, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [receivedproducts] ([code], [date], [supplier], [product], [quantity], [price]) VALUES (@code, @date, @supplier, @product, @quantity, @price)"
                    With .Parameters
                        .AddWithValue("@code", receivedproduct.code)
                        .AddWithValue("@date", receivedproduct.eventdate)
                        .AddWithValue("@supplier", receivedproduct.supplierID)
                        .AddWithValue("@product", receivedproduct.productID)
                        .AddWithValue("@quantity", receivedproduct.quantity)
                        .AddWithValue("@price", receivedproduct.price)
                    End With
                Case sqlType.update

                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_returnedproduct(returnedproduct As returnedproduct, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [returnedproducts] ([date], [supplier], [product], [quantity], [remarks]) VALUES (@date, @supplier, @product, @quantity, @remarks)"
                    With .Parameters
                        .AddWithValue("@date", returnedproduct.eventdate)
                        .AddWithValue("@supplier", returnedproduct.supplierID)
                        .AddWithValue("@product", returnedproduct.productID)
                        .AddWithValue("@quantity", returnedproduct.quantity)
                        .AddWithValue("@remarks", returnedproduct.remarks)
                    End With
                Case sqlType.update

                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_setMarkUp(subcategory As subcategory)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "UPDATE [products] SET [markup]=@markup WHERE [subcategory]=@subcategory"
            With .Parameters
                .AddWithValue("@markup", subcategory.markup)
                .AddWithValue("@subcategory", subcategory.id)
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_subcategory(subcategory As subcategory, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [subcategories] ([category], [name], [markup]) VALUES (@category, @name, @markup)"
                    With .Parameters
                        .AddWithValue("@category", subcategory.categoryID)
                        .AddWithValue("@name", subcategory.name)
                        .AddWithValue("@markup", subcategory.markup)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [subcategories] SET [name]=@name, [markup]=@markup WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@name", subcategory.name)
                        .AddWithValue("@markup", subcategory.markup)
                        .AddWithValue("@id", subcategory.id)
                    End With
                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_supplier(supplier As supplier, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [suppliers] ([code], [name], [address], [telephone], [fax], [person], [number]) VALUES (@code, @name, @address, @telephone, @fax, @person, @number)"
                    With .Parameters
                        .AddWithValue("@code", supplier.code)
                        .AddWithValue("@name", supplier.name)
                        .AddWithValue("@address", supplier.address)
                        .AddWithValue("@telephone", supplier.telephone)
                        .AddWithValue("@fax", supplier.fax)
                        .AddWithValue("@person", supplier.person)
                        .AddWithValue("@number", supplier.number)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [suppliers] SET [code]=@code, [name]=@name, [address]=@address, [telephone]=@telephone, [fax]=@fax, [person]=@person, [number]=@number WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@code", supplier.code)
                        .AddWithValue("@name", supplier.name)
                        .AddWithValue("@address", supplier.address)
                        .AddWithValue("@telephone", supplier.telephone)
                        .AddWithValue("@fax", supplier.fax)
                        .AddWithValue("@person", supplier.person)
                        .AddWithValue("@number", supplier.number)
                        .AddWithValue("@id", supplier.id)
                    End With
                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_supplierproduct(supplier As supplier, product As product, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [suppliersproducts] ([supplier], [product]) VALUES (@supplier, @product)"
                    With .Parameters
                        .AddWithValue("@supplier", supplier.id)
                        .AddWithValue("@product", product.id)
                    End With
                Case sqlType.update

                Case sqlType.delete
                    .CommandText = "DELETE FROM [suppliersproducts] WHERE [supplier]=@supplier AND [product]=@product"
                    With .Parameters
                        .AddWithValue("@supplier", supplier.id)
                        .AddWithValue("@product", product.id)
                    End With
            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_transaction(transaction As transaction, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [transactions] ([receipt], [product], [price], [quantity]) VALUES (@receipt, @product, @price, @quantity)"
                    With .Parameters
                        .AddWithValue("@receipt", transaction.receiptID)
                        .AddWithValue("@product", transaction.productID)
                        .AddWithValue("@price", transaction.price)
                        .AddWithValue("@quantity", transaction.quantity)
                    End With
                Case sqlType.update

                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_unit(unit As unit, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [units] ([name]) VALUES (@name)"
                    .Parameters.AddWithValue("@name", unit.name)
                Case sqlType.update
                    .CommandText = "UPDATE [units] SET [name]=@name WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@name", unit.name)
                        .AddWithValue("@id", unit.id)
                    End With
                Case sqlType.delete

            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub query_vat(value As Decimal)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "UPDATE [vat] SET [value]=@value"
            .Parameters.AddWithValue("@value", value)
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub inventory_update(product As product, quantity As Integer, type As String)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "UPDATE [products] SET [stock]=@stock WHERE [id]=@product"
            With .Parameters
                .AddWithValue("@product", product.id)
                If type = "Add" Then
                    .AddWithValue("@stock", product.stock + quantity)
                End If
                If type = "Deduct" Then
                    .AddWithValue("@stock", product.stock - quantity)
                End If
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub user_create(user As user, password As String)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "CREATE USER @username IDENTIFIED BY @password"
            With .Parameters
                .AddWithValue("@username", user.name)
                .AddWithValue("@password", password)
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Function user_get(Optional id As Integer = 0, Optional name As String = "") As user
        Dim user As New user
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            If id <> 0 Then
                .CommandText = "SELECT [id], [name], [type], [hint], [surname], [givenname], [address] FROM [users] WHERE [id]=@id"
                .Parameters.AddWithValue("@id", id)
            End If
            If name <> String.Empty Then
                .CommandText = "SELECT [id], [name], [type], [hint], [surname], [givenname], [address] FROM [users] WHERE [name]=@name"
                .Parameters.AddWithValue("@name", name)
            End If
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With user
                    .id = reader("id").ToString
                    .name = reader("name").ToString
                    .typeID = reader("type").ToString
                    .hint = reader("hint").ToString
                    .surname = reader("surname").ToString
                    .givenname = reader("givenname").ToString
                    .address = reader("address").ToString
                End With
            End While
        End If
        reader.Close()
        Return user
    End Function

    Friend Function user_getType(Optional id As Integer = 0, Optional name As String = "") As usertype
        Dim usertype As New usertype
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            If id <> 0 Then
                .CommandText = "SELECT [id], [name], [fm], [tn], [rp], [sc] FROM [usertypes] WHERE [id]=@id"
                .Parameters.AddWithValue("@id", id)
            End If
            If name <> String.Empty Then
                .CommandText = "SELECT [id], [name], [fm], [tn], [rp], [sc] FROM [usertypes] WHERE [name]=@name"
                .Parameters.AddWithValue("@name", name)
            End If
        End With
        Dim reader As MySqlDataReader = sql.ExecuteReader()
        If reader.HasRows Then
            While reader.Read
                With usertype
                    .id = reader("id").ToString
                    .name = reader("name").ToString
                    .fm = reader("fm").ToString
                    .tn = reader("tn").ToString
                    .rp = reader("rp").ToString
                    .sc = reader("sc").ToString
                End With
            End While
        End If
        reader.Close()
        Return usertype
    End Function

    Friend Sub user_grant(user As user)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "GRANT ALL PRIVILEGES ON [pharmacy].* TO @username"
            With .Parameters
                .AddWithValue("@username", user.name)
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub user_passwordchange(password As String)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            .CommandText = "SET PASSWORD=PASSWORD(@password)"
            With .Parameters
                .AddWithValue("@password", password)
            End With
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub user_save(user As user, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [users] ([name], [type], [hint], [surname], [givenname], [address]) VALUES (@name, @type, @hint, @surname, @givenname, @address)"
                    With .Parameters
                        .AddWithValue("@name", user.name)
                        .AddWithValue("@type", user.typeID)
                        .AddWithValue("@hint", user.hint)
                        .AddWithValue("@surname", user.surname)
                        .AddWithValue("@givenname", user.givenname)
                        .AddWithValue("@address", user.address)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [users] [name]=@name, [type]=@type, [hint]=@hint, [surname]=@surname, [givenname]=@givenname, [address]=@address WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@name", user.name)
                        .AddWithValue("@type", user.typeID)
                        .AddWithValue("@hint", user.hint)
                        .AddWithValue("@surname", user.surname)
                        .AddWithValue("@givenname", user.givenname)
                        .AddWithValue("@address", user.address)
                        .AddWithValue("@id", user.id)
                    End With
                Case sqlType.delete
                    .CommandText = "DELETE FROM [users] WHERE [id]=@id"
                    .Parameters.AddWithValue("@id", user.id)
            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Sub user_saveType(usertype As usertype, type As sqlType)
        Dim sql As New MySqlCommand
        With sql
            .Connection = conn
            Select Case type
                Case sqlType.insert
                    .CommandText = "INSERT INTO [usertypes] ([name], [fm], [tn], [rp], [sc]) VALUES (@name, @fm, @tn, @rp, @sc)"
                    With .Parameters
                        .AddWithValue("@name", usertype.name)
                        .AddWithValue("@fm", usertype.fm)
                        .AddWithValue("@tn", usertype.tn)
                        .AddWithValue("@rp", usertype.rp)
                        .AddWithValue("@sc", usertype.sc)
                    End With
                Case sqlType.update
                    .CommandText = "UPDATE [usertypes] SET [name]=@name, [fm]=@fm, [tn]=@tn, [rp]=@rp, [sc]=@sc WHERE [id]=@id"
                    With .Parameters
                        .AddWithValue("@name", usertype.name)
                        .AddWithValue("@fm", usertype.fm)
                        .AddWithValue("@tn", usertype.tn)
                        .AddWithValue("@rp", usertype.rp)
                        .AddWithValue("@sc", usertype.sc)
                        .AddWithValue("@id", usertype.id)
                    End With
                Case sqlType.delete
                    .CommandText = "DELETE FROM [usertypes] WHERE [id]=@id"
                    .Parameters.AddWithValue("@id", usertype.id)
            End Select
        End With
        Try
            query.count += sql.ExecuteNonQuery()
        Catch ex As Exception
            With query
                .err = True
                .message = ex.Message
            End With
        End Try
    End Sub

    Friend Function connect() As ConnectionState
        conn.ConnectionString = csbConnStr.ConnectionString
        Try
            conn.Open()
        Catch ex As MySqlException
            query.err = True
            query.message = ex.Message
        End Try
        Return conn.State
    End Function
    Friend Function disconnect() As ConnectionState
        Try
            conn.Close()
        Catch ex As MySqlException
            query.err = True
            query.message = ex.Message
        End Try
        Return conn.State
    End Function
    Friend Function checkConnection() As ConnectionState
        Return conn.State
    End Function

    Friend Sub transBegin()
        sqlTrans = conn.BeginTransaction()
        query.err = False
        query.count = 0
    End Sub
    Friend Sub transCommit()
        sqlTrans.Commit()
    End Sub
    Friend Sub transRollback()
        sqlTrans.Rollback()
    End Sub

    Enum sqlType
        insert
        update
        delete
    End Enum

End Module



Friend Class lblTitle
    Inherits Label

    Friend Sub New(title As String)
        With Me
            .AutoSize = True
            .BackColor = Color.Indigo
            .Dock = DockStyle.Fill
            .ForeColor = Color.Gold
            .Font = New Font("Maiandra GD", 10.0!, FontStyle.Bold)
            .Margin = New Padding(0)
            .Padding = New Padding(3)
            .TextAlign = ContentAlignment.MiddleCenter
            .Text = title
        End With
    End Sub

    Dim drag As Boolean = False
    Dim mouseLocation As New Point

    Private Sub lblTitle_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left And Not Me.FindForm.WindowState = FormWindowState.Maximized Then
            drag = True
            With mouseLocation
                .X = Cursor.Position.X - Me.FindForm.Location.X
                .Y = Cursor.Position.Y - Me.FindForm.Location.Y
            End With
        End If
    End Sub

    Private Sub lblTitle_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove
        If drag Then
            With Me.FindForm
                .Location = New Point(Cursor.Position.X - mouseLocation.X, Cursor.Position.Y - mouseLocation.Y)
            End With
        End If
    End Sub

    Private Sub lblTitle_MouseUp(sender As Object, e As MouseEventArgs) Handles Me.MouseUp
        drag = False
        Dim clientSize As New Size
        If Me.FindForm.IsMdiChild Then
            Dim ctrl = Nothing
            For Each ctrls In Me.FindForm.MdiParent.Controls
                Try
                    ctrl = CType(ctrls, MdiClient)
                    With clientSize
                        .Width = ctrl.Size.Width - 5
                        .Height = ctrl.Size.Height - 5
                    End With
                    Exit For
                Catch
                End Try
            Next
        Else
            With clientSize
                .Width = My.Computer.Screen.Bounds.Width
                .Height = My.Computer.Screen.Bounds.Height
            End With
        End If
        If (Me.FindForm.Location.Y + Me.FindForm.Size.Height > clientSize.Height) Then
            Me.FindForm.Location = New Point(Me.FindForm.Location.X, clientSize.Height - Me.FindForm.Size.Height)
        End If
        If (Me.FindForm.Location.X + Me.FindForm.Size.Width > clientSize.Width) Then
            Me.FindForm.Location = New Point(clientSize.Width - Me.FindForm.Size.Width, Me.FindForm.Location.Y)
        End If
        If (Me.FindForm.Location.Y < 0) Then
            Me.FindForm.Location = New Point(Me.FindForm.Location.X, 0)
        End If
        If (Me.FindForm.Location.X < 0) Then
            Me.FindForm.Location = New Point(0, Me.FindForm.Location.Y)
        End If
    End Sub

End Class