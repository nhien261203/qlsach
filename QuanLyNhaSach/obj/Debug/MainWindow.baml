   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5   	       quanlynhasach.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:quanlynhasach     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	     � Title$  Quản lý nhà sách��5	   	   $	��450��6"   $	��850��6/   .��5
      � $
��Left=�6   $	��851��6&   $	��434��62   $	��Top=�6?    J� RenderTransformOrigin$ 0.396,0.504&�6W   ���	#FFEFF3E9 � ColumnDefinitions 5   
   �� 5      $
��369* �6   �� 5      $
��482* �6   .+�5   
   �� -   5         ��Name$ txtTaikhoan��5      $
��Left=�6'   $��
27,180,0,0q�6B    �� TextWrapping$
 Wrap=�6V   $�� ��6j   $	��Top=�6r   $	��276��6�   $��16(�6�   $��29��6�   $��Center=�6�    �� SelectionBrush
 �   �
���   �$��0,0,0,2q�6�   ���	#FFF2F3E86.  G� 5   
   -   5         G�Name$ 
txtMatkhau��5      $��Right=�6*   $��
0,251,66,0q�6F   $	��Top=�6Z   $	��276��6r    G� Password$  ��6~   $��16(�6�   $��30��6�   $��Center=�6�    G� SelectionBrush
 �   �
���   �$��0,0,0,2q�6�   ���	#FFEFF3E96"  �� 5   
   $��Tài khoản��6   $
��Left=�6$   $��
48,149,0,0q�6?   $	��Top=�6S   $��16(�6k   $
��Bold"�6y   $��96��6�   $��31��6�   .  (MahApps.Metro.IconPacks.PackIconMaterial  5   
   	   Kind$	 Account=�6       menuButtonIcon#���   6/   $��
29,157,0,0q�6X   $	��Top=�6l   $��15��6�   $��14��6�   �� 5   
   $ ��ĐĂNG NHẬP HỆ THỐNG��6   $��Center=�6-   $��0,70,0,0q�6J   $	��Top=�6\   $��24(�6t   $
��Bold"�6�   $��42��6�   $	��315��6�   �� 5   
   -   5        
 ��Name$
 btndangnhap��5        ButtonFunction#��[ 6&   $
��Left=�6O   $��
28,344,0,0q�6j   $	��Top=�6~   $	��142��6�   $��47��6�   ���	#FF19D42D.��5      ��  �� Orientation$ 
Horizontal=�6   .+�5        $	 Login=�6(     FuntButtonIcon#��[ 65   �� 5      $��Đăng nhập��6   $��20(�6-   5      5      �� 5   
   -   5        $
 btnthoat��5      #��[ 6#   $
��Left=�6L   $��209,344,0,0q�6g   $	��Top=�6|   $��93��6�   $��47��6�   ���	#FFD41919.��5      �� $ 
Horizontal=�6   .+�5        $	 Close=�6(   #��[ 65   �� 5      $��Thoát��6   $��20(�6)   5      5      �� 5!   
   $��1��6   $
��Left=�6    $��0,0,0,1q�6;   $	��478��6L   $	��435��6X   $��Bottom=�6e   $��/imglogin.gif��6�   �� 5"   
   $��Mật khẩu��6   $
��Left=�6#   $��
48,220,0,0q�6>   $	��Top=�6R   $��16(�6j   $
��Bold"�6x   $��96��6�   $��31��6�     5#   
   $
	 Lock=�6    #���   6,   $��
29,228,0,0q�6U   $	��Top=�6i   $��15��6�   $��14��6�   5$      5%      