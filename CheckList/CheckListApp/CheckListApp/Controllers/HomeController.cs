using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CheckListApp.Repositories;
using CheckListApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CheckListApp.Controllers
{
    [Route("")]
    public class HomeController : Controller
    {
        ItemRepository itemRepository;
        public HomeController(ItemRepository itemRepository)
        {
            this.itemRepository = itemRepository;
        }

        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View(itemRepository.GetList());
        }

        [Route("/add")]
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [Route("/add")]
        [HttpPost]
        public IActionResult Add(string name, RaceCategory raceCategory)
        {
            itemRepository.AddItem(name, raceCategory);
            return RedirectToAction("Index");
        }

        [Route("/{id}/delete")]
        [HttpPost]
        public IActionResult Delete(int id)
        {
            itemRepository.DeleteItem(id);
            return RedirectToAction("Index");
        }

        [Route("/{id}/update")]
        [HttpGet]
        public IActionResult Update([FromQuery]int id)
        {
            var item = itemRepository.GetId(id);
            return View(item);
        }

        [Route("/{id}/update")]
        [HttpPost]
        public IActionResult Update(Item item)
        {
            itemRepository.UpdateItem(item);
            return RedirectToAction("Index");
        }
    }
}
