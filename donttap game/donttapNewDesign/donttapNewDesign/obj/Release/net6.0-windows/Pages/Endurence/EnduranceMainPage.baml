   M S B A M L   `   `   `  ����   DONT TAPS.clr-namespace:donttapNewDesign.Pages.Endurence donttapNewDesign.Pages.Endurence  8    2donttapNewDesign.Pages.Endurence.EndurenceMainPage   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     @local.clr-namespace:donttapNewDesign.Pages.Endurence     -     N� Title$  
MainWindow�� 
  Height#��[   	 Width#��[  N� 
Background
 ���� .����   MainBorderTemplate#��[ ._��  � RowDefinitions �� $��8* ��� $	��27* �.+���   TitleBorderTemplate#��[ ._�� .+���   MoveableControl#��[ �� -   $��TextBlockTitle��$��	Endurence��$��Center=�$��Center=�$��45(�$��0 0 0 10q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  �� 
TargetName$ TextBlockTitle�� �� TargetProperty$ (TextBlock.Opacity)� W� From 0	 W� To 1	 g� Duration$	 0:0:0.75D�� $��0 0 0 90q�$��1�� �� $��2* ��� .+���   ContentBorderTemplate#��[ $��20,20,20,10q�$��0��._�� .+��� $��	Settings:��$��	Underline{�$
��Left=�$	��Top=�$��
10 10 10 5q�$��30(��� $��0��$��Bottom=�$
��Left=�$��	30,0,0,34q�$	��161��.+��� -   $��TextBlockBoardSize��$��Board size:��$
��Left=�$	��Top=�$��0 0 0 0q�$��18(��� -   $��TextBlockBoxSize��$��	Box size:��$
��Left=�$	��Top=�$��0 20 0 0q�$��18(��� -   $��TextBlockSpacing��$��Spacing:��$
��Left=�$	��Top=�$��0 20 0 0q�$��18(��� -   $��TextBlockLastScore��$��Last score:��$
��Left=�$	��Top=�$��0 20 0 0q�$��18(��� #��[ $��20,10,20,20q�$��1��._�� $��0��.+��� $"��Time regeneration (seconds):��$��	Underline{�$
��Left=�$	��Top=�$��
10 10 10 5q�$��30(��� -   $��TextBoxCustom��$��
20,82,20,8q�$��25��$y�Visible=�$��18(��� 
 �� Orientation$
 
Horizontal=�$��Center=�$��Center=�.+��� -   $��CheckBox30Clicks��$��30��$��	20 20 0 0q� � LayoutTransform ��  �� ScaleX$	 1.2Q� �� ScaleY$	 1.2Q��� -	   $��CheckBox40Clicks��$��40��$��	20 20 0 0q� �� $	 1.2Q�$	 1.2Q��� -
   $��CheckBox50Clicks��$��50��$��	20 20 0 0q� �� $	 1.2Q�$	 1.2Q��� -   $��CheckBoxCustom��$��Custom��$��	20 20 0 0q� �� $	 1.2Q�$	 1.2Q��� -   $��
ButtonBack��  RoundButtonTemplate#��[ $
��Left=�$��Bottom=�$��	30 0 0 30q�$
��Back��$��1���� -   $��ButtonStart��#��[ $��Right=�$��Bottom=�$��	0 0 30 30q�$��Start��$��1���� -   $��ButtonLeaderBoard��#��[ $��Center=�$��Bottom=�$��0,0,0,30q�$��Leaderboard��$��1��