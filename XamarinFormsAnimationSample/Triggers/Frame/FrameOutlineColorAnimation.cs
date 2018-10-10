using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class FrameOutlineColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Frame OutlineColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Frame).OutlineColor);

			sender.Animate(nameof(FrameOutlineColorAnimation), new Animation((d) =>
			{
				(sender as Frame).OutlineColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
