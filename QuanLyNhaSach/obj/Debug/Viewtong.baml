   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5   	       quanlynhasach.Viewtong   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:quanlynhasach     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  Quản lý nhà sách��5	   	   $	��873��6"   $
��1280��6/   .��5
      �� ��5   
   �� 5       �� ImageSource$ /background.jpg��6   ._�5   
   �  � RowDefinitions 5      �� 5      $
��473* �6    �� 5      $
��384* �6     � ColumnDefinitions 5      �� 5      $	��15* �6#   �� 5      $	��49* �6#   .+�5      �� ���	#FF19AED4 �� CornerRadius$ 	0 50 50 0��6-   $��0,84,0,0q�6F   $��2��6X   ._�5      ]� .+�5      �� $	��100��6   $��80��6)    �� Padding$ 3q�65   
�������$	 100��6T   $	��Top=�6g   $
��Left=�6|   $��
20 -30 0 0q�6�   ._�5      A� ��5      �� 5   "   $ /1.png��6-   5      5      �� 5       $��BookStore Group 5��6    
�������$��22(�6L   $��SemiBold"�6Z   $	��Top=�6p   $��10q�6�    �� TextAlignment$ Center=�6�   �� 5!      $��25q�6    $	��Top=�6,   $��5��6A   
�������6a   �� 5"      $	��Top=�6!   .+�5#      	� -   5         	�Name$ TrangchuButton��5#   &    	� 	GroupName$ 	MenuGroup��6>      
menuButton#��[  6T   	 d� 	IsChecked	 6x   Z� .��5$      �� 
 �� Orientation$
 
Horizontal=�6)   .+�5%   "   .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$
 Home=�68     menuButtonIcon#���  6D   �� 5&   "   $��Trang chủ��6,   5'      5(      	� 5)      -   5        $ QuanlysachButton��5)   &   $ 	MenuGroup��6@   #��[  6W   .��5*      �� $
 
Horizontal=�6)   .+�5+   "     $
 Book=�68   #���  6D   �� 5,   "   $��Quản lý sách��6,   5-      5.      	� 5/      -   5        $��Sanpham��5/   &   $ 	MenuGroup��65   #��[  6K   .��50      �� $
 
Horizontal=�6)   .+�51   "     $ Pencil=�68   #���  6F   �� 52   "   $��Sản phẩm��6,   53      54      	� 55      -   5        $��
btnThongke��55   &   $ 	MenuGroup��68   #��[  6O   .��56      �� $
 
Horizontal=�6)   .+�57   "     $ ChartBar=�68   #���  6H   �� 58   "   $��Thống kê��6,   59      5:      	� 5;      -   5        $��	btnHoadon��5;   &   $ 	MenuGroup��67   #��[  6M   .��5<      �� $
 
Horizontal=�6)   .+�5=   "     $
 Note=�68   #���  6D   �� 5>   "   $��
Hóa đơn��6,   5?      5@      	� 5A      -   5        $ btnTaikhoan��5A   &   $ 	MenuGroup��6;   #��[  6Q   .��5B      �� $
 
Horizontal=�6)   .+�5C   "     $ Account=�68   #���  6G   �� 5D   "   $��Tài khoản��6,   5E      5F      5G      	� 5H      -   5        $ btnDangxuat��5H   "   $ 	MenuGroup��67   #��[  6M   $��Bottom=�6q   $��Bottom=�6�   .��5I      �� $
 
Horizontal=�6%   .+�5J        $ Power=�64   #���  6A   �� 5K      $��Đăng xuất��6(   5L      5M      5N      5O      �� 5P      
������ $��1��6.   $��2��6>   ._�5Q      �� -   5         ��Name$ Control��5Q   !   $	��770��62   $	��Top=�6?   $��0,87,0,0q�6W   5R      5S      5T      5U      