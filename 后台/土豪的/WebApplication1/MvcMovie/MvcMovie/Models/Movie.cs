using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        //标题
        public string Title { get; set; }
        //发布日期
        public DateTime ReleaseDate { get; set; }
        //类别
        public string Genre { get; set; }
        //价格
        public decimal Price { get; set; }
    }
}