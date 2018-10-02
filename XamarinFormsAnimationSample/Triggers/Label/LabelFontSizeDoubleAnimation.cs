using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelFontSizeDoubleAnimation : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public double From { get; set; }
		public double To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

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
