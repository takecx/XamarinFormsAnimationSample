// Official Sample
// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/triggers#enterexit

using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class BackgroundColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke change BackgroundColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded(sender.BackgroundColor);

			sender.Animate("BackgroundColorAnimation", new Animation((d) =>
			{
				sender.BackgroundColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
