   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5          quanlynhasach.Sanpham   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:quanlynhasach     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .��5
      � 
������   � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   .+�5   
   ��  �� CornerRadius$ 15��6   
�������$��706,48,71,69q�66    J� RenderTransformOrigin$ 0.421,0.643&�6L   ._�5      � $��	0,0,-61,0q�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Magnify=�6(      FuntButtonIcon#��[  67   $��	170,3,0,0q�6_   $��34��6r   $��20��6~   $ 	0.619,0.5&�6�   $	��Top=�6�   �� 5      -   5         ��Name$ txtSearchSP��5      $��Tìm kiếm��6/   $��Center=�6?   $��	10,0,99,0q�6Z   $��16(�6m    �� SelectionBrush �	#FF049DFF$��0,0,0,0q�6�   ���	#FF403F3F��6�   Z� ��6�   Z� 6  5      5      �� 5   
   -   5         ��Name$ btnTimkiemSP��5        ButtonFunction#��[ 6'   $
��Left=�6P   $��
921,48,0,0q�6k   $	��Top=�6   $��40��6�   $��36��6�   ���	#FF2CA913.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5        $ TextBoxSearch=�6(   #��[  6=   �� 5      $�� ��6   5      5      �� 5   
   $)��#Quản lý sản phẩm văn phòng��6   $
��Left=�65   $	��Top=�6P   $��76��6h   $	��713��6t   $��	24,18,0,0q�6�   
�������$��50(�6�   �� 5    
   -   5        #��[ 5       $
��Left=�6:   $��
46,114,0,0q�6U   $	��Top=�6i   $��90��6�   $��36��6�   ���	#FF19D468.��5!      �� $ 
Horizontal=�6   .+�5"        $ 
PlusCircle=�6(   #��[  6:   �� 5#      $��Thêm��6   5$      5%      �� 5&   
   -   5        $ BtnSuasanpham��5&      #��[ 6(   $
��Left=�6Q   $��240,114,0,0q�6l   $	��Top=�6�   $��78��6�   $��36��6�   ���	#FF19D468.��5'      �� $ 
Horizontal=�6   .+�5(        $ Wrench=�6(   #��[  66   �� 5)      $��Sửa��6   5*      5+      �� 5,   
   -   5        $ BtnXoaSP��5,      #��[ 6#   $
��Left=�6L   $��428,114,0,0q�6g   $	��Top=�6|   $��81��6�   $��36��6�   ���	#FF19D468.��5-      �� $ 
Horizontal=�6   .+�5.        $ TrashCan=�6(   #��[  68   �� 5/      $
��Xóa��6   50      51      �� 52   
   -   5        $ 	btnLammoi��52      #��[ 6$   $
��Left=�6M   $��625,114,0,0q�6h   $	��Top=�6}   $��38��6�   $��36��6�   ���	#FF2CA913.��53      �� $ 
Horizontal=�6   .+�54        $ Refresh=�6(   #��[  67   �� 55      56      57      &   System.Windows.Controls.DataGrid  58   
   -   5        	  Name$	 	dgSanpham��58      $	��436��6&   $��0,13,0,0q�63   $	��Top=�6E   
   AutoGenerateColumns
 .  $��1��6y   $��Center=�6�   $	��980��6�      
IsReadOnly . $��18(�6�      Columns 59      0  *System.Windows.Controls.DataGridTextColumn  5:      ,  &System.Windows.Controls.DataGridColumn   Header$ MÃ SẢN PHẨM��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6X   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6:   �� *	MASANPHAM+   ElementStyle 5;      �� 5<       �� 
TargetType" ��6    .�5=      ��  �� Property � �� �� Value$ 18(�69   5>      5@        5A      $ TÊN SẢN PHẨM��6%   $	 250 6Z    6;   �� *
TENSANPHAM+ 5B      �� 5C      " ��6    .�5D      ��  � ��$ 18(�69   5E      5G        5H      $ SỐ LƯỢNG��6%   $	 200 6S    67   �� *	SOLUONG+ 5I      �� 5J      " ��6    .�5K      ��  � ��$ 18(�69   5L      5N        5O      $ GIÁ NHẬP ( VNĐ )��6%   $	 200 6[    6?   �� *	GIANHAP+ 5P      �� 5Q      " ��6    .�5R      ��  � ��$ 18(�69   5S      5U        5V      $ GIÁ BÁN ( VNĐ )��6%   $	 200 6Y    6>   �� *GIABAN+ 5W      �� 5X      " ��6    .�5Y      ��  � ��$ 18(�69   5Z      5\      5^      5`      5a      