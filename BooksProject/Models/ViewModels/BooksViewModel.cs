﻿using BooksProject.Models.BooksModels;

namespace BooksProject.Models.ViewModels
{
    public class BooksViewModel
    {
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public double Rating { get; set; }
        public int Reviews { get; set; }
    }
}
