using _123Pay.DB;
using _123Pay.DB.Entities;
using _123Pay.Models;
using cloudscribe.Pagination.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace _123Pay.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> userManager;

        public HomeController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            this.userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult> Index(int pageSize = 10, int pageNumber = 1, string sortOrder = "")
        {
            try
            {
                ViewData["Title"] = "Customer List";
                ViewData["Controller"] = "Customers";
                var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var excludeRecords = (pageSize * pageNumber) - pageSize;
                string by = "name";
                bool asc = true;
                ViewBag.DateSortParm = sortOrder == "created" ? "created_desc" : "created";
                ViewBag.CustomerSortParm = sortOrder == "name" ? "name_desc" : "name";
                ViewBag.AccountNoSortParm = sortOrder == "accountno" ? "accountno_desc" : "accountno";
                ViewBag.ProcessedBySortParm = sortOrder == "createdby" ? "createdby_desc" : "createdby";
                switch (sortOrder)
                {
                    case "name_desc":
                        by = "Name";
                        asc = false;
                        break;
                    case "created_desc":
                        by = "CreatedDate";
                        asc = true;
                        break;
                    case "accountno_desc":
                        by = "AccountNumber";
                        asc = false;
                        break;
                    case "createdby_desc":
                        by = "ProcessedBy";
                        asc = false;
                        break;
                    case "name":
                        by = "Name";
                        asc = true;
                        break;
                    case "accno":
                        by = "AccountNumber";
                        asc = true;
                        break;
                    case "createdby":
                        by = "ProcessedBy";
                        asc = true;
                        break;
                    default:
                        by = "CreatedDate";
                        asc = false;
                        break;
                }
                string sql = $@"
                Select a.* from Applications a
                left join Customers c on a.AccountNumber = c.AccountNumber
                order by {by} {(asc ? "asc" : "desc")}
                offset {excludeRecords} rows fetch next {pageSize} rows only";
                var clients = await _context.Applications.FromSqlRaw(sql).Select(c => new ApplicationListModel
                {
                    Id = c.Id,
                    ProcessedDate = c.CreatedDate,
                    Client = c.Client,
                    CustomerName = $"{_context.Customers.Where(x => x.AccountNumber == c.AccountNumber).Select(x => x.FirstName).FirstOrDefault()} {_context.Customers.Where(x => x.AccountNumber == c.AccountNumber).Select(x => x.LastName).FirstOrDefault()}",
                    Merchant = _context.LookUps.Where(x => x.LookupType.Name == "Merchant" && x.Id == c.MerchantId).Select(x => x.Name).FirstOrDefault(),
                    AccountName = c.AccountName,
                    AccountNumber = c.AccountNumber,
                    OtherDetails = c.OtherDetails,
                    Amount = c.Amount,
                    Status = _context.LookUps.Where(x => x.LookupType.Name == "Application Status" && x.Id == c.Status).Select(x => x.Name).FirstOrDefault(),
                    ProcessedBy = $"{userManager.FindByIdAsync(c.ProcessedBy.ToString()).Result.FirstName} {userManager.FindByIdAsync(c.ProcessedBy.ToString()).Result.LastName}",
                    ServiceFee = c.ServiceFee,
                    Remarks = c.Remarks,
                    Attachment = c.Attachment
                })
                    .ToListAsync();


                PagedResult<ApplicationListModel> result = new PagedResult<ApplicationListModel>
                {
                    Data = clients,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalItems = _context.Applications.FromSqlRaw($@"
                 Select a.* from Applications a
                left join Customers c on a.AccountNumber = c.AccountNumber").Count()
                };

                return View(result);
            }
            catch(Exception e)
            {
                throw e;
            }
           
        }

       
        [HttpGet]
        public async Task<IActionResult> ApplicationList(int pageSize = 10, int pageNumber = 1, string sortOrder = "")
        {

            try
            {
                ViewData["Title"] = "Customer List";
                ViewData["Controller"] = "Customers";
                var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                var excludeRecords = (pageSize * pageNumber) - pageSize;
                string by = "name";
                bool asc = true;
                ViewBag.DateSortParm = sortOrder == "created" ? "created_desc" : "created";
                ViewBag.CustomerSortParm = sortOrder == "name" ? "name_desc" : "name";
                ViewBag.AccountNoSortParm = sortOrder == "accountno" ? "accountno_desc" : "accountno";
                ViewBag.ProcessedBySortParm = sortOrder == "createdby" ? "createdby_desc" : "createdby";
                switch (sortOrder)
                {
                    case "name_desc":
                        by = "Name";
                        asc = false;
                        break;
                    case "created_desc":
                        by = "CreatedDate";
                        asc = true;
                        break;
                    case "accountno_desc":
                        by = "AccountNumber";
                        asc = false;
                        break;
                    case "createdby_desc":
                        by = "ProcessedBy";
                        asc = false;
                        break;
                    case "name":
                        by = "Name";
                        asc = true;
                        break;
                    case "accno":
                        by = "AccountNumber";
                        asc = true;
                        break;
                    case "createdby":
                        by = "ProcessedBy";
                        asc = true;
                        break;
                    default:
                        by = "CreatedDate";
                        asc = false;
                        break;
                }
                string sql = $@"
                Select a.* from Applications a
                left join Customers c on a.AccountNumber = c.AccountNumber
                order by {by} {(asc ? "asc" : "desc")}
                offset {excludeRecords} rows fetch next {pageSize} rows only";
                var clients = await _context.Applications.FromSqlRaw(sql).Select(c => new ApplicationListModel
                {
                    Id = c.Id,
                    ProcessedDate = c.CreatedDate,
                    Client = c.Client,
                    CustomerName = $"{_context.Customers.Where(x => x.AccountNumber == c.AccountNumber).Select(x => x.FirstName).FirstOrDefault()} {_context.Customers.Where(x => x.AccountNumber == c.AccountNumber).Select(x => x.LastName).FirstOrDefault()}",
                    Merchant = _context.LookUps.Where(x => x.LookupType.Name == "Merchant" && x.Id == c.MerchantId).Select(x => x.Name).FirstOrDefault(),
                    AccountName = c.AccountName,
                    AccountNumber = c.AccountNumber,
                    OtherDetails = c.OtherDetails,
                    Amount = c.Amount,
                    Status = _context.LookUps.Where(x => x.LookupType.Name == "Application Status" && x.Id == c.Status).Select(x => x.Name).FirstOrDefault(),
                    ProcessedBy = $"{userManager.FindByIdAsync(c.ProcessedBy.ToString()).Result.FirstName} {userManager.FindByIdAsync(c.ProcessedBy.ToString()).Result.LastName}",
                    ServiceFee = c.ServiceFee,
                    Remarks = c.Remarks,
                    Attachment = c.Attachment
                })
                    .ToListAsync();


                PagedResult<ApplicationListModel> result = new PagedResult<ApplicationListModel>
                {
                    Data = clients,
                    PageNumber = pageNumber,
                    PageSize = pageSize,
                    TotalItems = _context.Applications.FromSqlRaw($@"
                 Select a.* from Applications a
                left join Customers c on a.AccountNumber = c.AccountNumber").Count()
                };

                return View(result);
            }
            catch (Exception e)
            {
                throw e;
            }

        }
        [HttpPost]
        public async Task<IActionResult> ProcessingStatus(int id)
        {
            var client = await _context.Applications.Where(x => x.Id == id).FirstOrDefaultAsync();

            client.Status = _context.LookUps.Where(x => x.LookupType.Name == "Application Status" && x.Value == 2).Select(x => x.Id).FirstOrDefault();

            var attach = _context.Applications.Attach(client);
            attach.State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }
        [HttpPost]
        public async Task<JsonResult> SubmitApplicationPayment()
        {
            try
            {
                string file = "";
                var FilePath = string.Empty;
                var pathfile = string.Empty;
                var files = Request.Form.Files;
                string id = Request.Form.Where(x => x.Key == "Id").FirstOrDefault().Value;
                string status = Request.Form.Where(x => x.Key == "Status").FirstOrDefault().Value;
                string dir = Path.Combine(Directory.GetCurrentDirectory(), @"wwwroot\uploads\PaymentReceipts");
                var client = await _context.Applications.Where(x => x.Id == Convert.ToInt32(id)).FirstOrDefaultAsync();
                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                dir = Path.Combine(dir, client.AccountNumber);

                if (!Directory.Exists(dir))
                {
                    Directory.CreateDirectory(dir);
                }
                if (files.Count != 0)
                {
                    file = files[0].FileName;
                    FilePath = client.AccountNumber + $"/" + file;
                    pathfile = Path.Combine(dir, files[0].FileName);
                }
                client.Attachment = FilePath;
                if (status == "Done")
                {
                    client.Status = client.Status = _context.LookUps.Where(x => x.LookupType.Name == "Application Status" && x.Value == 3).Select(x => x.Id).FirstOrDefault();
                }
                else
                {
                    client.Status = client.Status = _context.LookUps.Where(x => x.LookupType.Name == "Application Status" && x.Value == 4).Select(x => x.Id).FirstOrDefault();
                }
                var attach = _context.Applications.Attach(client);
                attach.State = EntityState.Modified;
                await _context.SaveChangesAsync();

                if (files.Count != 0)
                {
                    using (FileStream fs = System.IO.File.Create(pathfile))
                    {
                        files[0].CopyTo(fs);
                        fs.Flush();
                    }
                }

                return Json(client);
            }
            catch(Exception e)
            {
                throw e;
            }
           
        }
    }
}
