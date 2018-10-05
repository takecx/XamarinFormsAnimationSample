using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ButtonTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke change Button textColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Button).TextColor);

			sender.Animate("ButtonTextColorAnimation", new Animation((d) =>
			{
				(sender as Button).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
