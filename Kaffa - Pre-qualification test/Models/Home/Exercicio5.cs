using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kaffa___Pre_qualification_test.Models.Home
{
    public class Exercicio5
    {
        [Required(ErrorMessage = ("O campo é obrigatório"))]
        public string nome { get; set; }

        [Required(ErrorMessage = ("O campo é obrigatório"))]
        public string sobrenome { get; set; }

    }
}