using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class EntryFontSizeDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke Entry FontSize animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Entry).FontSize);

			var animation = new Animation((d) =>
			{
				(sender as Entry).FontSize = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("EntryFontSizeDoubleAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
