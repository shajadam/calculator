using System.ComponentModel.DataAnnotations;

namespace CalculatorAPI.ViewModels
{
    public class CalculatorViewModel
    {
        [Required]
        public decimal Number1 { get; set; }
        [Required]
        public decimal Number2 { get; set; }
        public Operand Operator { get; set; }
    }
    public enum Operand
    {
        Add, Subtract, Multiply, Division
    }
}