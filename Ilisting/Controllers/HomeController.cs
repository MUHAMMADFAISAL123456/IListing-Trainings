using Ilisting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ilisting.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Author> AuthorList = new List<Author>();
            AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10)));
            AuthorList.Add(new Author("Neel Beniwal", 18, "Graphics Development with C#", false, new DateTime(2010, 2, 22)));
            AuthorList.Add(new Author("Praveen Kumar", 28, "Mastering WCF", true, new DateTime(2012, 01, 01)));
            AuthorList.Add(new Author("Mahesh Chand", 35, "Graphics Programming with GDI+", true, new DateTime(2008, 01, 20)));
            AuthorList.Add(new Author("Raj Kumar", 30, "Building Creative Systems", false, new DateTime(2011, 6, 3)));
            //foreach (var author in AuthorList)
            //{
            //    Console.WriteLine("Author: {0},{1},{2},{3},{4}", author.Name, author.Age,
            //   author.BookTitle, author.IsMVP, author.PublishedDate);
            //}
            return View(AuthorList);
        }

        public ActionResult CreateList()
        {
            // Create a list of strings
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            // Read all data
            Console.WriteLine("Authors List");
            foreach (var author in AuthorList)
            {
                Console.WriteLine(author);
            }

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            return View();
        }

        public ActionResult Capacity()
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            // Original Capacity
            Console.WriteLine("Original Capacity: {0}", AuthorList.Capacity);
            // Trim excess
            AuthorList.TrimExcess();
            Console.WriteLine("Trimmed Capacity: {0}", AuthorList.Capacity);
            // Update Capacity
            AuthorList.Capacity = 20;
            Console.WriteLine(AuthorList.Capacity);
            Console.WriteLine("Updated Capacity: {0}", AuthorList.Capacity);
            Console.WriteLine("Count: {0}", AuthorList.Count);
            // Get first item of a List
            string auth = AuthorList[0];
            Console.WriteLine(auth);
            // Set first item of a List
            AuthorList[0] = "New Author";
            string[] authors = { "Mike Gold", "Don Box", "Sundar Lal", "Neel Beniwal" };
            AuthorList.AddRange(authors);
            //AuthorList.InsertRange(3, authors);
            return View();
        }

        public ActionResult AddRange()
        {
            // Create a list
            List<string> AuthorList = new List<string>();
            // Add items using Add method
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            // Insert an item at position 2
            AuthorList.Insert(1, "Second Author");
            // Insert a range of items
            string[] authors = { "Mike Gold", "Don Box", "Sundar Lal", "Neel Beniwal" };
            AuthorList.InsertRange(4, authors);
            return View();
        }

        public ActionResult RemoveElements()
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            AuthorList.Add("Mahesh Chand");
            // AuthorList.Remove("Mahesh Chand");
            // AuthorList.RemoveAt(2);
            //AuthorList.RemoveRange(3, 2);
            AuthorList.Clear();
            return View();
        }

        public ActionResult Searching()
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            int itemPosition = AuthorList.BinarySearch("Raj Kumar");
            Console.WriteLine("Item found at position: {0}", itemPosition + 1);
            return View();
        }

        public ActionResult sorting()
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            // Read all data
            Console.WriteLine("Original Authors List");
            AuthorList.Sort();
            Console.WriteLine("Sorted Authors List");
            return View();
        }

        public ActionResult Reversing()
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            // Read all data
            Console.WriteLine("Original Authors List");
            AuthorList.Reverse();
            return View();
        }

        public ActionResult Copylist()
        {
            List<string> AuthorList = new List<string>();
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");
            AuthorList.Add("Mahesh Chand");
            AuthorList.Add("Praveen Kumar");
            AuthorList.Add("Raj Kumar");
            AuthorList.Add("Nipun Tomar");
            AuthorList.Add("Dinesh Beniwal");

            // Create an array of strings
            string[] authorArray = new string[15];
            // Copy entire List
            //AuthorList.CopyTo(authorArray);
            // Copy items starting at index = 4
            //AuthorList.CopyTo(authorArray, 4);
            // Copy 4 items starting at index 2 in List and copying
            // to array starting at index 10
            AuthorList.CopyTo(2, authorArray, 3, 4);
            
            return View();
        }
        public ActionResult Temp()
        {
            return View();
        }
    }
}