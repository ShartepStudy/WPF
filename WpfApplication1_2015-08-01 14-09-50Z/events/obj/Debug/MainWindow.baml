   M S B A M L   `   `   `  ����
  events    events.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � Title$  
MainWindow��5   	   $	��450��6   $	��696��6)    � 	Resources 5       �� DataType$  System.Windows.RoutedEventArgs � ColumnDefinitions �� Mode d� 	IsChecked��%�  (��       5	      *, +)�� 6
   "  6   .R�5
      �  5      �� 5      $
��281* �6!   �� 5      $
��281* �6!   �� 5      $
��281* �6!   �� 5      $
��252* �6!   �� 5      $	��29* �6!   .+�5      �� $
��Wrap=�6   $
��5, 2q�6\   ��6-   �� *RoutedEvent.Name+$ OneWay=�6\   �� 5      $
��Wrap=�6   $
��5, 2q�6h   $��1��6v   ��6-   �� *RoutedEvent.HandlerType.Name+$ OneWay=�6v   �� 5      $
��Wrap=�6   $
��5, 2q�6E   $��2��6S   ��6-   �� *Source+6S   �� 5      $
��Wrap=�6   $��3��6-   �� 5      {�.  $��Center=�6H   $	��5,2q�6c   $��4��6p    6   �� *	Handled+6p   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��140 �6   �� 5      $��10 �6   �� 5       5    
   �� 5!      �� 5"      .+�5$   
   �� -   5         ��Name$ repeateButton��5$      $��Repeate Button��6.   $��0��6G   $��40q�6W   �� 5%   
   -   5         ��Name$ button��5%      $��Button��6!   $��1��62   $��40q�6B   �� 5&   
   -   5        	 ��Name$	 eventsListBox��5&      $��1��6)   $��2��66   $��2��6J   �� 5'   
   -   5        
 ��Name$
 gridSplitter��5'      $��Stretch=�6-    J� RenderTransformOrigin$ 0.5,0.5&�6K   $��2��6k   $��1��6   5(      5)      