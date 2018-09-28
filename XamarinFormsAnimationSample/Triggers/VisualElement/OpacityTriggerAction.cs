using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class OpacityTriggerAction : TriggerAction<VisualElement>
	{
		public int StartsFrom { set; get; }

		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("VisualElementOpacityAnimation", new Animation((d) =>
			{
				var animationRatio = StartsFrom == 0 ? d : 1 - d;
				sender.Opacity = animationRatio;
			}),
			length: 1000, // milliseconds
			easing: Easing.Linear);
		}
	}
}
