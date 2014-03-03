﻿using System.Windows;
using System.Windows.Controls;
using Raven.Studio.Infrastructure;

namespace Raven.Studio.Features.Stats
{
	public partial class StatisticsStatusSectionView : PageView
	{
		public StatisticsStatusSectionView()
		{
			InitializeComponent();
		}

		private void IndexClicked(object sender, RoutedEventArgs e)
		{
			var hyperlink = sender as HyperlinkButton;
			if(hyperlink == null)
				return;

			ViewSelect.SelectedValue = hyperlink.Content;
		}
	}
}