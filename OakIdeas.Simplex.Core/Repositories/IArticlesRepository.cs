using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace OakIdeas.Simplex.Core.Repositories
{
	public interface IArticlesRepository
	{
		Task<IEnumerable<Article>> GetArticles();
		
	}
}
