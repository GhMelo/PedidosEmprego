using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace emprego.Models
{
    public class pedidos
    {
        public int Id { get; set; }
        public string nome_produto { get; set; }
        public string valor { get; set; }
        public DateTime data_vencimento { get; set; }

    }
}

