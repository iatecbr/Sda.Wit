﻿namespace Sda.VSTS.RestApi.Entities
{
	public class CreatedBy
	{
		public string Id { get; set; }

		public string Name { get; set; }

		public object Url { get; set; }


		public override string ToString()
		{
			return this.Name;
		}
	}
}
