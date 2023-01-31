﻿namespace BooksProject.Models.BooksModels
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }
        public string Genre { get; set; }
        public int Price { get; set; }
        public bool Rating { get; set; }
        public int Reviews { get; set; }
    }
}
