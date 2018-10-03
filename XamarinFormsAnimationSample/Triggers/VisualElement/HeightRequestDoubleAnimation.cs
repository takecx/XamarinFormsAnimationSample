using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class HeightRequestDoubleAnimation : AnimationBase<double>
	{
		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("HeightRequestDoubleAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				sender.HeightRequest = AnimationUtil.CalcCurrentValue(From, To, animationRatio);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
