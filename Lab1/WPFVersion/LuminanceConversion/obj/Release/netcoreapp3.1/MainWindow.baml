   M S B A M L   `   `   `  ���� N  JLuminanceConversion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:LuminanceConversionLuminanceConversion  $    LuminanceConversion.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     3local!clr-namespace:LuminanceConversion       � WindowStartupLocation$  CenterScreen=� � Title$ Luminance Conversion��$	��700��$	��900��$	��650��$	��650��.��� -    �Name$ MainGrid��$y�Visible=�$��Stretch=�$��Stretch=�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black��� $ 	#FF230526�� � Offset$ 1Q� � ColumnDefinitions �� $	��43* ��� $��7* ��� $	��50* ��� $	��50* � � RowDefinitions �� $��* ��� $��0.10* �.+��� -   	 ��Name$	 ButtonClose��
�������
���� ��$��3��$��1��$��0,27,5,0q�$��30��$	��100��$	��200��$	��300��$��Close��$
��Auto��$
��Auto��$	��Top=�$��Right=��� -   $	 ButtonSaveImage��
�������
���� ��$��0��$��1��$��5 0 0 5q�$��30��$	��100��$	��200��$	��300��$��
Save image��$
��Auto��$
��Auto��$��Bottom=�$
��Left=��� $	��0.5q�
���� ��$��2��$��0,0,0,62q�$��2��._��� $��0��$��0��.+��� -   
 ��Name$
 TextForImage��
�������$��30��$	��100��$	��200��$	��300��$
��Auto��$
��Auto��$	��Top=�$��Center=�$��Center=�$��0 5 0 0q�.��Source image�� $	��0.5q�
���� ��$	��Top=�._��� -    ��Name$ ImageBox������  �� Path$ 	LoadImage��� $	��0.5q�
���� ��$��2��$��0,0,0,62q�$��2��._��� $��0��$��1��.+��� -   $	 ButtonUploadImage��
�������
���� ��$
��Auto��$
��Auto��$��30��$	��100��$��20��$	��300��$��10 10 10 10q�$��Upload image���� -   $	 ButtonSourceImage��
�������
���� ��$
��Auto��$
��Auto��$��30��$	��100��$��20��$	��300��$��
10 0 10 10q�$��Source image���� -   $	 ButtonGrayScaleImage��
�������
���� ��$
��Auto��$
��Auto��$��30��$	��100��$��20��$	��300��$��
10 0 10 10q�$��Grayscale image���� $	��0.9q�
���� ��._��� .+��� 
�������$��Italic$�$��20(�$��	UnderLine{�$��10 10 10 10q�Reference color correction��  �� Orientation$ 
Horizontal=�.+��� 
�������$��15(�$��10 0 0 0q�Pixel:�� -	    ��Name$ ValuesOfPallete��
�������$��20 0 0 0q�$��15(�(click on color pallete)�� -
   $ 	 ButtonApplyColorCorrection��
���� ��$��Apply��$��10 10 10 10q�
�������$	��100��$��20���� $	��0.9q�
���� ��._��� .+��� 
�������$��Italic$�$��20(�$��	UnderLine{�$��10 10 10 10q�
Gray world�� -   $	 ButtonApplyGrayWorld��
���� ��$��Apply��$��10 10 10 10q�
�������$	��100��$��20���� .+��� 
�������$��Italic$�$��20(�$��	UnderLine{�$��10 10 10 10q�Basic luminance conversions�� $ 
Horizontal=�.+��� -   $	 buttonLogarithm��
���� ��$��	Logarithm��$��10 10 10 10q�
�������$	��100��$��20���� -    ��Name$ valuesLogarithm��$��50��$��20��$��0 0 10 0q�.��5 10�� 
�������$��15(�$��80��$��20��: base coef�� $ 
Horizontal=�.+��� -   $	 ButtonDegree��
���� ��$��Degree��$��10 10 10 10q�
�������$	��100��$��20���� -   $ valuesDegree��$��50��$��20��$��0 0 10 0q�.��5 10�� 
�������$��15(�$	��100��$��20��: degree coef�� $ 
Horizontal=�.+��� -   $	 buttonNegative��
���� ��$��Negative��$��10 10 10 10q�
�������$	��100��$��20���� $��10 10 10 10q�$��Anticonversion��
��������� $��1q�
���� ��._��� .+��� -   $	 ButtonNormalizationImage��
�������
���� ��$
��Auto��$
��Auto��$��30��$	��100��$��20��$	��300��$��10 10 10 10q�$��Normalization image���� -   $	 ButtonEqualizationImage��
�������
���� ��$
��Auto��$
��Auto��$��30��$	��100��$��20��$	��300��$��
10 0 10 10q�$��Equalization image���� $��1q�
���� ��$��3��$��0,0,0,62q�$��2��._��� $��0��$��2��.+��� -   $
 NameColorPallete��
�������$��30��$	��100��$	��200��$	��300��$
��Auto��$
��Auto��$	��Top=�$��Center=�$��Center=�$��0 5 0 0q�.��Color pallete�� $	��0.5q�
���� ��._��� -   $ ColorPalleteImage��$ ��Resources/colorPallete.jpg��$��0 10 0 0q��� -   $
 	hystogram��
�������$��30��$	��100��$	��200��$	��300��$
��Auto��$
��Auto��$	��Top=�$��Center=�$��Center=�$��0 5 0 0q�.��	Histogram�� $	��0.5q�
���� ��._��� $
��Auto��$
��Auto��