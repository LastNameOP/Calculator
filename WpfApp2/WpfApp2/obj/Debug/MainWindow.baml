   M S B A M L   `   `   `  ????B  >WpfApp2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp2WpfApp2  5   	       WpfApp2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp2     5   	     ? Title$  Калькулятор??5   	   $	??450??6   $	??320??6*   $	??320??66   $	??320??6E   $	??450??6T   $	??450??6d   .??5	      ?  ? ShowGridLines .  $	??300??6!    ? RowDefinitions 5
   
    ? ColumnDefinitions 5   
   .+?5   
   A?  A? Rows$ 6??6    A? Columns$ 4??6   $	??290??6+   $	??280??67   $??Bottom=?6D   $??0,0,0,5q?6_   .+?5      ?? -   5         ??Name$ Percent??5      $??%??6&   $
??Bold"?62   $??18(?6D   ?? 5      -   5        $ ClearAllLines??5      $??CE??6,   $
??Bold"?69   $??18(?6K   6Y   ?? 5      -   5        $ 	ClearLine??5      $??C??6(   $
??Bold"?64   $??18(?6F   6T   ?? 5      -   5        $ Erase??5      $	??⌫??6$   $
??Bold"?60   $??18(?6B   6P   ?? 5      -   5        $ 
OneDivideX??5      $	??1/x??6)   $
??Bold"?67   $??18(?6I   6W   ?? 5      -   5        $ XInRank2??5      $	??x²??6'   $
??Bold"?64   $??18(?6F   6T   ?? 5      -   5        $ RootOfX??5      $
??√x??6&   $
??Bold"?63   $??18(?6E   6S   ?? 5      -   5        $ Divine??5      $??÷??6%   $
??Bold"?61   $??18(?6C   6Q   ?? 5      -	   5        $ SevenBut??5      $??7??6'   $
??Bold"?63   $??18(?6E   6S   ?? 5      -
   5        $ EightBut??5      $??8??6'   $
??Bold"?63   $??18(?6E   6S   ?? 5      -   5        $ NineBut??5      $??9??6&   $
??Bold"?62   $??18(?6D   6R   ?? 5      -   5        $ Multiply??5      $??×??6'   $
??Bold"?63   $??18(?6E   6S   ?? 5      -   5        $ FourBut??5      $??4??6&   $
??Bold"?62   $??18(?6D   6R   ?? 5      -   5        $ FiveBut??5      $??5??6&   $
??Bold"?62   $??18(?6D   6R   ?? 5      -   5        $ SixBut??5      $??6??6%   $
??Bold"?61   $??18(?6C   6Q   ?? 5      -   5        $ MinusBut??5      $??-??6'   $
??Bold"?63   $??18(?6E   6S   ?? 5      -   5        $ OneBut??5      $??1??6%   $
??Bold"?61   $??18(?6C   6Q   ?? 5       -   5        $ TwoBut??5       $??2??6%   $
??Bold"?61   $??18(?6C   6Q   ?? 5!      -   5        $ ThreeBut??5!      $??3??6'   $
??Bold"?63   $??18(?6E   6S   ?? 5"      -   5        $ PlusBut??5"      $??+??6&   $
??Bold"?62   $??18(?6D   6R   ?? 5#      -   5        $ PlusMinusBut??5#      $	??+/-??6+   $
??Bold"?69   $??18(?6K   6Y   ?? 5$      -   5        $ ZeroBut??5$      $??0??6&   $
??Bold"?62   $??18(?6D   6R   ?? 5%      -   5        $ DotBut??5%      $??,??6%   $
??Bold"?61   $??18(?6C   6Q   ?? 5&      -   5        $ EnterBut??5&      $??=??6'   $
??Bold"?63   $??18(?6E   6S   5(      ?? 5)   
   -   5         ??Name$
 Row1??5)      $??0??6   $??Center=?6*   $??0,60,0,0q?6G   $	??Top=?6Y   $??36(?6q   $
??Bold"?6   $	??290??6?   $??55??6?   $??Right=?6?   $??Center=?6?   ?? 5*   
   -   5        $
 Row2??5*      $?? ??6   $??Center=?6)   $??0,27,0,0q?6F   $	??Top=?6X   $??18(?6p   $
??Bold"?6~   $	??290??6?   $??33??6?   $??Right=?6?   $??Center=?6?   5+      5,      