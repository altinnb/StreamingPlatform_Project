using Microsoft.AspNetCore.Mvc;
using MovieClub_P1.Core.Repositories;

namespace MovieClub_P1.Controllers
{
    public class UserController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public UserController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            var users = _unitOfWork.User.GetUsers();
            return View(users);
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
