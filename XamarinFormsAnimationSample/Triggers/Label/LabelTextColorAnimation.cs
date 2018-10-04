using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke change Label TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Label).TextColor);

			sender.Animate("LabelTextColorAnimation", new Animation((d) =>
			{
				(sender as Label).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
