   M S B A M L   `   `   `  ����C  ?BookWorm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:BookWormBookWorm  5   	       BookWorm.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:BookWorm     5   	     � Title$  
MainWindow��5      $	��450��6)   $	��380��66    � AllowsTransparency$
 True��5	   	   
������  � WindowStyle$
 None=�5
   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ 	#FFFFF865��6'    � Offset$
 0.13Q�69   � 5      $ 	#FF00FFA2��6'   $	 0.5Q�69   � 5      $ 	#FFB64646��6'   $
 0.97Q�69   5      5       �� 5"      $��Center=�6   .+�5#      �� $��Resources/bookworms.png��6   $	��120��69   �� 5$      $��	Book Worm��6   $��DemiBold"�5%      $��	helvetica)�5&      $��22(�5'      
���   �$��Center=�5)      5+      A� 5,      -   5        
��� ���$��16��5,   $   $��16��60   $��Right=�6;   $	��Top=�6W   $��0,5,31,0q�6o    � ToolTip$ Minimize��6�   6�   A� 5-      -   5        
���  ��$��0��5-   !   $��16��6.   $��15��6:   $��Right=�6E   $	��Top=�6a   	 J� RenderTransformOrigin$	 0.625,0.128&�6y   $��0,5,8,0q�6�   $ Close��6�   6�   �� 50      $��1��6   .+�51      �� 
 �� Orientation$
 
Horizontal=�6   .+�52      �� -   5         ��Name$ txtUsername��52      $��	Helvetica)�63   $
��Bold"�53      $��Username��54      $��20(�55      $
��Left=�56      
���   �
������ $��0q�59      $��228.5��5:      $
��Left=�5;       J� Opacity$	 0.5Q�5<      $��25��5=      $��65,0,0,0q�5>      �� 5?      $��Resources/User.png��6   5@      �� 5A      $	��250��6   $��2��5B      
�������$	 0.5Q�5D      �� 5I      $
 
Horizontal=�6   $��0,20,0,0q�66   .+�5J      G� -   5         G�Name$ txtPassword��5J   "   $��	Helvetica)�67   $��Light"�5K       G� Password$ Password��5L      $��20(�5M      $
��Left=�5N      
���   �
������ $��0q�5Q      $	��228��5R      $
��Left=�5S      $	 0.5Q�5T      $��25��5U      $��65,0,0,0q�5V      5W      �� 5X      $��Resources/pass.png��6   $��25��68   5Y      �� 5Z      $	��250��6   $��2��5[      
�������$	 0.5Q�5]      ]� 5`      $��0,20,0,0q�6   .+�5a      �� -   5         ��Name$ LoginButton��5a      $	��100��5b      $��25��6)   $��LOGIN��5c      
���   �$��	Helvetica)�5e      
������ 
���   � �� 	IsDefault$
 True��5i      5k      5l      5n      5o      5p      