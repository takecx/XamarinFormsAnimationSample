using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class HeightRequestDoubleAnimation : TriggerAction<VisualElement>
	{
		// Animation Parameter
		public double From { get; set; }
		public double To { get; set; }
		public int StartsFrom { set; get; }
		public uint Length { get; set; } = 1000;
		public string Easing { get; set; } = "Linear";

		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("HeightRequestDoubleAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				sender.HeightRequest = AnimationUtil.CalculateCurrentValue(From, To, animationRatio);
			}),
			length: Length,
			easing: EasingValueConverter.Convert(Easing));
		}
	}
}
