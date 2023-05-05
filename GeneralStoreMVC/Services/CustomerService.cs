using System;
using GeneralStoreMVC.Data;
using GeneralStoreMVC.Models.Customer;
using System.Web.Helpers;

//namespace GeneralStoreMVC.Services
//{
//	public class CustomerService :ICustomerService
//	{
//		public CustomerService(GeneralStoreDbContext)
//		{
//			_ctx = ctx;
//		}

//        public async Task<IEnumerable<CustomerIndexModel>> GetAllCustomersAsync()
//        {
//            var customers = await _ctx.Customers.Select(customer => new CustomerIndexModel)

//            {
//                Id = customer.Id,
//				Name = customer.Name,
//				Email = customers.Email,
//			}).ToListAsync();
//            return customers;
//        }
//    }
//}
