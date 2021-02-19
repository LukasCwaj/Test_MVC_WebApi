using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_WebApi_ToDoList.Models
{
    public class ToDoList
    {
            [Required, Key]
            public int Id { get; set; }

            [Required]
            [MaxLength(50)]
            public string Title { get; set; }

            [Required]
            [MaxLength(1000)]
            public string Description { get; set; }

            [Required]
            public bool IsCompleted { get; set; }
    }
}