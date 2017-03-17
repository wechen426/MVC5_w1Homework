using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCw1Homework.Models
{   
	public  class 客戶資料Repository : EFRepository<客戶資料>, I客戶資料Repository
	{
        public 客戶資料 Find(int id)
        {
            return this.All().FirstOrDefault(客戶資料 => 客戶資料.Id == id);
        }
        public override IQueryable<客戶資料> All()
        {
            return base.Where(客戶資料 => 客戶資料.是否刪除 == false);
        }
        public IQueryable<客戶資料> All(bool showall)
        {
            if (showall == true)
                return base.All();
            else
                return this.All();
        }
        public override void Delete(客戶資料 entity)
        {
            //從 Entity Framework 關閉實體模型驗證的方式
            //this.UnitOfWork.Context.Configuration.ValidateOnSaveEnabled = false;
            entity.是否刪除 = true;
        }
    }

	public  interface I客戶資料Repository : IRepository<客戶資料>
	{

	}
}