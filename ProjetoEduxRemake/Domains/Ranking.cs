﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEduxRemake.Domains
{
    public class Ranking
    {
        public Ranking()
        {
            IdRanking = Guid.NewGuid();
        }

        [Key]
        public Guid IdRanking { get; set; }

        public string PosicaoRanking { get; set; }

        public string QuantidadeTotal { get; set; }

        public string TextoDescricao { get; set; }


        public Guid IdObjetivoAluno { get; set; }
        [ForeignKey("IdobjetivoAluno")]
        public ObjetivoAluno ObjetivoAluno { get; set; }
    }
}
