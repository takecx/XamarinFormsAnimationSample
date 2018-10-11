using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class FrameCornerRadiusAnimation : AnimationBase<float>
	{
		/// <summary>
		/// Invoke Frame CornerRadius animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Frame).CornerRadius);

			sender.Animate(nameof(FrameCornerRadiusAnimation), new Animation((d) =>
			{
				(sender as Frame).CornerRadius = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
