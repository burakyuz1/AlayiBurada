﻿using AlayıBurada.Interfaces;
using AlayıBurada.MvcUI.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlayıBurada.MvcUI.Controllers
{
    public class BasketController : Controller
    {
        IBasketService BasketService;

        public BasketController(IBasketService basketService)
        {
            BasketService = basketService;
        }

        public ActionResult ConfirmTheBasket()
        {
            return View();
        }
        [HttpPost]
        public ActionResult ConfirmTheBasket(BasketViewModel basketViewModel)
        {
            if (ModelState.IsValid)
            {
                var basket = BasketService.ConfirmToBasket(basketViewModel.ProductId, basketViewModel.CustomerId);
                return View(basketViewModel);
            }
            else
                return RedirectToAction("Login", "Customer");
        }

        //ConfirmTheBasket metodunun ayağa kalkması için parametre lazım, parametrenin dolması için de metodun post işlemiyle desteklenmesi lazım
        //bir türlü post yapamadım. ben postu yapsam bile CustomerId yi nasıl yollayacaz onu da bilmiyom
        //o yüzden sessionda tuttuğumuz liste yok mu sepetteki ürünler listesi. BasketService.ConfirmToBasket(BURAYA SESSION LİSTESİ)
        // Yollayacaz. arka tarafta da listenin içinden ProductId leri alıp basacak.
        //Customer ı  da zaten Session["user"] da tutuyoz. yani bizim metot şu hale geldi
        //BasketService.ConfirmToBasket(SEPETTEKİ_URUN_LISTESİ,SESSIONDAKI_KİŞİNİN_ID)
        // ama beynim durduğu için yapamadım dursun yarın bakcam.
    }
}
