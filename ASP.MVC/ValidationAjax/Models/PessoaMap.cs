using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;

namespace ValidationAjax.Models
{
    public class PessoaMap : EntityTypeConfiguration<Pessoa>
    {
        //Mapeamento da tabela pessoa.
        public PessoaMap()
        {
            ToTable("Pessoa");
            HasKey(p => p.PessoaID);
            Property(x => x.Nome).HasMaxLength(10);
            Property(x => x.CPF).IsRequired();
        }
    }
}