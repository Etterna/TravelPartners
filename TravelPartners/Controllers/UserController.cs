using System;
using System.Web.Mvc;
using AutoMapper;
using TravelPartners.Models;
using TravelPartners.Repositories;
using TravelPartners.Repositories.Entities;

namespace TravelPartners.Controllers
{
    public class UserController : Controller
    {
        private readonly IRepository _repository;

        // The repository used here for simplicity, usually we will have a service which will contain a business logic and IRepository will be there.
        public UserController(IRepository repository)
        {
            _repository = repository;
        }

        public ActionResult CreateUser()
        {
            return View("Add");
        }

        [HttpPost]
        public ActionResult Create(UserRequestModel model)
        {
            var user = Mapper.Map<UserEntity>(model);

            _repository.CreateUser(user);

            var responseModel = Mapper.Map<UserResponseModel>(user);
            return View("Details", responseModel);
        }

        public ActionResult ViewUser(Guid userId)
        {
            var user = _repository.GetUserById(userId);

            var responseModel = Mapper.Map<UserResponseModel>(user);

            return View("Details", responseModel);
        }

        public ActionResult EditUser(Guid userId)
        {
            var user = _repository.GetUserById(userId);

            var responseModel = Mapper.Map<UserResponseModel>(user);

            return View("Edit", responseModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Update(Guid userId, UserRequestModel changed)
        {
            var merged = _repository.GetUserById(userId);
            if (merged is null)
            {
                return BackToList();
            }

            merged.FirstName = changed.FirstName;
            merged.LastName = changed.LastName;
            merged.Email = changed.Email;

            _repository.UpdateUser(merged);

            var responseModel = Mapper.Map<UserResponseModel>(merged);

            return View("Details", responseModel);
        }

        public ActionResult DeleteUser(Guid userId)
        {
            _repository.DeleteUser(userId);

            return RedirectToAction("Index", "Users");
        }

        public ActionResult BackToList()
        {
            return RedirectToAction("Index", "Users");
        }
    }
}