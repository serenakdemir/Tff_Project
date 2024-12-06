using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Tff_Project.Models.ReturnModels;

public class ReturnModel<T>
{
    public string Message { get; set; }
    public bool Success { get; set; }

    public T? Data { get; set; }

    public HttpStatusCode StatusCode { get; set; }


    public override string ToString()
    {
        return $"Message :{Message}," +
            $" \n Başarılı Mı: {Success}," +
            $"\n Veri :  {Data}" +
            $"\n Statü Kodu : {StatusCode}";
    }
}

