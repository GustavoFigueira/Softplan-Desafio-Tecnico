using Softplan.DesafioTecnico.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Softplan.DesafioTecnico.Application.ViewModels
{
    public class CompoundInterestModel
    {
        [Required]
        [Key]
        public Guid Id { get; set; }

        [Required]
        public decimal InitialValue { get; set; }

        public decimal FinalValue { get; set; }

        [Required]
        public InterestRate InterestRate { get; set; }

        [Required]
        public decimal Period { get; set; }
    }
}
