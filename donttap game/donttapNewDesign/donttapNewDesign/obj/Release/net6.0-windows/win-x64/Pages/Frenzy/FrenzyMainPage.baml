   M S B A M L   `   `   `  ���� K  GdonttapNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:donttapNewDesign.Pages.FrenzydonttapNewDesign.Pages.Frenzy  2    ,donttapNewDesign.Pages.Frenzy.FrenzyMainPage   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     =local+clr-namespace:donttapNewDesign.Pages.Frenzy     -     N� Title$  
MainWindow�� 
  Height#��[   	 Width#��[  N� 
Background
 ���� .����   MainBorderTemplate#��[ ._��  � RowDefinitions �� $��8* ��� $	��27* �.+���   TitleBorderTemplate#��[ ._�� .+�� -     MouseDownGridTemplate#��[ .+��� -     xButtonTemplate#��[ �� -     _ButtonTemplate#��[ �� -   $��TextBlockTitle��$��Frenzy��$��Center=�$��Center=�$��45(�$��0 0 0 10q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  �� 
TargetName$ TextBlockTitle�� �� TargetProperty$ (TextBlock.Opacity)� W� From 0	 W� To 1	 g� Duration$	 0:0:0.75D�� $��0 0 0 90q�$��1�� �� �� .+���   ContentBorderTemplate#��[ $��20 20 20 10q�$��0��._�� .+��� $��	Settings:��$��	Underline{�$
��Left=�$	��Top=�$��
10 10 10 5q�$��30(��� $��0��$��Center=�$��Center=�.+��� -   $��TextBlockBoardSize��$��Board size: 99��$
��Left=�$	��Top=�$��	0 10 0 00q�$��18(��� -   $��TextBlockBoxSize��$��Box size: 99��$
��Left=�$	��Top=�$��0 10 0 0q�$��18(��� -   $��TextBlockSpacing��$��Spacing: 99��$
��Left=�$	��Top=�$��0 10 0 0q�$��18(��� -	   $��TextBlockLastScore��$��Last score: 99��$
��Left=�$	��Top=�$��0 10 0 0q�$��18(��� #��[ $��20 10 20 20q�$��1��._�� $��0��.+��� $��Time (seconds):��$��	Underline{�$
��Left=�$	��Top=�$��
10 10 10 5q�$��30(��� -
   $��TextBoxCustom��$��20 100 20 0q�$��25��$y�Visible=�$��18(��� 
 �� Orientation$
 
Horizontal=�$��Center=�$��Center=�.+��� -   $��
CheckBox30��$��30��$��	20 20 0 0q� � LayoutTransform ��  �� ScaleX$	 1.2Q� �� ScaleY$	 1.2Q��� -   $��
CheckBox60��$��60��$��	20 20 0 0q� �� $	 1.2Q�$	 1.2Q��� -   $��
CheckBox90��$��90��$��	20 20 0 0q� �� $	 1.2Q�$	 1.2Q��� -   $��CheckBoxCustom��$��Custom��$��	20 20 0 0q� �� $	 1.2Q�$	 1.2Q��� -   $��
ButtonBack��  RoundButtonTemplate#��[ $
��Left=�$��Bottom=�$��	30 0 0 30q�$
��Back��$��1���� -   $��ButtonStart��#��[ $��Right=�$��Bottom=�$��	0 0 30 30q�$��Start��$��1���� -   $��ButtonLeaderBoard��#��[ $��Center=�$��Bottom=�$��0,0,0,30q�$��Leaderboard��$��1��