   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5          quanlynhasach.Hoadon   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:quanlynhasach     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .��5
      � 
������ $��0,8,0,-8q�6$     � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   .+�5   
   �� $��Hóa đơn
��6   $
��Left=�6,   $	��Top=�6G   $��76��6_   $	��294��6k   $��	24,18,0,0q�6w   
�������$��50(�6�   �� 5   
    �� CornerRadius$ 15��6   
�������$��398,52,190,68q�66   ._�5      � $��	0,0,-61,0q�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ Magnify=�6(      FuntButtonIcon#��[  67   $��	350,0,0,0q�6_   $��34��6r   $��21��6~    J� RenderTransformOrigin$ 	0.619,0.5&�6�   �� 5      -   5         ��Name$ txtSearchHD��5      $��Tìm kiếm��6/   $��Center=�6?   
���   �$��
10,0,115,0q�6m   $��16(�6�   $��0,0,0,0q�6�    �� SelectionBrush 6�   Z� ��6�   Z� 6�   5      5      �� 5   
   -   5         ��Name$ btnAddHoadon��5        ButtonFunction#��[ 6'   $
��Left=�6P   $��162,114,0,0q�6k   $	��Top=�6�   $	��171��6�   $��36��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5        $ 
PlusCircle=�6(   #��[  6:   �� 5      $��Thêm hóa đơn��6   $��20(�60   5      5      �� 5!   
   -   5        $ 
btnChitiet��5!      #��[ 6%   $
��Left=�6N   $��387,114,0,0q�6i   $	��Top=�6~   $	��171��6�   $��36��6�   .��5"      �� $ 
Horizontal=�6   .+�5#        $ AlertBoxOutline=�6(   #��[  6?   �� 5$      $��Chi tiết hóa đơn��6   5%      5&      &   System.Windows.Controls.DataGrid  5'   
   -   5        	  Name$	 dgHoadon��5'      $��Center=�6%   $	��436��6B   $��0,13,0,0q�6O   $	��Top=�6a   $	��656��6y   
   AutoGenerateColumns
 .  $��1��6�      
IsReadOnly . ��5(      �� 5)       �� Color$ White��6"    �� Opacity$	 0.5Q�60      Columns 5+      0  *System.Windows.Controls.DataGridTextColumn  5,      ,  &System.Windows.Controls.DataGridColumn   Header$ MÃ HÓA ĐƠN��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 69   �� *
MAHOADON+6V     5-      $ TÊN KHÁCH HÀNG��6%   $	 150 6^    6=   �� *TENKHACHHANG+6^     5.      $ NGÀY LẬP��6%   $	 150 6S    67   �� *	NGAYLAP+6S     5/      $ NHÂN VIÊN LẬP HĐ��6%   $	 150 6a    6?   �� *NHANVIENLAPHD+6a     50      $ TỔNG TIỀN��6%   $	 110 6U    68   �� *
TONGTIEN+6U   52      �� 53   
   -   5        $ Search��53      #��[ 6!   $
��Left=�6J   $��
825,55,0,0q�6e   $	��Top=�6y   $	��108��6�   $��31��6�   .��54      �� $ 
Horizontal=�6   .+�55        $ TextBoxSearch=�6(   #��[  6=   $��16��6e   $��16��6q   �� 56      $��Tìm kiếm��6   $��81��6-   57      58      59      5:      