   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	        quanlynhasach.Themtaikhoan   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   )localclr-namespace:quanlynhasach   5   	   5System&clr-namespace:System;assembly=mscorlib   5   	     � Title$  ThemTaiKhoan��5
   	   $	��450��6   $	��400��6+   .��5      � 
����� � � ColumnDefinitions 5   
   �� 5      �� 5      .+�5   
   �� -   5         ��Name$ btnThem��5         ButtonFunction#��[  6"   ���	#FF17D617$
��Left=�6b   $��129,323,0,0q�6}   $	��Top=�6�   $	��142��6�   $��37��6�   $��14(�6�   $��2��6�   .��5      ��  �� Orientation$ 
Horizontal=�6    J� RenderTransformOrigin$ 0.713,2.187&�62   .+�5      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ 
PlusCircle=�6(     FuntButtonIcon#��[ 6:   $��14(�6b   $��14��6p   $��19��6|   $ -2.043,1.808&�6�   �� 5      $��Thêm tài khoản��6   5      5      �� 5   
   $$��Nhập thông tin tài khoản��6   $
��Left=�63   $	��Top=�6N   $��33(�6f   $��2��6t   $	��400��6�   $��	11,10,0,0q�6�   �� 5   
   -   5         ��Name$ addTenTaiKhoan��5      $��144,92,28,0q�6*    �� TextWrapping$
 Wrap=�6?   $�� ��6S   $	��Top=�6[   $��30��6s   $��15(�6   $��2��6�   ���	#FFF3F3F36�   �� 5   
   $��Tên tài khoản :��6   $
��Left=�6*   $��	11,88,0,0q�6E   $	��Top=�6X   $��38��6p   $	��116��6|   $��16(�6�   �� 5   
   -   5        $ addTenNguoiDung��5      $��144,142,28,0q�6+   $
 Wrap=�6A   $�� ��6U   $	��Top=�6]   $��30��6u   $��15(�6�   $��2��6�   ���	#FFF3F3F36�   �� 5   
   $��Tên người dùng :��6   $
��Left=�6+   $��
11,138,0,0q�6F   $	��Top=�6Z   $��38��6r   $	��128��6~   $��16(�6�   �� 5    
   -   5        $ 
addMatKhau��5       $��144,197,28,0q�6&   $
 Wrap=�6<   $�� ��6P   $	��Top=�6X   $��30��6p   $��15(�6|   $��2��6�   ���	#FFF3F3F36�   �� 5!   
   $��Mật khẩu :��6   $
��Left=�6%   $��
11,193,0,0q�6@   $	��Top=�6T   $��38��6l   $	��116��6x   $��16(�6�   �� 5"   
   -   5         ��Name$ addPhanQuyen��5"      $��144,248,28,0q�6)   	 �� Text$	  ��6@   $	��Top=�6H   $��30��5#      $��15(�6   $��2��6-   
�������.@�5$      �� $��admin��6   �� 5%      $
��user��6   5&      �� 5'   
   $��Phân quyền :��6   $
��Left=�6'   $��
11,244,0,0q�6B   $	��Top=�6V   $��38��6n   $	��116��6z   $��16(�6�   5(      5)      