using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class WidthRequestDoubleAnimation : AnimationBase<double>
	{
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.WidthRequest);

			sender.Animate("HeightRequestDoubleAnimation", new Animation((d) =>
			{
				sender.WidthRequest = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
