   M S B A M L   `   `   `  ���� K  GdonttapNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:donttapNewDesign.Pages.FrenzydonttapNewDesign.Pages.Frenzy  9    3donttapNewDesign.Pages.Frenzy.FrenzyLeaderboardPage   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     =local+clr-namespace:donttapNewDesign.Pages.Frenzy     -     N� Title$  
MainWindow�� 
  Height#��[   	 Width#��[ .����   MainBorderTemplate#��[ ._��  � RowDefinitions �� $��8* ��� $	��27* �.+���   TitleBorderTemplate#��[ ._�� .+�� -     MouseDownGridTemplate#��[ .+��� -     xButtonTemplate#��[ �� -     _ButtonTemplate#��[ �� -   $��TextBlockTitle��$��Leaderboard��$��Center=�$��Center=�$��45(�$��0 0 0 10q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  �� 
TargetName$ TextBlockTitle�� �� TargetProperty$ (TextBlock.Opacity)� W� From 0	 W� To 1 g� Duration$ 0:0:0.75D��� -   $��TextBlockTitleUnderText��$��Frenzy��$��Bottom=�$��Center=�$��20q�$��16(� :� $ Loaded��.[��� .���� .��W� $ TextBlockTitleUnderText��$ (TextBlock.Opacity)� 0 1$ 0:0:0.75D�� $��1��.+�&   System.Windows.Controls.DataGrid  -   $��DataGridMrdko��	   ColumnWidth5  /System.Windows.Controls.DataGridLengthConverter$	 * !
   EnableColumnVirtualization$
 False��   CanUserAddRows$ False��   CanUserReorderColumns$ False�� �� AlternationCount$ 2��   AlternatingRowBackground
 ��������#BDBDC7   
IsReadOnly$
 True��$��20,20,20,70q�   Columns �� -   $��ButtonEndurence��  RoundButtonTemplate#��[ $
��Left=�$��Bottom=�$��	30 0 0 30q�$
��Back���� -	   $��
ButtonBack��#��[ $
��Left=�$��Bottom=�$��	30 0 0 30q�$
��Back���� -
   $��ButtonDelete��#��[ $��Right=�$��Bottom=�$��	0 0 30 30q�$��Delete��