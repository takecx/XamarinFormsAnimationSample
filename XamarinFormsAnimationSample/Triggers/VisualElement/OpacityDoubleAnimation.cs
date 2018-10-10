using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class OpacityDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke VisualElement Opacity animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.Opacity);

			sender.Animate(nameof(OpacityDoubleAnimation), new Animation((d) =>
			{
				sender.Opacity = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
