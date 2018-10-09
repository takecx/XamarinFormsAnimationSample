using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ProgressBarColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke change ProgressBar Color animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as ProgressBar).ProgressColor);

			sender.Animate("ProgressBarColorAnimation", new Animation((d) =>
			{
				(sender as ProgressBar).ProgressColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
