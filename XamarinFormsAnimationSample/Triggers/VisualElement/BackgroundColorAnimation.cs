// Official Sample
// https://docs.microsoft.com/ja-jp/xamarin/xamarin-forms/app-fundamentals/triggers#enterexit

using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class BackgroundColorAnimation : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public Color From { get; set; }
		public Color To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		/// <summary>
		/// Invoke change BackgroundColor animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("BackgroundColorAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				sender.BackgroundColor = AnimationUtil.CalculateCurrentValue(From, To, animationRatio);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
