using System.Collections.Generic;
using QuanLySinhVien.DAL.Models;
using QuanLySinhVien.DAL.Repositories;

namespace QuanLySinhVien.BUS.Services
{
    public class VaiTroService
    {
        private readonly VaiTroRepository _repository;

        public VaiTroService()
        {
            _repository = new VaiTroRepository();
        }

        public List<VaiTro> GetAll()
        {
            return _repository.GetAll();
        }
    }
}