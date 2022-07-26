using System;

/*
 * Consiste na ess�ncia das regras de neg�cio, envolvendo as classes do sistema e o acesso aos dados
 
 */

namespace API_Livros.Models
{
    public class ErrorViewModel
    {
        public string RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
