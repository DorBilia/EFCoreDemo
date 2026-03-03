using System;
using System.Collections.Generic;
using System.Text;
using EFCoreDemo.DB;

namespace EFCoreDemo.Operations
{
    public class DbContextSingletone
    {
        private static AppDbContext _dbContext;

        // Public method to get the singleton instance of AppDbContext
        public static AppDbContext GetDbContext()
        {
            if (_dbContext == null)
            {
                _dbContext = new AppDbContext();
            }
            return _dbContext;
        }
    }
}
