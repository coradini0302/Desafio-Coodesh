using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using System.Net;
using techChallengeApi.Data;
using techChallengeApi.Model;
using techChallengeApi.Repositories.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace techChallengeApi.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]
    public class FileController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public FileController(ApplicationDbContext context)
        {
            _context = context;
        }

        // POST api/<FileController>
        
        [HttpPost("upload")]
        public async Task<ActionResult> Post([FromForm] ICollection<IFormFile> files)
        {

            try


            {
                if (files == null || files.Count == 0)
                {
                    return BadRequest();
                }
             

                List<byte[]> data = new List<byte[]>();

                foreach (var formFile in files)
                {
                    if (formFile.Length > 0)
                    {
                        using (var stream = new MemoryStream())
                        {
                            await formFile.CopyToAsync(stream);
                            data.Add(stream.ToArray());
                        }
                    }
                }

               System.IO.File.WriteAllBytes("C:\\Users\\Gabriel\\source\\repos\\techChallengeApi\\techChallengeApi\\sales.txt", data[0]);

                StreamReader streamReader = new StreamReader("C:\\Users\\Gabriel\\source\\repos\\techChallengeApi\\techChallengeApi\\sales.txt");

                string fileReader = streamReader.ReadLine();
                
                while(fileReader != null && fileReader != "")
                {
                    if(fileReader != "")
                    {
                        var date = "";
                        var product = "";
                        var type = 0;
                        var value = "";
                        var sellerName = "";
                        var realDate = new DateTime();
                        var variety = new Variety();
                        var products = new Products();
                        var seller = new Seller();
                        var productList = new List<string>();
                        for (int i = 0; i < fileReader.Count(); i++)
                        {

                            if (i == 0)
                            {
                                type = int.Parse(fileReader[i].ToString());

                            }

                            if (i > 0 && i <= 25)
                            {
                                date += fileReader[i].ToString();
                            }
                            if (i == 25)
                            {
                                realDate = DateTime.Parse(date);
                            }


                            if (i >= 26 && i <= 55)
                            {
                                product += fileReader[i].ToString();
                            }

                            if (i >= 56 && i <= 65)
                            {
                                value += fileReader[i].ToString();
                            }

                            if (i >= 66 && i <= fileReader.Length)
                            {
                                sellerName += fileReader[i].ToString();
                            }
                        }

                        /// VARIAÇÔES DE ENTRADA DE VALORES
                        #region Type



                        #endregion


                        #region assignments
                        seller.Name = sellerName;
                        products.Name = product;
                        var existSeller = _context.Seller.Where(p => p.Name == sellerName).FirstOrDefault();
                        if (existSeller == null)
                        {
                            _context.Seller.Add(seller);

                        }
                        else
                            seller = existSeller;
                        var exist = _context.Products.Where(p => p.Name == product).FirstOrDefault();
                        if (exist == null)
                        {
                            _context.Products.Add(products);

                        }
                        else
                            products = exist;

                        var varieties = _context.Varieties.Where(x => x.Sort == type).FirstOrDefault();


                        var generalSales = new GeneralSales();

                        generalSales.Variety = varieties;
                        generalSales.Date = realDate;
                        generalSales.Seller = seller;
                        generalSales.Product = products;
                        generalSales.Value = int.Parse(value);
                        _context.GeneralSales.Add(generalSales);

                        await _context.SaveChangesAsync();


                        #endregion




                        fileReader = streamReader.ReadLine();
                    }
                    

                }
                
                streamReader.Close();
                
                System.IO.File.Delete("C:\\Users\\Gabriel\\source\\repos\\techChallengeApi\\techChallengeApi\\sales.txt");
            }
            catch (Exception ex)
            {
                throw new Exception();
            }


            return Ok();
        }


       
        
    }
}
