   M S B A M L   `   `   `  ����C  ?BookWorm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BookWormBookWorm  5   	       BookWorm.AdminPage   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BookWorm     5   	     � Title$  
Admin Page��5   	   $	��450��6   $	��710��6)    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      �  � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   ��  �� CornerRadius$ 10��6   $��2��6#   ��5      �� 5      .��5      �  � Color$ 	#FFFFF865��6#    � Offset$
 0.13Q�65   � 5      $ 	#FF00FFA2��6#   $	 0.5Q�65   � 5      $ 	#FFB64646��6#   $
 0.97Q�65   5      5      �� 5   
   $��2��6   .+�5      o� -   5        .@�5      m� $
��File��6   .@�5      m� -   5        $��	Main Menu��5      5      5      5       A� 5!      -   5        
��� ���$��16��5!   $   $��16��60   $��Right=�6;   $	��Top=�6W   $��
0,-17,30,0q�6o    � ToolTip$ Minimize��6�   6�   A� 5"      -   5        	 A�Name$	 CloseButton��5"      
���  ��$��0��66   $��16��6C   $��16��6O   $��Right=�6Z   $	��Top=�6v   
 J� RenderTransformOrigin$
 0.625,0.128&�6�   $��	0,-17,8,0q�6�   $ Close��6�   5$      5%      �� 5'      .+�5(      &   System.Windows.Controls.DataGrid  -   5          Name$ CostumerGrid��5(      $	��192��6.   5)      5+      5,      