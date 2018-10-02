using EFDataBaseFirst.Models;
public Class CategoriesController:ControllerBase
{
	NorthWindDbEntities Db=new NorthWindDbEntities()
	
	public ViewResult Index()
	{
		return view(db.tblCategories.Tolist());
	}
}