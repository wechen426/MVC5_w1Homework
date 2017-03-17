using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCw1Homework.Models
{   
	public  class 客戶聯絡人Repository : EFRepository<客戶聯絡人>, I客戶聯絡人Repository
	{
        public 客戶聯絡人 Find (int  id)
        {
            return this.All().FirstOrDefault(客戶聯絡人 => 客戶聯絡人.Id == id);
        }
        public override IQueryable<客戶聯絡人> All()
        {
            return base.Where(客戶聯絡人 => 客戶聯絡人.是否刪除 == false);
        }
        public IQueryable<客戶聯絡人> All (bool showall)
        {
            if (showall ==true)
                return base.All();
            else
                return this.All();
        }
        public override void Delete(客戶聯絡人 entity)
        {
            //從 Entity Framework 關閉實體模型驗證的方式
            //this.UnitOfWork.Context.Configuration.ValidateOnSaveEnabled = false;
            entity.是否刪除 = true;
        }
    }

	public  interface I客戶聯絡人Repository : IRepository<客戶聯絡人>
	{

	}
}