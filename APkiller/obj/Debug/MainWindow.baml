   M S B A M L   `   `   `  ����C  ?APkiller, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:APkillerAPkiller  5   	   I)clr-namespace:APkiller.Controls.UIproccesAPkiller.Controls.UIprocces  5   	       APkiller.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:APkiller     5   	   ?	UIprocces)clr-namespace:APkiller.Controls.UIprocces     5   	   -   5          �Name$  window��5   E      WindowStyle#��[  5   	   .��5	      � $��0q�6e   ��6   �� *Height+ �� ElementName$ window����69   �� *Width+$ window�� � RowDefinitions 5
   
   �� 5      $��3* �6   �� 5      $	��37* �6    � ColumnDefinitions 5   
   �� 5      $��4* �6   �� 5      $
��231* �6   �� 5      $��4* �6   .+�5   
   �� $��3��6    �� Orientation$ 
Horizontal=�6)   .+�5      ��   
NameWindwo#��[ 6   $��34��69   ._�5      �� $��  APkiller  ��6   
�������$��Center=�6B   $��Center=�6f   $��5,-9,5,0q�6�   $��18(�6�   5      �� 5      $��9��6   �� 5      $y�Hidden=�6   #��[ 6)   $��34��6M   ._�5      �� $��
  Active  ��6   
�������$��Center=�6@   $��Center=�6d   $��5,-9,5,0q�6�   $��18(�6�   5      5      �� 5   
   $��Right=�6   $	��Top=�61   $ 
Horizontal=�6I   $��1��6b   $��34��6r   $	��104��6~   $��2��6�   .+�5      �� -   5          ResizeWindBorder#��[ 5      $��34��6?   $��34��6J   ._�5       �� $��-��6   
�������$��Center=�67   $��Center=�6[   $��5,-9,5,0q�6}   $��24(�6�   $��Segoe Print)�6�   ��. $��0,-4,0,4q�6�   5!      �� 5"      $��1��6   �� 5#      -   5        #��[ 5#      $��34��6?   $��34��6J   ._�5$      �� $��=��6   
�������$��Center=�67   $��Center=�6[   $��5,-9,5,0q�6}   $��24(�6�   $��Segoe Print)�6�   ��. $��0,-4,0,4q�6�   5%      �� 5&      $��1��6   �� 5'      -   5          CloseWindBorder#��[ 5'      $��34��6>   $��34��6I   ._�5(      �� $��X��6   
�������$��Center=�67   $��Center=�6[   $��5,-9,5,0q�6}   $��24(�6�   $��Segoe Print)�6�   ��. $��0,-4,0,4q�6�   5)      5*      �� 5+   
   $��1��6   $��1��6%   $ 
Horizontal=�62   $��2��6K   .+�5,      �� -   5        $��All processes��5,        
LabelStyle#��[ 6,   $��20(�6P   $��Franklin Gothic Medium)�6^   6�   �� 5.      -   5        $��Blocked Processes��5.      #��[ 60   $��20(�6T   $��Franklin Gothic Medium)�6b   $��4,5,0,0q�6�   6�   50      +   %APkiller.Controls.UIprocces.UIAllproc  52   
   -   5          Name$ 	ProcPanel��52      $y�Hidden=�61   $��1��6E   $��1��6U   $��0,45,0,0q�6b   .   (APkiller.Controls.UIprocces.UIClosingPoc  53   
   -   5          Name$ ClosingProcPanel��53   !   $y�Hidden=�6;   $��1��6O   $��1��6_   $��0,45,0,0q�6l   55      57      