   M S B A M L   `   `   `  ����C  ?BookWorm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BookWormBookWorm  5   	       BookWorm.MenuWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BookWorm     5   	     � Title$  
MenuWindow��5   	   $	��450��6   $	��800��6)    � AllowsTransparency$
 True��65   
������  � WindowStyle$
 None=�5	   	    � 
ResizeMode$ NoResize=�6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   �� 5      $��4* �6   .+�5   
   ��  �� CornerRadius$ 10��6   $��4��6#   ��5      �� 5      .��5      �  � Color$ 	#FFFFF865��6#    � Offset$
 0.13Q�65   � 5      $ 	#FF00FFA2��6#   $	 0.5Q�65   � 5      $ 	#FFB64646��6#   $
 0.97Q�65   5      5      �� 5   
   $��4��6   .+�5       o� -   5        .@�5!      m� $
��File��6   .@�5"      m� -   5        $��Logout��5"      5#      5$      5%      A� 5&      -   5        
��� ���$��16��5&   $   $��16��60   $��Right=�6;   $	��Top=�6W   $��
0,-17,30,0q�6o    � ToolTip$ Minimize��6�   6�   A� 5'      -   5        	 A�Name$	 CloseButton��5'      
���  ��$��0��66   $��16��6C   $��16��6O   $��Right=�6Z   $	��Top=�6v   
 J� RenderTransformOrigin$
 0.625,0.128&�6�   $��	0,-17,8,0q�6�   $ Close��6�   5)      5*      �� 5-   
   $��0��6   $��Center=�6%   $��Center=�6@   .+�5.      �� $��
10,30,10,0q�6   ���	#FF8EB3F1.��5/      �� $��Stretch=�6   $��Stretch=�6;   $��0,0,0,0q�6W   .+�50      �� -   5        $��Resources/borrow.png��50      6:   51      52      �� 53      $��Book Borrow��6   $��DemiBold"�54      $��	helvetica)�55      $��22(�56      
���   �$��Center=�58      59      �� 5;   
   $��1��6   $��Center=�6%   $��Center=�6@   .+�5<      �� $��
10,30,10,0q�6   ���	#FF8EB3F1.��5=      �� $��Stretch=�6   $��Stretch=�6;   $��0,0,0,0q�6W   .+�5>      �� -   5        $��Resources/addUser.png��5>      6;   5?      5@      �� 5A      $��Add User��6   $��DemiBold"�5B      $��	helvetica)�5C      $��22(�5D      
���   �$��Center=�5F      5G      �� 5I   
   $��2��6   $��Center=�6%   $��Center=�6@   .+�5J      �� $��
10,30,10,0q�6   ���	#FF8EB3F1.��5K      �� $��Stretch=�6   $��Stretch=�6;   $��0,0,0,0q�6W   .+�5L      �� $��Resources/addBook.png��6   5M      5N      �� 5O      $��Add Book��6   $��DemiBold"�5P      $��	helvetica)�5Q      $��22(�5R      
���   �$��Center=�5T      5U      �� 5W   
   $��3��6   $��Center=�6%   $��Center=�6@   .+�5X      �� $��
10,30,10,0q�6   ���	#FF8EB3F1.��5Y      �� $��Stretch=�6   $��Stretch=�6;   $��0,0,0,0q�6W   .+�5Z      �� $��Resources/List.png��6   5[      5\      �� 5]      $��List All Borrow��6   $��DemiBold"�5^      $��	helvetica)�5_      $��22(�5`      
���   �$��Center=�5b      5c      5d      5f      