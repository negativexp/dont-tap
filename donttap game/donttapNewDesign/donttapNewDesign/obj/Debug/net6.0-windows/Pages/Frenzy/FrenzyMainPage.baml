   M S B A M L   `   `   `  ����  DONT TAPM+clr-namespace:donttapNewDesign.Pages.FrenzydonttapNewDesign.Pages.Frenzy  5      2    ,donttapNewDesign.Pages.Frenzy.FrenzyMainPage   5      W SPresentationCore, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      =local+clr-namespace:donttapNewDesign.Pages.Frenzy     5      -   5          N� Title$  
MainWindow��5       
  Height#��[  6    	 Width#��[ 6;    N� 
Background
 ���� .��5      ��   MainBorderTemplate#��[ 6   ._�5   
   �  � RowDefinitions 5      �� 5      $��8* �6    �� 5      $	��27* �6    .+�5      ��   TitleBorderTemplate#��[ 6   ._�5      � .+�5      ��   MoveableControl#��[ 6%   �� 5      -   5        $��TextBlockTitle��5       $��Frenzy��66   $��Center=�6D   $��Center=�6_   $��45(�5       $��0 0 0 10q�6.    � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6+   .[�5   "   �� .��5   &   �� .��5   *   W�  �� 
TargetName$ TextBlockTitle��5    -    �� TargetProperty$ (TextBlock.Opacity)�5!   -    W� From 05"   -   	 W� To 166   	 g� Duration$	 0:0:0.75D�6=   5#   '   5$   #   5%      5'      5(      5)      � 5,      $��0 0 0 90q�6   $��1��6%    5-      �� 5.      $��2* �6$   �� 5/      .+�51      ��   ContentBorderTemplate#��[ 6   $��20,20,20,10q�6H   $��0��6]   ._�52      � .+�53      �� $��	Settings:��6$   $��	Underline{�65   $
��Left=�6Q   $	��Top=�6l   $��
10 10 10 5q�6�   $��30(�6�   �� 54      $��0��6%   $��Bottom=�62   $
��Left=�6M   $��	30,0,0,34q�6h   $	��161��6{   .+�55      �� -   5        $��TextBlockBoardSize��55   (   $��Board size:��6B   $
��Left=�6U   $	��Top=�6p   $��0 0 0 0q�6�   $��18(�6�   �� 56      -   5        $��TextBlockBoxSize��56   (   $��	Box size:��6@   $
��Left=�6Q   $	��Top=�6l   $��0 20 0 0q�6�   $��18(�6�   �� 57      -   5        $��TextBlockSpacing��57   (   $��Spacing:��6@   $
��Left=�6P   $	��Top=�6k   $��0 20 0 0q�6�   $��18(�6�   �� 58      -   5        $��TextBlockLastScore��58   (   $��Last score:��6B   $
��Left=�6U   $	��Top=�6p   $��0 20 0 0q�6�   $��18(�6�   59      5:      5;      �� 5<      #��[ 6   $��20,10,20,20q�6H   $��1��6]   ._�5=      � $��0��6   .+�5>      �� $��Time (seconds):��6$   $��	Underline{�6;   $
��Left=�6W   $	��Top=�6r   $��
10 10 10 5q�6�   $��30(�6�   �� 5?      -   5        $��TextBoxCustom��5?   "   $��
20,82,20,8q�67   $��25��6K   $y�Visible=�6W   $��18(�6l   �� 5@      
 �� Orientation$
 
Horizontal=�6%   $��Center=�6>   $��Center=�6Y   .+�5A      �� -   5        $��
CheckBox30��5A   '   $��30��6V   $��	20 20 0 0q�6c    � LayoutTransform 5B   "   �� 5C   &    �� ScaleX$	 1.2Q�65    �� ScaleY$	 1.2Q�6B   5E      �� 5F      -	   5        $��
CheckBox60��5F   '   $��60��6V   $��	20 20 0 0q�6c    5G   "   �� 5H   &   $	 1.2Q�65   $	 1.2Q�6B   5J      �� 5K      -
   5        $��
CheckBox90��5K   '   $��90��6V   $��	20 20 0 0q�6c    5L   "   �� 5M   &   $	 1.2Q�65   $	 1.2Q�6B   5O      �� 5P      -   5        $��CheckBoxCustom��5P   '   $��Custom��6^   $��	20 20 0 0q�6o    5Q   "   �� 5R   &   $	 1.2Q�65   $	 1.2Q�6B   5T      5U      5V      5W      5X      �� 5Y      -   5        $��
ButtonBack��5Y   B     RoundButtonTemplate#��[ 6   $
��Left=�5Z      $��Bottom=�68   $��	30 0 0 30q�6S   $
��Back��5[      $��1��6E   �� 5]      -   5        $��ButtonStart��5]   B   #��[ 6   $��Right=�5^      $��Bottom=�69   $��	0 0 30 30q�6T   $��Start��5_      $��1��6G   �� 5a      -   5        $��ButtonLeaderBoard��5a   B   #��[ 6   $��Center=�5b      $��Bottom=�6:   $��0,0,0,30q�6U   $��Leaderboard��5c      $��1��6S   5d      5e      5f      