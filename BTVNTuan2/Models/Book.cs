using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BTVNTuan2.Models
{
    public class Book
    {
        private int id;
        private string author;
        private string title;
        private string description;
        private string image_cover;
        private string price;

        public Book()
        {

        }

        public Book(int id, string author, string title, string description, string image_cover, string price)
        {
            this.id = id;
            this.author = author;
            this.title = title;
            this.description = description;
            this.image_cover = image_cover;
            this.price = price;
        }
        [Display(Name = "Mã sách")]
        public int Id { get => id; set => id = value; }
        [Required(ErrorMessage = "Tác giả không được để trống")]
        [StringLength(30, ErrorMessage = "Tác giả sách không được vượt quá 30 ký tự")]
        [Display(Name = "Tác giả")]
        public string Author { get => author; set => author = value; }
        [Required(ErrorMessage = "Tựa sách không được để trống")]
        [StringLength(30, ErrorMessage = "Tựa sách không được vượt quá 100 ký tự")]
        [Display(Name = "Tựa sách")]
        public string Title { get => title; set => title = value; }
        [Display(Name = "Miêu tả")]
        public string Description { get => description; set => description = value; }
        [Display(Name = "Hình ảnh")]
        public string ImageCover { get => image_cover; set => image_cover = value; }
        [Required(ErrorMessage = "Giá không được để trống")]
        [Range(1000, 1000000, ErrorMessage = "Giá sách từ 1000 - 1.000.000")]
        [Display(Name = "Giá sách")]
        public string Price { get => price; set => price = value; }
    }
}