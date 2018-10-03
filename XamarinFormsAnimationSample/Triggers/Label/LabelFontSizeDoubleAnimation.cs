using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change font-size animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			var animation = new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				(sender as Label).FontSize = AnimationUtil.CalcCurrentValue(From, To, animationRatio);
			});
			sender.Animate("LabelFontSizeAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
