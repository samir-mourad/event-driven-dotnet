using System;
using System.Collections.Generic;
using System.Text;

namespace EventDrivenProject
{
    public class NotificacaoEventArgs : EventArgs
    {
        public decimal Valor { get; set; }
    }
}
