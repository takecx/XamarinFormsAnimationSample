using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class DatePickerFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change DatePicker font-size animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as DatePicker).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as DatePicker).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("DatePickerFontSizeDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
