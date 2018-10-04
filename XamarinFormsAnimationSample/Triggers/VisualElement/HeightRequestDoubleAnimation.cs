using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class HeightRequestDoubleAnimation : AnimationBase<double>
	{
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.Height);

			sender.Animate("HeightRequestDoubleAnimation", new Animation((d) =>
			{
				sender.HeightRequest = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
