   M S B A M L   `   `   `  ����  LightsOutWPF    LightsOutWPF.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  LightsOutWindow��5   	    � Title$ 
MainWindow��5   	   $	��410��6   $	��340��6)   $	��340��65   $	��410��6D   $	��340��6T   $	��410��6c    � WindowStartupLocation$ CenterScreen=�6s    � Icon$ icon.ico��6�    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ Close��5      6)     5   
   -   5        $	 New��5      6'   .��5	      � -   5        $��MainGrid��5	      .+�5
   
   o� -   5        $
��Menu��5
      $��20��6   $��	0,0,0,350q�6'   $��20��6:   $��20��6I   $	��Top=�6X   $
��Left=�6p   ��5      �� 5      .R�5      ]� $��Stretch=�6    5      .@�5      m� $��_Game��6   .@�5      m� $��	_New Game��6    m� Command$	 New��6.   m� 5      $��E_xit��6   $ Close��6*   5      m� 5      $��_Help��6   $
��Left=�6&   .@�5      m� -   5         m�Name$ About��5      $��_About��6*   6:   5      5      �� 5   
   -   5        $��paintCanvas��5      $	��Top=�6$   $
��Left=�6<   $��	10,30,0,0q�6y   �� 5   
   $��New Game��6   $	��New��6$   $
��Left=�62   $	��Top=�6M   $��75��6e   $��
50,342,0,0q�6p   �� 5   
   $
��Exit��6   $��Close��6    $
��Left=�60   $	��Top=�6K   $��75��6c   $��203,342,0,0q�6n   5      5      