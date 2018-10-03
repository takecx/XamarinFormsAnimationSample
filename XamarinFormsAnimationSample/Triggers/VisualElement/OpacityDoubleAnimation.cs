using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class OpacityDoubleAnimation : AnimationBase<double>
	{
		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("OpacityDoubleAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				sender.Opacity = AnimationUtil.CalcCurrentValue(From, To, animationRatio);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
