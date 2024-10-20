﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modell;
using DataAccess;
using DataAccess.Repository;
using DataAccess.Repositorys;

namespace Business.Controller
{
    public class KategoriController
    {
        KategoriRepository Krepository;

        public KategoriController()
        {
            Krepository = new KategoriRepository();
        }

        public void CreateKategori(string KategoriString)
        {
            Kategori kategori = new Kategori(KategoriString);
            Krepository.Insert(kategori);
        }

        public void Delete(string kategoriNamn)
        {
            int index = Krepository.GetIndex(kategoriNamn);
            Krepository.Delete(index);
        }

        public int GetIndex(string namn)
        {
            return Krepository.GetIndex(namn);
        }
        public List<Kategori> GetAll()
        {
            List<Kategori> listaMedKategorier = new List<Kategori>();
            listaMedKategorier = Krepository.GetAll();
            return listaMedKategorier;
        }

        public void Update(string nyttKategoriNamn, string gammaltNamn)
        {
            Kategori kategori = new Kategori(nyttKategoriNamn);
            int index = Krepository.GetIndex(gammaltNamn);
            Krepository.Update(index, kategori);
        }

    }
}
