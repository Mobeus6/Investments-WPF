   M S B A M L   `   `   `  ????U  QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5   	   H DWPFInvestment, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullI)clr-namespace:WPFInvestment.User_ControlsWPFInvestment.User_Controls 6J      WPFInvestment.MainWindow   5   	   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   X TFontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5   	   >lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5   	   2uc)clr-namespace:WPFInvestment.User_Controls  6J   -   5          ?Name$  homePage??5	   O   $	??740??5      $
??1280??6'    ? WindowStartupLocation$ CenterScreen=?64    ? WindowStyle$
 None=?5	   	    ? AllowsTransparency . 
?????? .??5      ?  ? ColumnDefinitions 5   
   ?? 5      $	??250 ?6   ?? 5      $??* ?6   .+?5   
   ??  ?? CornerRadius$ 	10 0 0 10??6   ??5      ?? 5       ?? 
StartPoint$ 0.5,0&?6&    ?? EndPoint$ 0.5,1&?69   .??5      ?  ? Color$ #223266??6#   	 ? Offset$	 0Q?63   ? 5      $ #273966??6#   $	 1Q?63   5      ._?5      ?? .+?5      ?? 
 ?? Orientation$
 
Horizontal=?6   $??Center=?66   $??0 35 0 0q?6S   .+?5      ?? $ 10??6   $??40??6/   $??40??6:    J? RenderTransformOrigin$ 0.46,-1.194&?6F   ??5      ?? 5      $	 0,0&?62   $	 1,2&?6C   .??5   "   ? $ #7f7cf1??6/   $	 0Q?6?   ? 5   "   $ #d3b7ff??6/   $	 1Q?6?   5       ._?5#      ?? $??II??6$   ???#ffffff$??22(?6C   $??SemiBold"?6Q    ?? TextAlignment$ Center=?5$      $??Center=?60   $??3 0 0 2q?6K   5%      ?? 5&      $??10 0 0 0q?6!   $??Center=?63   .+?5'      ?? $??Ivan Ilchenko??6$   $??15(?69   $??0 0 0 5q?6G   ???#c2cfff6X   ?? 5(      $??Beta 1.1??6$   $??11(?64   $??0 0 0 5q?6B   ???#7788bf6S   5)      5*      ?? 5+      $	??0.8??6   $??20 30q?6)   ???#46658a68   ?? 5.      -   5         ??Name$ homePageBtn??5.         
menuButton#??[  6.   .??5/      ?? $
 
Horizontal=?6!   .+?50      !  FontAwesome.Sharp.IconImage  ?  ?FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.1.1.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$
 Home=?6'     menuButtonIcon#??[ 63   ?? 51      $??	Home Page??6$     menuButtonText#??[ 65   52      53      ?? 54      -   5        $ addTransactionBtn??54      #??[  64   .??55      ?? $
 
Horizontal=?6!   .+?56        $ Wallet=?6'   #??[ 65   ?? 57      $??Add Transaction??6$   #??[ 6;   58      59      ?? 5:      #??[  6   .??5;      ?? $
 
Horizontal=?6!   .+?5<        $ Remove=?6'   #??[ 65   ?? 5=      $??Delete Transaction??6$   #??[ 6>   5>      5?      ?? 5@      #??[  6   .??5A      ?? $
 
Horizontal=?6!   .+?5B        $ 	ChartArea=?6'   #??[ 68   ?? 5C      $??
Investment??6$   #??[ 66   5D      5E      ?? 5F      #??[  6   .??5G      ?? $
 
Horizontal=?6!   .+?5H        $ 
MoneyBill1=?6'   #??[ 69   ?? 5I      $??Expenses??6$   #??[ 64   5J      5K      ?? 5L      #??[  6   .??5M      ?? $
 
Horizontal=?6!   .+?5N        $
 Bank=?6'   #??[ 63   ?? 5O      $??Capital Statement??6$   #??[ 6=   5P      5Q      ?? 5R      #??[  6   .??5S      ?? $
 
Horizontal=?6!   .+?5T        $
 Gear=?6'   #??[ 63   ?? 5U      $??Settings??6$   #??[ 64   5V      5W      ?? 5X      #??[  6   .??5Y      ?? $
 
Horizontal=?6!   .+?5Z        $ PowerOff=?6'   #??[ 67   ?? 5[      $??Logout??6$   #??[ 62   5\      5]      5^      5_       ? 5b   
   -   5          ?Name$ 	MainFrame??5b       $??1??6     ? NavigationUIVisibility$ Hidden=?63   5d      5f      5g      