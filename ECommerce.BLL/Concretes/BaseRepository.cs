using ECommerce.BLL.Abstract;
using ECommerce.DAL.Context;
using ECommerce.Entity.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Concrete
{
    public class BaseRepository<T> : IRepository<T> where T : BaseClass
    {
        private readonly ECommerceContext _context;
        private DbSet<T> _entities;

        //Dependency inversion?
        public BaseRepository(ECommerceContext context)
        {
            _context = context;
            _entities=_context.Set<T>();
        }
        public string Create(T entity)//Dışarıdan product yolladık diyelim. Dbsetlerde product var ise producta cast edecek.
        {
            try
            {
                _entities.Add(entity);
                _context.SaveChanges();
                return "Veri Kaydedildi.";
            }
            catch (Exception ex)
            {

                return ex.Message;
            }            
        }

        public string Delete(int id)
        {
            try
            {
                var entity = GetById(id);
                if (entity != null)
                {
                    entity.Status=Entity.Enum.Status.Deleted;
                    Update(entity);
                    return "Veri Silindi!";
                }
                else
                {
                    return "Silinecek Veri Bulunamadı!";
                }
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }

        public IEnumerable<T> GetAll()
        {
            return _entities.Where(x => x.Status == Entity.Enum.Status.Active).ToList();
        }

        public T GetById(int id)
        {
            return _entities.Find(id);
        }

        public string Update(T entity)
        {
            try
            {
                _context.Entry(entity).State = EntityState.Modified;
                _context.SaveChanges();
                return "Veri Güncellendi.";
            }
            catch (Exception ex) 
            {
                return ex.Message;
            }
        }
    }
}
