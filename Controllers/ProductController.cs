using Microsoft.AspNetCore.Mvc;

namespace fullStackLearningBackend.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ProductController : ControllerBase
	{
		[HttpGet(Name = "GetProducts")]
		public IEnumerable<Product> Get()
		{
			return new List<Product>
			{
				new Product
				{
					Id = 1,
					Name = "iPhone 16",
					Price = 1200
				},
				new Product
				{
					Id = 2,
					Name = "Samsung S25",
					Price = 1100
				},
				new Product
				{
					Id = 3,
					Name = "MacBook Pro",
					Price = 2500
				}
			};
		}
	}

	public class Product
	{
		public int Id { get; set; }

		public string Name { get; set; } = string.Empty;

		public decimal Price { get; set; }
	}
}