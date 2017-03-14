using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCw1Homework.Models
{   
	public  class View_客戶資料統計Repository : EFRepository<View_客戶資料統計>, IView_客戶資料統計Repository
	{

	}

	public  interface IView_客戶資料統計Repository : IRepository<View_客戶資料統計>
	{

	}
}