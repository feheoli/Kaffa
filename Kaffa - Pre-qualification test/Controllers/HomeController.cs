using Kaffa___Pre_qualification_test.Models.Home;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kaffa___Pre_qualification_test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Exercicio1()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Exercicio1Result(Exercicio1 model)
        {
            string cnpj = "";

            try
            {
                if (ModelState.IsValid)
                {
                    TempData["msgSuccess"] = "O CNPJ " + model.CNPJ + " foi validado com sucesso";
                }
                else
                {
                    TempData["msgFalha"] = "Favor Verificar o preenchimento";
                }
            }
            catch
            {
                TempData["msgFalha"] = "Ocorreu um erro, favor entrar em contato com o administrador";
            }


            return View("Exercicio1", model);
        }

        public ActionResult Exercicio2()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Exercicio2Result(string txtCNPJ)
        {
            var cnpj = new string[txtCNPJ.Length];

            for (int i = 0; i < cnpj.Length; i++)
                cnpj[i] = txtCNPJ[i].ToString();

            try
            {
                if (txtCNPJ != "") 
                { 
                    if(txtCNPJ.Length == 18)
                    {
                        if(cnpj[2] == "." && cnpj[6] == "." && cnpj[10] == "/" && cnpj[15] == "-")
                        {
                            if(this.contemNumeros(cnpj[0]) && this.contemNumeros(cnpj[1]) && this.contemNumeros(cnpj[3])
                                && this.contemNumeros(cnpj[4]) && this.contemNumeros(cnpj[5]) && this.contemNumeros(cnpj[7])
                                && this.contemNumeros(cnpj[8]) && this.contemNumeros(cnpj[9]) && this.contemNumeros(cnpj[11])
                                && this.contemNumeros(cnpj[12]) && this.contemNumeros(cnpj[13]) && this.contemNumeros(cnpj[14])
                                && this.contemNumeros(cnpj[16]) && this.contemNumeros(cnpj[17]))
                            {
                                TempData["msgSuccess"] = "O CNPJ " + txtCNPJ + " foi validado com sucesso";
                            }
                            else { TempData["msgFalha"] = "O CNPJ está com formato incorreto"; }
                        }
                        else { TempData["msgFalha"] = "O CNPJ está com formato incorreto"; }
                    }
                    else { TempData["msgFalha"] = "O CNPJ não é válido"; }
                }
                else { TempData["msgFalha"] = "O campo não pode ser vazio";  }
            }
            catch
            {
                TempData["msgFalha"] = "Ocorreu um erro, favor entrar em contato com o administrador";
            }


            return View("Exercicio2");
        }
        public bool contemNumeros(string texto)
        {
            if (texto.Where(c => char.IsNumber(c)).Count() > 0)
                return true;
            else
                return false;
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Exercicio5()
        {

            return View();
        }
        public ActionResult Exercicio8()
        {
            return View();
        }
        public ActionResult Exercicio7()
        {
            return View();
        }
        public ActionResult Exercicio6()
        {
            return View();
        }
        public ActionResult LimparArquivo()
        {
            bool success = true;
            StreamWriter x;
            //string Caminho = @"C:\\Users\\fhenriquedeo\\Desktop\\Teste Kaffa\\Kaffa - Pre-qualification test\\Kaffa - Pre-qualification test\\File\\dados.txt";
            string dataDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            string Caminho = dataDir + @"\\../File\\dados.txt";

            using (StreamWriter sw = new StreamWriter(Caminho))
            {
                sw.WriteLine("");
            }

            return new JsonResult() { Data = new { success} };
        }
            public ActionResult Exercicio5Result(Exercicio5 model)
        {
            StreamWriter x;
            string dataDir = AppDomain.CurrentDomain.GetData("DataDirectory").ToString();
            string Caminho = dataDir + @"\\../File\\dados.txt";
            //string Caminho = @"C:\\Users\\fhenriquedeo\\Desktop\\Teste Kaffa\\Kaffa - Pre-qualification test\\Kaffa - Pre-qualification test\\File\\dados.txt";

            System.IO.File.AppendText(Caminho).Close();

            if (ModelState.IsValid)
            { 
                x = System.IO.File.AppendText(Caminho);

                x.WriteLine();
                x.WriteLine("__________________________________________________");
                x.WriteLine("Nome: " + model.nome);
                x.WriteLine("Sobrenome: " + model.sobrenome);

                x.Close();
            }

            return RedirectToAction("Exercicio5");
        }
        }
}