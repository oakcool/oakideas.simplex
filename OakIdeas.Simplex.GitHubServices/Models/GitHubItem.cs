using System;
using System.Collections.Generic;
using System.Text;

namespace OakIdeas.Simplex.GitHubServices.Models
{
	public class GitHubItem
	{
		public string Name { get; set; }
		public string Path { get; set; }
		public string Sha { get; set; }
		public int Size { get; set; }
		public string Url { get; set; }
		public string Html_url { get; set; }
		public string Git_url { get; set; }
		public string Download_url { get; set; }
		public string Type { get; set; }
		public string Content { get; set; }
		public string Encoding { get; set; }
		public Links Links { get; set; }
	}
}
