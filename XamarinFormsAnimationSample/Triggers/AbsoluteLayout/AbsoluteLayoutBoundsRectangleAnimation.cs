using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class AbsoluteLayoutBoundsRectangleAnimation : AnimationBase<Rectangle>
	{
		/// <summary>
		/// Invoke the AbsoluteLayout LayoutBounds Animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			//SetDefaultValueIfNeeded((sender as AbsoluteLayout).LayoutBounds);

			//sender.Animate("AbsoluteLayoutBoundsRectangleAnimation", new Animation((d) =>
			//{
			//	(sender as AbsoluteLayout).LayoutBounds = AnimationUtil.CalcCurrentValue(From, To, d);
			//}),
			//length: Length,
			//easing: EasingValueConverter.Convert(Easing));
		}
	}
}
