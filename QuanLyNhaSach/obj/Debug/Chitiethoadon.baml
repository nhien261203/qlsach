   M S B A M L   `   `   `  ����H  Dquanlynhasach, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:quanlynhasachquanlynhasach  5   	   !    quanlynhasach.Chitiethoadon   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:quanlynhasach     5   	     � Title$  Chi Tiết Hóa Đơn��5   	   $	��400��6"   $	��900��6/   .��5	      � 
����� �$	��984��6   $��Center=�6*   $
��Left=�6E   $
��1100��6`   .+�5
   
   �� $��Chi tiết hóa đơn��6   $
��Left=�6+   $	��Top=�6F   $��36(�6^   $��51��6l   $��330,322,0,0q�6x   $	��274��6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ dgChiTietHD��5      $
��Left=�6(   $��
58,472,0,0q�6C   $	��Top=�6W   $	��772��6o   $��16(�6{      AutoGenerateColumns .  $	��185��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�      
IsReadOnly . z�5      V� 5      .~�5      �� �� 5       �� AngleY$ 0.053Q�6$   �� 5      T� 5       T� Y$ 0.457Q�6)   5         Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Mã hóa đơn��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$		 100 6V   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 69   �� *
MAHOADON+6V     5      $ Mã sản phẩm��6%   $		 110 6Y   
 6:   �� *	MASANPHAM+6Y     5      $ Tên sản phẩm��6%   $		 250 6Z   
 6;   �� *
TENSANPHAM+6Z     5      $ SL��6%   $	 50 6O   
 61   �� *	SOLUONGSP+6O     5      $ 
Đơn Giá��6%   $		 110 6Q   
 66   �� *GIABAN+6Q     5      $ Thành Tiền��6%   $		 150 6W   
 69   �� *	THANHTIEN+6W   5      �� 5   
   $$��Nhân viên lập hóa đơn :��6   $
��Left=�62   $��
59,389,0,0q�6M   $	��Top=�6a   $��18(�6y   �� 5   
   $��Tên khách hàng :��6   $
��Left=�6+   $��
59,431,0,0q�6F   $	��Top=�6Z   $��18(�6r   �� 5   
   -   5        $��nhanvien��5      $
��Left=�6    $��267,389,0,0q�6;   $	��Top=�6P   $��18(�6h   �� 5    
   -   5        $��tenkhachhang��5       $
��Left=�6$   $��207,431,0,0q�6?   $	��Top=�6T   $��18(�6l   5!      5"      