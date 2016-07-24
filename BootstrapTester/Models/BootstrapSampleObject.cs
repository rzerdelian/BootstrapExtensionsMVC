using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using BootstrapExtensionsMVC.Models;


namespace BootstrapTester.Models
{
    public class BootstrapSampleObject
    {
        public BootstrapSampleObject()
        {
            Id = 3;
            Name = "John Doe";
            Email = "john@sample.com";
            Colors = CreateDictionary<Colors>();
            ButtonSizes = CreateDictionary<ButtonSizes>();
            ButtonStyles = CreateDictionary<ButtonStyles>();
            CreateDate = DateTime.Now;
            ColorsEnum = BootstrapExtensionsMVC.Models.Colors.Success;

            Date = DateTime.Now;
            Time = DateTime.Now;
        }

        [Required]
        public int Id { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        [Required()]
        [Display(Name="Create Date")]
        public DateTime CreateDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Display(Name = "Colors Enum")]
        public Colors ColorsEnum { get; set; }

        [DataType(DataType.MultilineText)]
        public string Multiline { get; set; }

        [DataType(DataType.PhoneNumber)]
        [DisplayFormat(ApplyFormatInEditMode=true,  
            DataFormatString="{0:(###) ###-####}")]
        [Display(Name = "Phone")]
        public string PhoneNumber{ get; set; }

        [DataType(DataType.Url)]
        public string Website{ get; set; }

        [DataType(DataType.Currency)]
        public float Currency { get; set; }

        public decimal Decimal { get; set; }

        [DataType(DataType.Password)]
        public string Password{ get; set; }

        [Display(Name = "Boolean")]
        public bool BooleanOption { get; set; }

        #region helpers

        public IDictionary<string, Colors> Colors { get; set; }

        public IDictionary<string, ButtonSizes> ButtonSizes{ get; set; }

        public IDictionary<string, ButtonStyles> ButtonStyles { get; set; }

        public IDictionary<string, T> CreateDictionary<T>()
        {
            var dic = new Dictionary<string, T>();
            foreach (var item in Enum.GetNames(typeof(T)))
            {
                dic.Add(item, (T)Enum.Parse(typeof(T), item));
            }
            return dic;
        }

        #endregion
    }
}