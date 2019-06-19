using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MusicStoreWebApp.Data;
using MusicStoreWebApp.Models;

namespace MusicStoreWebApp.Controllers
{
    public class MusicController : Controller
    {
        ListViewAlbums model = new ListViewAlbums
        {
            AlbumList = AlbumDataBase.AlbumList
        };
        public IActionResult Music()
        {
            
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Album model)
        {
            AlbumDataBase.AlbumList.Add(model);
            return View();
        }

        public ActionResult Edit(int id)
        {

            return View(model.AlbumList.FirstOrDefault(a => a.Id == id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Album model)
        {
            var albumForEdit = AlbumDataBase.AlbumList.FirstOrDefault(x => x.Id == id);
            albumForEdit.Id = model.Id;
            albumForEdit.Name = model.Name;
            albumForEdit.NumberOfSongs = model.NumberOfSongs;
            albumForEdit.Price = model.Price;

            return View();
        }

        

        public ActionResult Delete(int id)
        {
            Album album = AlbumDataBase.AlbumList.FirstOrDefault(x => x.Id == id);
            AlbumDataBase.AlbumList.Remove(album);
            return View(album);
        }

        [HttpPost]
        public ActionResult Delete(int id, Album model)
        {
            return View();
        }
    }
}