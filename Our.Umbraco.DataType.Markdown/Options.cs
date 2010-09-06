﻿using System;
using System.ComponentModel;

namespace Our.Umbraco.DataType.Markdown
{
	/// <summary>
	/// The options for the Markdown data-type.
	/// </summary>
	public class Options
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="Options"/> class.
		/// </summary>
		public Options()
		{
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Options"/> class.
		/// </summary>
		/// <param name="loadDefaults">if set to <c>true</c> [load defaults].</param>
		public Options(bool loadDefaults)
		{
			if (loadDefaults)
			{
				this.EnableWmd = true;
				this.Height = 400;
				this.SelectedPreview = "toolbar";
				this.Width = 490;
			}
		}

		/// <summary>
		/// Gets or sets a value indicating whether [enable WMD].
		/// </summary>
		/// <value><c>true</c> if [enable WMD]; otherwise, <c>false</c>.</value>
		[DefaultValue(true)]
		public bool EnableWmd { get; set; }

		/// <summary>
		/// Gets or sets the height.
		/// </summary>
		/// <value>The height.</value>
		[DefaultValue(400)]
		public int Height { get; set; }


		/// <summary>
		/// Gets or sets the selected preview.
		/// </summary>
		/// <value>The selected preview.</value>
		[DefaultValue("toolbar")]
		public string SelectedPreview { get; set; }

		/// <summary>
		/// Gets or sets the width.
		/// </summary>
		/// <value>The width.</value>
		[DefaultValue(490)]
		public int Width { get; set; }
	}
}