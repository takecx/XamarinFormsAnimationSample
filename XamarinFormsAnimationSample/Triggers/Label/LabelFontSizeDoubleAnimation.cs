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
			SetDefaultValueIfNeeded((sender as Label).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as Label).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("LabelFontSizeAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
