using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyFruits2.Models;

public class Fruit
{
    public int Id { get; set; }

    [Required]
    [Display(Name="Nom")]
    [StringLength(50, MinimumLength =3)]
    public string Name { get; set; }


    public string?  Description { get; set; }//? indique que la description est nullable

    public virtual Image? Image { get; set; }


    [Required]
    [Display(Name="Prix")]
    [Range(1,100)]//le prix doirt se situer entre 1 et 100€
    [DataType(DataType.Currency)]//pour indiquer qu"on utilise des données monétaires
    [Column(TypeName ="decimal(3,2)")]//prix jusqu'à 3 chiffre (999) et 2 chiffres après la virgules (125.08)
    public decimal Price { get; set; }  =decimal.One;
}
