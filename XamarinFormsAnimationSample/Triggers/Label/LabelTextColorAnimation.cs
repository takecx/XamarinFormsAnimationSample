using System;
using System.IO;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelTextColorAnimation : TriggerAction<Label>
	{
		// Animation Parameter
		public Color From { set; get; }
		public Color To { set; get; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		/// <summary>
		/// Invoke change Label TextColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(Label sender)
		{
			sender.Animate("LabelTextColorAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				sender.TextColor = AnimationUtil.CalculateCurrentValue(From, To, animationRatio);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
