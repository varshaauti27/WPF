   M S B A M L   `   `   `  ����]  YJoeCoffeeStore.StockManagement.App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulla5clr-namespace:JoeCoffeeStore.StockManagement.App.View'JoeCoffeeStore.StockManagement.App.View  5   	   <    6JoeCoffeeStore.StockManagement.App.View.ValidationDemo   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Glocal5clr-namespace:JoeCoffeeStore.StockManagement.App.View     5   	   c _System.Windows.Interactivity, Version=4.5.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5   	     � Title$  ValidationDemo��5
   	   $	��450��6    $	��450��6-    � DataContext 5   	   ��    mainViewModelLocator �� Source# [   �� Path$ ValidationDemoViewModel�.��5      �  � RowDefinitions 5   
   �� 5      $��70 �6   6*   �� 5      $��70 �6   6*   �� 5      $��70 �6   6*   �� 5      $��70 �6   6*   �� 5      $��70 �6   6*   �� 5      $��70 �6   6*    � ColumnDefinitions 5   
   �� 5      $	��200 �6   6-   �� 5      $	��200 �6   6-   .+�5   
   �� $��Number(Default):��6   $��0��6,   $��0��6<   $��5q�6I   $��14(�6T   $
��Bold"�6b   $	��Top=�6t   6�   �� 5   
   $��0��6L   $��1��6Y   $��5q�6i   $��20��6t   $	��Top=�6�   ��6   �� *Age+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Number(ErrorTemplate):��6   $��0��62   $��1��6B   $��5q�6O   $��14(�6Z   $
��Bold"�6h   $	��Top=�6z   6�   �� 5   
   $��1��6L   $��1��6Y   $��5q�6i   $��20��6t   $	��Top=�6�   ��6   �� *Age+$ PropertyChanged=�.��6�    =� ErrorTemplate 5      �� 5      .R�5       �� .+�5"      ��  ��Name$ textBox��64   �� 5#      
���  ����6$   �� *[0].ErrorContent+6F   5$      5%      .��5&   (   5'      �� 5)   
   $��Number(ValidationRule):��6   $��0��63   $��2��6C   $��5q�6P   $��14(�6[   $
��Bold"�6i   $	��Top=�6{   6�   �� 5*   
   $��2��6   $��1��6   $��5q�6/   $	��Top=�6:   .��6R   ��5+      �� 5,      $	 Age�6   $ PropertyChanged=�6%   	 �� ValidationRules	 5-      G   AJoeCoffeeStore.StockManagement.App.View.StringToIntValidationRule  5.      ,  &System.Windows.Controls.ValidationRule
   ValidationStep$
 RawProposedValue=�6:   50      .��51      52      �� 54   
   $&�� Number(ExceptionValidationRule):��6   $��0��6<   $��3��6L   $��5q�6Y   $��14(�6d   $
��Bold"�6r   $	��Top=�6�   6�   �� 55   
   $��3��6   $��1��6   $��5q�6/   $��20��6:   $	��Top=�6F   .��6^   .��56      �� $ ValidAge�6   $ PropertyChanged=�6&   	 57      5  /System.Windows.Controls.ExceptionValidationRule  58      5:      5;      �� 5@   
   $��Number(IDataErrorInfo):��6   $��0��63   $��4��6C   $��5q�6P   $��14(�6[   $
��Bold"�6i   $	��Top=�6{   6�   �� 5A   
   $��4��6h   $��1��6u   $��5q�6�   $��20��6�   $	��Top=�6�   ��6   �� *Age+$ PropertyChanged=� �� ValidatesOnDataErrors . 6�   5F      5G      