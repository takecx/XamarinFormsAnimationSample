using System;
using System.Threading;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace XamarinFormsAnimationSample
{
	public class MainPageViewModel : BindableBase
	{
		#region BindableProperty
		private bool _IsChangeFontSizeAnimationStart;
		public bool m_IsChangeFontSizeAnimationStart
		{
			get { return _IsChangeFontSizeAnimationStart; }
			set { this.SetProperty(ref this._IsChangeFontSizeAnimationStart, value); }
		}
		private bool _IsChangeBackgroundColorAminationStart;
		public bool m_IsChangeBackgroundColorAminationStart
		{
			get { return _IsChangeBackgroundColorAminationStart; }
			set { this.SetProperty(ref this._IsChangeBackgroundColorAminationStart, value); }
		}
		private bool _IndicatorProgressing;
		public bool m_IndicatorProgressing
		{
			get { return _IndicatorProgressing; }
			set { this.SetProperty(ref this._IndicatorProgressing, value); }
		}

		#endregion

		#region Commands
		public DelegateCommand StartChangeFontSizeAnimationCommand { get; }
		public DelegateCommand StartChangeBackgroundColorAnimationCommand { get; }
		public DelegateCommand StartChangeActivityIndicatorColorAnimationCommand { get; }
		#endregion

		public MainPageViewModel()
		{
			// Create Commands
			StartChangeFontSizeAnimationCommand = new DelegateCommand(StartChangeFontSizeAnimation);
			StartChangeBackgroundColorAnimationCommand = new DelegateCommand(StartChangeBackgroundColorAnimation);
			StartChangeActivityIndicatorColorAnimationCommand = new DelegateCommand(StartChangeActivityIndicatorColorAnimation);
		}

		private void StartChangeActivityIndicatorColorAnimation()
		{
			m_IndicatorProgressing = true;
			Task.Run(() =>
			{
				Thread.Sleep(3000);
			}).ContinueWith((r) =>
			{
				m_IndicatorProgressing = false;
			});

		}

		/// <summary>
		/// Starts the change background color animation.
		/// </summary>
		private void StartChangeBackgroundColorAnimation()
		{
			m_IsChangeBackgroundColorAminationStart = true;
			Task.Run(() =>
			{
				Thread.Sleep(3000);
			}).ContinueWith((r) =>
			{
				m_IsChangeBackgroundColorAminationStart = false;
			});

		}

		private void StartChangeFontSizeAnimation()
		{
			m_IsChangeFontSizeAnimationStart = true;

			Task.Run(() =>
			{
				Thread.Sleep(3000);
			}).ContinueWith((r) =>
			{
				m_IsChangeFontSizeAnimationStart = false;
			});
		}
	}
}
