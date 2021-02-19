using Databaza.DB;
using System.Collections.Generic;
using System.Linq;


namespace Portfolio.Core
{
      public class AboutmeServices : IAboutmeServices
    {
        private AppDbContext _context;
        public AboutmeServices(AppDbContext context)
        {
            _context = context;
        }

        public Aboutme GetAboutme(int id)
        {
            return _context.Aboutmes.First(n => n.aboutmeId == id);
        }

        public void EditAboutme(Aboutme aboutme)
        {
            var editedAboutme = _context.Aboutmes.First(n => n.aboutmeId == aboutme.aboutmeId);
            editedAboutme.text = aboutme.text;
            _context.SaveChanges();
        }
    }
}


