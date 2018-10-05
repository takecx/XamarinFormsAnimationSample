using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ButtonBorderWidthDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change button borderwidth animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Button).BorderWidth);

			var animation = new Animation((d) =>
			{
				(sender as Button).BorderWidth = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("ButtonBorderWidthDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
