using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CourseManager.Models;

namespace CourseManager.Migrations.Seeds
{
    public class SideBarCreator
    {
                private readonly CourseManager.Models.CourseManagerEntities _context;

                public SideBarCreator(CourseManager.Models.CourseManagerEntities context)
        {
            _context = context;
        }

        public void Seed()
        {
            var initialSideBars = new List<SideBars>
            {
                new SideBars
                {
                    Name= "班级",
                    Controller = "Home",
                    Action = "Index"
                }
            };
            foreach (var bar in initialSideBars)
            {
                if (_context.SideBars.Any(r => r.Name == bar.Name))
                {
                    continue;
                }
                _context.SideBars.Add(bar);
            }
            _context.SaveChanges();
        }
    }
}