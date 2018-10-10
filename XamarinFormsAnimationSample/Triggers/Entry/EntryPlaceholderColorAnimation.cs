using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class EntryPlaceholderColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Entry PlaceholderColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Entry).PlaceholderColor);

			sender.Animate("EntryPlaceholderColorAnimation", new Animation((d) =>
			{
				(sender as Entry).PlaceholderColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
