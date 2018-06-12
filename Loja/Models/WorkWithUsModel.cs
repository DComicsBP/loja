﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Loja.Models
{
    public class WorkWithUsModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [EmailAddress(ErrorMessage ="Você não colocou um email válido!")]
        public string Email { get; set; }
        public string File { get; set; }
        public DateTime Date { get; set; }
        public string Description{ get; set; }
        
    
    }
}


