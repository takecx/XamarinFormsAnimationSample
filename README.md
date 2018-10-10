# XamarinFormsAnimationSample
UI Animation Sample with Xamarin.Forms

# Environments
Xamarin.Forms : 3.0.0.482510

# Common Property
~~~C#
public T From { get; set; } = default(T); // Animation starting point
public T To { get; set; } = default(T); // Animation ending point
public uint Length { get; set; } = 1000; // Animation Length (milliseconds)
public string Easing { get; set; } = "Linear"; // Animation EasingFunction name(https://docs.microsoft.com/en-us/dotnet/api/xamarin.forms.easing?view=xamarin-forms)
~~~

Toは必須項目です。

Fromを指定しない場合は現在のプロパティ値を自動で設定します。

LengthとEasingは必要に応じて変更してください。

# Animation List
<table>
<tr>
  <th>Property Owner</th>
  <th>Property</th>
  <th>Animation Class Name</th>
  <th>T</th>
  <th>Implemented</th>
</tr>
<tr>
  <td rowspan=6>VisualElement</td>
  <td>BackgroundColor</td>
  <td>BackgroundColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>Opacity</td>
  <td>OpacityDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>HeightRequest</td>
  <td>HeightRequestDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>WidthRequest</td>
  <td>WidthRequestDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>Rotation</td>
  <td>(RotationTo)</td>
  <td align=center>double</td>
  <td align=center>-</td>
</tr>
<tr>
  <td>Scale</td>
  <td>(ScaleTo)</td>
  <td align=center>double</td>
  <td align=center>-</td>
</tr>
<tr>
  <td>View</td>
  <td>Margin</td>
  <td>MarginThicknessAnimation</td>
  <td align=center>Thickness</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=3>Label</td>
  <td>FontSize</td>
  <td>LabelFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>LabelTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>LineHeight</td>
  <td>LabelLineHeightDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>?</td>
</tr>
<tr>
  <td>ActivityIndicator</td>
  <td>Color</td>
  <td>ActivityIndicatorColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>△</td>
</tr>
<tr>
  <td rowspan=2>BoxView</td>
  <td>Color</td>
  <td>BoxViewColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>CornerRadius</td>
  <td>BoxViewCornerRadiusAnimation</td>
  <td align=center>CornerRadius</td>
  <td align=center>?</td>
</tr>
<tr>
  <td rowspan=6>Button</td>
  <td>BorderColor</td>
  <td>ButtonBorderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>BorderWidth</td>
  <td>ButtonBorderWidthDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>CornerRadius</td>
  <td>ButtonCornerRadiusAnimation</td>
  <td align=center>CornerRadius</td>
  <td align=center>X</td>
</tr>
<tr>
  <td>FontSize</td>
  <td>ButtonFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>Padding</td>
  <td>ButtonPaddingThicknessAnimation</td>
  <td align=center>Thickness</td>
  <td align=center>?</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>ButtonTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=2>DatePicker</td>
  <td>FontSize</td>
  <td>DatePickerFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>DatePickerTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>Layout</td>
  <td>Padding</td>
  <td>LayoutPaddingThicknessAnimation</td>
  <td align=center>Thickness</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>AbsoluteLayout</td>
  <td>LayoutBounds</td>
  <td>AbsoluteLayoutBoundsRectangleAnimation</td>
  <td align=center>Rectangle</td>
  <td align=center>?</td>
</tr>
<tr>
  <td rowspan=2>Grid</td>
  <td>ColumnSpacing</td>
  <td>GridColumnSpacingDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>RowSpacing</td>
  <td>GridRowSpacingDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>StackLayout</td>
  <td>Spacing</td>
  <td>StackLayoutSpacingDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=2>Picker</td>
  <td>TextColor</td>
  <td>PickerTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>FontSize</td>
  <td>PickerFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>ProgressBar</td>
  <td>ProgressColor</td>
  <td>ProgressBarColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=3>Slider</td>
  <td>MaximumTrackColor</td>
  <td>SliderMaximumTrackColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>△</td>
</tr>
<tr>
  <td>MinimumTrackColor</td>
  <td>SliderMinimumTrackColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>△</td>
</tr>
<tr>
  <td>ThumbColor</td>
  <td>SliderThumbColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>△</td>
</tr>
<tr>
  <td>Switch</td>
  <td>OnColor</td>
  <td>SwitchOnColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>△</td>
</tr>
<tr>
  <td>TableView</td>
  <td>RowHeight</td>
  <td>TableViewRowHeightIntAnimation</td>
  <td align=center>int</td>
  <td align=center><b>X</b></td>
</tr>
<tr>
  <td rowspan=2>TimePicker</td>
  <td>FontSize</td>
  <td>TimePickerFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>TimePickerTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=3>Editor</td>
  <td>FontSize</td>
  <td>EditorFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>PlaceholderColor</td>
  <td>EditorPlaceholderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>△</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>EditorTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=3>Entry</td>
  <td>FontSize</td>
  <td>EntryFontSizeDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>PlaceholderColor</td>
  <td>EntryPlaceholderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>TextColor</td>
  <td>EntryTextColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=2>ListView</td>
  <td>RowHeight</td>
  <td>ListViewRowHeightDoubleAnimation</td>
  <td align=center>double</td>
  <td align=center><b>X</b></td>
</tr>
<tr>
  <td>SeparatorColor</td>
  <td>ListViewSeparatorColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td rowspan=3>Frame</td>
  <td>BorderColor</td>
  <td>FrameBorderColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>O</td>
</tr>
<tr>
  <td>CornerRadius</td>
  <td>FrameCornerRadiusAnimation</td>
  <td align=center>CornerRadius</td>
  <td align=center>?</td>
</tr>
<tr>
  <td>OutlineColor(Obsolete)</td>
  <td>FrameOutlineColorAnimation</td>
  <td align=center>Color</td>
  <td align=center>0</td>
</tr>
</table>

# Xamarin.Forms namespace Class Diagram
<https://drive.google.com/file/d/1cYChmthboGXX__Rg5pFC1O2pTNE7vWGy/view?usp=sharing>