   M S B A M L   `   `   `  ����F  B"DON'T TAP", Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:donttapNewDesign.PagesdonttapNewDesign.Pages  5      )    #donttapNewDesign.Pages.SettingsPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:donttapNewDesign.Pages     5      -   5          N� Title$  
MainWindow��5       
  Height#��[  6    	 Width#��[ 6;    N� 
Background
 ���� .��5      ��   MainBorderTemplate#��[ 6   ._�5   
   �  � RowDefinitions 5      �� 5      $��8* �6    �� 5      $	��27* �6    .+�5      ��   TitleBorderTemplate#��[ 6   ._�5      � .+�5      ��   MoveableControl#��[ 6%   �� 5      -   5        $��TextBlockTitle��5       $��Settings��66   $��Center=�6F   $��Center=�6a   $��45(�5       $��0 0 0 10q�6.    � Triggers 5      :� 5       :� RoutedEvent$ Loaded��6+   .[�5   "   �� .��5   &   �� .��5   *   W�  �� 
TargetName$ TextBlockTitle��5    -    �� TargetProperty$ (TextBlock.Opacity)�5!   -    W� From 05"   -   	 W� To 166   	 g� Duration$	 0:0:0.75D�6=   5#   '   5$   #   5%      5'      5(      5)      � 5,      $��1��6   .+�5.      �� $��Board size: ��6   $��24(�60   $
��Left=�6>   $	��Top=�5/       $��	20 20 0 0q�68   �� 50      -   5        $��TextBoxBoardSize��50      $��
30,57,30,0q�62   $��18(�6F   $��25��6T   $	��Top=�6`   �� 53      $��
Box size: ��6   $��24(�6.   $
��Left=�6<   $	��Top=�54      $��	20,90,0,0q�61   �� 55      -   5        
 ��Name$
 TextBoxBoxSize��55      $��25��62   $��30,127,30,0q�6>   $��18(�6S   $	��Top=�6a   �� 58      $��	Spacing: ��6   $��24(�6-   $
��Left=�6;   $	��Top=�59      $��
20,170,0,0q�61   �� 5:      -   5        $
 TextBoxSpacingSize��5:      $��25��66   $��30,207,30,0q�6B   $��18(�6W   $	��Top=�6e   �� 5=      -   5        $��
ButtonBack��5=   F     RoundButtonTemplate#��[ 6   $
��Left=�5>      $��Bottom=�68   $��	30 0 0 30q�6S   $
��Back��5?      6,   �� 5A      -   5        $��
ButtonSave��5A   F   #��[ 6   $��Right=�5B      $��Bottom=�69   $��	0 0 30 30q�6T   $
��Save��5C      6,   5D      5E      5F      5G      