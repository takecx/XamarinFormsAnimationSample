using System;
using Xamarin.Forms;
using XamarinFormsAnimationSample.Utils;

namespace XamarinFormsAnimationSample.Triggers
{
	public class TableViewRowHeightIntAnimation : AnimationBase<int>
	{
		/// <summary>
		/// Invoke change TableView RowHeight animation.
		/// </summary>
		/// <param name="sender">Sender.</param>
		protected override void Invoke(VisualElement sender)
		{
			SetDefaultValueIfNeeded((sender as TableView).RowHeight);

			var animation = new Animation((d) =>
			{
				(sender as TableView).RowHeight = AnimationUtil.CalcCurrentValue(From, To, d);
			});
			sender.Animate("TableViewRowHeightIntAnimation", animation, length: Length, easing: EasingValueConverter.Convert(Easing));
		}
	}
}
