using System;
using Xamarin.Forms;

namespace XamarinFormsAnimationSample.Triggers
{
	public class LabelFontSizeTriggerAction : TriggerAction<VisualElement>
	{
		public int AddingFontSize { get; set; }
		public int InitialFontSize { get; set; }
		public int StartsFrom { set; get; }

		public LabelFontSizeTriggerAction()
		{
		}

		protected override void Invoke(VisualElement sender)
		{
			var animation = new Animation((d) =>
			{
				var percent = StartsFrom == 1 ? d : 1 - d;
				var currentSize = AddingFontSize * percent;
				var label = sender as Label;
				label.FontSize = InitialFontSize + currentSize;
			});
			sender.Animate("LabelFontSize", animation, length: 1000, easing: Easing.Linear);
		}
	}
}
