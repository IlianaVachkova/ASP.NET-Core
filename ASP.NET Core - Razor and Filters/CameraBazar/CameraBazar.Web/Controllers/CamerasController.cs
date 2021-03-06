﻿using CameraBazar.Data.Models;
using CameraBazar.Services;
using CameraBazar.Web.Models.Cameras;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CameraBazar.Web.Controllers
{
    public class CamerasController : Controller
    {
        private readonly UserManager<User> userManager;
        private readonly ICameraService cameras;

        public CamerasController(UserManager<User> userManager, ICameraService cameras)
        {
            this.userManager = userManager;
            this.cameras = cameras;
        }

        [Authorize]
        public IActionResult Add() => this.View();

        [Authorize]
        [HttpPost]
        public IActionResult Add(AddCameraViewModel cameraModel)
        {
            if (!ModelState.IsValid)
            {
                return View(cameraModel);
            }

            this.cameras.Create(
                cameraModel.Make,
                cameraModel.Model,
                cameraModel.Price,
                cameraModel.Quantity,
                cameraModel.MinShutterSpeed,
                cameraModel.MaxShutterSpeed,
                cameraModel.MinISO,
                cameraModel.MaxISO,
                cameraModel.IsFullFrame,
                cameraModel.VideoResolution,
                cameraModel.LightMeterings,
                cameraModel.Description,
                cameraModel.ImageUrl,
                this.userManager.GetUserId(User));

            return RedirectToAction(nameof(HomeController.Index), "Home");
        }
    }
}
