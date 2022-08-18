using AsmApp.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AsmApp.Controllers
{
    public class BookController : Controller
    {
        //khai báo ApplicationDbContext để truy xuất và thay đổi dữ liệu của bảng
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public IActionResult Index()
        {
            var books = context.Book.ToList();
            return View(books);
        }
        public IActionResult List()
        {
            return View(context.Book.ToList());
        }
    }
}
