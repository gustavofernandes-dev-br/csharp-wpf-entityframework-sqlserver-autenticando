   M S B A M L   `   `   `  ����A  =NewPDV, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:NewPDVNewPDV  5   	   $    NewPDV.Formularios.wpfUsuarios   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   &localclr-namespace:NewPDV     5   	   -   5          �Name$  frmUsuarios��5   	      WindowControlTemplate1#���   5   	     	wpfPadrao#��[ 5	   	     PadraoBackGround#���  5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � Title$ 	Usuários��6.   .��5      � $��0q�6     GridForm#��[ 6   .+�5   
   � -   5         �Name$ quaDados��5   !   $��20,0,0,0q�6   $y�Visible=�63   .+�5      � $��80��6   $	��Top=�6   .+�5      ��  �� Orientation$ 
Horizontal=�6   $��Right=�66   .+�5      �� -   5         ��Name$ 	btnSalvar��5      $	��120��61   $��40��6=   $��Right=�6I   $��5q�5        BotaoPadrao#��[ 5      .��5      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�5      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $��/imagens/white/Salvar.png��6|   �� 5      $��Center=�6(   $��5q�6C   Salvar6V   5      5      �� 5      -   5        $ 	btnVoltar��5      $	��120��61   $��40��6=   $��Right=�6I   $��5q�5      #��[ 5      .��5      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�5      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $��/imagens/white/voltar.png��6|   �� 5      $��Center=�6(   $��5q�6C   Voltar6V   5      5      5!      5"      � 5%      $��0,80,0,0q�6   $��60��6%   $	��Top=�61   .+�5&      ��   fonteFamilia#���  6   .��6D   	Código6L   �� 5'        TextBox#��[ 6   $��Bottom=�6=   $
��Left=�6X   $��5q�6s   $��50��6   $��30��6�   6�   �� 5(      #���  6   $��65,0,0,0q�6D   .��6V   
Usuário6_   �� 5)      #��[ 6   $��70,0,0,5q�6<   $��Bottom=�6N   $
��Left=�6i   $	��200��6�   6�   5*      5+      � 5-   
   -   5        $ quaPesquisa��5-       $��0,0,0,0q�6   $y�	Collapsed=�65   .+�5.      � $��80��6   $	��Top=�6   .+�5/      �� $ 
Horizontal=�6   $��Right=�66   .+�50      �� -   5        $ 
btnIncluir��50      $	��120��62   $��40��6>   $��Right=�6J   $��5q�51      #��[ 52      .��53      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�54      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $��/imagens/white/add.png��6|   �� 55      $��Center=�6(   $��5q�6C   	Incluir6W   56      57      �� 58      -   5        $ 
btnAlterar��58      $	��120��62   $��40��6>   $��Right=�6J   $��5q�59      #��[ 5:      .��5;      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�5<      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $��/imagens/white/editar.png��6|   �� 5=      $��Center=�6(   $��5q�6C   	Alterar6W   5>      5?      �� 5@      -   5        $ btnConsultar��5@      $	��120��64   $��40��6@   $��Right=�6L   $��5q�5A      #��[ 5B      .��5C      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�5D      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $"��/imagens/white/consultar.png��6|   �� 5E      $��Center=�6(   $��5q�6C   	Consultar6Y   5F      5G      �� 5H      -	   5        $ 
btnExcluir��5H      $	��120��62   $��40��6>   $��Right=�6J   $��5q�5I      #��[ 5J      .��5K      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�5L      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $ ��/imagens/white/delete1.png��6|   �� 5M      $��Center=�6(   $��5q�6C   	Excluir6X   5N      5O      �� 5P      -
   5        $ btnSair��5P      $	��120��6/   $��40��6;   $��Right=�6G   $��5q�5Q      #��[ 5R      .��5S      �� $	��100��6%   $ 
Horizontal=�61   $
��Left=�6J   .+�5T      �� $��Center=�6$   $��5q�6?   $
��Left=�6J   $��20��6e   $��20��6p   $��/imagens/white/exit.png��6|   �� 5U      $��Center=�6(   $��5q�6C   Sair6T   5V      5W      5X      5Y      � 5Z      $��3,80,3,5q�6   .+�5[      � $��0,0,0,0q�6   .+�5\      �� $	��Top=�6   $	��100��65   #���  6B   $��1q�6s   5]      � 5_      $	��100��6   $	��Top=�6(   .+�5`      �� -   5        $ BtnPesquisar��5`   !   $	��130��68   $��40��6D   $��Right=�6P   $��5q�5a      #��[ 5b      .��5c      �� $	��100��6)   $ 
Horizontal=�65   $
��Left=�6N   .+�5d   "   �� $��Center=�6(   $��5q�6C   $
��Left=�6N   $��20��6i   $��20��6t   $!��/imagens/white/procurar.png��6�   �� 5e   "   $��Center=�6,   $��5q�6G   
Procurar6\   5f      5g      5h      � 5j      -   5        $ quaPesquisa_Grid��5j      $��	0,100,0,0q�65   .+�5k      &   System.Windows.Controls.DataGrid  -   5          Name$ gridUsuario��5k   #      AutoGenerateColumns .   �� AlternationCount$ 2��5m   #   	   SelectionUnit$	 FullRow=�5n   #   
   SelectionMode$
 Extended=�5o   #     columnHeaderStyle   ColumnHeaderStyle# �  5p   #     rowStyle   RowStyle# �  5q   #   $��0q�5r   #      CanUserAddRows .  ��5t   $   ��    Columns 5v      0  *System.Windows.Controls.DataGridTextColumn  5x   "   ,  &System.Windows.Controls.DataGridColumn   Header$ Id��6T      Width5  /System.Windows.Controls.DataGridLengthConverter$ 70 6`      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *
USU_CODIGO+6k     5y   "   $ Usuário��6U   $	 150 6f    .  65   �� *USU_USUARIO+6r     5z   "   $ Atualização��6Y   $	 150 6n    .  65   �� *USU_ATUALIZACAO+6z   4  .System.Windows.Controls.DataGridCheckBoxColumn  5{   "   $ Inativo��6Y    . $ 60 6|    69   �� *USU_INATIVO+6|   4  .System.Windows.Controls.DataGridTemplateColumn  5|   "   $ Alterar��69   $ 80 6J      CellTemplate 5}   &   �� 5~   *   .R�5   .   �� $ GridAlterar��6�   -   5        #���  5   5   $��Center=�6[   $��Alterar��6   6�   5�   +   5�   #     5�   "   $ Excluir��69   $ 80 6J    5�   &   �� 5�   *   .R�5�   .   �� #��[ 65   $��Center=�6Z   $��Excluir��6~   5�   +   5�   #     5�   "   $  ��66    . $ * 6R   5�      5�      5�      5�      5�      5�      5�      