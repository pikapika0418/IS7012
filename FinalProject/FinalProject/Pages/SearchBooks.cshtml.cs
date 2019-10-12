using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FinalProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace FinalProject.Pages
{
    public class SearchBooksModel : PageModel
    {

        private FinalProjectContext _context;

        public SearchBooksModel(FinalProjectContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
            SearchCompleted = false;
        }

        [BindProperty]
        public string SearchBook { get; set; }
        [BindProperty]
        public string SearchGenre { get; set; }
        [BindProperty]
        public string SearchAuthor { get; set; }
        public bool SearchCompleted { get; set; }
        public ICollection<Book> SearchByBookResults { get; set; }
        public ICollection<Book> SearchByGenreResults { get; set; }
        public ICollection<Book> SearchByAuthorResults { get; set; }
        public void OnPost()
        {
            
            if(!string.IsNullOrWhiteSpace(SearchBook))
            {
                SearchByBookResults = _context.Book
                                    .Where(y => y.Name.ToLower().Contains(SearchBook.ToLower()))
                                    .ToList();
                SearchCompleted = true;
            }
            
            if(!string.IsNullOrWhiteSpace(SearchGenre))
            {
                SearchByGenreResults = _context.Book
                                            .Where(y => y.Genre.Type.ToLower().Contains(SearchGenre.ToLower()))
                                            .ToList();
                SearchCompleted = true;
            }
            
            if(!string.IsNullOrWhiteSpace(SearchAuthor))
            {
                SearchByAuthorResults = _context.Book
                                            .Where(y => y.Author.ToLower().Contains(SearchAuthor.ToLower()))
                                            .ToList();
                SearchCompleted = true;
            }
            //url..https://wallpaperplay.com/walls/full/9/7/e/162410.jpg
            }
    }
}