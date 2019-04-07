using prmToolkit.NotificationPattern;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TesteHBSIS.Domain.Entidades.Base
{
    public abstract class EntidadeBase : Notifiable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public abstract void ValidarEntidade();
    }
}
