using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TarefasAcademicas.Models
{
    [Table("Tarefa")]
    public class Tarefa
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }
        [Column("Nome")]
        [Display(Name = "Nome da Tarefa")]
        public string Nome { get; set; }
        [Column("Descricao")]
        [Display(Name = "Descrição da Tarefa")]
        public string Descricao { get; set; }
        [Column("DataInicio")]
        [Display(Name = "Data de Inicio")]
        public DateTime DataInicio { get; set; }
        [Column("DataLimite")]
        [Display(Name = "Prazo de Entrega")]
        public DateTime DataLimite { get; set; }
        [Column("Disciplina")]
        [Display(Name = "Disciplina")]
        public string Disciplina { get; set; }
        [Column("Pontos")]
        [Display(Name = "Pontos Obtidos")]
        public decimal Pontos { get; set; }
    }
}
