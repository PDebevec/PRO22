   M S B A M L   `   `   `  ????I  ENepoezanDostop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:NepoezanDostopNepoezanDostop  5   	       NepoezanDostop.Prodaja   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:NepoezanDostop     5   	   -   5          ? Title$  Prodaja??5   	   $	??445??6   $	??979??6&    ? 	Resources 5	         NepoezanDostop.adw   adw  salesOrderHeaderViewSource ?? Source ?? Source  salesOrderDetailViewSource??%?   &	        &	      7   &	 I     7     5
   
   6   ?? 5   
    6B   ?? *SalesOrderHeader+8   ?? 5   
    6B   ?? *SalesOrderDetail+8   5      .??5      ?  ? DataContext# [ 6   .+?5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ salesOrderHeaderDataGrid??5         AutoGenerateColumns .     EnableRowVirtualization .    RowDetailsVisibilityMode$ VisibleWhenSelected=?6?   $??10,10,10,217q?6?   ??6p   ?? 	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        salesOrderIDColumn??,  &System.Windows.Controls.DataGridColumn
   Header$
 Sales Order ID??5   b      
IsReadOnly .    Width5  /System.Windows.Controls.DataGridLengthConverter$ SizeToHeader 6?   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6A   ?? *SalesOrderID+6?   4  .System.Windows.Controls.DataGridTemplateColumn  5      -   5        orderDateColumn??$
 
Order Date??5   B   $ SizeToHeader 6V      CellTemplate 5      ?? 5      .R?5      (  "System.Windows.Controls.DatePicker     SelectedDate 6)   ?? *	OrderDate+ ?? Mode$ TwoWay=? ?? NotifyOnValidationError .  ?? ValidatesOnExceptions . 5      5        5      -   5        dueDateColumn??$
 Due Date??5   @   $ SizeToHeader 6R    5      ?? 5      .R?5         6)   ?? *	DueDate+$ TwoWay=? .  . 5      5        5       -   5        shipDateColumn??$
 	Ship Date??5    A   $ SizeToHeader 6T    5!      ?? 5"      .R?5#         6)   ?? *
ShipDate+$ TwoWay=? .  . 5$      5&        5'      -   5        statusColumn??$
 Status??5'   V   $ SizeToHeader 6f    6;   ?? *Status+6f     5(      -   5        salesOrderNumberColumn??$
 Sales Order Number??5(   j    . $ SizeToHeader 6?    6E   ?? *SalesOrderNumber+6?     5)      -	   5        purchaseOrderNumberColumn??$
 Purchase Order Number??5)   p   $ SizeToHeader 6?    6H   ?? *PurchaseOrderNumber+6?     5*      -
   5        accountNumberColumn??$
 Account Number??5*   d   $ SizeToHeader 6|    6B   ?? *AccountNumber+6|     5+      -   5        customerIDColumn??$
 Customer ID??5+   ^   $ SizeToHeader 6s    6?   ?? *
CustomerID+6s     5,      -   5        shipMethodColumn??$
 Ship Method??5,   ^   $ SizeToHeader 6s    6?   ?? *
ShipMethod+6s     5-      -   5        totalDueColumn??$
 	Total Due??5-   Z    . $ SizeToHeader 6    6=   ?? *
TotalDue+6     5.      -   5        commentColumn??$
 Comment??5.   X   $ SizeToHeader 6i    6<   ?? *	Comment+6i   50        51   
   -   5        $ salesOrderDetailDataGrid??51       .   . $ VisibleWhenSelected=?6?   $??10,222,10,12q?6?   ??6p   ?? # [ 	 52        53      -   5        salesOrderIDColumn1??$
 Sales Order ID??53   c   $ SizeToHeader 6{    6B   ?? *SalesOrderID+6{     54      -   5        salesOrderDetailIDColumn??$
 Sales Order Detail ID??54   n    . $ SizeToHeader 6?    6G   ?? *SalesOrderDetailID+6?     55      -   5        orderQtyColumn??$
 	Order Qty??55   Z   $ SizeToHeader 6m    6=   ?? *
OrderQty+6m     56      -   5        productIDColumn??$
 
Product ID??56   \   $ SizeToHeader 6p    6>   ?? *	ProductID+6p     57      -   5        unitPriceColumn??$
 
Unit Price??57   \   $ SizeToHeader 6p    6>   ?? *	UnitPrice+6p     58      -   5        unitPriceDiscountColumn??$
 Unit Price Discount??58   l   $ SizeToHeader 6?    6F   ?? *UnitPriceDiscount+6?     59      -   5        lineTotalColumn??$
 
Line Total??59   \    . $ SizeToHeader 6?    6>   ?? *	LineTotal+6?     5:      -   5        rowguidColumn??$
 rowguid??5:   X   $ SizeToHeader 6i    6<   ?? *	rowguid+6i     5;      -   5        modifiedDateColumn??$
 Modified Date??5;   E   $ SizeToHeader 6\    5<      ?? 5=      .R?5>         6)   ?? *ModifiedDate+$ TwoWay=? .  . 5?      5A      5C      5E      5F      