using system.data.entity
namespace EntityCURD.Models
{
	public class ProductContext:DbContext
	{
		public Dbset<product>ProductTable{get;set;}
	}
}