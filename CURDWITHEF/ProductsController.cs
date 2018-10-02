using system.linq;
using system.web.mvc;
using system.net;
using EntityCURD.Models
using namespace EntityCURD.Controller
{
	
	ProductContext  Db= new productContext();
	
	public ActionViewResult index()
	{
		return view(Db.ProductTable.Tostring());
	}
	
	public ActionResult Details(int ? Id)
	{
		if(Id==null)
		{
			return new HttpPostStatusCodeResult(HttpStatusCode.BadRequest,"Product id Requied");
		}
		Product product=Db.ProductTable.find(Id);
		
		if(product==null)
		{
			return new HttpPostStatusCodeResult(HttpStatusCode.NotFound,"product Not Found");
		}
		
	return view(product);
	}
	
	public ActionResult  Create()
	{
		return view();
	}
	
	[HttpPost]
	[ActionName("create")]
	public ActionResult CreatePost()
	{
		Product product =new Product();
		if(ModelState.Isvalid)
		{
			tryUpdateModel(product);
			Db.ProductTable.add(Product);
			Db.savechanges();
		}
		return RedirectToActionResult("index");
	}
	
	public ActionResult Edite(int ? Id)
	{
		if(Id==null)
		{
			return new HttpPostStatusCodeResult(HttpStatusCode.BadRequest,"Product id Requied");
		}
		Product product=Db.ProductTable.find(Id);
		
		if(product==null)
		{
			return new HttpPostStatusCodeResult(HttpStatusCode.NotFound,"product Not Found");
		}
		
	return view(product);
	}
	
	[HttpPost]
	public ActionResult Edite(int id)
	{
			Product product=Db.ProductTable.find(Id);
			UpdateModel(product);
			Db.ProductTable.add(Product);
			Db.savechanges();
			return RedirectToActionResult("index");	
	}
	
	public ActionResult Delet(int ? Id)
	{
		if(Id==null)
		{
			return new HttpPostStatusCodeResult(HttpStatusCode.BadRequest,"Product id Requied");
		}
		Product product=Db.ProductTable.find(Id);
		
		if(product==null)
		{
			return new HttpPostStatusCodeResult(HttpStatusCode.NotFound,"product Not Found");
		}
		
	return view(product);
	}
	
	[HttpPost]
	public ActionResult Delet(int Id)
	{
			Product product=Db.ProductTable.find(Id);
			UpdateModel(product);
			Db.ProductTable.add(Product);
			Db.savechanges();
			return RedirectToActionResult("index");	
	}
	
}