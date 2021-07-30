using BTVNTuan2.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BTVNTuan2.Controllers
{
    public class BookController : Controller
    {
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyễn Du", "Truyện Thúy Kiều (Bản Đặc Biệt)", "Truyện Kiều của Nguyễn Du đã hiện diện trong đời sống của dân tộc Việt Nam ta và trở thành một phần quan trọng làm nên vẻ đẹp của tâm hồn Việt, tinh hoa văn hóa Việt.", "/Content/images/1.png", "90000"));
            books.Add(new Book(2, "Vũ Ngọc Phan", "Tục Ngữ, Ca Dao, Dân Ca Việt Nam (Tái Bản 2020)", "Tác phẩm của nhà nghiên cứu văn học Vũ Ngọc Phan được trao tặng Giải thưởng Hồ Chí Minh đợt đầu tiên (năm1996, lĩnh vực văn nghệ dân gian.", "/Content/images/2.png", "105000"));
            books.Add(new Book(3, "Hồ Chí Minh", "Nhật Ký Trong Tù", "“Tập thơ Nhật ký trong tùcủa Hồ Chí Minh là một kho tàng về biết bao khía cạnh của cuộc đời, con người và nghệ thuật mà sự phong phú còn cần được tiếp tục nghiên cứu.” - THỦ TƯỚNG PHẠM VĂN ĐỒNG", "/Content/images/3.png", "65000"));
            return View(books);
        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyễn Du", "Truyện Thúy Kiều (Bản Đặc Biệt)", "Truyện Kiều của Nguyễn Du đã hiện diện trong đời sống của dân tộc Việt Nam ta và trở thành một phần quan trọng làm nên vẻ đẹp của tâm hồn Việt, tinh hoa văn hóa Việt.", "/Content/images/1.png", "90000"));
            books.Add(new Book(2, "Vũ Ngọc Phan", "Tục Ngữ, Ca Dao, Dân Ca Việt Nam (Tái Bản 2020)", "Tác phẩm của nhà nghiên cứu văn học Vũ Ngọc Phan được trao tặng Giải thưởng Hồ Chí Minh đợt đầu tiên (năm1996, lĩnh vực văn nghệ dân gian.", "/Content/images/2.png", "105000"));
            books.Add(new Book(3, "Hồ Chí Minh", "Nhật Ký Trong Tù", "“Tập thơ Nhật ký trong tùcủa Hồ Chí Minh là một kho tàng về biết bao khía cạnh của cuộc đời, con người và nghệ thuật mà sự phong phú còn cần được tiếp tục nghiên cứu.” - THỦ TƯỚNG PHẠM VĂN ĐỒNG", "/Content/images/3.png", "65000"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost, ActionName("EditBook")]
        [ValidateAntiForgeryToken]
        public ActionResult EditBook(int id, string Author, string Title, string Description, string ImageCover, string Price)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyễn Du", "Truyện Thúy Kiều (Bản Đặc Biệt)", "Truyện Kiều của Nguyễn Du đã hiện diện trong đời sống của dân tộc Việt Nam ta và trở thành một phần quan trọng làm nên vẻ đẹp của tâm hồn Việt, tinh hoa văn hóa Việt.", "/Content/images/1.png", "90000"));
            books.Add(new Book(2, "Vũ Ngọc Phan", "Tục Ngữ, Ca Dao, Dân Ca Việt Nam (Tái Bản 2020)", "Tác phẩm của nhà nghiên cứu văn học Vũ Ngọc Phan được trao tặng Giải thưởng Hồ Chí Minh đợt đầu tiên (năm1996, lĩnh vực văn nghệ dân gian.", "/Content/images/2.png", "105000"));
            books.Add(new Book(3, "Hồ Chí Minh", "Nhật Ký Trong Tù", "“Tập thơ Nhật ký trong tùcủa Hồ Chí Minh là một kho tàng về biết bao khía cạnh của cuộc đời, con người và nghệ thuật mà sự phong phú còn cần được tiếp tục nghiên cứu.” - THỦ TƯỚNG PHẠM VĂN ĐỒNG", "/Content/images/3.png", "65000"));
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    b.Description = Description;
                    b.Price = Price;
                    b.Title = Title;
                    b.Author = Author;
                    b.ImageCover = ImageCover;
                    break;
                }
            }
            return View("ListBookModel", books);
        }
        public ActionResult CreateBook()
        {
            return View();
        }
        [HttpPost, ActionName("CreateBook")]
        [ValidateAntiForgeryToken]
        public ActionResult Contract([Bind(Include = "Id, Author, Title, Description,ImageCover, Price")] Book book)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyễn Du", "Truyện Thúy Kiều (Bản Đặc Biệt)", "Truyện Kiều của Nguyễn Du đã hiện diện trong đời sống của dân tộc Việt Nam ta và trở thành một phần quan trọng làm nên vẻ đẹp của tâm hồn Việt, tinh hoa văn hóa Việt.", "/Content/images/1.png", "90000"));
            books.Add(new Book(2, "Vũ Ngọc Phan", "Tục Ngữ, Ca Dao, Dân Ca Việt Nam (Tái Bản 2020)", "Tác phẩm của nhà nghiên cứu văn học Vũ Ngọc Phan được trao tặng Giải thưởng Hồ Chí Minh đợt đầu tiên (năm1996, lĩnh vực văn nghệ dân gian.", "/Content/images/2.png", "105000"));
            books.Add(new Book(3, "Hồ Chí Minh", "Nhật Ký Trong Tù", "“Tập thơ Nhật ký trong tùcủa Hồ Chí Minh là một kho tàng về biết bao khía cạnh của cuộc đời, con người và nghệ thuật mà sự phong phú còn cần được tiếp tục nghiên cứu.” - THỦ TƯỚNG PHẠM VĂN ĐỒNG", "/Content/images/3.png", "65000"));
            try
            {
                if (ModelState.IsValid)
                {
                    books.Add(book);
                }
            }
            catch (RetryLimitExceededException)
            {
                ModelState.AddModelError("", "Error Save Data");
            }
            return View("ListBookModel", books);
        }
        public ActionResult Delete(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyễn Du", "Truyện Thúy Kiều (Bản Đặc Biệt)", "Truyện Kiều của Nguyễn Du đã hiện diện trong đời sống của dân tộc Việt Nam ta và trở thành một phần quan trọng làm nên vẻ đẹp của tâm hồn Việt, tinh hoa văn hóa Việt.", "/Content/images/1.png", "90000"));
            books.Add(new Book(2, "Vũ Ngọc Phan", "Tục Ngữ, Ca Dao, Dân Ca Việt Nam (Tái Bản 2020)", "Tác phẩm của nhà nghiên cứu văn học Vũ Ngọc Phan được trao tặng Giải thưởng Hồ Chí Minh đợt đầu tiên (năm1996, lĩnh vực văn nghệ dân gian.", "/Content/images/2.png", "105000"));
            books.Add(new Book(3, "Hồ Chí Minh", "Nhật Ký Trong Tù", "“Tập thơ Nhật ký trong tùcủa Hồ Chí Minh là một kho tàng về biết bao khía cạnh của cuộc đời, con người và nghệ thuật mà sự phong phú còn cần được tiếp tục nghiên cứu.” - THỦ TƯỚNG PHẠM VĂN ĐỒNG", "/Content/images/3.png", "65000"));
            Book book = new Book();
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();
            }
            return View(book);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, string Author, string Title, string Description, string ImageCover, string Price)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "Nguyễn Du", "Truyện Thúy Kiều (Bản Đặc Biệt)", "Truyện Kiều của Nguyễn Du đã hiện diện trong đời sống của dân tộc Việt Nam ta và trở thành một phần quan trọng làm nên vẻ đẹp của tâm hồn Việt, tinh hoa văn hóa Việt.", "/Content/images/1.png", "90000"));
            books.Add(new Book(2, "Vũ Ngọc Phan", "Tục Ngữ, Ca Dao, Dân Ca Việt Nam (Tái Bản 2020)", "Tác phẩm của nhà nghiên cứu văn học Vũ Ngọc Phan được trao tặng Giải thưởng Hồ Chí Minh đợt đầu tiên (năm1996, lĩnh vực văn nghệ dân gian.", "/Content/images/2.png", "105000"));
            books.Add(new Book(3, "Hồ Chí Minh", "Nhật Ký Trong Tù", "“Tập thơ Nhật ký trong tùcủa Hồ Chí Minh là một kho tàng về biết bao khía cạnh của cuộc đời, con người và nghệ thuật mà sự phong phú còn cần được tiếp tục nghiên cứu.” - THỦ TƯỚNG PHẠM VĂN ĐỒNG", "/Content/images/3.png", "65000"));
            if (id == null)
            {
                return HttpNotFound();
            }
            foreach (Book b in books)
            {
                if (b.Id == id)
                {
                    books.Remove(b);
                    break;
                }
            }
            return View("ListBookModel", books);
        }
    }
}