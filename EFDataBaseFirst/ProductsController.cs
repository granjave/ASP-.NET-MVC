using EFDataBaseFirst.Models;
public Class ProductsController:ControllerBase
{
	NorthWindDbEntities db=new NorthWindDbEntities();
	public Viewresult Index(int Id)
	{
	return view(db.tblProducts.where(x=>x.Category_CatagoryId)==Id).TOlist());	
	}
	
	public Viewresult Details()
	{
		return view(db.tblProducts.find(Id));
	}
}