using _123Pay.DB;
using _123Pay.DB.Entities;
using _123Pay.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _123Pay.Controllers
{
    public class ApplicationController : ApiController
    {
        private readonly AppDbContext _context;

        public ApplicationController(AppDbContext context)
        {
            _context = context;
        }
        [AllowAnonymous]
        [HttpPost("application")]
        public async Task<IActionResult> PostApplication([FromForm] ApplicationModel application)
        {
            if (ModelState.IsValid)
            {
                var customer = await _context.Customers.Where(x => x.AccountNumber == application.AccountNumber).FirstOrDefaultAsync();

                var client = new Application
                {
                    Client = application.Client,
                    CustomerId = customer.Id,
                    AccountNumber = application.AccountNumber,
                    AccountName = application.AccountName,
                    OtherDetails = application.OtherDetails,
                    Amount = application.Amount,
                    ServiceFee = application.ServiceFee,
                    Remarks = application.Remarks,
                    MerchantId = application.MerchantId,
                    CreatedDate = DateTime.Now,
                    Status = _context.LookUps.Where(x => x.Value == 1 && x.LookupType.Name == "Application Status").Select(x => x.Id).FirstOrDefault()
                };
                _context.Applications.Add(client);
                await _context.SaveChangesAsync();

                return Ok();
            }
            return BadRequest();
        }
    }
}
