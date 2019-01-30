using System;
using System.Linq;
using System.Web.Mvc;
using AutoMapper;
using TravelPartners.Models;
using TravelPartners.Repositories;

namespace TravelPartners.Controllers
{
    public class UsersController : Controller
    {
        private readonly IRepository _repository;

        public UsersController(IRepository repository)
        {
            _repository = repository;
        }
        
        public ActionResult Index()
        {
            var users = _repository.GetUsers();

            var models = users.Select(Mapper.Map<UserResponseModel>);

            return View(models);
        }

        public ActionResult Create()
        {
            return RedirectToAction("CreateUser", "User");
        }

        public ActionResult Details(Guid userId)
        {
            return RedirectToAction("ViewUser", "User", new { userId });
        }

        public ActionResult Edit(Guid userId)
        {
            return RedirectToAction("EditUser", "User", new { userId });
        }
    }
}