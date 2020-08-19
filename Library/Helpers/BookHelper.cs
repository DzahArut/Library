﻿using System.Collections.Generic;
 using System.Linq;
 using Library.Data;
 using Library.ViewModels;

 namespace Library.Controllers.Helpers
{
    public class BookHelper : IBookHelper
    {
        private readonly ApplicationDbContext _context;
        public BookHelper(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public List<BookVM> GetRange()
        {
            var books = _context.Books.ToList();
            var booksVM = new List<BookVM>();
            foreach (var b in books)
            {
                var author = _context.Authors.FirstOrDefault(a => a.Id == b.AuthorId);
                if (author != null)
                {
                    booksVM.Add(new BookVM
                    {
                        Title = b.Title,
                        Author = author.Surname + " " + author.Name + " " + author.Patronymic
                    });
                }
                else
                {
                    booksVM.Add(new BookVM
                    {
                        Title = b.Title,
                    });
                }
            }
            return booksVM;
        }

        public CreateBookVM CreateBookVM()
        {
            throw new System.NotImplementedException();
        }

        public void Create(BookVM bookVM)
        {
            throw new System.NotImplementedException();
        }

        public void Edit(EditBookVM editBookVm)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}