using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kaffa___Pre_qualification_test.Models.Home
{
    public class Exercicio1
    {
        [Required(ErrorMessage = ("O campo é obrigatório"))]
        [RegularExpression(@"[0-9]{2}\.?[0-9]{3}\.?[0-9]{3}\/?[0-9]{4}\-?[0-9]{2}", ErrorMessage = ("CNPJ inválido"))]
        public string CNPJ { get; set; }

    }
}