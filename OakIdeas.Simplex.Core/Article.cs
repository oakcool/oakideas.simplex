using System;
using System.Collections.Generic;
using System.Text;

namespace OakIdeas.Simplex.Core
{
	public class Article
	{
		public Guid ID { get; set; }
		public string Title { get; set; }
		public DateTime Published { get; set; }
		public string URL { get; set; }
	}
}
