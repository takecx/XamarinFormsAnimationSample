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
| Property Owner |  Property  |  Animation Class Name | T | Implemented|
| ---- | ---- | ---- | :----: | :----: |
| VisualElement |  BackgroundColor  |  BackgroundColorAnimation  |  Color  | O |
| VisualElement |  Opacity  |  OpacityDoubleAnimation  | double |O|
| VisualElement | HeightRequest | HeightRequestDoubleAnimation | double |O|
| VisualElement | WidthRequest | WidthRequestDoubleAnimation | double |O|
| VisualElement| Rotation | (RotationTo) | double | - |
| VisualElement| Scale | (ScaleTo) | double | - |
| View | Margin | MarginThicknessAnimation | Thickness | △ |
| Label | FontSize | LabelFontSizeDoubleAnimation | double | O |
| Label| TextColor | LabelTextColorAnimation | Color | O |
| Label| LineHeight | LabelLineHeightDoubleAnimation | double | ? |
| ActivityIndicator | Color | ActivityIndicatorColorAnimation | Color| △ |
| BoxView | Color | BoxViewColorAnimation | Color | O |
| BoxView | CornerRadius | BoxViewCornerRadiusAnimation | CornerRadius | ? |
| Button | BorderColor | ButtonBorderColorAnimation | Color | O |
| Button | BorderWidth | ButtonBorderWidthDoubleAnimation | double | X|
| Button | CornerRadius | ButtonCornerRadiusAnimation | CornerRadius | X |
| Button | FontSize | ButtonFontSizeDoubleAnimation | double | X |
| Button | Padding | ButtonPaddingThicknessAnimation | Thickness | X |
| Button | TextColor |ButtonTextColorAnimation | Color | X |
| DatePicker | FontSize | DatePickerFontSizeDoubleAnimation | double | X |
| DatePicker | TextColor | DatePickerTextColorAnimation | Color | X |
| Layout | Padding | LayoutPaddingThicknessAnimation | Thickness | X |
| AbsoluteLayout | LayoutBounds | AbsoluteLayoutBoundsRectangleAnimation | Rectangle | X |
| Grid | ColumnSpacing | GridColumnSpacingDoubleAnimation | double | X |
| Grid | RowSpacing | GridRowSpacingDoubleAnimation | double | X |
| StackLayout | Spacing | StackLayoutSpacingDoubleAnimation | double | X |
| Picker | TextColor | PickerTextColorAnimation | Color | X |
| Picker | FontSize | PickerFontSizeDoubleAnimation | double | X |
| ProgressBar | ProgressColor | ProgressBarColorAnimation | Color | X |
| SearchBar | CancelButtonColor | SearchBarCancelButtonColorAnimation | Color | X |
| SearchBar | FontSize | SearchBarFontSizeDoubleAnimation | double | X |
| SearchBar | PlaceholderColor |SearchBarPlaceholderColorAnimation | Color | X |
| SearchBar | TextColor |SearchBarTextColorAnimation | Color | X |
| Slider | MaximumTrackColor | SliderMaximumTrackColorAnimation | Color | X |
| Slider | MinumumTrackColor | SliderMinumumTrackColorAnimation | Color | X |
| Slider | ThumbColor | SliderThumbColorAnimation | Color | X |
| Switch | OnColor | SwitchOnColorAnimation | Color | X |
| TableView | RowHeight | TableViewRowHeightDoubleAnimation | double| X |
| TimePicker | FontSize | TimePickerFontSizeDoubleAnimation | double| X |
| TimePicker | TextColor | TimePickerTextColorAnimation | Color | X |
| Editor | FontSize | EditorFontSizeAnimation | Color | X |
| Editor | PlaceholderColor | EditorPlaceholderColorAnimation | Color | X |
| Editor | TextColor | EditorTextColorAnimation | Color | X |
| Entry | FontSize | EntryFontSizeAnimation | Color | X |
| Entry | PlaceholderColor | EntryPlaceholderColorAnimation | Color | X |
| Entry | TextColor | EntryTextColorAnimation | Color | X |
| ListView | RowHeight | ListViewRowHeightDoubleAnimation | double | X |
| ListView | SeparatorColor | ListViewSeparatorColorAnimation | Color | X |
| ScrollView | ContentSize | ScrollViewContentSizeAnimation | Size | X |
| Frame | BorderColor | FrameBorderColorAnimation | Color | X |
| Frame | CornerRadius | FrameCornerRadiusAnimation | CornerRadius | X |
| Frame | OutlineColor |FrameOutlineColorAnimation | Color | X |

# Xamarin.Forms namespace Class Diagram
<https://drive.google.com/file/d/1cYChmthboGXX__Rg5pFC1O2pTNE7vWGy/view?usp=sharing>