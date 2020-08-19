﻿using Library.Data;

 namespace Library.Controllers.Helpers
{
    public class AuthorHelper
    {
        private ApplicationDbContext _context;
        public AuthorHelper(ApplicationDbContext context)
        {
            _context = context;
        }
        
        
        
    }
}