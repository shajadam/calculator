using System.ComponentModel.DataAnnotations;

namespace calculator.ViewModel
{
    public class CalculatorViewModel
    {
        [Required]
        [Display(Name = "First Number")]
        public decimal Number1 { get; set; }
        [Required]
        [Display(Name = "Second Number")]
        public decimal Number2 { get; set; }
        public Operand Operator { get; set; }
    }
    public enum Operand
    {
        Add, Subtract, Multiply, Division
    }
}