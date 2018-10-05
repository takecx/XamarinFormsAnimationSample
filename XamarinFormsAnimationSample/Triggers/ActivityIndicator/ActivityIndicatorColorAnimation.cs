using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ActivityIndicatorColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke change ActivityIndicatorColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as ActivityIndicator).Color);

			sender.Animate("ActivityIndicatorColorAnimation", new Animation((d) =>
			{
				(sender as ActivityIndicator).Color = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
