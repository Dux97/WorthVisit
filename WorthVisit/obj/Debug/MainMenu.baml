   M S B A M L   `   `   `  ����E  AWorthVisit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:WorthVisit
WorthVisit  5   	       WorthVisit.MainMenu   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   *localclr-namespace:WorthVisit     5   	     � Title$  
MainWindow��5   	   $	��650��6   $	��900��6)    � 
ResizeMode$ CanMinimize=�65    � 	Resources 5	         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType �� Padding �� CornerRadius	 �� Triggers
 P� Property P� Value �� 
TargetName 
 Europa �� ImageSource  AmerkaPn  	AmerykaPl  Azja  	Australia 
 Afryka��%L  &	        &	 �    &	 #    &	 R    &	 �    &	 �    &	 �    �� 5
   
   " ��6&   .�5      ��  �@�OverridesDefaultStyle . 66   �� 5       � ��$ 5q�6'   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� $��border��6!   $��1q�5      $	 4,2q�5      
�������$ 3��5      #��z��5      ._�5      �� $��Center=�6/   $��Center=�6L   5      	 5      P� 5      
 �@J�IsMouseOver . . �5   "   �� $ border��6)    � ��
 �   �6T   5      5      5      5       �� 5"   
   $ zdjecia/Europa.jpg��6$   �� 5#   
   $ zdjecia/AmerykaPN.png��6&   �� 5$   
   $ zdjecia/AmerykaPL.png��6'   �� 5%   
   $ zdjecia/Azja.png��6"   �� 5&   
   $ zdjecia/Australia.png��6'   �� 5'   
   $ zdjecia/Afryka.png��6$   5)      .��5-      � -   5         �Name$ GridBackground��5-      $��Right=�6#   .+�5/   
    � -   5          �Name$ myframe��5/      $��4��6!   $��4��65   $��0,0,0.202,0q�6F   �� 50   
   $
��Fill=�6   $4��./WorthVisit;component/zdjecia/mapa świata.jpg��6   $��4��6V   $��4��6j   $��0,0,0.202,0q�6{   �� 52   
   -   5         ��Name$ ButtonAmerykaN��52      #��[ 6)   $��116,85,570,368q�6d    J� RenderTransformOrigin$ 0.5,0.5&�6|   #��[  6�   �� 53   
   -   5        $ ButtonEuropa��53      #��[ 6'   $��386,63,341,435q�6M   #��[  6w   �� 54   
   -   5        $ ButtonAmerykaS��54      #��[ 6)   $��211,275,543,123q�6e   #��[  6~   �� 55   
   -   5        $ 
ButtonAzja��55      #��[ 6%   $��558,63,129,284q�6X   #��[  6p   �� 56   
   -   5        $ ButtonAustralia��56      $��682,352,75,146q�6*   #���  6W   #��[  6�    �� 	ClickMode$ Press=�6�   ��6�   Z� 6�   �� 57   
   -   5        $ ButtonAfryka��57      #��[ 6'   $��386,201,368,184q�6L   #��[  6w   58      5:      