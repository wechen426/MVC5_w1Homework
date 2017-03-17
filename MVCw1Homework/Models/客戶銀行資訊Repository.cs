using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVCw1Homework.Models
{   
	public  class 客戶銀行資訊Repository : EFRepository<客戶銀行資訊>, I客戶銀行資訊Repository
	{
        public 客戶銀行資訊 Find(int id)
        {
            return this.All().FirstOrDefault(客戶銀行資訊 => 客戶銀行資訊.Id == id);
        }
        public override IQueryable<客戶銀行資訊> All()
        {
            return base.Where(客戶銀行資訊 => 客戶銀行資訊.是否刪除 == false);
        }
        public IQueryable<客戶銀行資訊> All(bool showall)
        {
            if (showall == true)
                return base.All();
            else
                return this.All();
        }
        public override void Delete(客戶銀行資訊 entity)
        {
            //從 Entity Framework 關閉實體模型驗證的方式
            //this.UnitOfWork.Context.Configuration.ValidateOnSaveEnabled = false;
            entity.是否刪除 = true;
        }
    }

	public  interface I客戶銀行資訊Repository : IRepository<客戶銀行資訊>
	{

	}
}