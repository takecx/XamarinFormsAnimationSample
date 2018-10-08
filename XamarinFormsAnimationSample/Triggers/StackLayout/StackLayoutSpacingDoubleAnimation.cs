using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class StackLayoutSpacingDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change StackLayout Spacing animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as StackLayout).Spacing);

			var animation = new Animation((d) =>
			{
				(sender as StackLayout).Spacing = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("StackLayoutSpacingDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
