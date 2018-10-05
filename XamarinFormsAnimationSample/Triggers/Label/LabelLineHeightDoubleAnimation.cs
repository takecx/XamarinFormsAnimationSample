using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelLineHeightDoubleAnimation : AnimationBase<double>
	{
		/// <summary>
		/// Invoke change font-size animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			// LabelにLineHeightプロパティが無い？？？
			//SetDefaultValueIfNeeded((sender as Label).LineHeight);

			//var animation = new Animation((d) =>
			//{
			//	(sender as Label).LineHeight = AnimationUtil.CalcCurrentValue(From, To, d);
			//});
			//sender.Animate("LabelFontSizeAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
