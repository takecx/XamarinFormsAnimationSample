using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ButtonPaddingThicknessAnimation : AnimationBase<Thickness>
	{
		/// <summary>
		/// Invoke the ButtonPadding Animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			//SetDefaultValueIfNeeded((sender as Button).Padding);

			//sender.Animate("ButtonPaddingThicknessAnimation", new Animation((d) =>
			//{
			//	(sender as Button).Padding = AnimationUtil.CalcCurrentValue(From, To, d);
			//}),
			//length: Length,
			//easing: EasingValueConverter.Convert(Easing));
		}
	}
}
