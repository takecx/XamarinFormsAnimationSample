using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class EditorTextColorAnimation : AnimationBase<Color>
	{
		/// <summary>
		/// Invoke Editor TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as Editor).TextColor);

			sender.Animate("EditorTextColorAnimation", new Animation((d) =>
			{
				(sender as Editor).TextColor = AnimationUtil.CalcCurrentValue(From, To, d);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
