using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class BoxViewCornerRadiusAnimation : AnimationBase<CornerRadius>
	{
		/// <summary>
		/// Invoke BoxView CornerRadius animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as BoxView).CornerRadius);

			sender.Animate(nameof(BoxViewColorAnimation), new Animation((d) =>
			{
				(sender as BoxView).CornerRadius = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
