   M S B A M L   `   `   `  ����E  AZzaDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:ZzaDesktop.CustomersZzaDesktop.Customers  5      C ?Zza.Data, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null5(clr-namespace:Zza.Data;assembly=Zza.DataZza.Data 5      =#clr-namespace:ZzaDesktop.ConvertersZzaDesktop.Converters  5      .    (ZzaDesktop.Customers.AddEditCustomerView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      4local"clr-namespace:ZzaDesktop.Customers     5      9Data(clr-namespace:Zza.Data;assembly=Zza.Data     5      4conv#clr-namespace:ZzaDesktop.Converters     5        � 	Resources  5      A   ;ZzaDesktop.Converters.NegatableBooleanToVisibilityConverter   VisConverter  NegVisConverter   Negate �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%  &	        &	      '�� 1       5   
   65     5   
    . 5   5   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5!   
   � -   5         �Name$ grid1��5!      $��0��6   $	��Top=�5"      $��	17,15,0,0q�5#      $
��Left=�5$       � DataContext 5%      �� *
Customer+ 5'      �� 5(      $
��Auto �6    �� 5)      $
��Auto �6    �� 5*      $
��Auto �6    �� 5+      $
��Auto �6     � ColumnDefinitions 5-      �� 5.      $
��Auto �6#   �� 5/      $
��Auto �6#   .+�52      �� $��First Name: ��6   $��Center=�53      $��0��54      $��0��6!   $��3q�55      $
��Left=�56      �� 57      -   5         ��Name$ firstNameTextBox��57      $	��120��58      $��Center=�59      $��0��5;      $��1��6#   $��3q�5<      $��23��5=      $
��Left=�5>      ��5:      �� *	FirstName+" �� ValidatesOnNotifyDataErrors . 5>      �� 5@      $��Last Name: ��6   $��Center=�5A      $��1��5B      $��0��6!   $��3q�5C      $
��Left=�5D      �� 5E      -   5        $ lastNameTextBox��5E      $	��120��5F      $��Center=�5G      $��1��5I      $��1��6#   $��3q�5J      $��23��5K      $
��Left=�5L      ��5H      �� *
LastName+ . 5L      �� 5N      $��Email: ��6   $��Center=�5O      $��2��5P      $��0��6!   $��3q�5Q      $
��Left=�5R      �� 5S      -   5        $ emailTextBox��5S      $	��120��5T      $��Center=�5U      $��2��5W      $��1��6#   $��3q�5X      $��23��6!   $
��Left=�5Y      ��5V      �� *Email+ . 5Y      �� 5[      $��Phone:��6   $��Center=�5\      $��3��5]      $��0��6"   $��3q�5^      $
��Left=�5_      �� 5`      -   5        $ phoneTextBox��5`      $	��120��5a      $��Center=�5b      $��3��5d      $��1��6#   $��3q�5e      $��23��5f      $
��Left=�6"   ��5c      �� *Phone+ . 5f   "   5g      � 5i   
   $��1��6   $
��Left=�5j      .+�5k      �� $
��Save��6   $
��Left=�5n      $��25,5,0,0q�5o      $	��Top=�5p      $��75��5q      ��5l      �� *SaveCommand+y�5m      �� *
EditMode+ �� 	Converter# [  5q      �� 5r      $	��Add��6   $
��Left=�5u      $��25,5,0,0q�5v      $	��Top=�5w      $��75��5x      ��5s      �� *SaveCommand+y�5t      �� *
EditMode+# [ 5x      �� 5y      $��Cancel��6   $
��Left=�5{      $��	150,5,0,0q�5|      $	��Top=�5}      $��75��5~      ��5z      �� *CancelCommand+5~      5      5�      5�      