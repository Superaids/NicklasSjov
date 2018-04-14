using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using BackEnd;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;

namespace NicklasSjov.Controllers.ApiControllers
{
    [Route("api/SecretApi")]
    public class SecretApiController : Controller
    {
        XmlHandler xHandler = new XmlHandler();

        [HttpGet("Start")]
        public void Start()
        {
            xHandler.ModifyXMLManager();
        }

        [HttpPost("GetXML")]
        public async Task GetXML()
        {
            string xmlPath = @"c:/temp/";
            string xmlName = "xmlData.xml";

            try
            {
                //using (WebClient client = new WebClient())
                //{
                //    byte[] responseArray = client.UploadFile("~/", "xmlData.xml");
                //}

                var _test =  xHandler.GetCurrentXML();

                //return File(Encoding.UTF8.GetBytes(_test), "application/xml", "xmlData.xml");

                using (FileStream outFs = new FileStream(xmlPath+xmlName,FileMode.Open))
                {
                    Response.Clear();
                    Response.Headers.Add("content-disposition", String.Format("attachment;filename=\"{0}\"", xmlPath+xmlName));
                    Response.Headers.Add("Content-Length", outFs.Length.ToString());
                    Response.ContentType = "application/x-zip-compressed";

                    await outFs.CopyToAsync(Response.Body);
                }

                //return File(fileName, "application/xml", Server.UrlEncode(fileName));

            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}