   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5          quanlynhasach.Taikhoan   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:quanlynhasach     5      g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      .��5
      � 
������   � RowDefinitions  5   
   �� 5      $��1* �6   �� 5      $��4* �6    � ColumnDefinitions 5   
   �� 5      $��1* �6   .+�5   
   �� $��Cập Nhật Tài Khoản��6   $
��Left=�6-   $	��Top=�6H   $��76��6`   $	��546��6l   $��	24,18,0,0q�6x   
�������$��50(�6�   �� 5   
   -   5         ��Name$ btnThemtaikhoan��5         ButtonFunction#��[  6*   $
��Left=�6S   $��
24,264,0,0q�6n   $	��Top=�6�   $	��163��6�   $��44��6�   $��1��6�   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ 
PlusCircle=�6(     FuntButtonIcon#��[ 6:   �� 5      $��Thêm tài khoản��6   $��26��62   $	��126��6>   5      5      &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ 
dgTaiKhoan��5      $
��Left=�6'   $	��231��6B   $	��Top=�6O   $	��980��6g   $��1��6s      AutoGenerateColumns .  $��16(�6�      
IsReadOnly . ��5      �� 5       �� Color$ White��6"   	 �� Opacity$		 0.5Q�60   
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ TÊN TÀI KHOẢN��6%      Width5  /System.Windows.Controls.DataGridLengthConverter$	 250 6]   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6<   �� *TENTAIKHOAN+6]     5      $ TÊN NGƯỜI DÙNG��6%   $	 250 6^    6=   �� *TENNGUOIDUNG+6^     5       $ MẬT KHẨU��6%   $	 250 6S    67   �� *	MATKHAU+6S     5!      $ PHÂN QUYỀN��6%   $	 250 6W    69   �� *	PHANQUYEN+6W   5#        5$   
   $ Account=�6    #��[ 6/   $��
78,330,0,0q�6W   $	��Top=�6k   $��1��6�   $��24��6�   $��24��6�   
�������6�     5%   
   $
 Lock=�6    #��[ 6,   $��
78,389,0,0q�6T   $	��Top=�6h   $��1��6�   $��24��6�   $��24��6�   
�������6�   �� 5&   
   $��Tên đăng nhập��6   $
��Left=�6)   $��121,324,0,0q�6D   $��1��6Y   $	��Top=�6f   $��20(�6~   
�������6�   �� 5'   
   $��Mật khẩu hiện tại��6   $
��Left=�6,   $��121,383,0,0q�6G   $��1��6\   $	��Top=�6i   $��20(�6�   
�������6�   �� 5(   
   $��Mật khẩu mới��6   $
��Left=�6'   $��121,436,0,0q�6B   $��1��6W   $	��Top=�6d   $��20(�6|   
�������6�   �� 5)   
   $$��Xác nhận mật khẩu mới��6   $
��Left=�60   $��121,490,0,0q�6K   $��1��6`   $	��Top=�6m   
�������$��20(�6�   �� 5*   
   -   5         ��Name$ txtTenDangNhap��5*      $
��Left=�5,      $��30��6-   $��359,331,0,0q�69    �� TextWrapping$
 Wrap=�6N   $	��Top=�6b   $	��302��6z   $��1��6�   $��16(�6�   $��Center=�6�    �� 
IsReadOnly . ��5+      �� *SelectedItem.TENTAIKHOAN+ �� ElementName$ 
dgTaiKhoan��5,   �   �� 5-   
   -   5        $ passwMKHienTai��5-      $
��Left=�5/      $��30��6-   $��359,383,0,0q�69   $	��Top=�6N   $	��302��6f   $��1��6r   $��Center=�6   $��16(�6�    . ��5.      �� *SelectedItem.MATKHAU+$ 
dgTaiKhoan��5/   �   G� 50   
   -   5         G�Name$ 
passwMKMoi��50      $
��Left=�6*   $��30��6E   $��359,439,0,0q�6Q   $	��Top=�6f   $	��302��6~   $��1��6�   $��16(�6�   $��Center=�6�   G� 51   
   -   5        $ passwNhapLai��51      $
��Left=�6,   $��30��6G   $��359,497,0,0q�6S   $	��Top=�6h   $	��302��6�   $��1��6�   $��16(�6�   $��Center=�6�   �� 52   
   -   5        #��[  52      
��� � �$
��Left=�6M   $��815,493,0,0q�6h   $	��Top=�6}   $	��116��6�   $��44��6�   $��1��6�   .��53      �� $ 
Horizontal=�6   .+�54        $ Check=�6(   #��[ 65   �� 55      $��Cập nhật��6   $��26��6,   $��85��68   56      57        58   
   $ LockPlus=�6    #��[ 60   $��
78,442,0,0q�6X   $	��Top=�6l   $��1��6�   $��24��6�   $��24��6�   
�������6�     59   
   $ 	LockCheck=�6    #��[ 61   $��
78,497,0,0q�6Y   $	��Top=�6m   $��1��6�   $��24��6�   $��24��6�   
�������6�   �� 5:   
   -   5        $ btnXoataikhoan��5:      #��[  6)   $
��Left=�6R   $��261,264,0,0q�6m   $	��Top=�6�   $��75��6�   $��44��6�   $��1��6�   ���	#FFD43319.��5;      �� $ 
Horizontal=�6   .+�5<        $ TrashCan=�6(   #��[ 68   �� 5=      $
��Xóa��6   $��26��6'   $��39��63   5>      5?      5@      5A      