   M S B A M L   `   `   `  ���� K  GdonttapNewDesign, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:donttapNewDesign.PagesdonttapNewDesign.Pages  )    #donttapNewDesign.Pages.SettingsPage   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     6local$clr-namespace:donttapNewDesign.Pages     -     N� Title$  
MainWindow�� 
  Height#��[   	 Width#��[  N� 
Background
 ���� .����   MainBorderTemplate#��[ ._��  � RowDefinitions �� $��8* ��� $	��27* �.+���   TitleBorderTemplate#��[ ._�� .+�� -     MouseDownGridTemplate#��[ .+��� -     xButtonTemplate#��[ �� -     _ButtonTemplate#��[ �� -   $��TextBlockTitle��$��Settings��$��Center=�$��Center=�$��45(�$��0 0 0 10q� � Triggers :�  :� RoutedEvent$ Loaded��.[��� .���� .��W�  �� 
TargetName$ TextBlockTitle�� �� TargetProperty$ (TextBlock.Opacity)� W� From 0	 W� To 1	 g� Duration$	 0:0:0.75D�� $��1��.+��� $��Board size: ��$��24(�$
��Left=�$	��Top=�$��	20 20 0 0q��� -   $��TextBoxBoardSize��$��
30,57,30,0q�$��18(�$��25��$	��Top=��� $��
Box size: ��$��24(�$
��Left=�$	��Top=�$��	20,90,0,0q��� -   
 ��Name$
 TextBoxBoxSize��$��25��$��30,127,30,0q�$��18(�$	��Top=��� $��	Spacing: ��$��24(�$
��Left=�$	��Top=�$��
20,170,0,0q��� -   $
 TextBoxSpacingSize��$��25��$��30,207,30,0q�$��18(�$	��Top=��� -	   $��
ButtonBack��  RoundButtonTemplate#��[ $
��Left=�$��Bottom=�$��	30 0 0 30q�$
��Back���� -
   $��
ButtonSave��#��[ $��Right=�$��Bottom=�$��	0 0 30 30q�$
��Save��