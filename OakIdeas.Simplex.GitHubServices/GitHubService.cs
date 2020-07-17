using Newtonsoft.Json;
using OakIdeas.Simplex.Core;
using OakIdeas.Simplex.Core.Repositories;
using OakIdeas.Simplex.GitHubServices.Models;
using Octokit;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace OakIdeas.Simplex.GitHubServices
{
	public class GitHubService : IArticlesRepository
	{
		public async Task<IEnumerable<Article>> GetArticles()
		{
			string repo = "oakcool/oakideas.blogs";
			string branch = "master";


			List<Article> articles = new List<Article>();
			var client = new GitHubClient(new ProductHeaderValue("oakideas-simplex"));

			RepositoryCollection repos = new RepositoryCollection
			{
				repo
			};
			var request = new SearchCodeRequest()
            {				
				Repos = repos,
                // we may want to restrict the file based on file extension
                Extensions = new[] { "info" }                
            };

			var result = await client.Search.SearchCode(request);
			HttpClient httpClient = new HttpClient();

			foreach (var item in result.Items)
			{
				var data = await httpClient.GetStringAsync($"https://raw.githubusercontent.com/{repo}/{branch}/{item.Path}");
				var article = JsonConvert.DeserializeObject<Article>(data);
				article.URL = item.HtmlUrl;
				articles.Add(article);
			}
			return articles;
		}
	}
}
