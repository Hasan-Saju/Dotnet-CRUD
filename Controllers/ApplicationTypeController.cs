﻿using CRUD.Data;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CRUD.Controllers
{
	public class ApplicationTypeController : Controller
	{
		private readonly ApplicationDbContext _db;
		public ApplicationTypeController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			IEnumerable<ApplicationType> objList = _db.ApplicationType;
			return View(objList);
		}

		//GET - CREATE
		public IActionResult Create()
		{
			return View();
		}

		//POST - CREATE
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Create(ApplicationType obj)
		{
			//server side validation
			if (ModelState.IsValid)
			{
				_db.ApplicationType.Add(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);

		}

		//GET-EDIT
		public IActionResult Edit(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var obj = _db.ApplicationType.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}

		//POST - Edit
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(ApplicationType obj)
		{
			//server side validation
			if (ModelState.IsValid)
			{
				_db.ApplicationType.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);

		}


		//GET-Delete
		public IActionResult Delete(int? id)
		{
			if (id == null || id == 0)
			{
				return NotFound();
			}
			var obj = _db.ApplicationType.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			return View(obj);
		}

		//POST - Delete
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult DeletePost(int? id)
		{
			var obj = _db.ApplicationType.Find(id);
			if (obj == null)
			{
				return NotFound();
			}
			_db.ApplicationType.Remove(obj);
			_db.SaveChanges();
			return RedirectToAction("Index");

		}

	}
}
