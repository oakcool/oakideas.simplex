using System;
using System.Threading.Tasks;

namespace OakIdeas.Simplex.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			FetchArticles().Wait();
			System.Console.ReadLine();
		}

		static async Task FetchArticles()
		{
			OakIdeas.Simplex.GitHubServices.GitHubService service = new GitHubServices.GitHubService();

			var articles = await service.GetArticles();
			foreach(var article in articles)
			{
				System.Console.WriteLine($"{article.Title} - {article.Published}");
				
			}
		}
	}
}
