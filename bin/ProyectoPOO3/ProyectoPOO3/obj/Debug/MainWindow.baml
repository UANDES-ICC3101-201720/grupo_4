   M S B A M L   `   `   `  ����G  CProyectoPOO3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ProyectoPOO3ProyectoPOO3  5   	       ProyectoPOO3.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ProyectoPOO3     5   	     � Title$  Mall Simulator��5   	   $	��750��6    $
��1280��6-    � WindowStyle$ ThreeDBorderWindow=�6:    � 
ResizeMode$ CanResizeWithGrip=�6[   ��5	      �� 5
   
    j� Stretch$ Uniform=�6   .��5      �  � ColumnDefinitions 5   
   �� 5      $
��190* �6   �� 5      $
��447* �6   ��5   
   �� 5       �� ImageSource$ 
imagen.jpg��6   .+�5   
   �� -   5        $��PassDay��5      $y�Hidden=�6    $��Siguiente Dia��64   $��Center=�6L   $��45,361,68,0q�6i   $	��Top=�6~   $	��267��6�   ���	#FFF5EBEB$��70��6�   ���	#FFF5E5E5$
��Bold"�6�   $��25(�6�   6�   �� 5   
   -   5        $��DiaLabel��5      $y�Hidden=�6    $��Center=�65   $��24(�6R   $��66,25,203,599.4q�6`   $�� Dia 1��6y   $��Center=�6�   
������� � Cursor$
 Help��6�   $��46��6�   $	��111��6�   $
��Bold"�6�   �� 5   
   -   5        $��GuardarArchivo��5      $y�Hidden=�6'   $��Guardar en Archivo��6;   $
 Hand��6X   $��24(�6f   $
��Left=�6t   $��467,204,0,0q�6�   $	��Top=�6�   $	��267��6�   ���	#FFF5EBEB$��72��6�   ���	#FFF5E5E5$
��Bold"�6   $��1��62  �� 5   
   -   5        $��Reportes��5      $y�Visible=�6!   $��Reportes��66   $
 Hand��6I   $��24(�6W   $��Center=�6e   $��45,491,68,107.4q�6�   $��Center=�6�   $	��267��6�   ���	#FFF5EBEB$��72��6�   ���	#FFF5E5E5$
��Bold"�6  �� 5   
   -   5        $��
Simulacion��5      $y�Visible=�6#   $��Iniciar Simulacion��68   $
 Hand��6U   $��24(�6c   $��Center=�6q   $��45,356,68,242.4q�6�   $��Center=�6�   $	��267��6�   ���	#FFF5EBEB$��72��6�   ���	#FFF5E5E5$
��Bold"�6"  �� 5   
   -   5        $��Datos��5      $y�Hidden=�6   $��Simular��62    ^� InitialShowDelay$
 5000��6D   $
 Hand��6m   $��24(�6{   $
��Left=�6�   $��
45,361,0,0q�6�   $	��Top=�6�   $	��267��6�   ���	#FFF3EFEF$��70��6  ���	#FFF5E5E5$
��Bold"�6+  �� 5   
   -   5        $��SimularSerializable��5      $y�Hidden=�6,   $��Iniciar Por Archivo��6@   $
 Hand��6^   $��24(�6l   $
��Left=�6z   $��
45,226,0,0q�6�   $	��Top=�6�   $	��267��6�   ���	#FFF5EBEB$��72��6  ���	#FFF5E5E5$
��Bold"�6*  �� 5   
   -   5        $��Plano��5      $y�Visible=�6   $��Plano��63   $
 Hand��6C   $��Center=�6Q   $��45,231,68,369.4q�6n   $��Center=�6�   $��24(�6�   $	��267��6�   $��70��6�   ���	#FFF9F9F9$
��Bold"�6�    � IsSharedSizeScope .  
�������6%  �� 5   
   -	   5        $��Titulo_Principal��5      $y�Hidden=�6(   $��Opciones De Mall��6<   $��Center=�6W   $��25(�6{   $��Center=�6�   ���	#FFF9F9F9$��46,171,67,448.4q�6�   $��Center=�6�   $��51��6�   $	��267��6�   &   System.Windows.Media.TextOptions	   TextHintingMode$	 Fixed=�6
  �� 5   
   -
   5        $��
PisosLabel��5      $y�Visible=�6"   $��25(�67   $��Center=�6E   $��Center=�6i   $��Ingrese Cantidad de Pisos��6�   $��Center=�6�   $��369,103,384.6,537.8q�6�   $��Center=�6�   ���	#FFF9F9F9$��80��6  $	��520��6'  $��2��63  �� 5   
   -   5        $��	PisosText��5      $y�Hidden=�6#   $��Center=�67   $��Center=�6Y   $��Center=�6}   $��Center=�6�   $��38��6�   $��202,211,597.6,421.4q�6�   
 �� TextWrapping$

 Wrap=�6�   $��94��6�   ���	#FFF5F0F0
���   � J� RenderTransformOrigin$ 0.441,0.448&�6F  $��25(�6j  $��1��6x  �� 5   
   -   5        $��
EnterPisos��5      $y�Hidden=�6#   $��Enter��67   $
 Hand��6G   $��Center=�6V   $��159,563,574.6,34.4q�6s   $��Center=�6�   $	��160��6�   ���	#FFF3E7E7���	#FFA45050$��73��6�   $��22(�6
  $
��Bold"�6  $��1��6*  �� 5    
   -   5        $��
EnterAreas��5       $y�Hidden=�6#   $��Enter��67   $
 Hand��6G   $��Center=�6U   $��159,565,574.6,37.4q�6r   $��Center=�6�   $	��160��6�   ���	#FFF5EEEE���	#FFA45050$��68��6�   $��22(�6  $
��Bold"�6  $��1��6(  �� 5!   
   -   5        $��EnterTiendas��5!      $y�Hidden=�6%   $��Enter��69   $
 Hand��6I   $��Center=�6W   $��159,562,574.6,35.4q�6t   $��Center=�6�   $	��160��6�   ���	#FFF5ECEC���	#FFA45050$��73��6  $��22(�6  $
��Bold"�6  $��1��6-  �� 5"   
   -   5        $��EnterTiendasArea��5"      $y�Hidden=�6)   $��Enter��6=   $
 Hand��6M   $��Center=�6[   $��159,563,574.6,43.4q�6x   $��Center=�6�   $	��160��6�   
����������	#FFA45050$��64��6  $��22(�6  $
��Bold"�6  $��1��61  �� 5#   
   -   5        $��Panel��5#      $y�Visible=�6"   $
��Left=�67   $	��353��6R   $��369,183,0,0q�6_   $	��Top=�6t   $	��509��6�   $��2��6�   ��6�   Z� 6�   �� 5$   
   -   5        $��	EnterMall��5$      $y�Hidden=�6#   $��25(�67   $
��Bold"�6E   $��Enter��6W   $
��Left=�6g   $��158,561,0,0q�6�   $	��Top=�6�   $	��160��6�   ���	#FFA45050$��73��6�   ���	#FFD6D6D6$��1��6  �� 5%   
   -   5        $��TiendasGrid��5%      $y�Hidden=�6&   $
��Left=�6:   $��	66,71,0,0q�6U   $	��Top=�6h   $	��390��6�   $��2��6�   �� 5&   
   -   5        $��ReportesComboBox��5&      $y�Hidden=�6+   $
��Left=�6?   $��	66,71,0,0q�6Z   $	��Top=�6m   $	��390��6�   $��2��6�   �� 5'   
   -   5        $��AllPanel��5'      $y�Hidden=�6%   $
��Left=�69   $	��280��6T   $��	45,71,0,0q�6a   $	��Top=�6t   $
��1148��6�   $��2��6�   �� 5(   
   -   5        $
��Back��5(   "   $��Inicio��6   $y�Hidden=�6.   $
��Left=�6B   $��25(�6]   $
 Hand��6k   $
��Bold"�6y   $��127,567,0,0q�6�   $	��Top=�6�   $	��220��6�   $��67��6�   $��1��6�   �� 5)   
   -   5        $��salir��5)      $��Salir��6   $y�Visible=�6.   $��Center=�6C   $��510,491,131.6,107.4q�6`   $��Center=�6}   $	��252��6�   $��72��6�   $��24(�6�   $
��Bold"�6�   $��1��6�   �� 5*   
   -   5        $��Titulo_Inicial��5*      $y�Visible=�6&   $%��Bienvenido al Simulador de Mall��6;   $��30(�6e   ���	#FFF9F9F9$��46,56,410.6,0q�6�   $	��Top=�6�   $��Center=�6�   $��60��6�   $ -0.003,0.533&�6�   $��1��6  5-      5.      