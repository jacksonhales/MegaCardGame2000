   M S B A M L   `   `   `  ����K  GMegaCardGame2000, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MegaCardGame2000MegaCardGame2000  5   	   !    MegaCardGame2000.GameResult   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:MegaCardGame2000     5   	     � Title$  
GameResult��5   	    � SizeToContent$ WidthAndHeight=�6    � WindowStartupLocation$ CenterScreen=�6;   .��5	      � $��15q�6    � ColumnDefinitions 5
   
   �� 5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   �� $��0��6   $��0��6%   .+�5   
   �� -   5         ��Name$ 	lblResult��5      $��2��6#   $��Center=�67   .��6T   Congratulations!6f   �� 5      -   5        $ lblResultMessage��5      $��2��6.   $��Center=�6B   .��6_   &$You have defeated the NPC in battle!6�   5      �� 5   
   -   5         ��Name$ 
btnNewGame��5   Z   $��0��6   $��1��6!   $
��Left=�6.    �� 	IsDefault . $��60��6�   $��0 10 0 0q�6�   .��6�   
New Game6�   �� 5   
   -   5        $ btnExit��5   J   $��0��6   $��1��6!   $��Right=�6.   $��60��6r   $��0 10 0 0q�6�   .��6�   Exit6�   5      5      