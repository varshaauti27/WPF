   M S B A M L   `   `   `  ����E  AZzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ZzaDesktop.CustomersZzaDesktop.Customers  5      +    %ZzaDesktop.Customers.CustomerListView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ZzaDesktop.Customers     5      _ [Microsoft.Xaml.Behaviors, Version=1.1.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a3b+http://schemas.microsoft.com/xaml/behaviors  5      *  $Microsoft.Xaml.Behaviors.Interaction    Triggers  5      +  %Microsoft.Xaml.Behaviors.EventTrigger  5   
      	EventName$ Loaded��6   *  $Microsoft.Xaml.Behaviors.TriggerBase   Actions. 5      4  .Microsoft.Xaml.Behaviors.Core.CallMethodAction     
MethodName$ LoadCustomer��6:      TargetObject 6!   �� 6:   5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   .+�5   
   �  � ColumnDefinitions 5      �� 5      $
��Auto �6#   �� 5      $��* �6#   .+�5      �� $��Add Customer��6   $��0��5      $
��Left=�5      ��5      �� *AddCustomerCommand+5      �� 5       �� Orientation$ 
Horizontal=�6   $��Right=�5       $��1��5!      .+�5"      �� $��Search:��6   �� 5#      $	��150��5$      ��5#      �� *SearchInput+ �� UpdateSourceTrigger$ PropertyChanged=�5$      �� 5%      $��X��6   ��5&      �� *ClearSearchCommand+5'      5(      &   System.Windows.Controls.DataGrid  5)   
   	   AutoGenerateColumns	 .  
   CanUserAddRows
 .  $��1��5,      ��5)      �� *	Customers+   Columns 5-      0  *System.Windows.Controls.DataGridTextColumn  5.      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6B   1	  +System.Windows.Controls.DataGridBoundColumn 	  Binding 6%   �� *
FullName+6B   4
  .System.Windows.Controls.DataGridTemplateColumn
  50      $
 Auto 6)    
  CellTemplate 51      �� 52      .R�53      �� $��Place Order��6%   $��5q�56   %   ��54   %   �� *DataContext.PlaceOrderCommand+ �� RelativeSource ��  �� AncestorType"  ��55   %   �� 56   %   57      59      
  5;      $
 Auto 6)    5<      �� 5=      .R�5>      �� $
��Edit��6%   $��5q�5A   %   ��5?   %   �� *!DataContext.EditCustomerCommand+ �� "  ��5@   %   �� 5A   %   5B      5D      5F      5G      5H      