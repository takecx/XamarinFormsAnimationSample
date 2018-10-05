using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ButtonFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change button font-size animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Button).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as Button).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("ButtonFontSizeDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
