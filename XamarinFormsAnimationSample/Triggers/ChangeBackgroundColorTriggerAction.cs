using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ChangeBackgroundColorTriggerAction : TriggerAction<VisualElement>
	{
		public int StartsFrom { set; get; }

		public ChangeBackgroundColorTriggerAction()
		{
		}

		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("", new Animation((d) =>
			{
				var val = StartsFrom == 1 ? d : 1 - d;
				sender.BackgroundColor = Color.FromRgb(1, val, 1);
			}),
			length: 1000, // milliseconds
			easing: Easing.Linear);
		}
	}
}
