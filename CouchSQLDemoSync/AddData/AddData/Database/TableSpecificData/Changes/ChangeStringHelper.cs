﻿using System.ComponentModel.DataAnnotations;

namespace AddData.Database.TableSpecificData.Changes
{
	public partial class ChangeStringHelper
	{
		[Key]
		public int id { get; set; }

		public string revision { get; set; }

		public ChangeStringHelper() { }

		public ChangeStringHelper(string rev)
		{
			this.revision = rev;
		}
	}
}
