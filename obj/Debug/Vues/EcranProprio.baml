   M S B A M L   `   `   `  ����B  >Bourses, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Bourses.VuesBourses.Vues  5          Bourses.Vues.EcranProprio   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Bourses.Vues     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $��30 �6   6*   �� 5      $��90 �6   6*   �� 5      $��30 �6   6*   �� 5      $	��100 �6   6+   �� 5      $��* �6   6)    � ColumnDefinitions 5   
   �� 5      $	��150 �6   6-   �� 5      $	��400 �6   6-   �� 5      $��* �6   6+   .+�5   
   �� $��2��6   $��24(�6(   
����  �
��� ���!Les Propriétaires Capitalistes6|   �� 5   
   $��1��6r   $��0��6   $��4��6�   ��6   �� *SommaireProprietaires+ �� SelectedItem 6A   �� *ProprietaireSelectionne+��5      �� 5      .R�5      ��  �� Orientation$ Vertical=�6!   .+�5      �� $��14(�6$   ��62   �� *Nom+6I   5      5       5"      � 5$   
   $��1��6   $��1��6     5%      �� 5&      $
��auto �6    60   �� 5'      $
��auto �6    60   �� 5(      $
��auto �6    60    5*      �� 5+      $
��auto �6#   62   �� 5,      $��* �6#   6/   �� 5-      $��* �6#   6/   .+�50      �� $	��Nom��6   6$   �� 51      -   5        $��txt_Nom��51      $��1��6%   ��65   �� *Nom+6L   �� 53      $��Date de naissance��6   $��1��60   6?   �� 54      -   5        $��txt_Naissance��54      $��1��6+   $��1��6;   ��6H   �� *	Naissance+ �� StringFormat$ 
yyyy-MM-dd��6~   �� 56      $��Capitaux disponible��6   $��2��62   6A   �� 57      -   5        $��txt_Capitaux��57      $��1��6*   $��2��6:   ��6G   �� *	Liquidite+6d   58      �� 5:   
   $��2��6   $��4��6%   .+�5;      �� -   5        $��Ajouter��5;      6C   �� 5<      -   5        $��Modifier��5<      6E   �� 5=      -   5        $��	Supprimer��5=      6G   �� 5>      -   5        $��Vider��5>      6?   5?      5C      5D      