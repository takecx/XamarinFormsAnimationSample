using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class ChangeLabelTextColorTriggerAction : TriggerAction<VisualElement>
	{
		public int StartsFrom { set; get; }

		public ChangeLabelTextColorTriggerAction()
		{
		}

		protected override void Invoke(VisualElement sender)
		{
			sender.Animate("ChangeLabelTextColor", new Animation((d) =>
			{
				var val = StartsFrom == 1 ? d : 1 - d;
				var label = sender as Label;
				label.TextColor = Color.FromRgb(1, val, 1);
			}),
			length: 1000, // milliseconds
			easing: Easing.Linear);
		}
	}
}
