using Databaza.DB;
using System.Collections.Generic;
using System.Linq;

namespace Portfolio.Core
{
    public class AdminsServices : IAdminsServices
    {
        private AppDbContext _context;
        public AdminsServices(AppDbContext context)
        {
            _context = context;
        }

        public Admin CreateAdmin(Admin admin)
        {
            _context.Add(admin);
            _context.SaveChanges();

            return admin;
        }

        public Admin GetAdmin(int id)
        {
            return _context.Admins.First(n => n.Id == id);
        }

        public List<Admin> GetAdmins()
        {
            return _context.Admins.ToList();
        }
        public void DeleteAdmin(int id)
        {
            var admin = _context.Admins.First(n => n.Id == id);
            _context.Admins.Remove(admin);
            _context.SaveChanges();
        }
        public void EditAdmin(Admin admin)
        {
            var editedAdmin = _context.Admins.First(n => n.Id == admin.Id);
            editedAdmin.password = admin.password;
            _context.SaveChanges();
        }
    }
}
