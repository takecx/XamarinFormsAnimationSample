using System;
namespace XamarinFormsAnimationSample.Interfaces
{
	public interface ITriggerAction<T>
	{
		T CalculateGap(T from, T to);
	}
}
