using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApp.Models
{
    // Models returned by MeController actions.
    public class InputModel
    {
        [Required]
        [DataType(DataType.Date)]
        public string dateFrom { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public string dateTo { get; set; }
    }
}